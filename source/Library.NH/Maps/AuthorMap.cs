namespace Library.NH
{
    using FluentNHibernate.Mapping;
    using Library.Domain;

    /// <summary>
    /// Правила отображения сущности <see cref="Author"/> на таблицу БД.
    /// </summary>
    internal class AuthorMap : ClassMap<Author>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AuthorMap"/>.
        /// </summary>
        public AuthorMap()
        {
            this.Table("Authors");

            this.Id(x => x.Id);

            this.Component(x => x.Name);

            this.HasManyToMany(x => x.Books).Table("AuthorBook");
        }
    }
}
