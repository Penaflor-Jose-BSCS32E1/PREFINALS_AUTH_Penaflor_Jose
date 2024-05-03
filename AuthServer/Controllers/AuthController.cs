using AuthServer.Core;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IAuthService _authService;

    public AuthController(IUserService userService, IAuthService authService)
    {
        _userService = userService;
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(User user)
    {
        var registeredUser = await _userService.RegisterUserAsync(user);
        // Return registered user or appropriate response
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserLoginModel loginModel)
    {
        if (await _authService.ValidateUserAsync(loginModel.Username, loginModel.Password))
        {
            var user = await _userService.GetUserAsync(loginModel.Username);
            var token = await _authService.GenerateJwtTokenAsync(user);
            // Return JWT token or appropriate response
        }
        // Invalid credentials response
    }

    // Other authentication endpoints
}
