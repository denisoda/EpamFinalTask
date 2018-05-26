using System;
using System.Collections.Generic;
using System.Linq;
using DLL;

namespace BLL.SearchAlrogorithms
{
    /// <summary>
    /// Representative of the linear search algorithm
    /// </summary>
    public class Linear : IFinderStrategy<Product>
    {
        /// <summary>
        /// Finds the products with a lowest price
        /// </summary>
        /// <param name="storage">source for looking for</param>
        /// <param name="item">item for the search</param>
        /// <param name="num">number of items for the output</param>
        /// <returns>list of filtered items</returns>
        public IList<Product> Find(IList<Product> productStorage, string item, int num)
        {
            IList<Product> items = new List<Product>();

            foreach (var product in productStorage)
            {
                if(product.Description == item)
                    items.Add(product);
            }

            return items.OrderBy(s => s.Price).Reverse().Take(num).Reverse().ToList();
        }
    }
}