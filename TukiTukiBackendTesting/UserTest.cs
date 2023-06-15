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
        /*Successful database insertion*/
        User user = new User("Javier", "Gonzales", "javiergonzales123@gmail.com", "javier123", "963571985");
        var result = _userController.create(user);
        Assert.IsType<CreatedResult>(result.Result);
        
        /*Conflict during database insertion*/
        User newUser = new User("Roberto", "Hernandez", "pepe43@gmail.com", "robert123", "963575685");
        var result2 = _userController.create(newUser);
        Assert.IsType<ConflictObjectResult>(result2.Result);
    }
}