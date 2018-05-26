using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DLL;

namespace BLL.SearchAlrogorithms
{
    /// <summary>
    /// The class represents parallel version of finding algorithm
    /// </summary>
    public class ParallelSearch : IFinderStrategy<Product>
    {
        /// <summary>
        /// Finds the products with a lowest price
        /// </summary>
        /// <param name="storage">source for looking for</param>
        /// <param name="item">item for the search</param>
        /// <param name="num">number of items for the output</param>
        /// <returns>list of filtered items</returns>
        public IList<Product> Find(IList<Product> storage, string item, int num)
        {
            IList<Product> products = new List<Product>();

            object sync = new object();;

            Parallel.ForEach(storage, product =>
                {
                    lock (sync)
                    {
                        if (product.Description == item)
                            products.Add(product);
                    }
                }
            );
            
            return products.OrderBy(s => s.Price).Reverse().Take(10).Reverse().ToList();
        }
    }
}