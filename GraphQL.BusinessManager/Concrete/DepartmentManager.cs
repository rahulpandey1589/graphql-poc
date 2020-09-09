using GraphQL.BusinessManager.Interfaces;
using GraphQL.DataAccess.IRepository;
using GraphQL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQL.BusinessManager.Concrete
{
    public class DepartmentManager : IDepartmentManager
    {
        private readonly IDeparmentRepository repository;

        public DepartmentManager(IDeparmentRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return repository.GetAllDepartments();
        }
    }
}
