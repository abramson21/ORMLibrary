namespace Library.Domain
{
    using System.Collections.Generic;

    public class Genre
    {
        public virtual int Id { get; protected set; }

        public virtual string ID_Book { get; protected set; }

        public virtual string Title { get; protected set; }

        public virtual ISet<Book> Books { get; protected set; } = new HashSet<Book>();

        public override string ToString() => $"{this.Title}";
    }
}
