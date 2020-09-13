using GraphQL.Api.GraphQL.Query;
using GraphQL.Types;

namespace GraphQL.Api.GraphQL.Schemas
{
    public class PersonSchema : Schema
    {
        public PersonSchema(IDependencyResolver dependencyResolver) : base(dependencyResolver)
        {
            Query = dependencyResolver.Resolve<PersonQuery>();
            Mutation = dependencyResolver.Resolve<PersonMutation>();
        }

    }
}
