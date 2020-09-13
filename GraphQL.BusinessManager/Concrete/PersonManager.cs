using GraphQL.BusinessManager.Interfaces;
using GraphQL.DataAccess.IRepository;
using GraphQL.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.BusinessManager.Concrete
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository personRepository;

        public PersonManager(IPersonRepository _personRepository)
        {
            personRepository = _personRepository;
        }

        public IEnumerable<Person> GetAllPerson()
        {
            return personRepository.GetAllPerson();
        }

        public Person GetPersonById(int personId)
        {
            return GetAllPerson()
                .Where(x => x.Id.Equals(personId))
                .FirstOrDefault();
        }

        public PersonDetails GetPersonDetailById(int personId)
        {
            return personRepository.GetPersonDetailById(personId);
        }

        public IEnumerable<Person> FindPersonByName(string nameToFind)
        {
            return
                GetAllPerson()
                .Where(x => x.FirstName.StartsWith(nameToFind))
                .ToList();
        }

        public Task<Person> AddNewPerson(Person person)
        {
            return personRepository.AddNewPerson(person);
        }
    }
}
