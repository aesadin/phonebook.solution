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
    public ActionResult Create(string first, string last, int number, string email)
    {
      Contact newContact = new Contact(first, last, number, email);
      newContact.save();
      newContact.AddContact();

      return;
    }
  
}