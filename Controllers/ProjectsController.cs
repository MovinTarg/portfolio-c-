using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace portfolio
{
    public class ProjectsController : Controller
    {
        [HttpGet]
        [Route("/projects")]
        public IActionResult Projects()
        {
            return View();
            //OR
            // return View("Index");
            //Both of these returns will render the same view (You only need one!)
        }
    }
}