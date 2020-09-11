using GraphQL.Web.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace GraphQL.Web.ApiClient
{
    public class PersonHttpClient
    {
        private readonly HttpClient httpClient;

        public PersonHttpClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<PersonContainer> GetPerson()
        {
            var response = await httpClient.GetAsync(@"?query= 
            { products 
                { id name price rating photoFileName } 
            }");
            var stringResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PersonContainer>(stringResult);
        }
    }
}
