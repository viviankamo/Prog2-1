using System;
using Microsoft.VisualBasic;

namespace oop.labb
{
    class Program
    {
        static void Main(string[] args)
        {
            var kund = new Customer();
            while (true)
            {
                Console.WriteLine("Do you want to buy something?");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    Console.WriteLine("What would you like to buy?");
                    Console.WriteLine("\t1. IceCream");
                    Console.WriteLine("\t2. Shirt");
                    Console.WriteLine("\t3. Shoes");
                    var choice = Console.ReadLine().ToLower();
                    if (choice == "1")
                    {
                        Console.Write("What flavour would you like?");
                        var iceCream = new IceCream() { flavour = Console.ReadLine(), _produktNumber = 123 };
                        kund._cart.Add(iceCream);
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("What color would you like?");
                        var shirt = new Shirt() { color = Console.ReadLine(), _produktNumber = 234 };
                        kund._cart.Add(shirt);
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("What brand would you like?");
                        var shoes = new Shoes() { brand = Console.ReadLine(), _produktNumber = 345 };
                        kund._cart.Add(shoes);
                    }
                    else
                        continue;
                }
                else
                    break;

                Console.WriteLine("Would you like to view your items?");
                if (Console.ReadLine().ToLower() == "yes")
                    foreach (var item in kund._cart)
                    {
                        Console.WriteLine(item.GetType().Name);
                        var productType = item.GetType();
                        if (productType == typeof(Shirt))
                        {
                            Console.WriteLine("\tcolor: " + ((Shirt)item).color);
                        }
                        else if (productType == typeof(IceCream))
                        {
                            Console.WriteLine("\tflavour: " + ((IceCream)item).flavour);
                        }
                        else if (productType == typeof(Shoes))
                        {
                            Console.WriteLine("\tbrand: " + ((Shoes)item).brand);
                        }
                    }

                else
                    Console.WriteLine("As you wish!");
                    

            }
        }
    }
}

