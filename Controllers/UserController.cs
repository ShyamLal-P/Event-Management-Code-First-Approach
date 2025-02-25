using EventManagementTrialCFA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementTrialCFA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private EventManagementDbContext _context;
        public UserController(EventManagementDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public void Create([FromBody] User User)
        {
            _context.Users.Add(User);
            _context.SaveChanges();
        }
        [HttpGet]
        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
