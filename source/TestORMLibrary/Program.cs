namespace TestORMLibrary
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using Library.NH.Repositories;
    using Library.Services;


    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args"> Аргументы командной строки. </param>
        internal static void Main(string[] args) => MainAsync(args).Wait();

        private static async Task MainAsync(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            
            serviceCollection.AddTransient<App>();

            serviceCollection.AddSingleton<IBookRepository, BookRepository>();
            serviceCollection.AddSingleton<IBookServices, BookServices>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            await serviceProvider.GetService<App>().Run();
            //var serviceProvider = serviceCollection.BuildServiceProvider();

            //var app = serviceProvider.GetService<App>();
            //if (app != null)
            //{
            //    await app.Run();
            //}

        }
    }
}
