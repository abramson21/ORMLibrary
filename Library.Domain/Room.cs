using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain
{
    using Infrastructure.Extensions;
    public class Room
    {
        public virtual int Id { get; protected set; }

        public virtual string RoomName { get; protected set; }

        public virtual string Note { get; protected set; }

        public virtual ISet<Shelf> Shelves { get; protected set; } = new HashSet<Shelf>();

        public virtual Book Book { get; protected set; }

        public override string ToString() => $"Номер комнаты: {this.RoomName} -- Номер полки: {this.Shelves.Join()}";
    }
}
