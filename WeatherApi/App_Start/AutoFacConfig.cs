using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using WeatherApi.Service;

namespace WeatherApi
{
    public class AutoFacConfig
    {
        public static void  Config(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            //builder.RegisterWebApiFilterProvider(config);
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<StudentService>().As<IStudentService>();
            builder.RegisterType<StudentApplicationImpl>().As<IStudentApplication>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }



        /// <summary>
        /// 获取程序集
        /// </summary>
        /// <returns></returns>
        private static List<Assembly> GetAssemblies()
        {
            List<Assembly> assems = new List<Assembly>();
            //host
            var searchFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);

            var dlls = Directory.EnumerateFiles(searchFolder, "*.dll", SearchOption.AllDirectories);

            foreach (var file in dlls)
            {
                var assembly = Assembly.LoadFrom(file);
                assems.Add(assembly);
            }

            return assems;
        }
    }
}