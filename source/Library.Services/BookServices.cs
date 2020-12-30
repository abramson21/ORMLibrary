namespace Library.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Library.Domain;
    using Library.NH.Repositories;

    public class BookServices : IBookServices
    {
        private readonly IBookRepository bookRepository;

        public BookServices(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
        }

        public Book Get(int id)
        {
            return this.bookRepository.Get(id);
        }

        public IQueryable<Book> GetAll()
        {
            return this.bookRepository.GetAll();
        }

        //Book IBookServices.Get(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
