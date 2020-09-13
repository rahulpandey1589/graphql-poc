using GraphQL.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphQL.DataAccess.IRepository
{
   public interface IPersonRepository
    {
        IEnumerable<Person> GetAllPerson();

        PersonDetails GetPersonDetailById(int personId);

        Task<Person> AddNewPerson(Person person);

    }
}
