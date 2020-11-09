using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

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

        static void CreateContext()
        {
            var services = new ServiceCollection();
            services.AddDbContext<GeomagnetismDbContext>(builder =>
            {
                //builder.UseInMemoryDatabase("myDb");
                builder.UseSqlite("Data Source=../../database/EFWorld.db");
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
