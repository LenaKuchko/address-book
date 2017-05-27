using System;
using System.Collections.Generic;
namespace AddressBook.Objects
{
  public class Address
  {
    private string _state;
    private string _city;
    private string _street;

    public Address(string state, string city, string street)
    {
      _state = state;
      _city = city;
      _street = street;
    }
    public string GetState()
    {
      return _state;
    }
    public string GetCity()
    {
      return _city;
    }
    public string GetStreet()
    {
      return _street;
    }
  }
}
