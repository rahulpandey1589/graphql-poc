using GraphQL.Web.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GraphQL.Web.ApiClient
{
    public class PersonHttpClient
    {
        private readonly HttpClient httpClient;
        private readonly ILogger logger;

        public PersonHttpClient(HttpClient httpClient, ILogger _logger)
        {
            this.httpClient = httpClient;
            logger = _logger;
        }

        public async Task<PersonContainer> GetAllPerson()
        {
            try
            {
                var response = await httpClient.GetAsync(@"/api/person/graphql?query= 
                                                         { personsObject 
                                                             { id firstName lastName } 
                                                         }"
                                                        );

                var stringResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<PersonContainer>(stringResult);
            }
            catch (Exception ex)
            {
                logger.LogError($"{"Error in GetPerson method in PersonHttpClient method"}{ex.Message}");
                throw;
            }
        }
    }
}
