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
        public ActionResult ContactCreated()
        {
            Contact newContact = new Contact(Request.Form["name"],Request.Form["phone"],Request.Form["address"]);
            List<Contact> allContacts = Contact.GetAll();
            return View();
        }
        [HttpGet("/contacts")]
        public ActionResult ContactList()
        {
            List<Contact> allContacts = Contact.GetAll();
            return View("Index",allContacts);
        }
        [HttpGet("/contacts/{id}")]
        public ActionResult ContactDetailsView(int id)
        {
            Contact contact = Contact.Find(id);
            return View(contact);
        }

        [HttpPost("/clearAllContacts")]
        public ActionResult ClearAllContacts()
        {
            Contact.ClearAll();
            return View();
        }

    }
}
