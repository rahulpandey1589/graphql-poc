using GraphQL.Client;
using GraphQL.Common.Request;
using GraphQL.Model;
using GraphQL.Web.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphQL.Web.ApiClient
{
    public class PersonGraphClient
    {
        private readonly GraphQLClient _client;
       
        public PersonGraphClient(GraphQLClient client)
        {
            _client = client;
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
                      personDetails
                      {
                        address
                        mobileNumber
                      }
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

        public async Task<ResponseModel<Person>> AddPerson(PersonInputModel person)
        {
            ResponseModel<Person> personObj
                 = new ResponseModel<Person>();
            try
            {
                var query = new GraphQLRequest()
                {
                    Query = @"mutation($person : personInput!){
                              createPerson(person:$person)
                              { 
                                firstName
                                lastName
                                gender
                              }
                            }",
                    Variables = new { person }
                };

                var response = await _client.PostAsync(query);
                personObj.Data = response.GetDataFieldAs<Person>("createPerson");
                return personObj;
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
