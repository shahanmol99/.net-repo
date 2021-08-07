using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsDBApp.Model
{
    class Contact
    {
        private String _name, _contactNumber;

        public Contact(string name, string contactNumber)
        {
            _name = name;
            _contactNumber = contactNumber;
        }

        public String GetName
        {
            get
            {
                return _name;
            }
        }
        public String GetContactNumber
        {
            get
            {
                return _contactNumber;
            }
        }
    }
}
