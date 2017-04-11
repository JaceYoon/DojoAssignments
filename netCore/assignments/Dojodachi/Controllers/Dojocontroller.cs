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
            string msg = HttpContext.Session.GetString("msg");
            int? imgnum = HttpContext.Session.GetInt32("imgnum");
            
            if(imgnum == null){
                imgnum = 1;
            }
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
            if(msg == null){
                HttpContext.Session.SetString("msg", "Eevee is home!! What is the next?");
            }

            if(fullness < 1 || happiness < 1|| energy <1){
                HttpContext.Session.SetString("msg", "Eevee got mad!! She bites you !!  <<Game Over>>");
                string endmsg = HttpContext.Session.GetString("msg");
                ViewBag.msg = endmsg;
                return RedirectToAction("Index");
            }
            if(fullness > 100 && happiness > 100 && energy >100){
                HttpContext.Session.SetString("msg", "You are successfully tamed Eevee! She loves you!");
                string endmsg = HttpContext.Session.GetString("msg");
                ViewBag.msg = endmsg;
                return RedirectToAction("Index");
            }
            string newmsg = HttpContext.Session.GetString("msg");
            ViewBag.fullness = fullness;
            ViewBag.happiness = happiness;
            ViewBag.meals = meals;
            ViewBag.energy = energy;
            ViewBag.msg = newmsg;
            ViewBag.imgnum = "/img/Eevee" + imgnum + ".jpg" ;
            return View();
        }

        [HttpGet]
        [Route("/feed")]
        public IActionResult Feed(){
            int? fullness = HttpContext.Session.GetInt32("fullness");
            int? meals = HttpContext.Session.GetInt32("meals");
            int? imgnum = HttpContext.Session.GetInt32("imgnum");
            
            if(fullness == null){
                fullness = 20;
            }
            if(meals == null){
                meals = 3;
            }
            if(meals > 0){
                meals -= 1;
                Random rand = new Random();
                int luck = rand.Next(1,5);
                if(luck == 4){
                    HttpContext.Session.SetString("msg", "You gave her bone but she looks like don't like it");
                    imgnum = 623;
                    string msg = HttpContext.Session.GetString("msg");
                    ViewBag.meals = meals;
                    ViewBag.msg = msg;
                    ViewBag.imgnum = imgnum;

                    HttpContext.Session.SetInt32("imgnum", (int)imgnum);
                    HttpContext.Session.SetInt32("meals", (int)meals);
                    return RedirectToAction("Index");
                }else{
                    fullness += rand.Next(5,11);
                    imgnum = 223;
                    HttpContext.Session.SetString("msg", "She loves Peanut Butter!");
                    string msg = HttpContext.Session.GetString("msg");
                    ViewBag.meals = meals;
                    ViewBag.fullness = fullness;
                    ViewBag.msg = msg;
                    ViewBag.imgnum = imgnum;

                    HttpContext.Session.SetInt32("imgnum", (int)imgnum);
                    HttpContext.Session.SetInt32("fullness", (int)fullness);
                    HttpContext.Session.SetInt32("meals", (int)meals);

                    return RedirectToAction("Index");
                }    
            }else{
                HttpContext.Session.SetString("msg", "Food is empty");
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        [Route("/play")]
        public IActionResult Play(){
            int? happiness = HttpContext.Session.GetInt32("happiness");
            int? energy = HttpContext.Session.GetInt32("energy");
            int? imgnum = HttpContext.Session.GetInt32("imgnum");
            
            if(happiness == null){
                happiness = 20;
            }
            if(energy == null){
                energy = 50;
            }
            if(energy > 1){
                energy -= 3;
                Random rand = new Random();
                int luck = rand.Next(1,5);
                if(luck == 4){
                    HttpContext.Session.SetString("msg", "You Threw the ball and hit Eevee's face.... :(");
                    imgnum = 123;
                    string msg = HttpContext.Session.GetString("msg");
                    ViewBag.energy = energy;
                    ViewBag.msg = msg;
                    ViewBag.imgnum = imgnum;
                    HttpContext.Session.SetInt32("energy", (int)energy);
                    HttpContext.Session.SetInt32("imgnum", (int)imgnum);
                    return RedirectToAction("Index");
                }else{
                    happiness += rand.Next(5,11);
                    HttpContext.Session.SetString("msg", "You Threw the ball and Eevee ran to the ball with smile!");
                    imgnum = 823;
                    string msg = HttpContext.Session.GetString("msg");
                    ViewBag.happiness = happiness;
                    ViewBag.energy = energy;
                    ViewBag.msg = msg;
                    ViewBag.imgnum = imgnum;

                    HttpContext.Session.SetInt32("energy", (int)energy);
                    HttpContext.Session.SetInt32("happiness", (int)happiness);
                    HttpContext.Session.SetInt32("imgnum", (int)imgnum);
                    return RedirectToAction("Index");
               }
            }else{
                return RedirectToAction("Index");   
            }
        }

        [HttpGet]
        [Route("/work")]
        public IActionResult Work(){
            int? meals = HttpContext.Session.GetInt32("meals");
            int? energy = HttpContext.Session.GetInt32("energy");
            int? imgnum = HttpContext.Session.GetInt32("imgnum");
            if(meals == null){
                meals = 3;
            }
            if(energy == null){
                energy = 50;
            }
            energy -= 5;
            Random rand = new Random();
            meals += rand.Next(1,4);
            imgnum = 923;
            HttpContext.Session.SetString("msg", "Shes digging.. and found a bound!");
            string msg = HttpContext.Session.GetString("msg");

            ViewBag.meals = meals;
            ViewBag.energy = energy;
            ViewBag.msg = msg;
            ViewBag.imgnum = imgnum;
            HttpContext.Session.SetInt32("energy", (int)energy);
            HttpContext.Session.SetInt32("meals", (int)meals);
            HttpContext.Session.SetInt32("imgnum", (int)imgnum);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/sleep")]
        public IActionResult Sleep(){
            int? happiness = HttpContext.Session.GetInt32("happiness");
            int? energy = HttpContext.Session.GetInt32("energy");
            int? fullness = HttpContext.Session.GetInt32("fullness");
            int? imgnum = HttpContext.Session.GetInt32("imgnum");
            if(happiness == null){
                happiness = 20;
            }
            if(energy == null){
                energy = 50;
            }
            if(fullness == null){
                fullness = 20;
            }
            
            energy += 15;
            fullness -= 5;
            happiness -= 5;
            imgnum = 323;
            HttpContext.Session.SetString("msg", "She went to bad.. rockabye baby..");
            string msg = HttpContext.Session.GetString("msg");
            ViewBag.happiness = happiness;
            ViewBag.energy = energy;
            ViewBag.fullness = fullness;
            ViewBag.msg = msg;
            ViewBag.imgnum = imgnum;

            HttpContext.Session.SetInt32("energy", (int)energy);
            HttpContext.Session.SetInt32("happiness", (int)happiness);
            HttpContext.Session.SetInt32("fullness", (int)fullness);
            HttpContext.Session.SetInt32("imgnum", (int)imgnum);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/reset")]
        public IActionResult Reset(){
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}