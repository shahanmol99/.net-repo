using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EmpApp.Model
{
    class AurionproDbContext : DbContext
    {
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Emp> Emps { get; set; }
    }
}
