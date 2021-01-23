namespace Library.Domain
{
    using System.Collections.Generic;
    using Infrastructure.Extensions;

    public class Book
    {
        public Book() { }

        public Book(string title)
        {
            this.Title = title;
        }

        public virtual int Id { get; protected set; }

        public virtual string Title { get; protected set; }

        public virtual ISet<Author> Authors { get; protected set; } = new HashSet<Author>();

        public virtual ISet<Genre> Genres { get; protected set; } = new HashSet<Genre>();

        public virtual ISet<Publisher> Publishers { get; protected set; } = new HashSet<Publisher>();

        public virtual Shelf Shelf { get; protected set; }

        public override string ToString()
        {
            return $"{this.Title} -- {this.Authors.Join()} -- {this.Genres} -- {this.Publishers}";
        }
    }
}
