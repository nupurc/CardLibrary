using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardLibrary.Data;
using CardLibrary.Services.Card;
using CardLibrary.Services.Group;
using CardLibrary.Services.User;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace CardLibrary.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddCors();
            services.AddControllers().AddNewtonsoftJson(opts => {
                opts.SerializerSettings.ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                };
            });
            services.AddMvcCore();
            services.AddDbContext<CardLibDbContext>(
                opts => {                    
                    opts.EnableDetailedErrors();
                    opts.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
                });
           
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICardService, CardService>();
            services.AddTransient<ICardGroupService, CardGroupService>();
            services.AddTransient<IUserRoleService, UserRoleService>();
            services.AddTransient<IUserGroupService, UserGroupService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(
               builder => builder
                   .WithOrigins(
                       "http://localhost:8081",
                       "http://localhost:8082")
                   .AllowAnyMethod()
                   .AllowAnyHeader()
                   .AllowCredentials()
               );
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
        }
    }
}
