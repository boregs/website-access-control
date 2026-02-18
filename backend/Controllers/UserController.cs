using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Data;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _dao.Users.Select(x => new UserModel
            {
                Id = x.Id,
                Username = x.Username,
                Email = x.Email,
                Password = x.Password,
                LastName = x.LastName,
                FirstName = x.FirstName
            }).ToListAsync();

            return Ok(result);
            
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] UserModel user)
        {
            _dao.Users.Add(user);
            await _dao.SaveChangesAsync();

            return Ok(user);
        }

        [HttpPut("EditUser")]
        public async Task<IActionResult> EditUser([FromBody] UserModel user)
        {
            var rows = await _dao.Users.Where(x => x.Id == user.Id).ExecuteUpdateAsync(x => x
                .SetProperty(x => x.Username, user.Username)
                .SetProperty(x => x.Email, user.Email)
                .SetProperty(x => x.Password, user.Password)
            );

            return Ok($"Updated {rows} rows.");
        }

        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var rows = await _dao.Users.Where(x => x.Id == id).ExecuteDeleteAsync();

            return Ok($"Deleted {rows} rows.");
        }
    }
}
