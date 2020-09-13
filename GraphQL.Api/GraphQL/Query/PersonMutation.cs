using GraphQL.Api.GraphQL.Types.InputTypes;
using GraphQL.Api.GraphQL.Types.OutputTypes;
using GraphQL.BusinessManager.Interfaces;
using GraphQL.DataAccess.Repository;
using GraphQL.Model;
using GraphQL.Types;

namespace GraphQL.Api.GraphQL.Query
{
    public class PersonMutation : ObjectGraphType
    {
        public PersonMutation(IPersonManager personManager)
        {
            FieldAsync<PersonModelType>
                (
                "createPerson",
                arguments: new QueryArguments(
                           new QueryArgument<NonNullGraphType<PersonInputType>> { Name = "person" }),
                resolve: async context =>
                {
                    var person = context.GetArgument<Person>("person");
                    return await context.TryAsyncResolve(
                        async c => await personManager.AddNewPerson(person));
                });
        }
    }
}
