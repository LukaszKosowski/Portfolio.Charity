using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Mvc.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Charity.Mvc.Services;
using Charity.Mvc.Services.Interfaces;
using System.IO;

namespace Charity.Mvc
{
	public class Startup
    {

        protected IConfigurationRoot Configuration;

        public Startup()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            //var configurationBuilder = new ConfigurationBuilder();
            //configurationBuilder.AddXmlFile("appsettings.xml");
            //Configuration = configurationBuilder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
		{
            services.AddDbContext<CharityContext>(builder =>
            {
                var connectionString = Configuration["ConnectionString:DataSource"];
                builder.UseSqlServer(connectionString);
            });

            //services.AddDbContext<CharityContext>(builder => {
            //    var connectionString = Configuration["ConnectionString"];
            //    builder.UseSqlServer(connectionString);
            //});

            services.AddScoped<IInstitutionSerwice, InstitutionSerwice>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IDonationService, DonationService>();

            services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseBrowserLink();
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();
            app.UseMvc();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
	}
}
