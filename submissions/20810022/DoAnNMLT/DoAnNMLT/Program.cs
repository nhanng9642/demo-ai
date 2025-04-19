using System;
using System.Collections.Generic;

namespace DoAnNMLT
{
    class Program
    {
        static List<ProductType> listProductType = new List<ProductType>();
        static List<Product> listProduct = new List<Product>();
        static void Main(string[] args)
        {
            while (true)
            {
                presentHomePage();
                // Sản phẩm
                var actionType = Console.ReadLine();

                if (actionType == "exit") break;

                switch (actionType)
                {
                    case "1":
                        addProductType();
                        break;
                    case "2":
                        showListProducType();
                        break;
                    case "3":
                        findProductType();
                        break;
                    case "4":
                        editProductType();
                        break;
                    case "5":
                        deleteProductType();
                        break;
                    case "6":
                        addProduct();
                        break;
                    case "7":
                        showListProduct();
                        break;
                    case "8":
                        findProduct();
                        break;
                    case "9":
                        editProduct();
                        break;
                    case "10":
                        deleteProduct();
                        break;                    
                    default:
                        Console.WriteLine("Please choose again!!!");
                        break;
                }                
            }
              
            
        }

        static void presentHomePage()
        {
            /** Giao diện khởi động app */
            Console.WriteLine("***********Welcome to the product management application.**********");
            Console.WriteLine("Please enter the function you want to run.");
            // Loại sản phẩm
            Console.WriteLine("1. Enter 1 to add one more product type.");
            Console.WriteLine("2. Enter 2 to see the list of current product type.");
            Console.WriteLine("3. Enter 3 to find a product type.");
            Console.WriteLine("4. Enter 4 to edit a product type.");
            Console.WriteLine("5. Enter 5 to delete a prodcut type.");
            // Sản phẩm
            Console.WriteLine("6. Enter 6 to add one more product.");
            Console.WriteLine("7. Enter 7 to see the list of current product.");
            Console.WriteLine("8. Enter 8 to find a product.");
            Console.WriteLine("9. Enter 9 to edit a product.");
            Console.WriteLine("10. Enter 10 to delete a prodcut.");
            // Exit
            Console.WriteLine("11. Enter exit to quit application.");
        }

        static void addProductType()
        {
            Console.WriteLine("-------------Add new product type ----------- ");
            Console.WriteLine("PLease enter new product type in the following format:  [Name of product type]-[code of product type] VD: Tivi-123");
            var productTypeString = Console.ReadLine();
            string[] productItem = productTypeString.Split("-");

            if(productItem.Length < 2)
            {
                Console.WriteLine("You enter product type with invalid format \n Please choose add product type function and try again \n");
                return;
            }            
            
            var productType = new ProductType(productItem[0], productItem[1]);
            listProductType.Add(productType);
            Console.WriteLine("Added successfully!! \n");
        }

        static void showListProducType()
        {
            Console.WriteLine("-------------List of product type ----------- ");
            if (listProductType.Count == 0) {
                Console.WriteLine("There are no products on the current list.");
                return;
            }
            Console.WriteLine("Name of product type - Code of product type");
            foreach (var productType in listProductType)
            {
                Console.WriteLine(String.Format("{0}-{1}", productType.typeName, productType.typeCode));
            }
        }

        static void findProductType()
        {
            Console.WriteLine("--------------Find Product type---------------");
            Console.WriteLine("PLease enter the name or product type code you want to search.");
            var findStr = Console.ReadLine();

            foreach(var productType in listProductType)
            {
                if(productType.typeCode == findStr || productType.typeName == findStr)
                {
                    Console.WriteLine(String.Format("The product type you want to search is:  {0}-{1}", productType.typeName, productType.typeCode));
                    return;
                }
            }
            Console.WriteLine("There are no product type you are looking for. \n");
        }

        static void editProductType()
        {
            Console.WriteLine("--------------Modify product type---------------");
            Console.WriteLine("PLease enter the name or product type code you want to modify.");
            var findStr = Console.ReadLine();
            int itemEditIndex = -1;
            for( var i =0; i< listProductType.Count; i++)
            {   
                if(listProductType[i].typeCode == findStr || listProductType[i].typeName == findStr)
                {
                    itemEditIndex = i;
                    break;
                }
            }
            if (itemEditIndex == -1)
            {
                Console.WriteLine("There are no product type you are looking for to modify.\n");
                return;
            }
            Console.WriteLine("PLease choose the information you want to change.");
            Console.WriteLine("1. Name of product type.");
            Console.WriteLine("2. Code of product type.");

            var typeChange = Console.ReadLine();
            
            if(typeChange == "1")
            {
                Console.WriteLine("PLease enter new product type name");
                var nameChange = Console.ReadLine();
                listProductType[itemEditIndex].typeName = nameChange;
                Console.WriteLine("Changed successfully!! \n");
                return;
            }
            if (typeChange == "2")
            {
                Console.WriteLine("Please enter new prpduct type code");
                var codeChange = Console.ReadLine();
                listProductType[itemEditIndex].typeCode = codeChange;
                Console.WriteLine("Changed successfully \n");
                return;
            }
            Console.WriteLine("Invalid information change!!\n");
        }

        static void deleteProductType()
        {
            Console.WriteLine("--------------Delete product type---------------");
            Console.WriteLine("PLease enter the name or product type code you want to delete.");
            var findStr = Console.ReadLine();
            int itemEditIndex = -1;
            for (var i = 0; i < listProductType.Count; i++)
            {
                if (listProductType[i].typeCode == findStr || listProductType[i].typeName == findStr)
                {
                    itemEditIndex = i;
                    break;
                }
            }
            if (itemEditIndex == -1)
            {
                Console.WriteLine("There are no product type you are looking for to delete.\n");
                return;
            }
            listProductType.RemoveAt(itemEditIndex);
            Console.WriteLine("deleted successfully!! \n");

        }

        static dynamic findProductType(string typeName)
        {
            foreach(var productType in listProductType)
            {
                if (productType.typeName == typeName) return productType;
            }
            return null;
        }

        static void addProduct()
        {
            Console.WriteLine("-------------Add new product ----------- ");
            Console.WriteLine("PLease enter new product in the following format:");
            Console.WriteLine("[Code]-[Product Name]-[Due Date]-[production company]-[Manufacture Year]-[Product type (Name of product type in current list of product type)]");
            Console.WriteLine("Example: TV02-Tivi-2030-LG-2020-TV");
      
            var productTypeString = Console.ReadLine();
            string[] productItem = productTypeString.Split("-");

            if (productItem.Length < 6)
            {
                Console.WriteLine("You enter product type with invalid format \n Please choose add product function and try again \n");
                return;
            }
            var productTypeName = productItem[5];
            var productType = findProductType(productTypeName);
            if (productType == null)
            {
                Console.WriteLine("The name of product type you enter does not have in current list of product type");
                Console.WriteLine("Please choose add product function and try again \n");
                return;
            }
            var product  = new Product(productItem[0], productItem[1],productItem[2], productItem[3], productType, productItem[4]);
            listProduct.Add(product);

            Console.WriteLine("Added successfully!! \n");
        }

        static void findProduct()
        {
            Console.WriteLine("--------------Search Product---------------");
            Console.WriteLine("PLease enter the name or product code you want to search.");
            var findStr = Console.ReadLine();

            foreach (var product in listProduct)
            {
                if (product.productCode == findStr || product.productName == findStr)
                {
                    Console.WriteLine("Code - Product Name - Due Date - Manufaction company - Manufacture year - Product type");
                    Console.WriteLine(String.Format("Product you want to search is:  {0} - {1} - {2} - {3} - {4} - {5}", product.productCode, product.productName, product.expiryDate, product.productOf, product.manufactureYear, product.productType.typeName));
                    return;
                }
            }
            Console.WriteLine("There are no product type you are looking for. \n");
        }

        static void showListProduct()
        {
            Console.WriteLine("-------------List of product ----------- ");
            if (listProduct.Count < 1) {
                Console.WriteLine("There are no Product in current list.\n");
                return;
            }
            Console.WriteLine("Code - Product Name - Due Date - Manufaction company - Manufacture year - Product type");
            foreach (var product in listProduct)
            {
                Console.WriteLine(String.Format("Product you want to search is:  {0} - {1} - {2} - {3} - {4} - {5}", product.productCode, product.productName, product.expiryDate, product.productOf, product.manufactureYear, product.productType.typeName));
            }
        }

        static void deleteProduct()
        {
            Console.WriteLine("--------------Delete Product---------------");
            Console.WriteLine("PLease enter the name or product code you want to delete.");
            var findStr = Console.ReadLine();
            int itemEditIndex = -1;
            for (var i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].productCode == findStr || listProduct[i].productName == findStr)
                {
                    itemEditIndex = i;
                    break;
                }
            }
            if (itemEditIndex == -1)
            {
                Console.WriteLine("There are no product type you are looking for to delete.\n");
                return;
            }
            listProduct.RemoveAt(itemEditIndex);
            Console.WriteLine("deleted successfully!! \n");

        }

        static void editProduct()
        {
            Console.WriteLine("--------------Modify Product---------------");
            Console.WriteLine("PLease enter the name or product code you want to modify.");
            var findStr = Console.ReadLine();
            int itemEditIndex = -1;
            for (var i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].productCode == findStr || listProduct[i].productName == findStr)
                {
                    itemEditIndex = i;
                    break;
                }
            }
            if (itemEditIndex == -1)
            {
                Console.WriteLine("There are no product type you are looking for to modify.\n");
                return;
            }
            Console.WriteLine("PLease choose the information you want to change.");
            Console.WriteLine("1. Code of product");
            Console.WriteLine("2. Name of product");
            Console.WriteLine("3. Due Date of product");
            Console.WriteLine("4. Manufaction Company of product");
            Console.WriteLine("5. Manufacture year of product");
            Console.WriteLine("6. Product type of product");

            var typeChange = Console.ReadLine();
            switch (typeChange)
            {
                case "1":
                    Console.WriteLine("Please enter new Code");
                    var codeChange = Console.ReadLine();
                    listProduct[itemEditIndex].productCode = codeChange;
                    Console.WriteLine("Changed successfully!!\n");
                    return;
                case "2":
                    Console.WriteLine("PLease enter new Name");
                    var nameChange = Console.ReadLine();
                    listProduct[itemEditIndex].productName = nameChange;
                    Console.WriteLine("Changed successfully!!\n");
                    return;
                case "3":
                    Console.WriteLine("Please enter new Due date");
                    var expiryDateChange = Console.ReadLine();
                    listProduct[itemEditIndex].expiryDate = expiryDateChange;
                    Console.WriteLine("Changed successfully!!\n");
                    return;
                case "4":
                    Console.WriteLine("Please enter new Manufaction Company");
                    var producerChange = Console.ReadLine();
                    listProduct[itemEditIndex].productOf = producerChange;
                    Console.WriteLine("Changed successfully!!\n");
                    return;
                case "5":
                    Console.WriteLine("Please enter new Manufacture year");
                    var manufactureYearChange = Console.ReadLine();
                    listProduct[itemEditIndex].manufactureYear = manufactureYearChange;
                    Console.WriteLine("Changed successfully!!\n");
                    return;
                case "6":
                    Console.WriteLine("Please enter new product type");
                    var productTypeChange = Console.ReadLine();
                    var productType = findProductType(productTypeChange);
                    if (productType == null)
                    {
                        Console.WriteLine("The name of product type you enter does not have in current list of product type");
                        Console.WriteLine("Please choose edit product function and try again \n");
                        return;
                    }
                    listProduct[itemEditIndex].productType = productType;
                    Console.WriteLine("Changed successfully!!\n");
                    return;                
            }            
             Console.WriteLine("Invalid information change!!\n");
        }

    }
}
