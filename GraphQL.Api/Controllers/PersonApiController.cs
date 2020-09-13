using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using GraphQL.BusinessManager.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GraphQL.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonApiController : ControllerBase
    {
        private readonly IPersonManager personManager;
        private readonly IDepartmentManager departmentManager;

        public PersonApiController(IPersonManager personManager,
            IDepartmentManager departmentManager)
        {
            this.personManager = personManager;
            this.departmentManager = departmentManager;
        }

        [HttpGet]
        [Route("getAllPerson")]
        public ActionResult GetAllPerson()
        {
            var result = personManager.GetAllPerson();

            return Ok(result);
        }

        [HttpGet]
        [Route("getAllDepartment")]
        public ActionResult GetAllDepartment()
        {
            var result = departmentManager.GetAllDepartments();
            return Ok(result);
        }

        [HttpPost]
        [Route("addNewPerson")]
        public ActionResult AddNewPerson()
        {
            var result = personManager.GetAllPerson();

            return Ok(result);
        }
    }
}
