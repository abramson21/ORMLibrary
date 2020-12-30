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
    /// Модульные тесты для класса <see cref="ShelfMap"/>.
    /// </summary>
    public class ShelfMappingTests
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(ShelfMap).Assembly);
        }

        [Test]
        public void Test1()
        {
            // arrange
            var books = new List<Book>
            {
                new Book("Война и мир"),
                new Book("Метро 2033"),
                new Book("Вино из одуванчиков")
            };

            var testRoom = new Room("Гостиная");

            //act &  assert
            new PersistenceSpecification<Shelf>(this.session)
                .CheckProperty(x => x.Description, "Самая нижняя полка")
                .CheckList(x => x.Books, books, book => book.Id)
                .CheckReference(x=>x.Room, testRoom, room=>room.Id)
                .VerifyTheMappings();
        }
    }
}
