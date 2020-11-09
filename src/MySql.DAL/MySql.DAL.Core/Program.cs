using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MySql.DAL.Core.Clock;
using MySql.DAL.Core.MyDbData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MySql.DAL.Core
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                await CreateTableAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }

        #region 创建表

        private static async Task CreateTableAsync()
        {
            var services = new ServiceCollection();
            //services.AddEntityFrameworkMySql();
            services.AddDbContext<MyDbContext>(builder =>
            {
                builder
                    .UseMySql(
                        // 连接字符串
                        "server=localhost;user=root;password=357592895;charset=utf8;database=mydb",
                        builder => builder.EnableRetryOnFailure())
                    .UseLoggerFactory(
                        LoggerFactory.Create(
                            logging => logging
                                .AddConsole()
                                .AddFilter(level => level >= LogLevel.Information)))
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            }, ServiceLifetime.Transient);

            var tasks = new Task[100];
            for (int i = 0; i < 100; i++)
            {
                var t = Task.Factory.StartNew(() =>
                {
                    while (true)
                    {
                        CreateOrUpdateItem(services);
                    }
                });

                tasks[i] = t;
            }
        }

        static void CreateOrUpdateItem(ServiceCollection services)
        {
            using (var sp = services.BuildServiceProvider())
            using (var scope = sp.CreateScope())
            {
                var db = scope.ServiceProvider.GetService<MyDbContext>();

                var model = new biz_GeomagCurrentStatus
                {
                    Id = Guid.NewGuid().ToString(),
                    Address = "福州",
                    Longitude = 120.1,
                    Latitude = 29.5,
                    State = "有车",
                    UploadTime = DateTime.Now.AddSeconds(-1D),
                    ReceiveTime = DateTime.Now,
                };

                if (db.biz_GeomagCurrentStatus.AsNoTracking().FirstOrDefault(b => b.Id == model.Id) == null)
                {
                    db.biz_GeomagCurrentStatus.Add(model);
                }
                else
                {
                    db.biz_GeomagCurrentStatus.Update(model);
                }

                db.SaveChanges();

                //foreach (var item in db.biz_GeomagCurrentStatus)
                //{
                //    Write(item);
                //}
            }
        }

        #endregion

        #region Linq表达式树 + EFCore

        private static void Void()
        {
            //var connStrParameter = "10.44.78.3;hbj_iot;(#G*Y3jfdiot;biz_263010";
            //var parameters = connStrParameter.Split(';');
            //if (parameters.Length != 4)
            //    return;

            //var server = parameters[0];
            //var userId = parameters[1];
            //var password = parameters[2];
            //var databaseName = parameters[3];

            //var connStr = $"server={server};user={userId};password={password};database={databaseName}";
            //Console.WriteLine(connStr);
            //return;

            var services = new ServiceCollection();
            //services.AddEntityFrameworkMySql();
            services.AddDbContextPool<biz_263010Context>(builder =>
            {
                builder
                    .UseMySql(
                        // 连接字符串
                        "server=localhost;user=root;password=357592895;database=biz_263010",
                        builder => builder.EnableRetryOnFailure())
                    //"server=10.44.78.3;user=hbj_iot;password=(#G*Y3jfdiot;database=biz_263010")
                    //, builder =>
                    //builder.EnableRetryOnFailure())
                    .UseLoggerFactory(
                        LoggerFactory.Create(
                            logging => logging
                                .AddConsole()
                                .AddFilter(level => level >= LogLevel.Information)))
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            });

            using (var sp = services.BuildServiceProvider())
            {
                var dbContext = sp.GetService<biz_263010Context>();
                GetObjectByExpressionTree(dbContext);

                //Console.WriteLine(dbContext.ContextId);

                //var demos = await dbContext.Biz263010YyszdjcdObjInfo.ToListAsync();
                //Console.WriteLine(JsonConvert.SerializeObject(demos, Formatting.Indented));
            }
        }

        /// <summary>
        /// 通过表达式树获取记录
        /// </summary>
        /// <param name="dbContext"></param>
        private static void GetObjectByExpressionTree(biz_263010Context dbContext)
        {
            const string TbDrinkWater = nameof(TbYyszdjcdDataHour);
            const string TbAutoMonitorWater = nameof(TbSzzdjcjcdDataHour);

            // 表达式树
            using var watch = new InvokeTimeWatcher();
            var queryableData = dbContext.TbCgdbsDataCg;
            var queryableStation = dbContext.TbCgdbsObjInfo;
            var id = 749;

            var data = GetData(queryableData, id);
            var station = GetStation(queryableStation, id);
            Write(data);
            Write(station);

            var queryableData1 = dbContext.TbSzzdjcjcdDataHour;
            var queryableStation1 = dbContext.TbSzzdjcjcdObjInfo;
            id = 54527;

            var data1 = GetData(queryableData1, id);
            var station1 = GetStation(queryableStation1, id);
            Write(data1);
            Write(station1);

            var queryableData2 = dbContext.TbAtmosphereDataHour;
            var queryableStation2 = dbContext.TbAtmosphereObjInfo;
            id = 54515;
            var data2 = GetData(queryableData2, id);
            var station2 = GetStation(queryableStation2, id);
            Write(data2);
            Write(station2);
        }

        private static T GetData<T>(IQueryable<T> queryableData, int id)
        {
            //// 获取站点最新的监测数据
            //Data = Services.DbContext.TbAtmosphereDataHour
            //    .Where(data => data.Objid.HasValue && data.Objid.Value == id)
            //    .OrderByDescending(data => data.Collecttime.HasValue ? data.Collecttime.Value : default)
            //    .FirstOrDefault();

            // Where
            ParameterExpression pe = Expression.Parameter(queryableData.ElementType, "data");
            Expression objId = Expression.Property(pe, "Objid");
            Expression left = Expression.Property(objId, "HasValue");
            Expression right = Expression.Equal(Expression.Property(objId, "Value"), Expression.Constant(id));
            Expression expr = Expression.AndAlso(left, right);
            MethodCallExpression whereCallExpression = Expression.Call(
                typeof(Queryable),
                "Where",
                new Type[] { queryableData.ElementType },
                queryableData.Expression,
                Expression.Lambda<Func<T, bool>>(expr, pe));

            // OrdeerByDecending
            Expression collectTime = Expression.Property(pe, "Collecttime");
            Expression condition = Expression.Property(collectTime, "HasValue");
            Expression ifTrue = Expression.Property(collectTime, "Value");
            Expression ifFalse = Expression.Default(ifTrue.Type);
            expr = Expression.Condition(condition, ifTrue, ifFalse);
            MethodCallExpression orderCallExpression = Expression.Call(
                typeof(Queryable),
                "OrderByDescending",
                new Type[] { queryableData.ElementType, ifTrue.Type },
                whereCallExpression,
                Expression.Lambda<Func<T, DateTime>>(expr, pe));

            // FirstOrDefault
            MethodCallExpression firstCallExpression = Expression.Call(
                typeof(Queryable),
                "FirstOrDefault",
                new Type[] { queryableData.ElementType },
                orderCallExpression);

            var data = (T)queryableData.Provider.Execute(firstCallExpression);
            return data;
        }

        private static T GetStation<T>(IQueryable<T> queryableData, int id)
        {
            //// 获取站点信息
            //Station = Services.DbContext.TbAtmosphereObjInfo
            //    .Where(obj => obj.Objid == id)
            //    .FirstOrDefault();

            ParameterExpression pe = Expression.Parameter(typeof(T), "obj");
            Expression left = Expression.Property(pe, "Objid");
            Expression right = Expression.Constant(id);
            Expression expr = Expression.Equal(left, right);

            // Where
            MethodCallExpression whereCallExpression = Expression.Call(
                typeof(Queryable),
                "Where",
                new Type[] { queryableData.ElementType },
                queryableData.Expression,
                Expression.Lambda<Func<T, bool>>(expr, pe));

            // FirstOrDefault
            MethodCallExpression firstCallExpression = Expression.Call(
                typeof(Queryable),
                "FirstOrDefault",
                new Type[] { queryableData.ElementType },
                whereCallExpression);

            var station = (T)queryableData.Provider.Execute(firstCallExpression);
            return station;
        }

        #endregion

        #region 日志

        private static void Write(object obj)
        {
            Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));
        }

        #endregion
    }
}
