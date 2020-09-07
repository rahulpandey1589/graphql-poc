using GraphQL.Api.GraphQL.Types;
using GraphQL.BusinessManager.Interfaces;
using GraphQL.Types;

namespace GraphQL.Api.GraphQL
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
            Field<ListGraphType<PersonModelType>>(
                "personByName",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>>
                {
                    Name="firstName"
                }),
                resolve: context =>
                {
                    var startsWith = context.GetArgument<string>("firstName");
                    return personManager.FindPersonByName(startsWith);
                });
        }
    }
}
