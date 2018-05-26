using System.Collections.Generic;
using System.Linq;
using DLL;

namespace BLL.SearchAlrogorithms
{
    public class FSLWay : IFinderStrategy<Product>
    {
        public IList<Product> Find(IList<Product> productStorage, string item)
        {
            var s = productStorage;

            var a = productStorage.OrderBy(z => z.Price).Select(z => z.Price).First();

            return new List<Product>();
        }
    }
}