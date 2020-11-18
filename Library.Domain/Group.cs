using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain
{
    using System.Collections.Generic;

    public class Group
    {
        public virtual int Id { get; protected set; } 

        public virtual ISet<Author> Authors { get; protected set; } = new HashSet<Author>();

        public virtual ISet<Book> Books { get; protected set; } = new HashSet<Book>();

    }
}
