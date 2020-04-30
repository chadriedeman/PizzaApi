using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace PizzaAPI
{
    using Microsoft.Extensions.Configuration;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureAppConfiguration(ConfigConfiguration);
        
        private static void ConfigConfiguration(WebHostBuilderContext ctx, IConfigurationBuilder config)
        {

            var environment = ctx.HostingEnvironment.EnvironmentName;

            config.AddJsonFile("appsettings.json", false, true);

            switch (environment)
            {
                case "Docker":
                    config.AddJsonFile("appsettings.Docker.json", true);
                    break;
                default:
                    config.AddJsonFile("appsettings.Development.json", true);
                    break;
            }
        }
    }
}
