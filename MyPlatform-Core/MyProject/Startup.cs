using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyProject.Middleware;
using Microsoft.AspNetCore.Routing;
using MyProject.Services;

namespace MyProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<MessageOptions>(options =>
            {
                options.City = "Vizag";
                options.Country = "India";
                options.Message = "This is a custom middleware component";
            });

            services.AddSingleton<IResponseFormatter, TextResponseFormatter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,IOptions<MessageOptions> options)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            MessageOptions msgOptions = options.Value;

            app.UseRouting();

            app.UseMiddleware<WeatherMiddleware>();

            app.Use(async (context, next) => {
                if (context.Request.Path == "/short")
                    await context.Response.WriteAsync("Request short circuited");
                else await next(); // this will short circuit 
            });

            app.Use(async (context, next) =>{

                if (context.Request.Method == "GET" && context.Request.Query["custom"].ToString().ToLower() == "true")
                    await context.Response.WriteAsync($"{msgOptions.Message} from city {msgOptions.City}\n");

                await next();
            });

            app.Map("/branch", branch =>
            {
                branch.UseMiddleware<QueryStringMiddleware>();

                branch.Use(async (context, next) =>
                {
                    await context.Response.WriteAsync("This is coming from branch middleware");
                });

            });

            app.MapWhen(context => context.Request.Query.Keys.Contains("branchwhen"), branch =>
            {
                branch.Use(async (context, next) =>
                {
                    await context.Response.WriteAsync("this is coming from branch when predicate");
                });
            });

            var responseFormatter1 = app.ApplicationServices.GetService<IResponseFormatter>();
            var responseFormatter2 = app.ApplicationServices.GetService<IResponseFormatter>();

            app.Use(async (context, next) =>
            {
                if (context.Request.Path == "/middleware/function")
                {
                    await responseFormatter1.Format(context, "Middleware Function 1: It is snowing in Chicago\n");
                    await responseFormatter2.Format(context, "Middleware Function 2: It is snowing in Chicago");
                }
                else await next();
            });

            app.UseEndpoints(endPoints =>
            {
                endPoints.MapGet("routing", async context =>
                {
                    await context.Response.WriteAsync("coming from routing endpoint");
                });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapGet("example/red{color}", async context =>
                {
                // URL http://localhost:40788/example/redredyellow will not be matched as 'redyellow' won't be treated as single string
                    await context.Response.WriteAsync($"value is {context.Request.RouteValues["color"]}");
                });
            });

            app.UseEndpoints(endPoints =>
            {
                endPoints.MapGet("{first}/{second}/{third}", async context =>
                {
                    await context.Response.WriteAsync("Request was routed \n");
                    foreach(var kvp in context.Request.RouteValues)
                    {
                        await context.Response.WriteAsync($"key is {kvp.Key} and value is {kvp.Value}");
                    }
                });

                endPoints.MapGet("/endpoint/class", WeatherEndpoint.EndPoint);

            });

            app.UseEndpoints(endPoints =>
            {
                //'France' is default value so http://localhost:40788/capital --> will match as http://localhost:40788/capital/france
                endPoints.MapGet("capital/{country=France}", Capital.Endpoint); 
                // optional segment means if city is not present it will have default value as 'london' (see population class)
                endPoints.MapGet("size/{city?}", Population.Endpoint)
                .WithMetadata(new RouteNameMetadata("population"));
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Terminal Middleware reached");
            });

        }
    }
}
