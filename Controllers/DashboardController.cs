using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StarterCode.Data;

namespace StarterCode.Controllers
{
    [Route("Dashboard")]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Post/Details/5
        [HttpGet("Main")]
        public async Task<IActionResult> Main()
        {
            return View("~/Views/Dashboard/Main.cshtml");
        }

        [HttpGet("Detailed")]
        public async Task<IActionResult> Detailed()
        {
            return View("~/Views/Dashboard/Detailed.cshtml");
        }
    }
}
