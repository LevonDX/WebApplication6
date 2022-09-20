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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Food food = _foodDbContext.Foods.Find(id)!;

            return View(food);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Food food)
        {
            _foodDbContext.Foods.Update(food);
            
            await _foodDbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
