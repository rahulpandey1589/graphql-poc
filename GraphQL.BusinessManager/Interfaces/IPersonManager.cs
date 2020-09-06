using GraphQL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQL.BusinessManager.Interfaces
{
    public interface IPersonManager
    {
        IEnumerable<Person> GetAllPerson();

        PersonDetails GetPersonDetailById(int personId);

    }
}
