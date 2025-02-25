using EventManagementTrialCFA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementTrialCFA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private EventManagementDbContext _context;
        public FeedbackController(EventManagementDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public void Create([FromBody] Feedback feedback)
        {
            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();
        }
        [HttpGet]
        public List<Feedback> GetEvents()
        {
            return _context.Feedbacks.ToList();
        }
    }
}
