using GraphQL.DataAccess.IRepository;
using GraphQL.Model;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace GraphQL.DataAccess.Repository
{
    public class DepartmentRepository : IDeparmentRepository
    {
        public IEnumerable<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department()
                {
                    DepartmentId = 1,
                     DepartmentName="Accounts"
                },
                new Department()
                {
                    DepartmentId = 2,
                     DepartmentName="Finance"
                },
                new Department()
                {
                    DepartmentId = 1,
                     DepartmentName="HumanResources"
                },
                new Department()
                {
                    DepartmentId = 1,
                     DepartmentName="Sales"
                }
            };
               
        }
    }
}
