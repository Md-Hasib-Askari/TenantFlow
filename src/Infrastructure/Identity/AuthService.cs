using Application.Auth;
using Application.Common;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Identity;

public class AuthService(
    UserManager<ApplicationUser> userManager,
    ITokenService tokenService,
    ITenantRepository tenantRepository,
    AppDbContext db
) : IAuthService
{
    private readonly UserManager<ApplicationUser> _userManager = userManager;
    private readonly ITokenService _tokenService = tokenService;
    private readonly ITenantRepository _tenantRepo = tenantRepository;
    private readonly AppDbContext _db = db;

    public async Task<TokenResponse> LoginAsync(
        LoginRequest request,
        CancellationToken ct = default
    )
    {
        // Check if user is valid_
        var user =
            await _userManager.FindByEmailAsync(request.Email)
            ?? throw new UnauthorizedAccessException("Invalid email or password.");

        if (!user.IsActive)
            throw new UnauthorizedAccessException("Account is not active.");

        var valid = await _userManager.CheckPasswordAsync(user, request.Password);
        if (!valid)
            throw new UnauthorizedAccessException("Invalid email or password.");

        // Resolve user's primary tenant
        var tenant =
            await _tenantRepo.GetByIdAsync(user.PrimaryTenantId, ct)
            ?? throw new InvalidOperationException("Primary Tenant not found.");

        // Determine role for the token
        var userRole = await _db.UserTenantRoles.FirstOrDefaultAsync(
            r => r.UserId == user.Id && r.TenantId == tenant.Id,
            ct
        );
        var role = userRole?.Role ?? TenantRole.Member;

        // Issue tokens
        var (accessToken, refreshToken) = _tokenService.CreateTokenPair(user, tenant, role);

        // Store refresh token hash
        var tokenHash = _tokenService.HashToken(refreshToken);
        var refreshEntity = RefreshToken.Create(user.Id, tokenHash, expiryDays: 7);
        _db.RefreshTokens.Add(refreshEntity);
        await _db.SaveChangesAsync(ct);

        return new TokenResponse(accessToken, refreshToken);
    }

    public async Task<TokenResponse> RefreshAsync(
        string refreshToken,
        CancellationToken ct = default
    )
    {
        // Check refresh token validity
        var tokenHash = _tokenService.HashToken(refreshToken);

        var storedToken = await _db
            .RefreshTokens.Include(r => r.User)
            .FirstOrDefaultAsync(r => r.TokenHash == tokenHash, ct);
        if (storedToken is null || !storedToken.IsActive)
            throw new UnauthorizedAccessException("Invalid or expired refresh token.");

        // Revoke the old token
        storedToken.Revoke();

        var user = storedToken.User;
        if (!user.IsActive)
            throw new UnauthorizedAccessException("Account is not active.");

        var tenant =
            await _tenantRepo.GetByIdAsync(user.PrimaryTenantId, ct)
            ?? throw new InvalidOperationException("Primary tenant not found.");

        var userRole = await _db.UserTenantRoles.FirstOrDefaultAsync(
            r => r.UserId == user.Id && r.TenantId == tenant.Id,
            ct
        );
        var role = userRole?.Role ?? TenantRole.Member;

        // Issue new token pair
        var (accessToken, newRefreshToken) = _tokenService.CreateTokenPair(user, tenant, role);

        // Store new refresh token hash
        var newTokenHash = _tokenService.HashToken(newRefreshToken);
        var newRefreshEntity = RefreshToken.Create(user.Id, newTokenHash, expiryDays: 7);
        _db.RefreshTokens.Add(newRefreshEntity);
        await _db.SaveChangesAsync(ct);

        return new TokenResponse(accessToken, newRefreshToken);
    }

    public async Task<TokenResponse> RegisterAsync(
        RegisterRequest request,
        CancellationToken ct = default
    )
    {
        // Validate tenant exists and is active
        var tenant =
            await _tenantRepo.GetBySlugAsync(request.TenantSlug, ct)
            ?? throw new InvalidOperationException("Tenant not found.");

        if (tenant.Status != TenantStatus.Active)
            throw new InvalidOperationException("Tenant is not active.");

        // Check if user already exists
        var existing = await _userManager.FindByEmailAsync(request.Email);
        if (existing is not null)
            throw new InvalidOperationException("A user with this email already exists.");

        // Create user
        var user = ApplicationUser.Create(
            userName: request.Email,
            email: request.Email,
            displayName: request.DisplayName,
            primaryTenantId: tenant.Id
        );

        var result = await _userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        {
            var errors = string.Join("; ", result.Errors.Select(e => e.Description));
            throw new InvalidOperationException($"User creation failed: {errors}");
        }

        // Assign Member role in the tenant
        var userTenantRole = UserTenantRole.Create(user.Id, tenant.Id, TenantRole.Member);
        _db.UserTenantRoles.Add(userTenantRole);
        await _db.SaveChangesAsync(ct);

        // Issue tokens
        var (accessToken, refreshToken) = _tokenService.CreateTokenPair(
            user,
            tenant,
            TenantRole.Member
        );

        // Store refresh token hash
        var tokenHash = _tokenService.HashToken(refreshToken);
        var refreshEntity = RefreshToken.Create(user.Id, tokenHash, expiryDays: 7);
        _db.RefreshTokens.Add(refreshEntity);
        await _db.SaveChangesAsync(ct);

        return new TokenResponse(accessToken, refreshToken);
    }
}
