namespace Library.NH
{
    using Library.Domain;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Правила отображения для <see cref="Name"/>.
    /// </summary>
    internal class NameMap : ComponentMap<Name>
    {
        public NameMap()
        {
            this.Map(x => x.LastName);
            this.Map(x => x.FirstName);
            this.Map(x => x.MiddleName);
        }
    }
}
