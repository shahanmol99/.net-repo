using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsLibrary.Model
{
    public class Contact
    {
        private String _id, _name, _contactNumber;

        public Contact(string id,string name, string contactNumber)
        {
            _id = id;
            _name = name;
            _contactNumber = contactNumber;
        }

        public string ID
        {
            get
            {
                return _id;
            }
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }
        public String ContactNumber
        {
            get
            {
                return _contactNumber;
            }
        }

    }
}
