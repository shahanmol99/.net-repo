using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsLibrary.Model
{
    public class ContactsWithAddress
    {
        private string id;
        private string contactName;
        private string contactNumber;
        private string address;
        private string street;
        private string city;
        private string pincode;

        public ContactsWithAddress(string id, string contactName, string contactNumber, string address, string street, string city, string pincode)
        {
            this.id = id;
            this.contactName = contactName;
            this.contactNumber = contactNumber;
            this.address = address;
            this.street = street;
            this.city = city;
            this.pincode = pincode;
        }

        public string ID
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return contactName;
            }
        }

        public string Number
        {
            get
            {
                return contactNumber;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
        }

        public string Pincode
        {
            get
            {
                return pincode;
            }
        }
    }
}
