namespace Library.NH.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Library.Domain;
    using NHibernate;

    public class AuthorRepository : IAuthorRepository
    {
        private readonly ISessionFactory sessionFactory;

        private readonly ISession session;

        public AuthorRepository(ISessionFactory sessionFactory)
        {
            var factory = sessionFactory ?? throw new ArgumentNullException(nameof(sessionFactory));

            this.session = factory.OpenSession();
        }

        public IQueryable<Author> GetAll()
        {
            return this.session.Query<Author>();
        }

        public IQueryable<Author> Filter(Expression<Func<Author, bool>> filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            //return this.GetAll().Where(x => filter(x));
            return this.GetAll().Where(filter);
        }

        public Author Get(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.ID == id);
        }

        public bool TryGet(int id, out Author author)
        {
            author = this.GetAll().SingleOrDefault(t => t.ID == id);
            return author != null;
            //return (author = this.Get(id)) != null;
        }

        public Author Create(Author author)
        {
            var id = (int)this.session.Save(author);
            this.session.Flush();
            return author;
        }

        public void Delete(int id)
        {
            if (!this.TryGet(id, out var author)) return;
            this.session.Delete(author);
            this.session.Flush();
        }
    }
}
