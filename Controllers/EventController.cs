using EventManagementTrialCFA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementTrialCFA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private EventManagementDbContext _context;
        public EventController(EventManagementDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public void Create([FromBody] Event Event)
        {
            _context.Events.Add(Event);
            _context.SaveChanges();
        }
        [HttpGet]
        public List<Event> GetEvents()
        {
            return _context.Events.ToList();
        }
    }
}
