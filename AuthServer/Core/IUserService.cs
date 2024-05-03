namespace AuthServer.Core

{
    public interface IUserService
    {
        Task<User> RegisterUserAsync(User user);
        Task<User> GetUserAsync(string username);
    }
}
