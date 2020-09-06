using GraphQL.BusinessManager.Interfaces;
using GraphQL.DataAccess.IRepository;
using GraphQL.Model;
using System;
using System.Collections.Generic;

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

        public PersonDetails GetPersonDetailById(int personId)
        {
            return personRepository.GetPersonDetailById(personId);
        }
    }
}
