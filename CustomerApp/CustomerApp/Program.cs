using AsyncLibrary;

namespace CustomerApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var collection = new CollectionClass();

            // The follow two warnings are produced by 'collection' below
            // The type 'IAsyncEnumerable<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'Microsoft.Bcl.AsyncInterfaces, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'.
            // Asynchronous foreach statement cannot operate on variables of type 'CollectionClass' because 'CollectionClass' does not contain a suitable public instance or extension definition for 'GetAsyncEnumerator'
            await foreach (var item in collection)
            {
                //do nothing
            }

            // This does not produce a warning
            await foreach (var item in GetFoos())
            {
                //do nothing
            }
        }

        private static async IAsyncEnumerable<object> GetFoos()
        {
            yield return new object();
        }
    }
}
