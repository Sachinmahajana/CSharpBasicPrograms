using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicPrograms
{
    /// <summary>
    /// Calculator class created to perform arthematic operations
    /// </summary>
    public class Calculator
    {
        //instance variables
        public int first, second, sum;

        /// <summary>
        /// Initializes a new instance of the <see cref="Calculator"/> class.
        /// </summary>
        /// <param name="firstNumb"></param>
        /// <param name="secondNumb"></param>
        public Calculator(int firstNumb, int secondNumb)
        {
            first = firstNumb;
            second = secondNumb;
        }
        /// <summary>
        /// Addition of 2 numbers to get sum
        /// </summary>

        public void Addition()
        {
            sum = first + second;
            Console.WriteLine("Sum:" + sum);

        }
        public void Subtraction()
        {
            sum = Math.Abs(first - second);
            Console.WriteLine("Subtraction:" + sum);

        }
        public void Multiplication()
        {
            sum = first * second;
            Console.WriteLine("Multipication:" + sum);

        }
        public void Dividing()
        {
            sum = first / second;
            Console.WriteLine("Dividing:" + sum);

        }
    }


}

        
    


