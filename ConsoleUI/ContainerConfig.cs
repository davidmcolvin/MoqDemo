using Autofac;
using DemoLibrary.Logic;
using DemoLibrary.Models;
using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
  public class ContainerConfig
  {
    internal static IContainer Configure()
    {
      var builder = new ContainerBuilder();

      builder.RegisterType<Application>().As<IApplication>();
      builder.RegisterType<PersonProcessor>().As<IPersonProcessor>();
      builder.RegisterType<PersonModel>().As<IPersonModel>();
      builder.RegisterType<SqliteDataAccess>().As<ISqliteDataAccess>();

      return builder.Build();

    }
  }
}
