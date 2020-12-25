namespace Library.Domain
{
    using System.Collections.Generic;
    using Infrastructure.Extensions;

    public class Book
    {
        public virtual int Id { get; protected set; }

        public virtual string Title { get; protected set; }

        public virtual ISet<Author> Authors { get; protected set; } = new HashSet<Author>();

        public virtual ISet<Genre> Genres { get; protected set; } = new HashSet<Genre>();

        public virtual ISet<Publisher> Publishers { get; protected set; } = new HashSet<Publisher>();

        public virtual Shelf Shelf { get; protected set; }

        public override string ToString() => $"Название книги: \"{this.Title}\"\n\tАвтор: {this.Authors.Join()}\n\tЖанр: {this.Genres.Join()}\n\tПубликация в \"{this.Publishers.Join()}\"\n\tКомната: {this.Shelf}\n";
    }
}
