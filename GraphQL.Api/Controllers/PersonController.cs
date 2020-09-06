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
    public class PersonController : ControllerBase
    {
        private readonly IPersonManager personManager;

        public PersonController(IPersonManager personManager)
        {
            this.personManager = personManager;
        }


        [HttpGet]
        [Route("getAllPerson")]
        public ActionResult GetAllPerson()
        {
            var result = personManager.GetAllPerson();

            return Ok(result);
        }


    }
}
