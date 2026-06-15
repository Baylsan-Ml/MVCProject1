using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProject1.Data;
using MVCProject1.ViewModels;
using MVCProject1.Models;

namespace MVCProject1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var productsViewModel = context.Products.Include(p => p.Category).AsNoTracking()
                .Select(p => new ProductsViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price=p.Price,
                    Quantity=p.Quantity,
                    Rate=p.Rate,
                    CategoryName=p.Category.Name
                });
           

            return View(productsViewModel);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = context.Categories.AsNoTracking().ToList();
            return View();
        }

        public IActionResult Store(ViewModels.CreateProductViewModel request)
        {
            var product = new MVCProject1.Models.Product
            {
                Name = request.Name,
                Price = request.Price,
                Rate = request.Rate,
                Description = request.Description,
                Quantity = request.Quantity,
                CategoryId = request.CategoryId
            };
            context.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }
        public IActionResult Update(Product request, int id)
        {
            request.Id = id;
            context.Update(request);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
