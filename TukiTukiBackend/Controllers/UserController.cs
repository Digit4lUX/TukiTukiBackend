using Microsoft.AspNetCore.Mvc;
using TukiTukiBackend.Models;
using TukiTukiBackend.Services;

namespace TukiTukiBackend.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController: ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public ActionResult<User> create(User user)
    {
        User? existingUser = _userService.getByEmail(user.email);
        if (existingUser != null)
        {
            return Conflict(new {message = "User already exists"});
        }

        var result = _userService.create(user);
        return Created("api/users", result);
    }
}