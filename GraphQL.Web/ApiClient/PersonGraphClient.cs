using GraphQL.Client;

namespace GraphQL.Web.ApiClient
{
    public class PersonGraphClient
    {
        private readonly GraphQLClient client;

        public PersonGraphClient(GraphQLClient client)
        {
            this.client = client;
        }
    }
}
