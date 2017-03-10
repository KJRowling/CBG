using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CBG.Controllers

{
    //inherit from controller class
    //controller classes must be public
    public class ComicBooksController : Controller
    {
        //every public method on a controller is an "action method"
        //can't be void??
        //must be public or mvc won't be able to find and call

            //actionresult almost always used for return type of action methods
        public ActionResult Detail()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                
                    return Redirect("/"); //Return string for target URL

            }

            return Content("Hello");

        }

        public string Index()
        {
            return "index";
        }

    }
}