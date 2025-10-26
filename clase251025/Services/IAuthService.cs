using clase251025.Models.DTOs;

namespace clase251025.Services
{
    public interface IAuthService
    {
        Task<string> RegisterAsync(RegisterDto dto);
        Task<bool> VerifyCredentials(LoginDto dto);
        Task<bool ok, string? token> LoginAsync(LoginDto dto);
    }
}
