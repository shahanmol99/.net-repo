using System;
using System.Collections;
using System.Collections.Generic;
using ContactsApp.Model;

namespace ContactsApp.Data
{
    interface DataAccess
    {
        void WriteContacts(String name, String contactNumber);
        List<Contact> GetContacts();
    }
}
