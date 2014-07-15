using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        // Get Home/about
        public ActionResult About()
        {
            return View();
        }
        // Get: Home/Work/
        public ActionResult Work()
        {
            return View();
        }
        // Get: Home/ Contact
        [HttpGet]
        public ActionResult Contact()
        {
            Models.ContactsForm cf = new Models.ContactsForm();
            return View(cf);
                
        
        }
        // post home contacts
        [HttpPost]
        public ActionResult Contact(Models.ContactsForm cf)
    {
        Models.NathanielEntities db = new Models.NathanielEntities();
        db.ContactsForms.Add(cf);
        db.SaveChanges();
        return RedirectToAction("ThankYou");

    }
        // redirect usre to thank you page
        public ActionResult ThankYou()
    {
        return View();
    }
        // my addin of link My Bio
        public ActionResult MyBio()
        {
            return View();
        
        }
    }

}
