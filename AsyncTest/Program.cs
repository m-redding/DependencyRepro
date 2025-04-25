using AsyncLibrary;
using System;
using System.Threading.Tasks;


namespace AsyncTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var collection = new CollectionClass();
            await foreach (var item in collection)
            {
                //do nothing
            }
        }
    }
}
