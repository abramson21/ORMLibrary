namespace Library.NH.Repositories
{
    using System;
    using System.Linq;
    using Library.Domain;
    using NHibernate;

    public class BookRepository : IBookRepository
    {

        private readonly ISession session;

        public BookRepository(ISession session)
        {
            this.session = session ?? throw new ArgumentNullException(nameof(session));
        }
        public IQueryable<Book> GetAll()
        {
            return this.session.Query<Book>();
        }

        public Book GetBooksForAuthorID(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.Id == id);
        }

        public Book GetId(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.Id == id);
        }

        public IQueryable<Book> GetBooksByTitle()
        {
            return this.GetAll();
        }
    }
}
