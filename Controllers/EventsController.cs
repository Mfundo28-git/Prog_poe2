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
    }
}
