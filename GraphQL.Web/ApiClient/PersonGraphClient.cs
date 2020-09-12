using GraphQL.Client;
using GraphQL.Common.Request;
using GraphQL.Model;
using GraphQL.Web.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace GraphQL.Web.ApiClient
{
    public class PersonGraphClient
    {
        private readonly GraphQLClient _client;
        private readonly IConfiguration _configuration;

        public PersonGraphClient(IConfiguration configuration)
        {
            _configuration = configuration;
            var productUrl = _configuration.GetSection("ApiEndPoints:PersonEndPoint").Value;

            _client = new GraphQLClient(productUrl);
        }

        public async Task<ResponseModel<PersonContainer>> GetPersonDetailsById(int personId)
        {
             ResponseModel<PersonContainer> personObj
                          = new ResponseModel<PersonContainer>();
            try
            {
                var query = new GraphQLRequest
                {
                    Query = @"
                 query personQuery($personId: ID!)
                { person(id: $personId) 
                    { 
                      firstName
                      lastName
                      gender
                      jobType
                    }
                }",
                    Variables = new { personId = personId },
                    OperationName = "personQuery",
                };
                var response = await _client.PostAsync(query);
                var personData = response.GetDataFieldAs<Person>("person");
                var personList = new List<Person>();
                personList.Add(personData);

                personObj.Data = new PersonContainer()
                {
                    Persons = personList
                };
            }
            catch (Exception)
            {
                throw;
            }
            return personObj;
        }
    }
}
