using GraphQL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.BusinessManager.Interfaces
{
    public interface IPersonManager
    {
        IEnumerable<Person> GetAllPerson();

        Person GetPersonById(int personId);

        PersonDetails GetPersonDetailById(int personId);

        IEnumerable<Person> FindPersonByName(string nameToFind);

        Task<Person> AddNewPerson(Person person);

    }
}
