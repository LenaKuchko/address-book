using System;
using System.Collections.Generic;
namespace AddressBook.Objects
{
  public class Group
  {
    private static List<Group> _groups = new List<Group> {};
    private int _id;
    private string _groupName;
    private List<Contact> _groupContacts = new List<Contact> {};

    public Group(string groupName)
    {
      _groupName = groupName;
      _groups.Add(this);
      _id = _groups.Count;
    }

    public int GetId()
    {
      return _id;
    }
    public string GetGroupName()
    {
      return _groupName;
    }
    public static List<Group> GetAllGroups()
    {
      return _groups;
    }
    public List<Contact> GetAllGroupContacts()
    {
      return _groupContacts;
    }
    public void SaveContactIntoGroup(Contact newContact)
    {
      _groupContacts.Add(newContact);
    }
  }
}
