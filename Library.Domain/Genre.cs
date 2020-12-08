using Library.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain
{
    using Infrastructure.Extensions;
    public class Genre
    {
        public virtual int Id { get; protected set; }

        public virtual string ID_Book { get; protected set; }

        public virtual string Title { get; protected set; }

        public virtual Book Book { get; protected set; }

        public override string ToString() => $" -- > {this.Title}";
    }
}
