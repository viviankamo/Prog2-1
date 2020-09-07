using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas!");

            

            int i = 0;
            while (i < 1)
            {
                Console.WriteLine(i);
                i++;


                Console.WriteLine("How old are you?");

                int myAge = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Your age is: " + myAge);

            }

            Console.WriteLine("What is your name?");

            string userName = Console.ReadLine();

            Console.WriteLine("Your name is: " + userName);

            Console.WriteLine("Are you alive?");

            bool Lifetrue = true;

            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("You are alive");   // Outputs True
            }

            else if (answer == "no")
            {
                Console.WriteLine("You are dead");   // Outputs False

            }


            Console.WriteLine("The best colour is:");

            int color = 1;
            switch (color) { 
                case 1:
                    Console.WriteLine("blue");
                    break;
                case 2:
                    Console.WriteLine("green");
                    break;
                case 3:
                    Console.WriteLine("red");
                    break;
                case 4:
                    Console.WriteLine("yellow");
                    break;
            }
            // Outputs "blue" (color 1)


            for (int v = 0; v < 5; v++)
            {
                Console.WriteLine(v);
                v++;


                Console.WriteLine("You are done, Mate!");

            }
        }






}
    }
