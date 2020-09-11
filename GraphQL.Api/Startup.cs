using GraphQL.Client;
using GraphQL.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.Api
{
    public class Startup
    {
        private readonly IHostingEnvironment environment;

        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Configuration = configuration;
            this.environment = environment;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            DepedencyRegistration.Register(services);
            GraphQLSchemaRegistration.Register(services);
            
            // GraphQL related configuration
            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));

            services.AddSingleton(t => new GraphQLClient(Configuration[""]));

            services.AddGraphQL(o => { o.ExposeExceptions = environment.IsDevelopment(); })
                .AddGraphTypes(ServiceLifetime.Scoped);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {   
            app.UseHttpsRedirection();
            ConfigureGraphQLEndpoints.Configure(app);
            app.UseMvcWithDefaultRoute();
        }
    }
}
