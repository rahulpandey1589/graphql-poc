using GraphQL.BusinessManager.Interfaces;
using GraphQL.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Api.GraphQL.Types
{
    public class PersonModelType : ObjectGraphType<Person>
    {
        public PersonModelType(IPersonManager personManager)
        {
            Field(t => t.FirstName);
            Field(t => t.LastName);
            Field(t => t.Gender);
            Field(t => t.Id);
            Field<JobTypeEnumType>("JobType", "The type of job i.e. Permanent or Contractual");
            Field<PersonDetailModelType>
                (
                   "personDetails",
                   resolve: context => personManager.GetPersonDetailById(context.Source.Id)
                );

        }

    }
}
