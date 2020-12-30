namespace Library.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Library.Domain;
    using Library.NH.Repositories;

    public interface IBookServices
    {
        IQueryable<Book> GetAll();

        Book Get(int id);
    }
}