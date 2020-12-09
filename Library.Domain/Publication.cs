﻿namespace Library.Domain
{
    using System.Collections.Generic;
    public class Publication
    {
        public virtual int Id { get; protected set; }

        public virtual string ID_Publication { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual ISet<Book> Books { get; protected set; } = new HashSet<Book>();

        public override string ToString() => $"{this.Name} ";
    }
}
