using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLib.Model;


namespace BankLib.Repository
{
    public class BankRepositoryDbContext<T> : DbContext, IRepository<T> where T : class
    {
        public DbSet<T> Table { get; set; }
        public BankRepositoryDbContext() : base("BankRepositoryDbContext")
        {
            Database.SetInitializer<BankRepositoryDbContext<T>>(new CreateDatabaseIfNotExists<BankRepositoryDbContext<T>>());
        }

        public bool Add(T obj)
        {
            try
            {
                Table.Add(obj);
                this.Commit();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public List<T> Get()
        {
            return Table.ToList();
        }

        public bool Update(T obj)
        {
            try
            {
                Table.Attach(obj);
                this.Entry(obj).State = EntityState.Modified;
                this.Commit();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public void Commit()
        {
            this.SaveChanges();
        }

        public T GetByName(string uName)
        {
            return Table.Find(uName);
        }
    }
}
