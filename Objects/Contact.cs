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

    public Contact(string name, string phoneNumber, Address address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
      _contacts.Add(this);
      _id = _contacts.Count;
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
  }
}
