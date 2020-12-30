namespace Library.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Library.Domain;
    using Library.NH.Repositories;
    public class AuthorServices : IAuthorServices
    {
        private readonly IAuthorRepository authorRepository;

        //private readonly IMovieRepository movieRepository;

        public AuthorServices(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository ?? throw new ArgumentNullException(nameof(authorRepository));
        }

        public Author Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAll()
        {
            return this.authorRepository.GetAll().ToList();
        }

        //public List<Author> Get(int id)
        //{
        //    return this.authorRepository.GetID(id);
        //}

        //public List<Movie> GetAllMoviesByDirectorId(int id)
        //{
        //    return this.authorServices.GetAll().FirstOrDefault(x => x.Id == id)?.Movie.ToList();
        //}
    }
}
