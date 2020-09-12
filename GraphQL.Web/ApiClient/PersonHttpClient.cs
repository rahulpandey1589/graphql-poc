using GraphQL.Web.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GraphQL.Web.ApiClient
{
    /// <summary>
    /// This class demostrates the way of calling a GraphQLQuery via Httpclient object.
    /// 
    /// </summary>
    public class PersonHttpClient
    {
        private readonly HttpClient httpClient;

        public PersonHttpClient(HttpClient httpClient
            )
        {
            this.httpClient = httpClient;
        }

        public async Task<ResponseModel<PersonContainer>> GetAllPerson()
        {
            try
            {
                var response = await httpClient.GetAsync(@"/api/person/graphql?query= 
                                                         { 
                                                             Persons :personsObject
                                                             { id 
                                                               firstName 
                                                               lastName 
                                                             } 
                                                         }"
                                                        );

                var stringResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ResponseModel<PersonContainer>>(stringResult);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
