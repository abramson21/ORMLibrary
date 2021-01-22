using System.Linq;

namespace Library.Services
{
    using System.Collections.Generic;
    using Library.Domain;

    public interface IBookService
    {
        IList<Book> GetAll();

        bool TryGet(int id, out Book book);

        Book GetBooksForAuthorID(int id);

        Book GetBookId(int id);

        IQueryable<Book> GetBooksByTitle(string str);

    }
}