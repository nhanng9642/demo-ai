using System;
using System.Collections.Generic;

namespace cshape
{
    class Program
    {
        static List<Item> items = new List<Item>();
        static List<Category> categories = new List<Category>(); 
        static void Main(string[] args)
        {
            Console.WriteLine("Star Application. if you want to stop the app, press ESC");
            do {
                Console.WriteLine("\n\n");
                Console.WriteLine("********************************************************");
                Console.WriteLine("*        Choose action:                                *");
                Console.WriteLine("*        - Press '1' for creating a category           *");
                Console.WriteLine("*        - Press '2' for editing an category           *");
                Console.WriteLine("*        - Press '3' for deleting an category          *");
                Console.WriteLine("*        - Press '4' for creating an item              *");
                Console.WriteLine("*        - Press '5' for editing a item                *");
                Console.WriteLine("*        - Press '6' for deleting a item               *");
                Console.WriteLine("*        - Press '7' for list all existing category    *");
                Console.WriteLine("*        - Press '8' for list all existing items       *");
                Console.WriteLine("*        - Press '9' for searching item                *");
                Console.WriteLine("*        - Press '10' for searching category           *");
                Console.WriteLine("*                                                      *");
                Console.WriteLine("********************************************************");
                Console.Write("Enter your action: ");
                string action = Console.ReadLine();

                if (String.Equals(action, "1")) {
                    createCategory();
                } else if (String.Equals(action, "2")) {
                    editCategory();
                } else if (String.Equals(action, "3")) {
                    deleteCategory();
                } else if (String.Equals(action, "4")) {
                    createItem();
                } else if (String.Equals(action, "5")) {
                    editItem();
                } else if (String.Equals(action, "6")) {
                    deleteItem();
                } else if (String.Equals(action, "7")) {
                    showAllCategories();
                } else if (String.Equals(action, "8")) {
                    showAllItems();
                } else if (String.Equals(action, "9")) {
                    searchItem();
                } else if (String.Equals(action, "10")) {
                    searchCategory();
                } 
                else {
                    Console.WriteLine("You did enter wrong action. Please read careful the list of action above");
                }

                 Console.WriteLine("Done the process, if you want to stop, press ESC. If you want to continue then press any other key :)");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            Console.WriteLine("End Application");
        }

        static void createItem() {
            Console.WriteLine("\nStart create item process!");
            Console.Write("Enter item's code: ");
            string itemCode = Console.ReadLine();
            Console.Write("Enter item's name: ");
            string itemName = Console.ReadLine();
            Console.Write("Enter expiration date of item: ");
            string expirationDate = Console.ReadLine();
            Console.Write("Enter the name of Manufacturer: ");
            string manufacturer = Console.ReadLine();
            Console.Write("Enter the created date of item: ");
            string createdDate = Console.ReadLine();
            Console.Write("Enter the id of category: ");
            string categoryId = Console.ReadLine();

            Item item = new Item();
            item.code = itemCode;
            item.name = itemName;
            item.expirationDate = expirationDate;
            item.manufacturer = manufacturer;
            item.createdDate = createdDate;
            Category category = findCategoryById(categoryId);
            item.category = category;

            Console.WriteLine("\nOne item has been created: ");
            Console.WriteLine(">>> " + item.toString());
            Console.WriteLine("\n");
            Program.items.Add(item);
        }
        
        static void editItem() {
            Console.WriteLine("\nStart edit item process!");
            Console.Write("Enter item's code: ");
            string itemCode = Console.ReadLine();
            Item item = findItemByCode(itemCode);
            if (item != null) {
                Console.WriteLine("\nFound the item: " + item.toString());
                Console.Write("Enter new name of item: ");
                string itemName = Console.ReadLine();
                Console.Write("Enter new expiration date of item: ");
                string expirationDate = Console.ReadLine();
                Console.Write("Enter new name of Manufacturer: ");
                string manufacturer = Console.ReadLine();
                Console.Write("Enter new created date of item: ");
                string createdDate = Console.ReadLine();
                Console.Write("Enter new id of category: ");
                string categoryId = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(itemName)) {
                    item.name = itemName;
                }
                if (!string.IsNullOrWhiteSpace(expirationDate)) {
                    item.expirationDate = expirationDate;
                }
                if (!string.IsNullOrWhiteSpace(manufacturer)) {
                    item.manufacturer = manufacturer;
                }
                if (!string.IsNullOrWhiteSpace(createdDate)) {
                    item.createdDate = createdDate;
                }
                if (!string.IsNullOrWhiteSpace(categoryId)) {
                    Category category = findCategoryById(categoryId);
                    if (category != null) {
                        item.category = category;
                    }
                }
            }
            Console.WriteLine("\n");
        }

        static void deleteItem() {
            Console.WriteLine("\nStart delete item process!");
            Console.Write("Enter item's code to be deleted: ");
            string code = Console.ReadLine();
            Item item = findItemByCode(code);
            if (item != null) {
                Program.items.Remove(item);
                Console.WriteLine("Finish deleting item");
            } else {
                Console.WriteLine("\nCannot find any item with code: " + code + " to delete");
            }
            Console.WriteLine("\n");
        }

        static void createCategory() {
            Console.WriteLine("\nStart create category process!");
            Console.Write("Enter category's id: ");
            string id = Console.ReadLine();
            Console.Write("Enter category's name: ");
            string name = Console.ReadLine();

            Category category = new Category();
            category.id = id;
            category.name = name;

            Console.WriteLine("\nOne category has been created: ");
            Console.WriteLine(">>> " + category.toString());
            Console.WriteLine("\n");
            Program.categories.Add(category);
        }

        static void editCategory() {
            Console.WriteLine("\nStart edit category process!");
            Console.Write("Enter category's id: ");
            string id = Console.ReadLine();

            Category category = findCategoryById(id);
            if (category != null) {
                Console.WriteLine("\nFound the category: " + category.toString());
                Console.Write("Enter new name for category: ");
                string newName = Console.ReadLine();
                category.name = newName;
                Console.WriteLine("This category was updated to: " + category.toString());
            }
            Console.WriteLine("\n");
        }

        static void deleteCategory() {
            Console.WriteLine("\nStart delete category process!");
            Console.Write("Enter category's id: ");
            string id = Console.ReadLine();

            Category category = findCategoryById(id);
            if (category != null) {
                Program.categories.Remove(category);
                Console.WriteLine("Finish deleting category");
            } else {
                Console.WriteLine("\nCannot find any category with id: " + id + " to delete");
            }
            Console.WriteLine("\n");
        }

        static void showAllItems() {
            int numberOfItem = Program.items.Count;
            if (numberOfItem == 0) {
                Console.WriteLine("There is no items in the applicaion");
            } else {
                Console.WriteLine("There is " + numberOfItem + " items in the applicaion: ");
                foreach (Item item in Program.items) {
                    Console.WriteLine(" - " + item.toString());
                }
            }
            Console.WriteLine("\n");
        }

        static void showAllCategories() {
            int numberOfCategory = Program.categories.Count;
            if (numberOfCategory == 0) {
                Console.WriteLine("There is no category in the applicaion");
            } else {
                Console.WriteLine("There is " + numberOfCategory + " categories in the applicaion: ");
                foreach (Category category in Program.categories) {
                    Console.WriteLine(" - " + category.toString());
                }
            }
            Console.WriteLine("\n");
        }

        static Category findCategoryById(string id) {
            Category category = Program.categories.Find(element => element.id.Equals(id));
            if (category == null) {
                Console.WriteLine("Warning: there is no category with id: " + id);
            }
            return category;
        }

        static Item findItemByCode(string code) {
            Item item = Program.items.Find(element => element.code.Equals(code));
            if (item == null) {
                Console.WriteLine("Warning: there is no item with code: " + code);
            }
            return item;
        }

        static void searchItem() {
            Console.WriteLine("\nStart searching item process!");
            Console.Write("Enter search code: ");
            string code = Console.ReadLine();
            Item item = findItemByCode(code);
            if (item != null) {
                Console.Write("Found item: " + item.toString());
            } else {
                Console.Write("Cannot find any item with code: " + code);
            }
            Console.WriteLine("\n");
        }

        static void searchCategory() {
            Console.WriteLine("\nStart searching category process!");
            Console.Write("Enter search id: ");
            string id = Console.ReadLine();
            Category category = findCategoryById(id);
            if (category != null) {
                Console.Write("Found category: " + category.toString());
            } else {
                Console.Write("Cannot find any category with id: " + id);
            }
            Console.WriteLine("\n");
        }
    }
}
