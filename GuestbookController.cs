using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using assignment_3.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using assignment_3.Models;

namespace assignment_3.Controllers
{
    public class GuestbookController : Controller
    {
        private readonly ILogger<GuestbookController> _logger;
        private readonly ApplicationDbContext _db;

        public GuestbookController(ILogger<GuestbookController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        // GET
        public IActionResult Index()
        {
            _logger.LogDebug("GET Guestbook/Index");

            ViewBag.Message = "This page was generated by the HTTP GET handler in Controllers/GuestbookController.cs";
            
            return View(_db.Guests.ToList());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new Guestbook());
    }

        [HttpPost]
        public IActionResult Add(Guestbook guestbook)
        {
            _logger.LogDebug("POST Guestbook/Index");

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Received invalid model");

                return View(guestbook);
            }

            _db.Guests.Add(guestbook);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
    

}