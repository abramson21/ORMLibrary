namespace Library.Services
{
    using Library.Domain;
    using Library.NH.Repositories;
    using System;
    using System.Linq;

    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository authorRepository;

        private readonly IBookService bookService;

        public AuthorService(IAuthorRepository authorRepository, IBookService bookService)
        {
            this.authorRepository = authorRepository ?? throw new ArgumentNullException(nameof(authorRepository));
            this.bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
        }
        public IQueryable<Author> GetAll()
        {
            return this.authorRepository.GetAll();
        }

        public Author GetId(int id)
        {
            return this.authorRepository.Get(id);
        }

        public IQueryable<Author> GetAuthorByBookId(int bookId)
        {
            if (!this.bookService.TryGet(bookId, out var targetBook))
            {
                //return this.publisherRepository.Filter(t => t.Books.Contains(author.)).ToList();
                return Enumerable.Empty<Author>().AsQueryable();
            }
            return authorRepository.Filter(t => t.Books.Contains(targetBook));
        }

        public bool TryGet(int id, out Author author)
        {
            throw new NotImplementedException();
        }

        public Author Create(string lastName, string firstName, string middleName)
        {
            Author author = null;
            try
            {
                author = new Author(lastName, firstName, middleName);
                return this.authorRepository.Create(author);
            }
            catch (Exception e)
            {
                return author;
            }
        }

        public void Delete(int id)
        {
            this.authorRepository.Delete(id);
        }
    }
}

