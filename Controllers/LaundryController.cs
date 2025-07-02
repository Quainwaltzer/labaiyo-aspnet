using LabaIyo.Data;
using LabaIyo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LabaIyo.Controllers
{
    [Authorize]
    public class LaundryController : Controller
    {
        private readonly LaundryDbContext _context;

        public LaundryController(LaundryDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Order()
        {
            var laundries = _context.laundryDb
             .Include(l => l.items)
             .ToList();

            return View(laundries);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Laundry laundry)
        {
          
                _context.laundryDb.Add(laundry);
                _context.SaveChanges();
                return RedirectToAction("Order");
            

            return View(laundry);
        }
    }
}
