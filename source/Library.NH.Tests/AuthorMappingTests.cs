namespace Library.NH.Tests
{
    using NUnit.Framework;
    using NHibernate;
    using Infrastructure.Helpers;
    using System.Collections.Generic;
    using FluentNHibernate.Testing;
    using Library.Domain;

    /// <summary>
    /// Модульные тесты для класса <see cref="AuthorMap"/>.
    /// </summary>
    public class AuthorMappingTests
    {

        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(AuthorMap).Assembly);
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

            var testName = new Name("Александр", "Пушкин", "Сергеевич");

            //act &  assert
            new PersistenceSpecification<Author>(this.session)
                .CheckProperty(x => x.Name, testName)
                .CheckList(x => x.Books, books, book=>book.Id)
                .VerifyTheMappings();
        }
    }
}