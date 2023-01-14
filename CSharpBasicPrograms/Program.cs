namespace CSharpBasicPrograms
{
    internal class Program
    {
      public static void Main(string[] args)
        {
         Console.WriteLine("Welcome to Csharp basic programs");
      
         Console.WriteLine("Please enter first number");
            int first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            
            int  second=Convert.ToInt32(Console.ReadLine());

            Calculator myObj = new Calculator(first,second);
            myObj.Addition();
            Console.WriteLine("Please enter first number");
            int first1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int second2 = Convert.ToInt32(Console.ReadLine()); 
            Calculator myObj2 = new Calculator(first1, second2);

            myObj2.Subtraction();
            Console.WriteLine("Please enter the first number");
            int first2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int second3 = Convert.ToInt32(Console.ReadLine());
            Calculator myObj3 = new Calculator(first2, second3);
            myObj3.Multiplication();

            Console.WriteLine("Please enter the first number");
            int first3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int second4 = Convert.ToInt32(Console.ReadLine());
            Calculator myObj4 = new Calculator(first3, second4);
            myObj4.Dividing();
            Console.ReadLine();
        }
    }
}
