using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StarterCode.Data;
using StarterCode.Models;

namespace StarterCode.Controllers
{
    [Route("Firewall")]
    public class FirewallController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FirewallController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Post
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Firewalls.ToListAsync());
        }
        // GET: Post/Details/5
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posts = await _context.Posts.FirstOrDefaultAsync(m => m.Id == id);
            if (posts == null)
            {
                return NotFound();
            }

            return View(posts);
        }

        // GET: Post/Create
        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("fw_name,fw_location,fw_site")] Firewall firewall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(firewall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(firewall);
        }

        // GET: Post/Edit/5
        [HttpGet("Edit/{id}")]
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firewalls = await _context.Firewalls.FindAsync(id);
            if (firewalls == null)
            {
                return NotFound();
            }
            return View(firewalls);
        }

        // POST: Post/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("id,fw_name,fw_location,fw_site")] Firewall firewall)
        {
            if (id != firewall.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(firewall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FirewallsExists(firewall.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(firewall);
        }

        // GET: Post/Delete/5
        [HttpGet("Delete/{id}")]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firewall = await _context.Firewalls
                .FirstOrDefaultAsync(m => m.id == id);
            if (firewall == null)
            {
                return NotFound();
            }

            return View(firewall);
        }

        // POST: Post/Delete/5
        [HttpPost("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var firewall = await _context.Firewalls.FindAsync(id);
            if (firewall != null)
            {
                _context.Firewalls.Remove(firewall);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FirewallsExists(long id)
        {
            return _context.Firewalls.Any(e => e.id == id);
        }
    }
}
