using DivarProject.Data;
using DivarProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DivarProject.Controllers
{
    [Authorize]
    public class AdvertisementController : Controller
    {
        private readonly AdvertisementDbContext _context;

        public AdvertisementController(AdvertisementDbContext context)
        {
            _context = context;
        }

        // نمایش لیست آگهی‌ها برای همه کاربران
        [AllowAnonymous]
        public IActionResult Index()
        {
            var ads = _context.advertisements.Include(a => a.User).ToList();
            return View(ads);
        }

        // فقط کاربران وارد شده می‌توانند آگهی ایجاد کنند
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Advertisement advertisement)
        {
            if (ModelState.IsValid)
            {
                _context.advertisements.Add(advertisement);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(advertisement);
        }
    }
}
