using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryTaxProfApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            double totalsalry = 0;
            Console.WriteLine("Enter your salary");
            float salary =Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine($"Enter your Experience {a}" );
            Console.WriteLine("Enter your experience");
            int exp = Convert.ToInt32(Console.ReadLine());
            if (exp < 10)
            {
                totalsalry = (salary * 0.02) + 1200;
            }
            else
            {
                totalsalry = (salary * 0.05) + 2000;
            }
            Console.WriteLine($"Your Total salary is {totalsalry}");
            Console.ReadKey();
           
        }
    }
}
