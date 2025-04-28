using System;
using System.Collections.Generic;
using System.Threading;

namespace BaseLibrary
{
    public class AsyncPageable<T> : IAsyncEnumerable<T>
    {
        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
