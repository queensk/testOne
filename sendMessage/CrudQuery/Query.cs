using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sendMessage.Models;
using sendMessage.AppDb;

namespace sendMessage.CrudQuery
{
    public class Query
    {
        AppDbContext context = new AppDbContext();
        // create person
        public void CreatePerson()
        {
        // Create a new person
        var person = new Person
        {
            Name = "Alice",
            Age = 25
        };
        // Create a new passport
        var passport = new Passport
        {
            Number = "123456789",
            ExpiryDate = DateTime.Now.AddYears(10)
        };
        // Set navigation properties
        person.Passport = passport;
        passport.Person = person;
        context.People.Add(person);
        context.Passports.Add(passport);
        context.SaveChanges();
        Console.WriteLine($"Person created {person.Id}");
        }

        public void ReadPerson()
        {
            var person = context.People.First(person => person.Name == "Alice");
            Console.WriteLine($"{person.Name} is {person.Age} years old.");
        }

        public void UpdatePerson()
        {
            var person = context.People.First(person => person.Name == "Alice");
            person.Age = 30;
            context.SaveChanges();
        }

        public void DeletePerson()
        {
            var person = context.People.First(person => person.Name == "Alice");
            context.People.Remove(person);
            context.SaveChanges();
        }
    }


}