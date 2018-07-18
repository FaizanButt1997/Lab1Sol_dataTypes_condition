using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Random r = new Random();
            int n=r.Next(1, 10);
            while(true)
            {
                Console.WriteLine(n);
                Console.WriteLine("Enter Guess number b/w 1 to 10"); 
                int n1=Convert.ToInt32(Console.ReadLine());
                if (n1 <= 10)
                {
                    if (n1 == n)
                    {
                        Console.WriteLine("You Won the Game :: Number Match");
                        System.Threading.Thread.Sleep(5000);
                        break;
                    }
                    else
                    {
                        if (n1 < n)
                        {
                            Console.WriteLine("Your Number is Small then Guess Number :: Try Again");
                            System.Threading.Thread.Sleep(1500);
                            Console.Clear();

                        }
                        else
                        {
                            Console.WriteLine("Your Number is greater then Guess Number :: Try Again");
                            System.Threading.Thread.Sleep(1500);
                            Console.Clear();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter Correct Choice");
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}
