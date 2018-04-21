using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace portfolio
{
    public class ContactController : Controller
    {
        [HttpGet]
        [Route("/contact")]
        public IActionResult Contact()
        {
            return View();
            //OR
            // return View("Index");
            //Both of these returns will render the same view (You only need one!)
        }
    }
}