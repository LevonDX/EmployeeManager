using EmployeeManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManager.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("Product/List")]
        public IActionResult List() // Server endpoint
        {
            // 1) ViewData - Dictionary
            // 2) ViewBag - Dynamic Property
            // 3) TempData - Dictionary
            // 4) Strongly Typed Views

            //ProductViewModel model = new ProductViewModel();
            //model.Name = "Laptop";
            //model.Category = "Electronics";
            //model.Price = 1200;
            //model.Description = "Dell Inspiron 15 3000 Series";


            //ViewData["Product"] = model;

            //ViewBag.Product = model;


            List<ProductViewModel> model = new List<ProductViewModel>();
            model.Add(new ProductViewModel() { Name = "Laptop", Category = "Electronics", Price = 1200, Description = "Dell Inspiron 15 3000 Series" });
            model.Add(new ProductViewModel() { Name = "Mobile", Category = "Electronics", Price = 800, Description = "Samsung Galaxy S10" });
            model.Add(new ProductViewModel() { Name = "Shirt", Category = "Clothing", Price = 50, Description = "Van Heusen" });
            model.Add(new ProductViewModel() { Name = "Trousers", Category = "Clothing", Price = 60, Description = "Levis" });


            return View(model); // HTML Page
        }

        [HttpPost]
        public IActionResult Add(ProductViewModel model)
        {
            return View(model);
        }
    }
}
