namespace TestORMLibrary
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Library.Domain;
    using NHibernate;
    using Library.Services;

    class App
    {
        private readonly IBookServices bookServices;

        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        /// <param name="bookServices"> </param>
        public App(IBookServices bookServices)
        {
            this.bookServices = bookServices ?? throw new ArgumentNullException(nameof(bookServices));
        }

        /// <summary>
        /// Метод запуска приложения.
        /// </summary>
        /// <returns> Успешно завершённая задача. </returns>
        public async Task Run()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var directorId = 2;

            var movies = this.bookServices.Get(directorId);
            //В
            //foreach (var item in movies)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(movies);


            await Task.CompletedTask;
        }
    }
}
