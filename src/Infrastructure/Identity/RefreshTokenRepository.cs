using Application.Auth;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Identity;

public class RefreshTokenRepository(AppDbContext db) : IRefreshTokenRepository
{
    private readonly AppDbContext _db = db;

    public async Task<RefreshToken?> GetByHashWithUserAsync(string tokenHash, CancellationToken ct = default) =>
        await _db.RefreshTokens
            .Include(r => r.User)
            .FirstOrDefaultAsync(r => r.TokenHash == tokenHash, ct);

    public async Task AddAsync(RefreshToken token, CancellationToken ct = default) =>
        await _db.RefreshTokens.AddAsync(token, ct);
}
