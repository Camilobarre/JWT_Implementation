using JWT_Implementation.Data;
using JWT_Implementation.Config;
using JWT_Implementation.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace JWT_Implementation.Controllers.v1.Auth;

[ApiController]
[AllowAnonymous]
[Route("api/v1/[controller]")]
public class AuthController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly Utilities _utilities;

    public AuthController(ApplicationDbContext context, Utilities utilities)
    {
        _context = context;
        _utilities = utilities;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(User newUser)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (_context.Users.Any(u => u.Email == newUser.Email))
        {
            return BadRequest("Email already exists");
        }

        newUser.Password = _utilities.EncryptSHA256(newUser.Password);

        _context.Users.Add(newUser);
        await _context.SaveChangesAsync();
        return Ok("User registered successfully");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
        if (user == null)
        {
            return Unauthorized("Invalid email");
        }

        var passwordIsValid = user.Password == _utilities.EncryptSHA256(request.Password);

        if (passwordIsValid == false)
        {
            return Unauthorized("Invalid password");
        }

        var token = _utilities.GenerateJwtToken(user);
        return Ok(new
        {
            message = "Please, save this token",
            jwt = token
        });
    }
}