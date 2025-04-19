using System.Collections.Generic;
using product_management.dto;

namespace product_management
{
    public class Database
    {
        private List<Product> products = new List<Product>();
        private List<Category> categories = new List<Category>();
        
        public Category Create(Category category)
        {
            category.Id = categories.Count;
            categories.Add(category);
            return category;
        }

        public List<Category> List()
        {
            return categories;
        }
    }
}