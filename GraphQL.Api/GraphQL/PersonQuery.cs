using GraphQL.Api.GraphQL.Types;
using GraphQL.BusinessManager.Interfaces;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Api.GraphQL
{
    public class PersonQuery : ObjectGraphType
    {
        public PersonQuery(IPersonManager personManager)
        {
            Field<ListGraphType<PersonModelType>>
                (
                   "persons",
                   resolve: context => personManager.GetAllPerson()
                );
        }

    }
}
