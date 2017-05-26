using System;
using System.Collections.Generic;
using Nancy;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        // Address address = new Address ("Oregon", "Portland", "5th Ave, 400");
        // Contact newContact = new Contact("Epicodus", "8-888-888-88", address);
        List<Contact> contacts = Contact.GetAllContacts();
        return View["index.cshtml", contacts];
      };
      Get["/contacts/new"] = _ => View ["create_new_contact.cshtml"];
      Post["/contacts/new"] = _ => {
        Address address = new Address(Request.Form["state"], Request.Form["city"], Request.Form["street"]);
        Contact newContact = new Contact(Request.Form["name"], Request.Form["phone"], address);
        return View["show_new_contact.cshtml", newContact];
      };
      Get["/contacts/{id}"] = parameters => {
        Contact searchContact = Contact.FindContact(parameters.id);
        return View["show_contact.cshtml", searchContact];
      };
      Post["/clear"] = _ => {
        Contact.ClearAddressBook();
        List<Contact> contacts = Contact.GetAllContacts();
        return View["index.cshtml", contacts];
      };
    }
  }
}
