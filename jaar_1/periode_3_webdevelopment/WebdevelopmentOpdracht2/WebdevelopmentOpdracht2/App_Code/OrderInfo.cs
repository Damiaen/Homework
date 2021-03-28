using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderInfo
/// </summary>
public class OrderInfo
{

    public string Username { get; set; }
    public string Password { get; set; }
    public string Product { get; set; }
    public string Street { get; set; }
    public int Number { get; set; }
    public string Location { get; set; }

    public OrderInfo(string username, string password, string product, string street, int number, string location)
    {
        Username = username;
        Password = password;
        Product = product;
        Street = street;
        Number = number;
        Location = location;
    }
}