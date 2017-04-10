using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
 
namespace Dojodachi.Controllers
{
    public class DojodachiController : Controller
    {
        [HttpGet]
        [Route("")]

        public IActionResult Index()
        {   
            int? fullness = HttpContext.Session.GetInt32("fullness");
            int? happiness = HttpContext.Session.GetInt32("happiness");
            int? meals = HttpContext.Session.GetInt32("meals");
            int? energy = HttpContext.Session.GetInt32("energy");
            if(fullness == null){
                fullness = 20;
            }
            if(happiness == null){
                happiness = 20;
            }
            if(energy == null){
                energy = 50;
            }
            if(meals == null){
                meals = 3;
            }

            ViewBag.fullness = fullness;
            ViewBag.happiness = happiness;
            ViewBag.meals = meals;
            ViewBag.energy = energy;
            ViewBag.msg = "Eevee is home now!!";
            return View();
        }

        [HttpGet]
        [Route("/feed")]
        public IActionResult Feed(){
            int? fullness = HttpContext.Session.GetInt32("fullness");
            int? meals = HttpContext.Session.GetInt32("meals");
            if(fullness == null){
                fullness = 20;
            }
            if(meals == null){
                meals = 3;
            }
            meals -= 1;
            Random rand = new Random();
            fullness += rand.Next(5,11);

            ViewBag.meals = meals;
            ViewBag.fullness = fullness;
            ViewBag.msg = "You are feeding Eevee!!";

            HttpContext.Session.SetInt32("fullness", (int)fullness);
            HttpContext.Session.SetInt32("meals", (int)meals);

            // return Redirect("/");
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/play")]
        public IActionResult Play(){
            int? happiness = HttpContext.Session.GetInt32("fullness");
            int? energy = HttpContext.Session.GetInt32("energy");
            if(happiness == null){
                happiness = 20;
            }
            if(energy == null){
                energy = 50;
            }
            energy -= 3;
            Random rand = new Random();
            happiness += rand.Next(5,11);

            ViewBag.happiness = happiness;
            ViewBag.energy = energy;
            ViewBag.msg = "You are feeding Eevee!!";

            HttpContext.Session.SetInt32("energy", (int)energy);
            HttpContext.Session.SetInt32("happiness", (int)happiness);

            // return Redirect("/");
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/work")]
        public IActionResult Work(){
            int? meals = HttpContext.Session.GetInt32("meals");
            int? energy = HttpContext.Session.GetInt32("energy");
            if(meals == null){
                meals = 3;
            }
            if(energy == null){
                energy = 50;
            }
            energy -= 5;
            Random rand = new Random();
            meals += rand.Next(1,4);

            ViewBag.meals = meals;
            ViewBag.energy = energy;
            ViewBag.msg = "You are feeding Eevee!!";

            HttpContext.Session.SetInt32("energy", (int)energy);
            HttpContext.Session.SetInt32("meals", (int)meals);

            // return Redirect("/");
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/sleep")]
        public IActionResult Sleep(){
            int? happiness = HttpContext.Session.GetInt32("happiness");
            int? energy = HttpContext.Session.GetInt32("energy");
            int? fullness = HttpContext.Session.GetInt32("fullness");
            if(happiness == null){
                happiness = 20;
            }
            if(energy == null){
                energy = 50;
            }
            if(fullness == null){
                fullness = 20;
            }
            
            energy -= 15;
            fullness -= 15;
            happiness += 5;

            ViewBag.happiness = happiness;
            ViewBag.energy = energy;
            ViewBag.fullness = fullness;
            ViewBag.msg = "You are feeding Eevee!!";

            HttpContext.Session.SetInt32("energy", (int)energy);
            HttpContext.Session.SetInt32("happiness", (int)happiness);
            HttpContext.Session.SetInt32("fullness", (int)fullness);

            // return Redirect("/");
            return RedirectToAction("Index");
        }

    }
}