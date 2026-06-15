using Microsoft.AspNetCore.Mvc;
using MVCProject1.Data;
using MVCProject1.Models;

namespace MVCProject1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var categories = context.Categories.AsNoTracking().ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        
        public IActionResult Store(Category request)
        {
            context.Categories.Add(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var category = context.Categories.Find(id);
            return View(category);
        }
        public IActionResult Update(Category request, int id)
        {
            var category = context.Categories.Find(id);
            request.Id = id;
            context.Categories.Update(request);
                context.SaveChanges();
            
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var category = context.Categories.Find(id);
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
