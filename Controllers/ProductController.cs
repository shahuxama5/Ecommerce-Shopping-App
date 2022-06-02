using ECommerceShoppingApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceShoppingApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.findAll();
            return View();
        }
    }
}
