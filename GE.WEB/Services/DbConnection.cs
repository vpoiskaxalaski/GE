using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GE.WEB
{
    public class DbConnection
    {
        private string connectionName;

        public DbConnection(string connectionName)
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
    }
}
