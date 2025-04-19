using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNMLT_20880040_Console
{
    struct CATEGORY
    {
        public int id;
        public string name;
    }
    class Category
    {
        static private int nextId = 0;
        static public CATEGORY createCategory()
        {
            CATEGORY cat;

            Console.Write("Ten loai hang: ");
            cat.name = Console.ReadLine();
            
            cat.id = nextId;
            nextId++;
            return cat;
        }

        static public void printCategories(List<CATEGORY> categories)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(
                   "{0,5} {1,20}",
                   "ID",
                   "Ten loai hang"
               );
            Console.WriteLine("-------------------------------------");
            if (categories.Count > 0)
            {
                for (int i = 0; i < categories.Count; i++)
                {
                    Console.WriteLine(
                        "{0,5} {1,20}",
                        categories[i].id,
                        categories[i].name
                    );
                }
            } else
            {
                Console.WriteLine("Chua co loai hang nao");
            }
            Console.WriteLine();
        }

        static public int getCategoryById(List<CATEGORY> categories, int id)
        {
            int index = categories.FindIndex(cat => cat.id == id);
            return index;
        }

        static public List<CATEGORY> getCategoriesByName(List<CATEGORY> categories)
        {
            Console.Write("Nhap chuoi tim kiem: ");
            string seq = Console.ReadLine();

            List<CATEGORY> cats = new List<CATEGORY>();
            categories.ForEach(c =>
            {
                if (c.name.Contains(seq))
                {
                    cats.Add(c);
                }
            });

            return cats;
        }

        static public List<CATEGORY> updateCategory(List<CATEGORY> categories)
        {
            Console.Write("Nhap id loai hang can sua: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                int id = int.Parse(input);
                int index = getCategoryById(categories, id);
                if (index > -1)
                {
                    CATEGORY c = categories[index];

                    
                    Console.Write("Nhap ten loai hang moi (" + c.name + "): ");
                    string nameNew = Console.ReadLine();
                    if (!string.IsNullOrEmpty(nameNew))
                    {
                        c.name = nameNew;
                    }

                    categories[index] = c;
                }
                else
                {
                    Console.WriteLine("Khong co loai hang nao voi Id tren");
                }

            }

            return categories;

        }

        static public List<CATEGORY> deleteCategory(List<CATEGORY> categories)
        {
            Console.Write("Nhap id loai hang can xoa: ");
            int id = int.Parse(Console.ReadLine());
            int index = getCategoryById(categories, id);
            if (index < 0)
            {
                Console.WriteLine("Khong co loai hang nao voi ID tren");
            }
            else
            {
                categories.RemoveAt(index);
            }
            return categories;
        }
    }
}
