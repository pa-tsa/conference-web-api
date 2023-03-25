using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PaTsa.Conference.App.Api.WebApi.Middleware;
using PaTsa.Conference.App.Api.WebApi.Swagger;

namespace PaTsa.Conference.App.Api.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMiddleware<ApiKeyMiddleware>();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<PointOfSalesDatabase>(Configuration.GetSection(ConfigurationKeys.ConferenceDatabaseSection));

            // Injectable Services

            // Cosmos DB Services

            // Pingable Services - Should match MongoDB Services

            // Validators;

            // Setup controllers
            services
                .AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                    options.SerializerSettings.Converters.Add(new StringEnumConverter());
                });

            // Add Fluent Validation
            //services.AddFluentValidationAutoValidation();

            //services.AddEndpointsApiExplorer();

            services
                .AddSwaggerGen(options =>
                {
                    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

                    options.OperationFilter<ApiKeyHeaderFilter>();
                })
                .AddSwaggerGenNewtonsoftSupport();
        }
    }
}
