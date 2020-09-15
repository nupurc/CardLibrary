using CardLibrary.Services.Group;
using CardLibrary.Services.User;
using CardLibrary.Web.Serialization;
using CardLibrary.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace CardLibrary.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        private readonly IUserRoleService _userRoleService;
        private readonly IUserGroupService _userGroupService;
        public UserController(ILogger<UserController> logger, IUserService userService, IUserRoleService userRoleService, IUserGroupService userGroupService)
        {
            _userService = userService;
            _userRoleService = userRoleService;
            _userGroupService = userGroupService;
            _logger = logger; 
        }
        [Authorize]
        [HttpPost("/api/user")]
        public ActionResult CreateUser([FromBody] UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _logger.LogInformation("Creating a new user");
            userModel.CreatedOn = DateTime.UtcNow;
            userModel.UpdatedOn = DateTime.UtcNow;
            var userData = UserMapper.SerializeUser(userModel);
            var newUser = _userService.CreateUser(userData);
            return Ok(newUser);
        }
        [Authorize]
        [HttpGet("/api/user")]
        public ActionResult GetUsers()
        {
            _logger.LogInformation("Getting Users");
            var users = _userService.GetAllUsers();            

            var userModels = users
                .Select(usr => new UserModel
                {
                    UserId = usr.UserId,
                    FirstName = usr.FirstName,
                    LastName = usr.LastName,
                    UsertName = usr.UsertName,
                    password = usr.password,
                    isActive = usr.isActive,
                    UserRoleModelId = usr.UserRoleId,
                    UserGroupModelId = usr.UserGroupId,
                    CreatedOn = usr.CreatedOn,
                    UpdatedOn = usr.UpdatedOn
                })
                .OrderByDescending(usr => usr.CreatedOn)
                .ToList();

            return Ok(userModels);
        }
        [Authorize]
        [HttpDelete("/api/user/{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            _logger.LogInformation("Deleting a User");
            var response = _userService
                .DeleteUser(id);
            return Ok(response);
        }
    }
}
