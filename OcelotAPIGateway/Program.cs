using Microsoft.AspNetCore.Hosting;
using OcelotAPIGateway;

namespace OcelotAPIGateway
{ 
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webHost => { webHost.UseStartup<Startup>(); }).ConfigureAppConfiguration((hostingContext, config) =>
            {
                config
                .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
            });


    }
}