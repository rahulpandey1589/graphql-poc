using GraphQL.Web.ApiClient;
using GraphQL.Web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace GraphQL.Web.Pages
{
    public class IndexModel : PageModel
    {

        public PersonContainer Person { get; set; }



        private readonly PersonHttpClient personHttpClient;

        public IndexModel(PersonHttpClient _personHttpClient)
        {
            personHttpClient = _personHttpClient;
        }

        public async Task OnGet()
        {
           var personObj = await GetAllPerson();
            Person = personObj.Data;
        }

        private async Task<ResponseModel<PersonContainer>> GetAllPerson()
        {
            return await personHttpClient.GetAllPerson();
        }
    }
}
