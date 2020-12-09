using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain
{
    public class Publication
    {
        public virtual int Id { get; protected set; }

        public virtual string ID_Publication { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual Book Book { get; protected set; }

        public override string ToString() => $"{this.Name} ";
    }
}
