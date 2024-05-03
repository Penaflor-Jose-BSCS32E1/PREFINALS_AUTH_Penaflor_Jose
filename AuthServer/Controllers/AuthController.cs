using AuthServer.Core;
using AuthServer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
    public async Task<IActionResult> Register(UserRegisterModel registerModel)
    {
        // Check if the model is valid
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // Map the register model to a User entity
        var user = new User
        {
            Username = registerModel.Username,
            PasswordHash = registerModel.Password, // Assuming you hash the password before saving
            Email = registerModel.Email
        };

        try
        {
            // Call the user service to register the user
            var registeredUser = await _userService.RegisterUserAsync(user);
            return Ok(new { message = "User registered successfully", user = registeredUser });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Error registering user", error = ex.Message });
        }
    }


    [HttpPost("login")]
    public async Task<IActionResult> Login(UserLoginModel loginModel)
    {
        // Check if the model is valid
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            // Call the authentication service to validate the user credentials
            var isValidUser = await _authService.ValidateUserAsync(loginModel.Username, loginModel.Password);

            if (!isValidUser)
            {
                return Unauthorized(new { message = "Invalid username or password" });
            }

            var user = await _userService.GetUserAsync(loginModel.Username);
            var token = await _authService.GenerateJwtTokenAsync(user);

            return Ok(new { token });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Error authenticating user", error = ex.Message });
        }

        [HttpGet("about/me")]
        IActionResult GetAboutMe()
        {
    
            var randomFacts = new List<string>
            {
                 "Gamer",
                 "Loves coding",
                "Introvert"

             };

            var random = new Random();
            var randomIndex = random.Next(0, randomFacts.Count);

            return Ok(new { about = randomFacts[randomIndex] });
        }
        [HttpGet("about")]
        IActionResult GetAbout()
        {
            var creatorName = "Jose Peñaflor";
            return Ok(new { name = creatorName });
        }

        [HttpPost("about")]
        IActionResult PostAbout([FromBody] NameModel nameModel)
        {
            if (nameModel == null || string.IsNullOrEmpty(nameModel.Name))
            {
                return BadRequest("Name is required.");
            }

            var ownerName = "Jose Peñaflor";
            var greetingMessage = $"Hi {nameModel.Name} from {ownerName}";
            return Ok(new { message = greetingMessage });
        }



    }
}
