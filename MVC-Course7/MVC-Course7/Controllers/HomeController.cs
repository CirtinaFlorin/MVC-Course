using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Course7.Controllers
{
    //Exercise 1 - Course 7
    public class HomeController: Controller
    {
        [ActionName ("about")]
        public ActionResult SomeMethodName() {
            return View();
        }
        public ActionResult index()
        {
            return View();
        }

        //Exercise 3 - Course 7
        [NonAction]
        public int Calc() {
            return 1 + 2 + 3;
        }

        public int displayCalc() {
            return Calc();
        }

        //Exercise 4 - Course 7
        [HttpGet]
        public ActionResult VerbTest() {
            return Content ("Hello");
        }

        //Exercise 5 - Course 7
        [ActionName ("authorize")]
        [Authorize (Roles = "Admin")]
        public ActionResult ThisMethodNeedsAuthorization() {
            return Content("Hello");
        }


    }
}