using GraphQL.Types;
using GraphQL.BusinessManager.Interfaces;
using System.Linq;
using GraphQL.Api.GraphQL.Types.OutputTypes;

namespace GraphQL.Api.GraphQL.Query
{
    public class PersonQuery : ObjectGraphType
    {
        public PersonQuery(IPersonManager personManager)
        {
            // Fetch All persons

            Field<ListGraphType<PersonModelType>>
                (
                   "personsObject",
                    resolve: context => personManager.GetAllPerson()
                );

            // Fetch person by person Id
            Field<PersonModelType>(
                "person",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
                {
                    Name="id"
                }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return personManager.GetPersonById(id);
                });


            // Fetch person with person name starts with
            // Passed multiple parameters in query object
            Field<ListGraphType<PersonModelType>>(
                "personByName",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                    {
                        Name = "firstName"
                    },
                    new QueryArgument<NonNullGraphType<IdGraphType>>
                    {
                          Name="limit"
                    }),
                resolve: context =>
                {
                    var startsWith = context.GetArgument<string>("firstName");
                    var limit = context.GetArgument<int>("limit");
                    return personManager.FindPersonByName(startsWith).Take(limit); ;
                });
        }
    }
}
