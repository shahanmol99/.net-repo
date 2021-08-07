using System;
using System.Collections.Generic;
using ContactsApp.Data;
using ContactsApp.Model;

namespace ContactsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess contact = new ContactsTxtFile();
            String name, contactNumber;
            int choice;

            Console.WriteLine("----Contacts App----");
            Console.WriteLine("1. Display Contacts");
            Console.WriteLine("2. Add to Contacts");
            Console.WriteLine("3. Exit");
            Console.Write("Enter Your Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            while(choice!=3)
            {
                Console.WriteLine();
                switch(choice)
                {
                    case 1:
                        try
                        {
                            List<Contact> contacts = contact.GetContacts();
                            foreach (Contact c in contacts)
                            {
                                Console.WriteLine(c.GetName + "-" + c.GetContactNumber);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 2:
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Contact Number: ");
                        contactNumber = Console.ReadLine();
                        contact.WriteContacts(name, contactNumber);
                        break;

                    default:
                        Console.WriteLine("Please Enter A Valid Choice");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("1. Display Contacts");
                Console.WriteLine("2. Add to Contacts");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
