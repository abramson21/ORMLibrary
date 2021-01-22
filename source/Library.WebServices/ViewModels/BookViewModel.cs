namespace Library.WebServices.ViewModels
{
    using System;
    using Library.Domain;

    public class BookViewModel
    {
        public string Title { get; }

        public Author Author { get; }

        public Genre Genre { get; }

        public Publisher Publisher { get; }

        public BookViewModel(string title, Author author, Genre genre, Publisher publisher)
        {
            if (title == null || author == null || genre == null || publisher == null || genre == null) throw new ArgumentNullException($"Имя объекта {nameof(title)} или сущность автора  равна null");
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.Publisher = publisher;
        }
    }
}
