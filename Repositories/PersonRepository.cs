using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VTA.ContactManager.CrossCutting.DataClasses;

namespace VTA.ContactManager.Data.Repositories
{
    public class PersonRepository
    {
        public IEnumerable<Person> Load()
        {
            var persons = File
                .ReadAllLines("data.csv")
                .Select(l => l.Split(new[] {","}, StringSplitOptions.None))
                .Select(parts => new Person
                {
                    Id = int.Parse(parts[0]),
                    Name = parts[1],
                    Age = int.Parse(parts[2])
                });
            return persons;
        }
    }
}