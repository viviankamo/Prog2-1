using System;

namespace projekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("........................");

            
            for (int i = names.Length - 1; i >= 0; i--)
            {
                
                Console.WriteLine(names[i]);
            }



        }


    }

    }

