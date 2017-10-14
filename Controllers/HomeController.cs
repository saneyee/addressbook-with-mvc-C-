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
            List<Contact> allContacts = Contact.GetAll();
            return View(allContacts);
        }
        [HttpGet("/addacontact")]
        public ActionResult AddContactForm()
        {
            return View();
        }
        [HttpPost("/contact/new")]
        public ActionResult ContactsAdded()
        {
            Contact newContact = new Contact(Request.Form["name"],Request.Form["phone"],Request.Form["address"]);
            List<Contact> allTheContacts = Contact.GetAll();
            return View("ContactCreated", allTheContacts);
        }
        [HttpGet("/contact/new")]
        public ActionResult ContactCreated()
        {
            // List<Contact> ContactsCreated = Contact.GetAll();
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
