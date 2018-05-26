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
            object sync = new object();;

            Parallel.ForEach(storage, product =>
                {
                    lock (sync)
                    {
                        if (product.Description != item)
                            product = null;
                    }
                }
            );
            

            return storage;
        }
    }
}