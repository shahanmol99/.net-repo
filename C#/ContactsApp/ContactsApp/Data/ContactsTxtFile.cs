using ContactsApp.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace ContactsApp.Data
{
    class ContactsTxtFile : DataAccess
    {
        String _filePath = "Contacts.csv";
        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            StreamReader reader = null;
            if (File.Exists("Contacts.csv"))
            {
                reader = new StreamReader(File.OpenRead("Contacts.csv"));

                List<Contact> Contacts = new List<Contact>();
                String name, contactNumber;

                while (!reader.EndOfStream)
                {
                    String ContactLine = reader.ReadLine();
                    String[] contactDetails = ContactLine.Split(',');
                    name = contactDetails[0];
                    contactNumber = contactDetails[1];

                    Contact contact = new Contact(name, contactNumber);
                    contacts.Add(contact);

                }
                reader.Close();
            }
            else
            {
                throw new Exception("No Contacts To Display");
            }

            return contacts;
        }

        public void WriteContacts(string name, string contactNumber)
        {
            using(StreamWriter contactsFile = new StreamWriter(_filePath,true))
            {
                contactsFile.WriteLine(name + "," + contactNumber);
            }
        }
    }
}
