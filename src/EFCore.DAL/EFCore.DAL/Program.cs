using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace EFCore.DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateContext();

            Console.WriteLine($"End");
            Console.ReadLine();
        }

        #region 创建上下文
        public static readonly ILoggerFactory MyLoggerFactory
    = LoggerFactory.Create(builder => { builder.AddConsole(); });

        static void CreateContext()
        {
            if (!Directory.Exists("../../database"))
                Directory.CreateDirectory("../../database");

            var services = new ServiceCollection();
            services.AddDbContext<GeomagnetismDbContext>(builder =>
            {
                //builder.UseInMemoryDatabase("myDb");
                builder.UseSqlite("Data Source=../../database/EFWorld.db")
                .UseLoggerFactory(MyLoggerFactory);
            }, ServiceLifetime.Transient);

            using (var sp = services.BuildServiceProvider())
            using (var scope = sp.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetService<GeomagnetismDbContext>();
                var result = dbContext.Database.EnsureCreated();
                Console.WriteLine(result);
                foreach (var item in dbContext.Info)
                {
                    Console.WriteLine(item);
                }
            }
        }

        #endregion
    }
}
