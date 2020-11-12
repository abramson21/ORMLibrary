namespace TestORMLibrary
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;

    internal class Program
    {
        internal static void Main(string[] args) => MainAsync(args).Wait();
        private static async Task MainAsync(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            ..serviceCollection.AddConfiguration
        }
    }
}
