using GraphQL.DataAccess.IRepository;
using GraphQL.Model;
using GraphQL.Model.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.DataAccess.Repository
{
    public class PersonRepository : IPersonRepository
    {
        IList<Person> personList;

        public PersonRepository()
        {
            personList = GetAllPerson().ToList();
        }

        public async Task<Person> AddNewPerson(Person person)
        {
            try
            {
                personList.Add(person);
                return person;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

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
                     FirstName="Roberto",
                     LastName="Fed",
                     Gender="Male",
                      JobType = JobType.Permanent
                },
                   new Person()
                {
                    Id=4,
                     FirstName="Alan",
                     LastName="Freed",
                     Gender="Male",
                    JobType = JobType.Permanent
                },
                     new Person()
                {
                    Id=5,
                     FirstName="Michael",
                     LastName="Jordan",
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
                    Address="North America",
                    MobileNumber="1111111111111"
                },
                new PersonDetails()
                {
                    PersonId=2,
                    Address="South America",
                    MobileNumber="2222222222222"
                },new PersonDetails()
                {
                    PersonId=3,
                    Address="Canada",
                    MobileNumber="3333333333333"
                },new PersonDetails()
                {
                    PersonId=4,
                    Address="United Kingdom",
                    MobileNumber="4444444444444"
                },
            };
        }
    }
}
