using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace portfolio
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/home")]
        public IActionResult Index()
        {
            return View();
            //OR
            // return View("Index");
            //Both of these returns will render the same view (You only need one!)
        }
    }
}