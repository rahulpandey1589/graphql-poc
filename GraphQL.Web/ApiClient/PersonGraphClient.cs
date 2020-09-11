using GraphQL.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
