using Domain.Entities;

namespace Application.Auth;

public interface IRefreshTokenRepository
{
    Task<RefreshToken?> GetByHashWithUserAsync(string tokenHash, CancellationToken ct = default);
    Task AddAsync(RefreshToken token, CancellationToken ct = default);
}
