using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Execution;
using HotChocolate.Execution.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Demo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphQL(s =>
            {
                ISchemaBuilder builder = SchemaBuilder.New()
                    .AddType<AbcType>()
                    .AddType<XyzType>()
                    .AddQueryType<QueryType>()
                    .AddServices(s);

                return builder.Create();
            }, QueryOptions);

            services.AddDiagnosticObserver<HotChocolateLogger>();
            services.AddLogging();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseGraphQL();
        }

        protected QueryExecutionOptions QueryOptions =>
            new QueryExecutionOptions
            {
                TracingPreference = TracingPreference.OnDemand
            };
    }
}
