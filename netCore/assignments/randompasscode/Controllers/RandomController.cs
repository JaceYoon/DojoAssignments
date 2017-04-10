using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
// using Newtonsoft.Json;
 
namespace randompasscode.Controllers
{
    public class randompasscodeController : Controller
    {
        [HttpGet]
        [Route("")]

        public IActionResult Index()
        {
            int? Count = HttpContext.Session.GetInt32("Count");
            if(Count == null){
                Count = 0;
            }
            Count ++;
            string RandCode = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string PassCode = "";

            Random rand = new Random();
            for(var i = 0; i < 14; i++){
                PassCode += RandCode[rand.Next(0,RandCode.Length)];
            }
            ViewBag.PassCode = PassCode;
            ViewBag.Count = Count;
            HttpContext.Session.SetInt32("Count", (int)Count);

            return View();
        }
    }
}