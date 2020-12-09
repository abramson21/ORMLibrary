namespace Library.Domain
{
    using System.Collections.Generic;

    public class Author
    {
        public virtual int Id { get; protected set; }

        public virtual Name Name { get; protected set; }

        public virtual ISet<Book> Books { get; protected set; } = new HashSet<Book>();

        public override string ToString() => $"{this.Name} ";
    }
}
