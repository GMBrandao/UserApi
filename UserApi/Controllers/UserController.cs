using Microsoft.AspNetCore.Mvc;
using UserApi.Domain.Dto;
using UserApi.Domain.Interfaces;

namespace UserApi.Controllers;

[Route("api/users")]
[ApiController]
public class UserController : Controller
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var users = _userService.GetUsers();

        if (users == null) return NotFound();

        return Ok(users);
    }

    [HttpPost]
    public ActionResult Post([FromBody] CreateUserDto user)
    {
        if (user == null) return NotFound();

        _userService.CreateUser(user);

        return Ok();
    }
}