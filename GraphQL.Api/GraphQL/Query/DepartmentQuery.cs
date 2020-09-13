using GraphQL.Api.GraphQL.Types.OutputTypes;
using GraphQL.BusinessManager.Interfaces;
using GraphQL.Types;

namespace GraphQL.Api.GraphQL.Query
{
    public class DepartmentQuery : ObjectGraphType
    {
        public DepartmentQuery(IDepartmentManager departmentManager)
        {
            Field<ListGraphType<DepartmentModelType>>
                    (
                       "departmentObject",
                        resolve: context => departmentManager.GetAllDepartments()
                    );
        }
    }
}
