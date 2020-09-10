using GraphQL.Api.GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Api
{
    public static class ConfigureGraphQLEndpoints
    {
        public static void Configure(IApplicationBuilder app)
        {
            app.UseGraphQL<PersonSchema>(path: "/api/person/graphql");
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions
            {
                GraphQLEndPoint = "/api/person/graphql",
                Path = "/api/person/playground"

            }); // opens GraphQLPlayground UI interface


            app.UseGraphQL<DepartmentSchema>(path: "/api/department/graphql");
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions
            {
                GraphQLEndPoint = "/api/department/graphql",
                Path = "/api/department/playground"

            }); // opens GraphQLPlayground UI interface
        }
    }
}
