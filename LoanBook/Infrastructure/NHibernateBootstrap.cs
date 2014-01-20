using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Dialect;
using Ninject.Modules;
using NHibernate;
using Ninject.Activation;

namespace Infrastructure
{
    public sealed class NHibernateNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISessionFactory>().ToMethod(BuildSessionFactory).InSingletonScope();
        }

        public ISessionFactory BuildSessionFactory(IContext context)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Seb"].ConnectionString;

            return Fluently.Configure()
            .Database(MsSqlConfiguration.MsSql2008
            .ConnectionString(connectionString)
            .ShowSql()
            .Dialect<MsSql2008Dialect>())
            .Mappings(m => m.FluentMappings.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly()))
            .ExposeConfiguration(x => x.SetProperty("connection.release_mode", "on_close"))
            .BuildConfiguration().BuildSessionFactory();

            //var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["main"].ConnectionString;

            //return Fluently.Configure()
            //.Database(MsSqlCeConfiguration.Standard
            //.ConnectionString(connectionString)
            //.ShowSql()
            //.Driver<NHibernate.Driver.SqlServerCeDriver>()
            //.Dialect<FixedMsSqlCe40Dialect>())
            //.Mappings(m => m.FluentMappings.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly()))
            //.ExposeConfiguration(x => x.SetProperty("connection.release_mode", "on_close"))
            //.BuildConfiguration().BuildSessionFactory();
        }
    }

    //http://stackoverflow.com/questions/9944136/nhibernate-3-2-mssqlcedialect-dialect-does-not-support-variable-limits
    public class FixedMsSqlCe40Dialect : MsSqlCe40Dialect
    {
        public override bool SupportsVariableLimit
        {
            get
            {
                return true;
            }
        }
    }
}
