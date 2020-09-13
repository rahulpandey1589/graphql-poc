using GraphQL.Model;
using GraphQL.Types;

namespace GraphQL.Api.GraphQL.Types.OutputTypes
{
    public class DepartmentModelType : ObjectGraphType<Department>
    {
        public DepartmentModelType()
        {
            Field(t => t.DepartmentId);
            Field(t => t.DepartmentName);
        }
    }
}
