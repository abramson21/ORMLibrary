namespace Library.NH.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Library.Domain;

    public interface IAuthorRepository
    {
        IQueryable<Author> Filter(Expression<Func<Author, bool>> filter);

        //Author Get(int id);

        IQueryable<Author> GetAll();

        bool TryGet(int id, out Author author);
    }
}