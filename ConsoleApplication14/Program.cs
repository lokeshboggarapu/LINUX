using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Enter First Number ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            b = Convert.ToInt32(Console.ReadLine());

            Class1 multip = new Class1();
            bool x = multip.multiple(a, b);

            Console.WriteLine("Result is {0}", x);
            Console.ReadKey();
            

        }




    }
}
