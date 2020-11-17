namespace Library.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Book
    {
        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual ISet<Author> Authors { get; protected set; } = new HashSet<Author>();

        public virtual string ToString() => $"{this.Id} --> {this.Name}";

    }
}
