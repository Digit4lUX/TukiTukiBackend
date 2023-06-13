using Microsoft.AspNetCore.Mvc;
using TukiTukiBackend.Controllers;
using TukiTukiBackend.Models;
using TukiTukiBackend.Services;

namespace TukiTukiBackendTesting;

public class UserTest
{
    private readonly UserController _userController;
    private readonly UserService _userService;
    
    public UserTest()
    {
        _userService = new UserService();
        _userController = new UserController(_userService);
    }
    
    [Fact]
    public void RegisterUserTest()
    {
        User user = new User("Javier", "Gonzales", "javiergonzales123@gmail.com", "javier123", "963571985");
        
        var result = _userController.create(user);
        Assert.NotNull(result);
        Assert.IsType<ActionResult<User>>(result);
    }
}