﻿namespace TestORMLibrary
{
    using System;
    using System.IO;

    using Infrastructure.Helpers;

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    using NHibernate;

    using Library.NH;

    internal static class ProgramConfigurationExtensions
    {
        internal static IServiceCollection AddConfigurationFromFile(this IServiceCollection serviceCollection, string filename)
        {
            var basePath = Directory.GetParent(AppContext.BaseDirectory).FullName;

            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile(filename, optional: false, reloadOnChange: true)
                .Build();

            return serviceCollection.AddSingleton(configuration);
        }

        internal static IServiceCollection AddNHibernateConfiguration(this IServiceCollection serviceCollection, string connectionStringKey)
        {
            return serviceCollection.AddSingleton(serviceProvider => GetSessionFactory(serviceProvider, connectionStringKey));
        }

        private static ISessionFactory GetSessionFactory(IServiceProvider serviceProvider, string connectionStringKey)
        {
            var basePath = Directory.GetParent(AppContext.BaseDirectory).FullName;

            var configuration = serviceProvider.GetService<IConfigurationRoot>();

            var dataSourceLacation = Path.GetFullPath(configuration.GetConnectionString(connectionStringKey), basePath);

            NHibernateConfigurator.DataSourceLocation = dataSourceLacation;

            NHibernateConfigurator.GetConfiguration(LibraryNHibernateConfigurator.GetAssembly());

            return NHibernateConfigurator.GetSessionFactory();
        }
    }
}
