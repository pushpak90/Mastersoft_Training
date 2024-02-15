using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/demo")]
    [ApiController]
    public class DemApiController : ControllerBase
    {
        private readonly ApiDemoDbContext _apiDemoDbContext;
        public DemApiController(ApiDemoDbContext apiDemoDbContext)
        {
            _apiDemoDbContext = apiDemoDbContext;
        }

        [HttpGet]
        [Route("get-users-list")]
        public async Task<IActionResult> GetAsync()
        {
            var users = await _apiDemoDbContext.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet]
        [Route("get-user-by-id/{UserId}")]
        public async Task<IActionResult> GetUserByIdAsync(int UserId)
        {
            var user = await _apiDemoDbContext.Users.FindAsync(UserId);
            return Ok(user);
        }

        [HttpPost]
        [Route("create-user")]
        public async Task<IActionResult> PostAsync(Users user)
        {
            _apiDemoDbContext.Users.Add(user);
            await _apiDemoDbContext.SaveChangesAsync();
            return Created($"/get-user-by-id/{user.UserID}", user);
        }

        [HttpPut]
        [Route("update-user")]
        public async Task<IActionResult> PutAsync(Users userToUpdate)
        {
            _apiDemoDbContext.Users.Update(userToUpdate);
            await _apiDemoDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        [Route("delete-user/{UserId}")]
        public async Task<IActionResult> DeleteAsync(int UserId)
        {
            var userToDelete = await _apiDemoDbContext.Users.FindAsync(UserId);
            if(userToDelete == null)
            {
                return NotFound();
            }
            _apiDemoDbContext.Users.Remove(userToDelete);
            await _apiDemoDbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
