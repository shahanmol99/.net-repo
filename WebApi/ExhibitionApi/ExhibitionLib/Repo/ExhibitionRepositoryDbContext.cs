using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExhibitionLib.Model;
using System.Collections;

namespace ExhibitionLib.Repo
{
    public class ExhibitionRepositoryDbContext : DbContext
    {
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<Organizer> Organizers { get; set; }

        private static ExhibitionRepositoryDbContext instance;

        private ExhibitionRepositoryDbContext()
        {
            Database.SetInitializer<ExhibitionRepositoryDbContext>(new CreateDatabaseIfNotExists<ExhibitionRepositoryDbContext>());
        }

        public static ExhibitionRepositoryDbContext GetInstance()
        {
            if(instance==null)
            {
                instance = new ExhibitionRepositoryDbContext();
            }

            return instance;
        }

        internal object GetExhibition(string organizerid, string exhibitionId)
        {
            return Exhibitions.Where(e => e.Organizer.OrganizerId == organizerid && e.ExhibitionId == exhibitionId)
                                .Select(e => new { e.ExhibitionId, e.Country, e.State });
        }

        public IEnumerable Get(string organizerId)
        {
            var exhibitionList = Exhibitions.Where(e => e.Organizer.OrganizerId == organizerId)
                                .ToList()
                                .Select(e => new { e.ExhibitionId, e.Country, e.State });
            return exhibitionList;
        }
    }
}
