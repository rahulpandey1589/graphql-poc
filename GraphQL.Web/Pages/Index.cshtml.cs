using GraphQL.Model;
using GraphQL.Web.ApiClient;
using GraphQL.Web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphQL.Web.Pages
{
    public class IndexModel : PageModel
    {
        #region Models
        public PersonContainer PersonContainer { get; set; }

        #endregion

        #region ReadOnly Objects
        private readonly PersonHttpClient personHttpClient;
        private readonly PersonGraphClient personGraphClient;
        #endregion

        #region Constructor
        public IndexModel(PersonHttpClient _personHttpClient,PersonGraphClient _personGraphClient)
        {
            personHttpClient = _personHttpClient;
            personGraphClient = _personGraphClient;
        }
        #endregion

        public async Task OnGet()
        {
          // var personObj = await AddPerson();
           
        }

        #region Private Methods
        


        private async Task<ResponseModel<PersonContainer>> GetPersonByPersonId(int personId)
        {
            return await personGraphClient.GetPersonDetailsById(personId);
        }
        //private async Task<ResponseModel<Person>> AddPerson()
        //{
        //    return await personGraphClient.AddPerson(new PersonInputModel() 
        //    {
        //        FirstName = "FirstName",
        //        LastName = "LastName",
        //        Gender="Gender"
        //    });
        //}

        #endregion
    }
}
