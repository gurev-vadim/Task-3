using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult GroceryList()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult AddProduct()
        {
            return View();
        }
    }
}