using System;
using System.Collections.Generic;
using product_management.dto;
using product_management.service;

namespace product_management
{
    class Program
    {
        static string PRODUCT_TYPE = "PRODUCT";
        static string CATEGORY_TYPE = "CATEGORY";
        
        static void Main(string[] args)
        {
            
            var productStore = new ProductStore();
            var categoryStore = new Store<Category>();
            
            Console.WriteLine("Hello World!");
            while (true)
            {
                rootMenu();
                Store<Entity> selectedStore;
                var selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Console.WriteLine("# Products");
                        productStore.List();
                        Console.WriteLine("# Categories");
                        categoryStore.List();
                        break;
                    case "2": // Product
                        Console.WriteLine("Please select PRODUCT operation:");
                        editProduct(ref productStore);
                        break;
                    case "3": // Category
                        Console.WriteLine("Please select CATEGORY operation:");
                        editCategory(ref categoryStore);
                        break;
                    default:
                        break;
                }
                continue;
            }
        }

        static void editProduct(ref ProductStore store)
        {
            operationMenu();
            Console.WriteLine("6. Find by category");
            var selection = Console.ReadLine();
            Product product;
            int id;
            string search;
            switch (selection)
            {
                case "1": // Create
                    product = newProduct();
                    product = store.Create(product);
                    Console.WriteLine($"Product created | {product}");
                    break;
                case "2": // List
                    Console.WriteLine("# Products");
                    store.List();
                    break;
                case "3": // Update
                    Console.Write("Product ID: ");
                    id = Int32.Parse(Console.ReadLine());
                    product = newProduct();
                    store.Update(id, product);
                    break;
                case "4": // Delete
                    Console.Write("Product ID: ");
                    id = Int32.Parse(Console.ReadLine());
                    store.Delete(id);
                    break;
                case "5": // Find by name
                    Console.Write("Find in Name: ");
                    search = Console.ReadLine();
                    store.FindByName(search);
                    break;
                case "6":
                    Console.Write("Find CategoryId: ");
                    search = Console.ReadLine();
                    store.FindByCategory(search);
                    break;
                default:
                    break;
            }
        }
        
        static void editCategory(ref Store<Category> store)
        {
            operationMenu();
            var selection = Console.ReadLine();
            Category category;
            int id;
            switch (selection)
            {
                case "1": // Create
                    category = newCategory();
                    category = store.Create(category);
                    Console.WriteLine($"Category created | {category}");
                    break;
                case "2": // List
                    Console.WriteLine("# Categories");
                    store.List();
                    break;
                case "3": // Update
                    Console.Write("Category ID: ");
                    id = Int32.Parse(Console.ReadLine());
                    category = newCategory();
                    store.Update(id, category);
                    break;
                case "4": // Delete
                    Console.Write("Category ID: ");
                    id = Int32.Parse(Console.ReadLine());
                    store.Delete(id);
                    break;
                case "5": // Find by name
                    Console.Write("Find: ");
                    var search = Console.ReadLine();
                    store.FindByName(search);
                    break;
                default:
                    break;
            }
        }
        
        static Category newCategory()
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            var category = new Category();
            category.Name = name;
            return category;
        }

        static Product newProduct()
        {
            var product = new Product();
            Console.Write("Name: ");
            product.Name = Console.ReadLine();
            Console.Write("CategoryId: ");
            product.CategoryId = Console.ReadLine();
            Console.Write("Producer: ");
            product.Producer = Console.ReadLine();
            return product;
        }

        static void rootMenu()
        {
            Console.WriteLine("Please select operation:");
            Console.WriteLine("1. List all tables");
            Console.WriteLine("2. Edit Product");
            Console.WriteLine("3. Edit Category");
        }

        static void operationMenu()
        {
            Console.WriteLine("1. Create");
            Console.WriteLine("2. List");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Find by name");
        }
    }
}
