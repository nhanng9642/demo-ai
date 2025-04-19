using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnNMLT_20880040_Console
{
    struct PRODUCT
    {
        public int id;
        public string code;
        public string name;
        public DateTime expDate;
        public string company;
        public int year;
        public int category;
    }
    class Product
    {
        static private int nextId = 0;
        static public PRODUCT createProduct (List<CATEGORY> categories)
        {
            PRODUCT prod = new PRODUCT();
            Console.Write("- Ma mat hang: ");
            prod.code = Console.ReadLine();
            Console.Write("- Ten mat hang: ");
            prod.name = Console.ReadLine();
            Console.WriteLine("- Han dung: ");
            Console.Write("      Nam het han: ");
            string yInput = Console.ReadLine();
            Console.Write("      Thang het han: ");
            string mInput = Console.ReadLine();
            Console.Write("      Ngay het han: ");
            string dInput = Console.ReadLine();

            if (
                !string.IsNullOrEmpty(yInput) &&
                !string.IsNullOrEmpty(mInput) &&
                !string.IsNullOrEmpty(dInput)
                )
            {
                try
                {
                    int y = int.Parse(yInput);
                    int m = int.Parse(mInput);
                    int d = int.Parse(dInput);
                    prod.expDate = new DateTime(y, m, d);
                } catch
                {
                    Console.WriteLine("Da xay ra loi, han dung mac dinh la hom nay");
                    prod.expDate = DateTime.Now;
                }
            }
            else
            {
                Console.WriteLine("Da xay ra loi, han dung mac dinh la hom nay");
                prod.expDate = DateTime.Now;
            }
            Console.Write("- Cong ty san xuat: ");
            prod.company = Console.ReadLine();
            Console.Write("- Nam san xuat: ");
            try
            {
                int yearInput = int.Parse(Console.ReadLine());
                DateTime temp = new DateTime(yearInput, 1, 1);
                prod.year = temp.Year;
            } catch
            {
                Console.WriteLine("Da xay ra loi, nam SX mac dinh la nam hien tai");
                prod.year = DateTime.Now.Year;
            }
            
            if (categories == null || categories.Count == 0)
            {
                Console.WriteLine("Chua co loai mat hang nao");
            } else
            {
                Console.WriteLine("Co cac loai mat hang sau");
                Category.printCategories(categories);
                Console.Write("Nhap Id mat hang: ");
                prod.category = int.Parse(Console.ReadLine());
            }

            prod.id = nextId;
            nextId++;
            return prod;
        }

        static public void printProducts(List<PRODUCT> products, List<CATEGORY> categories)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(
                "{0,5} {1,10} {2,20} {3,20} {4,20} {5,10} {6,20}",
                "ID",
                "Ma MH",
                "Ten MH",
                "Han dung",
                "CTy SX",
                "Nam SX",
                "Loai MH"
            );
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            if (products == null || products.Count == 0)
            {
                Console.WriteLine("Khong co mat hang nao");
            }
            else
            {
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine(
                        "{0,5} {1,10} {2,20} {3,20} {4,20} {5,10} {6,20}",
                        products[i].id,
                        products[i].code,
                        products[i].name,
                        products[i].expDate.ToString("dd-MM-yyyy"),
                        products[i].company,
                        products[i].year,
                        categories[Category.getCategoryById(categories, products[i].category)].name
                    );
                }
                Console.WriteLine();
            }
        }

        static public int getProductById(List<PRODUCT> products, int id)
        {
            int index = products.FindIndex(prod => prod.id == id);
            return index;
        }

        static public List<PRODUCT> getProductsByName(List<PRODUCT> products)
        {
            Console.Write("Nhap chuoi tim kiem");
            string seq = Console.ReadLine();

            List<PRODUCT> prods = new List<PRODUCT>();
            products.ForEach(p =>
            {
                if (p.name.Contains(seq))
                {
                    prods.Add(p);
                }
            });

            return prods;
        }

        static public List<PRODUCT> updateProduct (List<PRODUCT> products, List<CATEGORY> categories)
        {
            Console.Write("Nhap id mat hang can sua: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                int id = int.Parse(input);
                int index = getProductById(products, id);
                if (index > -1)
                {
                    PRODUCT p = products[index];

                    Console.Write("Nhap ma mat hang moi (" + p.code + "): ");
                    string codeNew = Console.ReadLine();
                    if (!string.IsNullOrEmpty(codeNew))
                    {
                        p.code = codeNew;
                    }

                    Console.Write("Nhap ten mat hang moi (" + p.name + "): ");
                    string nameNew = Console.ReadLine();
                    if (!string.IsNullOrEmpty(nameNew))
                    {
                        p.name = nameNew;
                    }

                    Console.Write("Nhap nam het han moi (" + p.expDate.Year + "): ");
                    string y = Console.ReadLine();
                    Console.Write("Nhap thang het han moi (" + p.expDate.Month + "): ");
                    string m = Console.ReadLine();
                    Console.Write("Nhap ngay het han moi (" + p.expDate.Day + "): ");
                    string d = Console.ReadLine();
                    int yNew = p.expDate.Year;
                    int mNew = p.expDate.Month;
                    int dNew = p.expDate.Day;
                    if (!string.IsNullOrEmpty(y))
                    {
                        yNew = int.Parse(y);
                    }
                    if (!string.IsNullOrEmpty(m))
                    {
                        mNew = int.Parse(m);
                    }
                    if (!string.IsNullOrEmpty(d))
                    {
                        dNew = int.Parse(d);
                    }
                    p.expDate = new DateTime(yNew, mNew, dNew);

                    Console.Write("Nhap Cty SX moi (" + p.company + "): ");
                    string companyNew = Console.ReadLine();
                    if (!string.IsNullOrEmpty(companyNew))
                    {
                        p.company = companyNew;
                    }

                    Console.Write("Nhap nam SX moi (" + p.year + "): ");
                    string yearNew = Console.ReadLine();
                    if (!string.IsNullOrEmpty(yearNew))
                    {
                        p.year = int.Parse(yearNew);
                    }

                    if (categories == null || categories.Count == 0)
                    {
                        Console.WriteLine("Chua co loai mat hang nao");
                    }
                    else
                    {
                        Console.WriteLine("Co cac loai mat hang sau");
                        Category.printCategories(categories);
                        Console.Write("Nhap Id loai hang moi: ");
                        string catIdNew = Console.ReadLine();
                        if (!string.IsNullOrEmpty(catIdNew))
                        {
                            p.category = int.Parse(catIdNew);
                        }
                    }

                    products[index] = p;
                } else
                {
                    Console.WriteLine("Khong co mat hang nao voi Id tren");
                }
                
            }
            
            return products;

        }

        static public List<PRODUCT> deleteProduct (List<PRODUCT> products)
        {
            Console.Write("Nhap id mat hang can xoa: ");
            int id = int.Parse(Console.ReadLine());
            int index = getProductById(products, id);
            if (index < 0)
            {
                Console.WriteLine("Khong co mat hang nao voi ID tren");
            } else
            {
                products.RemoveAt(index);
            }
            return products;
        }
    }
}
