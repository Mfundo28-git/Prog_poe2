using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prog_poe.Data;
using Prog_poe.Models;
using System.Security.Claims;



namespace Prog_poe.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : Controller
    {

        private readonly ApplicationDBContext _context;
        public IActionResult Index()
        {
            return View();
        }

        // Both roles can view all events
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            var events = await _context.Events
                .AsNoTracking()
                .ToListAsync();

            return Ok(events);
        }
    }
}
