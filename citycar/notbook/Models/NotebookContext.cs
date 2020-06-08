
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notbook.Models
{
    public class NotebookContext : DbContext
    {
        public DbSet<Order> People { get; set; }

        public DbSet<ContactType> ContactTypes { get; set; }

        


        public NotebookContext(DbContextOptions<NotebookContext> options): base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
