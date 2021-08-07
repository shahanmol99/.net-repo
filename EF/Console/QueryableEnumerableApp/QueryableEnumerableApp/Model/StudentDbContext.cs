
using System.Data.Entity;

namespace QueryableEnumerableApp.Model
{
    class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
