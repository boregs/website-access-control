using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Data;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly DAO _dao;
        public UserController(DAO dao)
        {
            _dao = dao;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _dao.Users.ToList();
            return Ok("All users retrieved successfully.");
        }

        [HttpPost]
        public IActionResult CreateUser(UserModel user)
        {
            _dao.Users.Add(user);
            _dao.SaveChanges();
            return Ok("User created successfully." + user.Username);
        }
    }
}
