namespace Library.Services
{
    using System.Collections.Generic;
    using Library.Domain;

    public interface IAuthorServices
    {
        List<Author> GetAll();

        Author Get(int id);
    }
}