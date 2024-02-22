using Microsoft.AspNetCore.Mvc;

namespace SchoolDemo.Controllers;

[Route("api/[controller]")]
[ApiController]

public class LoginController : Controller
{
    private readonly IUserService _service;
    public LoginController(IUserService service)
    {
        _service = service;
    }

    [HttpPost("")]
    public IActionResult Login([FromBody] User payload)
    {
        bool isUserValid = _service.LoginUser(payload.UserName, payload.Password);
        if (isUserValid)
        {
            return Ok();
        }
        return Unauthorized();
    }
}
