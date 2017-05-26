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
        List<Contact> contacts = Contact.GetAllContacts();
        return View["index.cshtml", contacts];
      };
      Get["/contacts/new"] = _ => {
        List<Group> groups = Group.GetAllGroups();
        return View ["create_new_contact.cshtml", groups];
      };
      Post["/contacts/new"] = _ => {
        Address address = new Address(Request.Form["state"], Request.Form["city"], Request.Form["street"]);
        Contact newContact = new Contact(Request.Form["name"], Request.Form["phone"], address);
        Group group = Group.FindGroup(Request.Form["group"]);
        newContact.SetGroupName(group.GetGroupName());
        group.SaveContactIntoGroup(newContact);
        return View["show_new_contact.cshtml", newContact];
      };
      Get["/contacts/{id}"] = parameters => {
        Contact contact = Contact.FindContact(parameters.id);
        return View["show_contact.cshtml", contact];
      };
      Post["/clear"] = _ => {
        Contact.ClearAddressBook();
        List<Contact> contacts = Contact.GetAllContacts();
        return View["index.cshtml", contacts];
      };
      Post["/contacts"] = _ => {
        Contact contact = Contact.FindContact(Request.Form["delete-contact"]);
        contact.DeleteContact();
        List<Contact> contacts = Contact.GetAllContacts();
        return View["index.cshtml", contacts];
      };
      Post["/groups/new"] = _ => {
        Group group = new Group (Request.Form["group-name"]);
        List<Group> groups = Group.GetAllGroups();
        return View["create_new_contact.cshtml", groups];
      };
      Get ["/search"] = _ => View ["search_contacts.cshtml"];
    }
  }
}
