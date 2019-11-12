using PhoneStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneStore.Controllers
{
    public class HomeController : Controller
    {
        //create data context
        PhoneContext db = new PhoneContext();
        public ActionResult Index()
        {
            //get all objects Phone from BD
            IEnumerable<Phone> phones = db.Phones;
            //transmit all objects into dynamic property Phones in ViewBag
            ViewBag.Phones = phones;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.PhoneId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            //Add information into DB about purchase
            db.Purchases.Add(purchase);
            //save all changes into DB

            db.SaveChanges();
            return "Спасибо, " + purchase.Person + ", за покупку!";
        }
    }
}