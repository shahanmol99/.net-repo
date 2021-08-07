using System;
using System.Collections.Generic;
using ContactsLibrary.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsLibrary.Data
{
    public interface DataAccess
    {
        bool AddContacts(string name, string contactNumber, string address, string street, string city, string pincode);
        List<Contact> GetContacts();
        List<ContactsWithAddress> GetContactAndAddress();
        bool AddAddress(string id, string address, string street, string city, string pin);
        //void CloseDB();
    }
}
