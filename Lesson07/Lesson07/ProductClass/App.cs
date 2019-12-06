using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace Lesson07.ProductClass
{
    class App : Product
    {
        public char key;
        public BasketShopping bs = new BasketShopping();

        public void ReadKey()
        {
            Console.WriteLine(
                $"\nHello!\nWhat do you want to do? Press appropriate keyboard.\nLegend:\nP - add product to shopping basket.\nK - copy last added product\n" +
                $"Z - show shopping basket\nS - show sum price of products in basket\nX - delete product from shopping list (you have to know number of product in list\n" +
                $"W - print receipt\nN - add new basket\nE - close the program.");

                Console.WriteLine($"Press the key: ");
                key = Console.ReadLine()[0];
        }

        public void DoAction()
        {
            switch (key)
            {
                case 'P':
                    
                    Console.WriteLine($"\nYou chose P - adding product to shopping  basket.");
                    
                    Console.WriteLine("Name of product: ");
                    
                    string name = Console.ReadLine();

                    decimal unitPrice;

                    string input;

                    do
                    {
                        Console.WriteLine($"Price: ");

                        input = Console.ReadLine();

                    } while (!decimal.TryParse(input, out unitPrice) || unitPrice < 0);

                    int amount;

                    do
                    {
                        Console.WriteLine($"Amount of product: ");

                        input = Console.ReadLine();
                    } while (!int.TryParse(input, out amount) || amount < 0);

                    var newProduct = new Product(name, unitPrice, amount);

                    this.bs.shoppingList.Add(newProduct);

                    Console.WriteLine($"Succes.");

                    break;
                
                case 'K':
                    
                    Console.WriteLine($"\nYou chose K - copying last added product.");

                    Product clonedProduct = (Product)this.bs.shoppingList[this.bs.shoppingList.Count - 1].CopyProduct();

                    this.bs.shoppingList.Add(clonedProduct);

                    break;
                
                case 'Z':
                    
                    Console.WriteLine($"\nYou chose Z - show shopping basket.");
                    
                    foreach (var el in this.bs.shoppingList.OrderBy(x => x.unitPrice))
                        Console.WriteLine($"Name: {el.name}\nPrice of unit: {el.unitPrice}\nAmount: {el.amount}");
                    
                    break;
                
                case 'S':
                    
                    Console.WriteLine($"\nYou chose S - showing sum price of products in basket.");

                    decimal sum = 0;

                    foreach (var el in this.bs.shoppingList)
                    {
                        sum += el.unitPrice * el.amount;
                    }

                    Console.WriteLine($"\nSum of products in basket: {sum}");

                    break;
                
                case 'X':
                    
                    Console.WriteLine($"\nYou chose X - Deleting product form shopping list (Remember to know number of product in list!");

                    int num = Int32.Parse(Console.ReadLine()) - 1;

                    this.bs.shoppingList.RemoveAt(num);

                    break;
                case 'W':
                    
                    Console.WriteLine($"\nYou chose X - printing receipt.");

                    string output = string.Empty;

                    output += $"Bought products: \n";

                    decimal sumOfProducts = 0;

                    foreach (var el in this.bs.shoppingList)
                    {
                        sumOfProducts += el.unitPrice * el.amount;
                        output += $"\nName of product: {el.name}, Price of unit: {el.unitPrice}, Amount of product: {el.amount}\n" +
                                  $"Price: {el.amount * el.unitPrice}";
                    }

                    output += $"\nPrice to pay: {sumOfProducts}";

                    Console.WriteLine($"{output}");

                    using (StreamWriter file = new StreamWriter(DateTime.Now.ToString($"ddMMyyyyHHmmss") + ".txt"))
                    {
                        file.WriteLine(output);
                    }

                    //File.WriteAllLines(DateTime.Now.ToString($"ddMMyyyyHHmmss") + ".txt" , output);

                    this.bs = new BasketShopping();

                    break;
                
                case 'N':
                    
                    Console.WriteLine($"\nYou chose N - new basket.");

                    this.bs = new BasketShopping();

                    Console.WriteLine($"You've already created new basket.");

                    break;
                
                case 'E':
                    
                    Console.WriteLine($"\nE - closing the program.");
                    
                    System.Environment.Exit(0);
                    
                    break;
            }

            //do
            //{
            //    Console.WriteLine("Press appropriate key: ");
            //    key = Console.ReadLine()[0];
            //} while ();


        }

    }
}
