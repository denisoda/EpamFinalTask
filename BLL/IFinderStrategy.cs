using System.Collections.Generic;

namespace BLL
{
    public interface IFinderStrategy<T> where T : class
    {
        IList<T> Find(IList<T> storage , string item);
    }
}