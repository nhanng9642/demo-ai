using System;
using System.Collections.Generic;
using product_management.dto;

namespace product_management.service
{
    public class ProductStore : Store<Product>
    {
        public ProductStore()
        {
            this.list = List();
        }

        public List<Product> FindByCategory(string str)
        {
            var result = new List<Product>();
            
            foreach (var item in list)
            {
                if (item.CategoryId.Contains(str))
                {
                    result.Add(item);
                    Console.WriteLine($"Found: {item}");
                }
            }

            return result;
        }
    }
}