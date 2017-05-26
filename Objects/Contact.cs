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
    private int _groupId;

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
    public int GetGroupId()
    {
      return _groupId;
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
  }
}
