using GE.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.RL
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            Lots.Add(new Lot { Name = "Nokia Lumia 630", Description = "Nokia", Price = 220 });
            Lots.Add(new Lot { Name = "Plate", Description = "White plate", Price = 22 });
            Lots.Add(new Lot { Name = "Suit", Description = "For kid", Price = 112 });
            SaveChanges();
        }
    }
}
