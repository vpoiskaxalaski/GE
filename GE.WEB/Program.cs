﻿using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using GE.DAL;
using GE.DAL.Initialize;
using GE.WEB.Controllers;
using GE.SL.Servives;
using GE.SL.Interfaces;

namespace GE.WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {

                    var context = services.GetRequiredService<DatabaseContext>();
                    SampleData.Initialize(context);

                    ICategoryService categoryService = services.GetRequiredService<ICategoryService>();
                    ICacheService cacheService = new CacheService();
                    cacheService.CacheCategories(categoryService);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
