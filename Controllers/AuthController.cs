using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prog_poe.Data;
using Prog_poe.Models;

namespace Prog_poe.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AuthController
    {
        private readonly ApplicationDBContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;

        public AuthController(
            ApplicationDBContext context,
            IPasswordHasher<User> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

       

    }
}
