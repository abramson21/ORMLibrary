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

                Console.WriteLine(new string('-', 42));

                var authors = session.Query<Author>().ToList();
                foreach (var author in authors)
                {
                    Console.WriteLine(author);
                }

                Console.WriteLine(new string('-', 42));

                var shelves = session.Query<Room>().ToList();
                foreach (var shelf in shelves)
                {
                    Console.WriteLine(shelf);
                }

                Console.WriteLine(new string('-', 42));

                var genres = session.Query<Publication>().ToList();
                foreach (var genre in genres)
                {
                    Console.WriteLine(genre);
                }
            }
            await Task.CompletedTask;
        }
    }
}
