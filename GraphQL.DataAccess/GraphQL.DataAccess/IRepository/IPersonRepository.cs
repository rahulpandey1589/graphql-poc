using GraphQL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQL.DataAccess.IRepository
{
   public interface IPersonRepository
    {
        IEnumerable<Person> GetAllPerson();

        PersonDetails GetPersonDetailById(int personId);

    }
}
