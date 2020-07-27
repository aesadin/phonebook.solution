using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;
using System.Collections.Generic;

namespace PhoneBook.Controllers 
{
  public class ContactsController : Controller
  {
    [HttpGet("/contacts/new")]
    public ActionResult New()
    {
    return View();
    }
    
    [HttpPost("contacts/new")]
    public ActionResult Create(string first, string last, string number, string email)
    {
      Contact newContact = new Contact(first, last, number, email);
      newContact.Save(); // this saves newContact in database
      return View("Show", newContact); // this pushes that new contact info to UI
    }
    [HttpGet("/items/{itemId}")]
    public ActionResult Show(int contactId)
    {
      Contact contact = Contact.Find(contactId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("contact", contact);
      return View(model);
    }
  }
}