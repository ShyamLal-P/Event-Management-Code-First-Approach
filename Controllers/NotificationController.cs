using EventManagementTrialCFA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementTrialCFA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private EventManagementDbContext _context;
        public NotificationController(EventManagementDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public void Create([FromBody] Notification notification)
        {
            _context.Notifications.Add(notification);
            _context.SaveChanges();
        }
        [HttpGet]
        public List<Notification> GetEvents()
        {
            return _context.Notifications.ToList();
        }
    }
}
