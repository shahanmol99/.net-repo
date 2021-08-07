using System;
using System.Collections.Generic;
using ContactsDBApp.Data;
using ContactsDBApp.Model;

namespace ContactsDBApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess contactDB = new ContactsDB();
            String name, contactNumber;
            int choice;

            Console.WriteLine("----Contacts App----");
            do
            {

                Console.WriteLine("1. Display Contacts");
                Console.WriteLine("2. Add to Contacts");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        List<Contact> contacts = contactDB.GetContacts();
                        if (contacts.Count == 0)
                        {
                            Console.WriteLine("Sorry No Contacts To Display");
                            break;
                        }

                        foreach (Contact c in contacts)
                        {
                            Console.WriteLine(c.GetName + "-" + c.GetContactNumber);
                        }
                        Console.WriteLine("Total: " + contacts.Count);
                        break;

                    case 2:
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Contact Number: ");
                        contactNumber = Console.ReadLine();
                        contactDB.AddContacts(name, contactNumber);
                        break;

                    case 3:
                        contactDB.CloseDB();
                        break;

                    default:
                        Console.WriteLine("Please Enter A Valid Choice");
                        break;
                }
                Console.WriteLine();
            } 
            while (choice != 3);
            Console.WriteLine("Exited From Contacts App");
            Console.ReadLine();
        }
    }
}
