using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zobi.Domain
{
    static class ServiceInitializer
    {

        public static DbContext InitializeContext(IHostingEnvironment _env)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddDbContext<ZobiDBContext>(options => options.UseSqlServer(ReadJsonFile(_env)));
            services.AddScoped<IZobiDBContext, ZobiDBContext>();
            var serviceProvider = services.BuildServiceProvider();
            var service = (IZobiDBContext)serviceProvider.GetService(typeof(IZobiDBContext));
            return (DbContext)service;
        }

        public static string ReadJsonFile(IHostingEnvironment _env)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.IndexOf("\\bin"));
            var rootPath = _env.ContentRootPath;
            var file = System.IO.Path.Combine(rootPath, "appsettings.json");
            var appsettingJson = File.ReadAllText(file);
            var appJObject = JObject.Parse(appsettingJson);
            var conn = appJObject["ConnectionStrings"]["conn"].ToString();
            return conn;
        }
    }
}
