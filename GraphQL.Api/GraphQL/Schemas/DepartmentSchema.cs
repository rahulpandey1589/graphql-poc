using GraphQL.Api.GraphQL.Query;
using GraphQL.Types;

namespace GraphQL.Api.GraphQL.Schemas
{
    public class DepartmentSchema : Schema
    {
        public DepartmentSchema(IDependencyResolver dependencyResolver) : base(dependencyResolver)
        {
            Query = dependencyResolver.Resolve<DepartmentQuery>();
        }
    }
}
