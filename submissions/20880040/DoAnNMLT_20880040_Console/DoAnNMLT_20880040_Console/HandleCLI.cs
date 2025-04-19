using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNMLT_20880040_Console
{
    class HandleCLI
    {
        static public void main (List<PRODUCT> products, List<CATEGORY> categories)
        {
            bool running = true;
            while (running)
            {
                
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("| 1: Xem tat ca mat hang         6: Xem tat ca loai hang     |");
                Console.WriteLine("| 2: Them mat hang               7: Them loai hang           |");
                Console.WriteLine("| 3: Tim mat hang theo ten       8: Tim loai hang theo ten   |");
                Console.WriteLine("| 4: Sua mat hang                9: Sua loai hang            |");
                Console.WriteLine("| 5: Xoa mat hang                10: Xoa loai hang           |");
                Console.WriteLine("| 11: Thoat                                                  |");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine();
                Console.Write(">>");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    Product.printProducts(products, categories);
                }
                else if (input == "2")
                {
                    products.Add(Product.createProduct(categories));
                }
                else if (input == "3")
                {
                    List<PRODUCT> result = Product.getProductsByName(products);
                    Product.printProducts(result, categories);
                }
                else if (input == "4")
                {
                    products = Product.updateProduct(products, categories);
                }
                else if (input == "5")
                {
                    products = Product.deleteProduct(products);
                }
                else if (input == "6")
                {
                    Category.printCategories(categories);
                }
                else if (input == "7")
                {
                    categories.Add(Category.createCategory());
                }
                else if (input == "8")
                {
                    List<CATEGORY> result = Category.getCategoriesByName(categories);
                    Category.printCategories(result);
                }
                else if (input == "9")
                {
                    Category.updateCategory(categories);
                }
                else if (input == "10")
                {
                    Category.deleteCategory(categories);
                }
                else if (input == "11")
                {
                    running = false;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
        
        //static public void printProducts(List<PRODUCT> products)
        //{
        //    if (products == null || products.Count == 0)
        //    {
        //        Console.WriteLine("Khong co mat hang nao");
        //    }
        //    else
        //    {
        //        for (int i = 0; i < products.Count; i++)
        //        {
        //            Console.WriteLine(
        //                products[i].id + "    " +
        //                products[i].code + "    " +
        //                products[i].name + "    " +
        //                products[i].expDate + "    " +
        //                products[i].company + "    " +
        //                products[i].year + "    " +
        //                products[i].category.name
        //            );
        //        }
        //    }
        //}

        //static public void printCategories(List<CATEGORY> categories)
        //{
        //    for (int i = 0; i < categories.Count; i++)
        //    {
        //        Console.WriteLine(
        //            categories[i].id + "    " +
        //            categories[i].name
        //        );
        //    }
        //}
    }
}
