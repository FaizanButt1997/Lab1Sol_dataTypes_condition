using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_VoteCheckCode
{
    public class Program
    {
        static void Main(string[] args)
        {

            // This code is just for your knowledge How to change Background and foreground color in CONSOLE (-_-)

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();



            Console.WriteLine("Enter Your age kindly !!!");
            int age = Convert.ToInt32(Console.ReadLine());

            //Method1 with ternary operator       
           
            //bool capabillity =     age > 18 ? true : false;
            //  if (capabillity)
            //  {
            //      Console.WriteLine("You are capable for vote casting");
            //  }
            //  else
            //  {
            //      Console.WriteLine("You are not capable for vote casting");


            //  }

            //Method2 with simple if condition

            if (age > 18)
            {
                Console.WriteLine("You are capable for vote casting");
            }
            else
            {
                Console.WriteLine("You are not capable for vote casting");

            }
            Console.ReadKey();
        }
    }
}
