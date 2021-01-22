namespace Library.WebServices.ViewModels
{
    using System.Collections.Generic;
    using Library.Domain;

    public class BookDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public IEnumerable<Author> Authors { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public IEnumerable<Publisher> Publishers { get; set; }

        public Shelf Shelf { get; set; }
    }
}
