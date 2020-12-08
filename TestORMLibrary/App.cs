namespace TestORMLibrary
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Library.Domain;
    using NHibernate;

    class App
    {
        private readonly ISessionFactory sessionFactory;

        public App(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory ?? throw new ArgumentNullException(nameof(sessionFactory));
        }

        public async Task Run()
        {
            Console.OutputEncoding = Encoding.UTF8;

            using (var session = this.sessionFactory.OpenSession())
            {
                var books = session.Query<Book>().ToList();
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }

                Console.WriteLine("_________________________________________");

                var authors = session.Query<Author>().ToList();
                foreach (var author in authors)
                {
                    Console.WriteLine(author);
                }

                Console.WriteLine("_________________________________________");

                var shelves = session.Query<Room>().ToList();
                foreach (var shelf in shelves)
                {
                    Console.WriteLine(shelf);
                }

                //Console.WriteLine("_________________________________________");

                //var genres = session.Query<Genre>().ToList();
                //foreach (var genre in genres)
                //{
                //    Console.WriteLine(genre);
                //}
            }
            await Task.CompletedTask;
        }
    }
}
