using System;
using System.Collections.Generic;
namespace AddressBook.Objects
{
  public class Contact
  {
    private static List<Contact> _contacts = new List<Contact> {};

    private int _id;
    private string _name;
    private string _phoneNumber;
    private Address _address;
    private string _groupName;

    public Contact(string name, string phoneNumber, Address address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
      _contacts.Add(this);
      _id = _contacts.Count;
    }
    public void SetGroupName(string groupName)
    {
      _groupName = groupName;
    }
    public int GetId()
    {
      return _id;
    }
    public string GetName()
    {
      return _name;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public Address GetAddress()
    {
      return _address;
    }
    public static List<Contact> GetAllContacts()
    {
      return _contacts;
    }
    public string GetGroupName()
    {
      return _groupName;
    }
    public static Contact FindContact(int searchId)
    {
      if (searchId-1 > _contacts.Count) {
        return null;
      }
      else
      {
        return _contacts[searchId-1];
      }
    }
    public static void ClearAddressBook()
    {
      _contacts.Clear();
    }
    public void DeleteContact()
    {
      _contacts.Remove(this);
    }
    public static List<Contact> GetSearchContacts (string searchBy, string searchParameter)
    {
      List<Contact> matchContacts = new List<Contact>{};
      if (searchBy == "name") {
        foreach (Contact item in _contacts) {
          if (item._name == searchParameter) {
            matchContacts.Add(item);
          }
        }
        return matchContacts;
      }
      else if (searchBy == "phoneNumber") {
        foreach (Contact item in _contacts) {
          if (item._phoneNumber == searchParameter) {
            matchContacts.Add(item);
          }
        }
        return matchContacts;
      }
      else {
        return matchContacts;
      }
    }
  }
}
