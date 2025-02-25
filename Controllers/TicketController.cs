using EventManagementTrialCFA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementTrialCFA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private EventManagementDbContext _context;
        public TicketController (EventManagementDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Ticket> GetTickets()
        {
            return _context.Tickets.ToList();
        }
        [HttpPost]
        public void CreateTicket([FromBody] Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }
    }
}
