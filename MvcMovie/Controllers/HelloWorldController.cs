using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //Get:/HelloWorld/

        
        //public string Index()
        //{
        //    return "This is my default action....";
        //}

        //
        //GET: /Helloworld/Welcome/

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
