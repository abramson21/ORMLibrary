namespace Library.NH.Tests
{
    using NUnit.Framework;
    using NHibernate;
    using Infrastructure.Helpers;
    using System.Collections.Generic;
    using FluentNHibernate.Testing;
    using Library.Domain;
    using Library.NH.Maps;

    /// <summary>
    /// Модульные тесты для класса <see cref="RoomMap"/>.
    /// </summary>
    public class RoomMappingTests
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(BookMap).Assembly);
        }

        [Test]
        public void Test1()
        {
            // arrange
            
            var shelves = new List<Shelf>
            {
                new Shelf("Верхняя полка"),
                new Shelf("Средняя полка"),
                new Shelf("Нижняя полка"),
            };

            //act &  assert
            new PersistenceSpecification<Room>(this.session)
                .CheckProperty(x => x.Name, "Спальня")
                .CheckList(x => x.Shelves, shelves, shelf => shelf.Id)
                .VerifyTheMappings();
        }
    }
}
