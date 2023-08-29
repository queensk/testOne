using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sendMessage.Models;

namespace sendMessage.AppDb
{
    public class AppDbContext: DbContext
    {
    public DbSet<Person> People { get; set; }
    public DbSet<Passport> Passports { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure one-to-one relationship between Person and Passport
        modelBuilder.Entity<Person>()
            .HasOne(p => p.Passport) // Specify navigation property on Person
            .WithOne(p => p.Person) // Specify inverse navigation property on Passport
            .HasForeignKey<Passport>(p => p.PersonId) // Specify foreign key property on Passport
            .IsRequired() // Make relationship required
            .OnDelete(DeleteBehavior.Cascade); // Delete dependent entity when principal entity is deleted
    }
        
    }
}