using System.Collections.Generic;
using System.Linq;
using DLL;

namespace BLL.SearchAlrogorithms
{
    public class FSLWay : IFinderStrategy<Product>
    {
        public Product Find(List<Product> storage, Product item) => storage.OrderBy(p => p.Price).First(p => p.Description == item.Description);
    }
}