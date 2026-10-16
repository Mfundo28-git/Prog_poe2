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
        public IActionResult Index()
        {
            return View();
        }
    }
}
