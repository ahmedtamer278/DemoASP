using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace DemoASP.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //var result = new ContentResult();
            //result.Content = "Hello From Home Index";
            //result.StatusCode = StatusCodes.Status200OK;
            //result.StatusCode = (int)HttpStatusCode.OK;
            //result.ContentType = "Object/Pdf";=> Download
            //return "Hello From Home Index";
            //return Content("Hello From Home Index");
            return View(); // View named Index => Html 
            // Views/Home/Index.csHtml
        } 
        public IActionResult Privacy()
        {
            
            return View(); 
        }

        public IActionResult Redirect()
        {
            //var result = new RedirectResult("Https://www.google.com");
            //return result;
            return Redirect("https://localhost:7108/Products");
        }

        public IActionResult RedirectToAction()
        {
            //var result = new RedirectToActionResult(nameof(ProductsController.Get),nameof(ProductsController).Replace("Controller",""),new {id =10});
            return RedirectToAction(nameof(ProductsController.Get), nameof(ProductsController).Replace("Controller", ""), new { id = 10 });
        }
    }
}
