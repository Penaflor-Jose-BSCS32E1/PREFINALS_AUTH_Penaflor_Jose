<h1>PREFINALS_AUTH_Penaflor_Jose</h1><br>
This solution contains two projects, AuthServer and ProtectedApi, for building a secure web API with JWT authentication using Onion Architecture principles in .NET Core.<br><br>

<h3>AuthServer<br></h3>
The AuthServer project implements the core logic for user authentication, including registration, login, password changes, and locking. It also handles JWT token generation. This project follows the Onion Architecture pattern with separate layers for core business logic, interfaces, and presentation (controllers).<br><br>

<h3>Setup and Configuration<br></h3>
<ol>
<li>Dependencies: Install required NuGet packages for JWT authentication and token management.</li>
<ul><li>Microsoft.AspNetCore.Authentication.JwtBearer</li>
<li>Microsoft.IdentityModel.Tokens</li>
<li>System.IdentityModel.Tokens.Jwt</li></ul>
<li>Configuration: Set up JWT settings in the appsettings.json file, including the JWT signing key, issuer, audience, and token expiry time.</li>
<li>Onion Architecture: Implement core logic for user management and authentication using interfaces and concrete classes following the Onion Architecture principles.</li>
<li>Presentation Layer: Create controllers in the Controllers folder to handle authentication endpoints (e.g., register, login).</li></ol><br><br>

<h3>Usage<br></h3>
<ul>
<li>Register a new user: POST /api/auth/register</li>
<li>Login with credentials: POST /api/auth/login</li>
<li>Other authentication and user management endpoints as needed.
  </li><br><br>
</ul>
<h3>ProtectedApi<br></h3>
The ProtectedApi project exposes an endpoint that requires a valid JWT token for access. It returns basic user information and fun facts about the API creator.

<h3>Setup<br></h3>
<ol>
<li>Dependencies: Install required NuGet packages for ASP.NET Core MVC.</li>
<ul><li>Microsoft.AspNetCore.Mvc</li></ul>
<li>Authorization: Configure JWT bearer token authentication in the Startup.cs file to require a valid token for accessing any endpoint.</li>
<li>Protected Endpoint: Implement a controller with an action decorated with [Authorize] to enforce authorization. This endpoint returns user information and fun facts.</li><br><br></ol>
  
<h3>Usage<br></h3>
<ul><li>Access protected endpoint: GET /api/protected/userinfo</li></ul>
