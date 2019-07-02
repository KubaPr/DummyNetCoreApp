using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace DummyNetCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(FileReader.Read());
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
