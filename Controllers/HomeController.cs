using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System.Collections.Generic;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        
        // [HttpGet("/")]
        // public ActionResult Index()
        // {
        //     return View();
        // }
        [HttpPost("/clearAllContacts")]
        public ActionResult ClearAllContacts()
        {
            Contact.ClearAll();
            return View();
        }

    }
}
