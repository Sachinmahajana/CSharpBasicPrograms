using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no;
            Console.WriteLine("Enter the number");
            no = Convert.ToInt32(Console.ReadLine());
            while(no > 0)
            {
                if (no % 2 == 0)
                {
                    Console.WriteLine("Number is even");
                    Console.ReadLine();
                }
                Console.WriteLine("Number is odd");
                Console.ReadLine();


            }
                  }
    }
}
