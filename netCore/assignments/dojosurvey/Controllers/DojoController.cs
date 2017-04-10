using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace DojoSurvey.Controllers
{
    public class DojoSurveyController : Controller
    {
        [HttpGet]
        [Route("")]

        public IActionResult Index()
        {
            return View("Index");
        }
        
        // [HttpGet]
        // [Route("/result")]

        // public IActionResult Result()
        // {
        //     return View("Result");
        // }

        [HttpPost]
        [Route("/submit")]

        public IActionResult Method(string fname, string lname, string location, string language, string comment)
        {   
            ViewBag.name = fname + lname;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View("Result");
        }

    }
}