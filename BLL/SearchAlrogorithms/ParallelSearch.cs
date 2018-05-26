using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DLL;

namespace BLL.SearchAlrogorithms
{
    public class ParallelSearch : IFinderStrategy<Product>
    {
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