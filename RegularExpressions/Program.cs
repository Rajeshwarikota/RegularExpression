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
            Console.WriteLine("\n1:Matches A\n2:Lower case sequence\n3:HTML Tag\n4:Occurances count\n22:Default:");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Matches.check();
                    break;
                case 2:
                    Matches.LowerCaseSequence();
                    break;
                case 3:
                    Matches.HTMLTag();
                    break;
                case 4:
                    Matches.Occurences();
                    break;
                default:
                    Console.WriteLine("Enter the Above option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
