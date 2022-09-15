using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Data;
using WebApplication6.Data.Entities;

namespace WebApplication6.Controllers
{
    public class FoodController : Controller
    {
        private readonly FoodDbContext _foodDbContext;

        public FoodController(FoodDbContext foodDbContext)
        {
            _foodDbContext = foodDbContext;
        }

        public async Task<IActionResult> Index()
        {
            List<Food> foods = await _foodDbContext.Foods.ToListAsync();

            return View(foods);
        }
    }
}
