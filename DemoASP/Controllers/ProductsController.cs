using System.Xml.Linq;
using DemoASP.Model;
using Microsoft.AspNetCore.Mvc;

namespace DemoASP.Controllers
{
    public class ProductsController : Controller
    {
        //                           => 1.Form Data
        //baseUrl/Products/Get/20    => 2.Route Data
        //baseUrl/Products/Get?id=20 => 3.Query String
        //                           => Request Headers
        //[HttpPost]
        public string Get(int id,string name) // simple object
        {
            return $"Product {name} :: {id}";
        }
        public string Create(Product product) // Complex Object
        {
           return $"Product {product.Name} :: {product.Id}";
        }
        public string Index()
        {
            return "Hello From Product Index";
        }
    }
}
