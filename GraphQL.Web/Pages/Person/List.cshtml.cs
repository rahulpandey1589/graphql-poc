using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL.Web.ApiClient;
using GraphQL.Web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GraphQL.Web.Pages.Person
{
    public class ListModel : PageModel
    {
        private readonly PersonHttpClient personGraphClient;

        public IEnumerable<GraphQL.Model.Person> PersonList { get; set; }


        public ListModel(PersonHttpClient _personGraphClient)
        {
            personGraphClient = _personGraphClient;
        }


        public async Task OnGet()
        {
            var responseObj = await ListAllPersons();
            PersonList = responseObj.Data.Persons;
        }

        private async Task<ResponseModel<PersonContainer>> ListAllPersons()
        {
            return await personGraphClient.GetAllPerson();
        }
    }
}
