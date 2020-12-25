namespace TestORMLibrary
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;

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

            serviceCollection.AddConfigurationFromFile("appsettings.json");

            serviceCollection.AddNHibernateConfiguration("relative");
            serviceCollection.AddTransient<App>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var app = serviceProvider.GetService<App>();
            if (app != null)
            {
                await app.Run();
            }

            Console.WriteLine(true);
        }
    }
}
