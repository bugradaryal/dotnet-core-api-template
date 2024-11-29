using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress; Database=TestDb; Trusted_Connection=True; MultipleActiveResultSets=true; TrustServerCertificate=True;");
        }

        public DbSet<User> Users { get; set; }

        //fluent api


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            //TEST DATA
            modelBuilder.Entity<User>().HasData(new User[] {
                new User{Id=1},
                new User{Id=2},
                new User{Id=3},
                new User{Id=4},
                new User{Id=5},
            });
        }
    }
}