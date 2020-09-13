using GraphQL.Api.GraphQL;
using GraphQL.Api.GraphQL.Schemas;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Api
{
    public static class GraphQLSchemaRegistration
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<PersonSchema>();
            services.AddScoped<DepartmentSchema>();
        }

    }
}
