namespace Library.Services
{
    using System.Linq;
    using Library.Domain;

    public interface IAuthorService
    {
        bool TryGet(int id, out Author author);

        IQueryable<Author> GetAll();

        Author GetId(int id);

        IQueryable<Author> GetAuthorByBookId(int bookId);

        Author Create(string lastName, string firstName, string middleName);

        void Delete(int id);
    }
}