using GraphQL.BusinessManager.Concrete;
using GraphQL.BusinessManager.Interfaces;
using GraphQL.DataAccess.IRepository;
using GraphQL.DataAccess.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.Api
{
    public static class DepedencyRegistration
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IPersonManager, PersonManager>();

        }

    }
}
