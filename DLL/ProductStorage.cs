using System.Collections;
using System.Collections.Generic;

namespace DLL
{
    /// <summary>
    /// A singleton product storage
    /// </summary>
    public sealed class ProductStorage
    {
        static readonly List<Product> _list = new List<Product>();

        public static List<Product> Instance => _list;
    }
}