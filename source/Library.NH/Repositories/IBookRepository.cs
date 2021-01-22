namespace Library.NH.Repositories
{
    using System.Linq;
    using Library.Domain;

    public interface IBookRepository
    {
        IQueryable<Book> GetAll();

        Book GetBooksForAuthorID(int id);

        Book GetId(int id);

        //bool TryGet(int id, out Book book) 

        IQueryable<Book> GetBooksByTitle();

    }
}