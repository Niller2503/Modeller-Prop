using System;
using Modeller_Prop.DataAccess;
using Modeller_Prop.Models;

Contacts contact1 = new Contacts();
ContactDBAccess contactDBAccess = new ContactDBAccess();
Contacts contact= new Contacts
{

   // Id = 6,
    Firstname = "niels",
    Lastname = "Nielsen",
    Address = "Tusindbenet 24",
    Pnumber = 9190,
    By = "Billund",
    Tlf = 50395096,
    Email = "nielsNielsen@gmail.com"
};
contactDBAccess.TilfojContact(contact);

contact = new();


foreach (Contacts contact4 in contactDBAccess.Get())
{


    Console.WriteLine($"Id: {contact.Id}, Firstname: {contact.Firstname}, Lastname: {contact.Lastname}");
}
