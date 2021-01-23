namespace Infrastructure.Helpers
{
    using System.Reflection;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using Infrastructure.Conventions;
    using NHibernate;

    public class NHibernateConfigurator
    {
        public static FluentConfiguration config;

        public static string DataSourceLocation = @"DESKTOP-V49F727\SQLEXPRESS";
        //@"DESKTOP-9RIQ0RR\SQLEXPRESS";

        public static string GetConnectionString() =>
            //@"Data Source=DESKTOP-9RIQ0RR\SQLEXPRESS;Initial Catalog = DBLibraryHome; Integrated Security = True";
        @"Data Source=DESKTOP-V49F727\SQLEXPRESS;Initial Catalog=DBLibraryHome;Integrated Security=True";

        public static FluentConfiguration GetConfiguration(Assembly assembly, bool showSQL = false)
        {
            //попробовать другую строку подклчбения
            var configuration = MsSqlConfiguration.MsSql2012.ConnectionString(GetConnectionString());

#if DEBAG
            configuration = configuration.ShowSql().FormatSql();
#endif

            if (showSQL)
            {
                configuration = configuration.ShowSql().FormatSql();
            }

            return config = Fluently.Configure()
                .Database(configuration)
                .Mappings(m => m.FluentMappings.AddFromAssembly(assembly)
            // добавляем из сборки, иначе случай ниже.
            //.Conventions.AddAssembly(Assembly.GetExecutingAssembly()));
            //.ExposeConfiguration(BuildSchema);
            //вместо.
            .Conventions.Add<MyIdConvention>()
            .Conventions.Add<MyForeignKeyConvention>()
            .Conventions.Add<MyManyToManyTableNameConvention>());
        }

        //доделать
        //private static void BuildSchema(Configuration configuration)
        //{
        //    new SchemaExport(configuration).Execute(true, true, false);
        //}

        public static ISessionFactory GetSessionFactory() => config?.BuildSessionFactory();
    }
}
