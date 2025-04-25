
namespace AsyncLibrary
{
    public class CollectionClass : IAsyncEnumerable<object>
    {
        public AsyncPageable<object> GetAllAsync()
        {
            return new AsyncPageable<object>();
        }

        IAsyncEnumerator<object> IAsyncEnumerable<object>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync().GetAsyncEnumerator(cancellationToken);
        }
    }
}
