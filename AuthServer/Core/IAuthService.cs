namespace AuthServer.Core
{
    public interface IAuthService
    {
        Task<string> GenerateJwtTokenAsync(User user);
        Task<bool> ValidateUserAsync(string username, string password);
    }
}
