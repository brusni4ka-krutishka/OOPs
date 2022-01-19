using System.Collections.Generic;

namespace Lab10
{
    public interface IEnumerable<T>
    {
        IEnumerator<T> GetEnumerator();
    }
}
