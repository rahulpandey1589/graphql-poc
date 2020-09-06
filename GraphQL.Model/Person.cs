using GraphQL.Model.Enumeration;
using System;

namespace GraphQL.Model
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public PersonDetails PersonDetails { get; set; }

        public JobType JobType { get; set; }
    }
}
