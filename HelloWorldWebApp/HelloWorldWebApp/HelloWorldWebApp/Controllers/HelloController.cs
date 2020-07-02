using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldWebApp.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Hello1()
        {
            //var result = new ContentResult
            //{
            //    StatusCode = 200, //default anyway
            //    ContentType = "test/html",
            //    Content = "<html><head></head><body>Hello controller</body></html>"

            //};
            //return result;
            ViewResult result = View("Hello", "this string is the model");
            return result;
        }


        //this class can contain action methods and nonaction methods
        [NonAction]
        public void HelperMethod()
        {

        }
    }
}
