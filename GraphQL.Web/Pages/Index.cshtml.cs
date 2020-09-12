using GraphQL.Web.ApiClient;
using GraphQL.Web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace GraphQL.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PersonHttpClient personHttpClient;

        public IndexModel(PersonHttpClient _personHttpClient)
        {
            personHttpClient = _personHttpClient;
        }

        public void OnGet()
        {
            GetAllPerson();
        }

        private async Task<PersonContainer> GetAllPerson()
        {
            return await personHttpClient.GetAllPerson();
        }
    }
}
