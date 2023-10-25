using Modeller_Prop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modeller_Prop.DataAccess
{
    public class ContactDBAccess
    {
         List<Contacts> contactList;


        public ContactDBAccess()
        {
            contactList = new List<Contacts>();
        }
        public bool Create(Contacts contact)
        {
            //min 2 maks 50 string
            bool isValid = ValidateModel(contact);
            if (isValid)
            {
                contact.Id=FindNextId();
                contactList.Add(contact);
                return true;

            }
            return true;
        }
        bool ValidateModel(Contacts contacts)
        {
            if (contacts != null)
            {
                if(contacts.Firstname.Length>1 && contacts.Firstname.Length < 51)
                {
                    if(contacts.Lastname.Length > 1 && contacts.Lastname.Length < 51)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        int FindNextId()
        {
            int next = 0;
            foreach(var item in contactList)
            {
                if (item.Id > next)
                {
                    next = item.Id;
                }  
            }
            return next + 1;

        }
        public List<Contacts> Get()
        {
            return contactList;
        }
        public Contacts Get(int id)
        {
            if (contactList != null)
            {
                foreach(var con in contactList)
                {
                    if(con.Id == id)
                    {
                        return con;
                    }
                }
            }
            return new Contacts();
        }
        public ContactdbAccess()
        {
            contactList = new List<Contacts>
            {
                new Contacts() { Id = 1, Firstname = "Niels", Lastname = "Nielsen", Address = "Tusindbenet 24", Pnumber = 7190, By = "Billund", Tlf = 50295029, Email = "NielsNielsen@gmail.com" },
                new Contacts() { Id = 2, Firstname = "Lars", Lastname = "Nielsen", Address = "Tusindbenet 23", Pnumber = 6190, By = "Billund", Tlf = 50503929, Email = "LarsNielsen@gmail.com" },
                new Contacts() { Id = 3, Firstname = "Niels Lars", Lastname = "Nielsen", Address = "Tusindbenet 22", Pnumber = 5190, By = "Billund", Tlf = 50111129, Email = "NielsLarsNielsen@gmail.com" },
                new Contacts() { Id = 4, Firstname = "Lars Niels", Lastname = "Nielsen", Address = "Tusindbenet 21", Pnumber = 4190, By = "Billund", Tlf = 50222229, Email = "LarsNielseNielsen@gmail.com" },
                new Contacts() { Id = 5, Firstname = "Tobias", Lastname = "Nielsen", Address = "Tusindbenet 20", Pnumber = 3190, By = "Billund", Tlf = 55595029, Email = "TobiasNielsen@gmail.com" }
            };
            
        }

        public void TilfojContact(Contacts newContact)
        {
            contactList.Add(newContact);
        }
        
    }
   
}
