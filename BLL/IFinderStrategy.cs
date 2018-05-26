using System.Collections.Generic;

namespace BLL
{
    /// <summary>
    /// An interface for substitutions of find algorithms
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IFinderStrategy<T> where T : class
    {
        IList<T> Find(IList<T> storage , string item, int number);
    }
}