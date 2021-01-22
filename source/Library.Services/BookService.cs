namespace Library.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Library.Domain;
    using Library.NH.Repositories;

    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
        }

        public IList<Book> GetAll()
        {
            return this.bookRepository.GetAll().ToList();
        }

        public bool TryGet(int id, out Book book)
        {
            book = this.GetAll().SingleOrDefault(g => g.Id == id);
            return book != null;
        }

        public Book GetBooksForAuthorID(int id)
        {
            return this.bookRepository.GetBooksForAuthorID(id);
        }

        public Book GetBookId(int id)
        {
            if (this.TryGet(id, out Book book)) return this.bookRepository.GetId(id);
            throw new ArgumentNullException(nameof(id));
        }

        public IQueryable<Book> GetBooksByTitle(string str)
        {
            return this.bookRepository.GetBooksByTitle().Where(x => x.Title.Contains(str));
        }
    }
}
