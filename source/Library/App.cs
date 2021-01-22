namespace Library
{
    using System;
    using System.Text;
    using System.Threading.Tasks;
    using Library.NH.Repositories;
    using Library.Services;
    using NHibernate;

    internal class App
    {
        private readonly ISessionFactory sessionFactory;

        private readonly IAuthorRepository authorRepository;

        private readonly IAuthorService authorService;

        private readonly IBookRepository bookRepository;

        private readonly IBookService bookService;

        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        /// <param name="sessionFactory"></param>
        /// <param name="authorRepository"></param>
        public App(ISessionFactory sessionFactory, IAuthorRepository authorRepository, IAuthorService authorService, IBookRepository bookRepository, IBookService bookService)
        {
            this.sessionFactory = sessionFactory ?? throw new ArgumentNullException(nameof(sessionFactory));
            this.authorRepository = authorRepository ?? throw new ArgumentNullException(nameof(authorRepository));
            this.authorService = authorService ?? throw new ArgumentNullException(nameof(authorService));
            this.bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
            this.bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
        }

        public async Task Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            await Task.CompletedTask;
        }
    }
}
