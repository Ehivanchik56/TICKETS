using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class ApplicationsContext : DbContext
    {
        public DbSet<Point> Points { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Passangers> Passangers { get; set; }
        public ApplicationsContext()
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tickets1.db");
            base.OnConfiguring(optionsBuilder);

        }
    }
}
