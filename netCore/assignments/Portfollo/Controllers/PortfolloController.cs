using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace Portfollo.Controllers
{
    public class PortfolloController : Controller
    {
        [HttpGet]
        [Route("")]

        public IActionResult Index()
        {
            // return View();
            //OR
            return View("Index");
            //Both of these returns will render the same view (You only need one!)
        }
        
        [HttpGet]
        [Route("/project")]

        public IActionResult Project()
        {
            // return View();
            //OR
            return View("Project");
            //Both of these returns will render the same view (You only need one!)
        }

        [HttpGet]
        [Route("/Contact")]

        public IActionResult Contact()
        {
            // return View();
            //OR
            return View("Contact");
            //Both of these returns will render the same view (You only need one!)
        }

    }
}