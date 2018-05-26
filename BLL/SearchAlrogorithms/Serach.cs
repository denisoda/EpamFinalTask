using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DLL;

namespace BLL.SearchAlrogorithms
{
    public class ParallelSearch : IFinderStrategy<Product>
    {
        public IList<Product> Find(IList<Product> storage, string item)
        {
            Parallel.ForEach(storage, product =>
                {
                    if (product.Description != item)
                        storage.Remove(product);
                }
            );

            return storage;
        }
    }
}