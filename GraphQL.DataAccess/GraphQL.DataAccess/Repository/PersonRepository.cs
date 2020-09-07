using GraphQL.DataAccess.IRepository;
using GraphQL.Model;
using GraphQL.Model.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQL.DataAccess.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetAllPerson()
        {
            return new List<Person>()
            {
                new Person()
                {
                    Id=1,
                     FirstName="Mike",
                     LastName="Tyson",
                     Gender="Male",
                     JobType = JobType.Contractual
                },
                 new Person()
                {
                    Id=2,
                     FirstName="James",
                     LastName="Douglas",
                     Gender="Male",
                      JobType = JobType.Contractual
                },
                  new Person()
                {
                    Id=3,
                     FirstName="Barrack",
                     LastName="Obama",
                     Gender="Male",
                      JobType = JobType.Permanent
                },
                   new Person()
                {
                    Id=4,
                     FirstName="Donald",
                     LastName="Trump",
                     Gender="Male",
                    JobType = JobType.Permanent
                }
            };

        }

        public PersonDetails GetPersonDetailById(int personId)
        {
            return GetAllPersonsDetails()
                .Where(x => x.PersonId == personId)
                .FirstOrDefault();
        }

        private IEnumerable<PersonDetails> GetAllPersonsDetails()
        {
            return new List<PersonDetails>()
            {
                new PersonDetails()
                {
                    PersonId=1,
                    Address="Faridabad",
                    MobileNumber="1111111111"
                },
                new PersonDetails()
                {
                    PersonId=2,
                    Address="Gurgaon",
                    MobileNumber="2222222222"
                },new PersonDetails()
                {
                    PersonId=3,
                    Address="Noida",
                    MobileNumber="3333333333"
                },new PersonDetails()
                {
                    PersonId=4,
                    Address="Pune",
                    MobileNumber="44444444"
                },
            };
        }
    }
}
