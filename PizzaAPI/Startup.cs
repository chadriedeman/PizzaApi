using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PizzaAPI.Data;
using PizzaAPI.Data.Repositories;
using PizzaAPI.Services;

namespace PizzaAPI
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var connection = _configuration.GetConnectionString("PizzaDatabase");
            services.AddDbContext<PizzaContext>(options => options.UseNpgsql(connection));
            
            services.AddScoped<IRepository<PizzaContext>, Repository<PizzaContext>>();
            services.AddScoped<ITimeRepository, TimeRepository>();

            services.AddScoped<IOrdersRepository, OrdersRepository>(x => new OrdersRepository("[database connection string would go here]"));
            services.AddScoped<IPizzasRepository, PizzasRepository>(x => new PizzasRepository());

            services.AddScoped<IPizzasService, PizzasService>(x => new PizzasService(x.GetRequiredService<IRepository<PizzaContext>>()));
            services.AddScoped<IOrdersService, OrdersService>(x => new OrdersService(x.GetRequiredService<IOrdersRepository>()));

            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment() || env.IsEnvironment("Docker"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseMvc();
        }
    }
}
