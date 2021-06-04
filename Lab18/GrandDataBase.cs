using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    public class GrandDataBase : DbContext
    {
        public DbSet<Guy> Guy { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server = DESKTOP-FJ25DCG; Database = Lab18; Trusted_Connection = True; MultipleActiveResultSets = true");
        }
    }
}
