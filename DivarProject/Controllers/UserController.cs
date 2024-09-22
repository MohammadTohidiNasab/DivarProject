using DivarProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DivarProject.Controllers
{
    public class UserController : Controller
    {
        private readonly AdvertisementDbContext _context;

        public UserController(AdvertisementDbContext context)
        {
            _context = context;
        }

        public IActionResult Profile(int id)
        {
            var user = _context.Users.Include(u => u.Advertisements).FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
    }
}
