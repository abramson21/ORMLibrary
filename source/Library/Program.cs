namespace Library
{
    using Microsoft.Extensions.DependencyInjection;
    using System.Threading.Tasks;
    using Library.Domain;
    using Library.NH.Repositories;
    using Library.Services;

    class Program
    {
        internal static void Main(string[] args) => MainAsync(args).Wait();

        private static async Task MainAsync(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<App>();

            serviceCollection.AddSingleton<IAuthorRepository, AuthorRepository>();
            serviceCollection.AddSingleton<IBookRepository, BookRepository>();

            serviceCollection.AddSingleton<IAuthorService, AuthorService>();
            serviceCollection.AddSingleton<IBookService, BookService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            await serviceProvider.GetService<App>().Run();
        }
    }
}


///Изучить Wait()
