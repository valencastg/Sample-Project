using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        /*
         * Authorize the page for any logged in user
         * Try to uncomment the following code.
         * Then run the application & access the "Contact" page in the followint 2 cases:
         *    1. no one logged in the app
         *    2. anyone logged in the app
         */
        //[Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return RedirectToAction("index", "ContactGVCs");
            return View();
        }

        public ActionResult Contact()
        {

            ViewBag.Message = "Your contact page.";

            /*
             * Authorize the page for a paticular user
             * Try to comment out the original "return View()" statement,
             * and uncomment the following code.
             * Then run the application & access the "Contact" page in the followint 3 cases:
             *    1. no one logged in the app
             *    2. email "qiaoli.116@gmail.com" logged in the app
             *    3. someone else logged in the app
             */
            
             
            if (User.Identity.Name == "valencastg@gmail.com")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
                //return RedirectToAction("ContactGVCs", "ContactGVCs");
            }
            
            return View();
        }

        
    }
}