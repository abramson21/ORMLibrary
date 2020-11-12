namespace Library.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Author
    {
        public virtual int Id { get; protected set; }

        public virtual Name Name { get; protected set; }

        public override string ToString() => $"{this.Id} --> {this.Name}";
    }
}
