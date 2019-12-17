using Microsoft.AspNetCore.Mvc;
using Phonebook.Data.Models;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (contact.Name != null && contact.Number != null)
            {
                DataAccess.Contacts.Add(contact);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}