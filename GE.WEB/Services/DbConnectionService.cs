using GE.RL.Interfaces;
using GE.RL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GE.WEB
{
    public class DbConnectionService
    {
        private string connectionName;

        public DbConnectionService(string connectionName)
        {
            this.connectionName = connectionName;
        }
        
        public string GetConnectionString()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("appsettings.json");
            // создаем конфигурацию
            var config = builder.Build();

            // получаем строку подключения
            return config.GetConnectionString(connectionName);
        }

        public DbContextOptions<RL.DatabaseContext> GetOptions()
        {
            var optionsBuilder = new DbContextOptionsBuilder<RL.DatabaseContext>();
            DbContextOptions<RL.DatabaseContext> options = optionsBuilder.UseSqlServer(GetConnectionString()).Options;

            return options;
        }

        public IUnitOfWork GetUnitOfWork()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(this.GetOptions());

            return ninjectKernel.Get<IUnitOfWork>();
        }
    }
}
