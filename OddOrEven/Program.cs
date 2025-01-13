using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please Enter The Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("This Number is Odd");
            }
            else
            {
                Console.WriteLine("This Number is Even");
            }
            Console.ReadKey();
        }
    }
}
