using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas!");

            string[] names = { "vivian", "filippa", "Philip", "amanda", "mary" };
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = i;
                Console.WriteLine(i);
            }
            Console.WriteLine("........................");
            
            int sum = 0;
            for (int i = names.Length -1; i >= 0; i--)
            {
                sum += names[];
                Console.WriteLine(sum);
            }



        }


        }
    }
