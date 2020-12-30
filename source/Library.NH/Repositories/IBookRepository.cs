namespace Library.NH.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Library.Domain;
    public interface IBookRepository
    {
        IQueryable<Book> Filter(Expression<Func<Book, bool>> filter);

        Book Get(int id);

        IQueryable<Book> GetAll();

        bool TryGet(int id, out Book book);
    }
}