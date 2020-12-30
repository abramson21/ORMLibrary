namespace Library.NH.Repositories
{
    using NHibernate;
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Library.Domain;

    public class AuthorRepository : IAuthorRepository
    {
        private readonly ISessionFactory sessionFactory;

        private readonly ISession session;

        public AuthorRepository(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory ?? throw new ArgumentNullException(nameof(sessionFactory));

            this.session = this.sessionFactory.OpenSession();
        }

        public IQueryable<Author> GetAll()
        {
            return this.session.Query<Author>();
        }

        public bool TryGet(int id, out Author author)
        {
            author = this.GetAll().SingleOrDefault(t => t.Id == id);
            return author != null;
        }

        public IQueryable<Author> Filter(Expression<Func<Author, bool>> filter)
        {
            return this.GetAll().Where(filter);
        }
        
    }
}
