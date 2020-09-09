using GraphQL.Api.GraphQL.Types;
using GraphQL.BusinessManager.Interfaces;
using GraphQL.Types;

namespace GraphQL.Api.GraphQL
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
