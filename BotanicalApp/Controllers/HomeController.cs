using BotanicalApp.Data;
using BotanicalApp.ViewModels.HomeViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BotanicalApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Products = await _context.Products.Where(p => p.isDeleted == false).ToListAsync()

            };
            return View(homeVM);
        }
    }
}
