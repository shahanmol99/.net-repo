using System;
using System.Collections.Generic;
using ContactsDBApp.Model;

namespace ContactsDBApp.Data
{
    interface DataAccess
    {
        void AddContacts(String name, String contactNumber);
        List<Contact> GetContacts();
        void CloseDB();
    }
}
