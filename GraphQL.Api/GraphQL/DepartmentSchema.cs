using GraphQL.Types;

namespace GraphQL.Api.GraphQL
{
    public class DepartmentSchema : Schema
    {
        public DepartmentSchema(IDependencyResolver dependencyResolver) : base(dependencyResolver)
        {
            Query = dependencyResolver.Resolve<DepartmentQuery>();
        }
    }
}
