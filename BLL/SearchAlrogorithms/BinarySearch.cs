//using System.Collections.Generic;
//using BLL;
//using DLL;

//namespace BLL.SearchAlrogorithms
//{
//    public class BinarySearch : IFinderStrategy<Product>
//    {
//        public Product Find(List<Product> item, int price)
//        {
//            item.Sort();

//            int min = 0;
//            int N = item.Count;
//            int max = N - 1;

//            do
//            {
//                int mid = (min + max) / 2;
//                if (price > item[mid])
//                    min = mid + 1;
//                else
//                    max = mid - 1;
//                if (data[mid] == item)
//                    return mid;
//            } while (min <= max);

//            if(item[item.Count / 2].Price < price)

//            return new Product();
//        }
//    }
//}