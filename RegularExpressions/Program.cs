using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Regular Expressions....");
            Console.WriteLine("choose the options");
            Console.WriteLine("\n1:Matches A\n22:Default:");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Matches.check();
                    break;
                default:
                    Console.WriteLine("Enter the Above option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
