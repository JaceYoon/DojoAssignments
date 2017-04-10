using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class HelloController : Controller
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

        // public JsonResult Example()
        // {   
        //     object obj = new {
        //         name = "Noname",
        //         Age = "100",
        //         FavoriteColor = "white"
        //     };
        //     return Json(obj);
        // }

        [HttpGet]
        [Route("{firstname}/{lastname}/{age}/{favoritecolor}")]

        public JsonResult New(string firstname, string lastname, int age, string favoritecolor)
        {   
            object obj = new {
                name = firstname + lastname,
                age = age,
                favoritecolor = favoritecolor
            };
            return Json(obj);
        }

    }
}