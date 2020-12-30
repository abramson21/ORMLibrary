namespace Library.NH.Maps

{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    /// <summary>
    /// Правила отображения для <see cref="Name"/>.
    /// </summary>
    public class NameMap : ComponentMap<Name>
    {
        public NameMap()
        {
            this.Map(x => x.LastName);
            this.Map(x => x.FirstName);
            this.Map(x => x.MiddleName);
        }
    }
}
