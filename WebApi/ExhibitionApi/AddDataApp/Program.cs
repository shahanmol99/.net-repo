using System;
using System.Collections.Generic;
using System.Linq;
using ExhibitionLib.Model;
using ExhibitionLib.Repo;

namespace AddDataApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            ExhibitionRepositoryDbContext db = ExhibitionRepositoryDbContext.GetInstance();

            Organizer o1 = new Organizer();
            o1.OrganizerId = "101";
            o1.OrganizerName = "Test";
            o1.Exhibitions = new List<Exhibition>();
            o1.Exhibitions.Add(new Exhibition { ExhibitionId = "1001", Country = "India", State = "Maharashtra", Organizer = o1 });
            o1.Exhibitions.Add(new Exhibition { ExhibitionId = "1002", Country = "India", State = "Gujarat", Organizer = o1 });
            o1.Exhibitions.Add(new Exhibition { ExhibitionId = "1003", Country = "India", State = "Orrissa", Organizer = o1 });
            db.Organizers.Add(o1);

            Organizer o2 = new Organizer { OrganizerId = "102", OrganizerName = "Dev" };
            o2.Exhibitions = new List<Exhibition>();
            o2.Exhibitions.Add(new Exhibition { ExhibitionId = "2001", Country = "India", State = "Kerala", Organizer = o2 });
            o2.Exhibitions.Add(new Exhibition { ExhibitionId = "2002", Country = "India", State = "Assam", Organizer = o2 });
            o2.Exhibitions.Add(new Exhibition { ExhibitionId = "2003", Country = "India", State = "Punjab", Organizer = o2 });

            db.Organizers.Add(o2);
            db.SaveChanges();

            Console.WriteLine("Added Succesfully");
        }
    }
}
