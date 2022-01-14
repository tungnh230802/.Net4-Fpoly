using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            // dotnet ef dbcontext scaffold -o Models -f -d "Data Source=DESKTOP-2V5F3CA\TUNGNH230802;Initial Catalog=lab7;Integrated Security=True;" "Microsoft.EntityFrameworkCore.SqlServer"
            //dotnet ef dbcontext scaffold -o Models -f -d "Data Source=DESKTOP-2V5F3CA\\TUNGNH230802;Initial Catalog=lab7;Integrated Security=True;" "Microsoft.EntityFrameworkCore.SqlServer"

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
