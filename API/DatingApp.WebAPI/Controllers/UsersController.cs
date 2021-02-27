using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.WebAPI.Data;
using DatingApp.WebAPI.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async  Task<IActionResult> GetAll()
        {
            var users = await _context.AppUsers.ToListAsync();
            return Ok(users);
        }

        //api/users/3
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _context.AppUsers.FindAsync(id);
            if(user == null)
                return BadRequest();
            
            return Ok(user);
        }
    }
}