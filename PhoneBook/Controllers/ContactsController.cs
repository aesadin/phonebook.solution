using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;
using System.Collections.Generic;

namespace PhoneBook.Controllers 
{
  public class ContactsController : Controller
  {
    [HttpGet("/contacts/new/")]
    public ActionResult New()
    {
    return View();
    }
  }
}