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
    /// Модульные тесты для класса <see cref="PublisherMap"/>.
    /// </summary>
    public class PublisherMappingTests
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(PublisherMap).Assembly);
        }

        [Test]
        public void Test1()
        {
            // arrange
            var books = new List<Book>
            {
                new Book("Капитанская дочка"),
                new Book("Евгений Онегин"),
                new Book("Руслан и Людмила")
            };

            //act &  assert
            new PersistenceSpecification<Publisher>(this.session)
                .CheckProperty(x => x.Name, "Росмэн")
                .CheckList(x => x.Books, books, book=>book.Id)
                .VerifyTheMappings();
        }
    }
}
