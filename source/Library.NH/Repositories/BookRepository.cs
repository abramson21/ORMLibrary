namespace Library.NH.Repositories
{
    using NHibernate;
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Library.Domain;

    public class BookRepository : IBookRepository
    {
        private readonly ISessionFactory sessionFactory;

        private readonly ISession session;

        public BookRepository(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory ?? throw new ArgumentNullException(nameof(sessionFactory));

            this.session = this.sessionFactory.OpenSession();
        }

        public IQueryable<Book> GetAll()
        {
            return this.session.Query<Book>();
        }

        public bool TryGet(int id, out Book book)
        {
            book = this.GetAll().SingleOrDefault(t => t.Id == id);
            return book != null;
        }
 
        public IQueryable<Book> Filter(Expression<Func<Book, bool>> filter)
        {
            return this.GetAll().Where(filter);
        }

        public Book Get(int id)
        {
            return this.GetAll().SingleOrDefault(g => g.Id == id);
        }
    }
}
