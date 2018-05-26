using System.Collections.Generic;

namespace BLL
{
    public interface IFinderStrategy<T> where T : class
    {
        T Find(List<T> storage , T item);
    }
}