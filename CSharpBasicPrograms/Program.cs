namespace CSharpBasicPrograms
{
    internal class Program
    {
      public static void Main(string[] args)
        {
         Console.WriteLine("Welcome to Csharp basic programs");
         Console.WriteLine("Please choose any one program from below option");
         Console.WriteLine("1:Calculator\n2:SwitchCase\n10:Exit");
         int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("please enter first number");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter second number");
                    int second = Convert.ToInt32(Console.ReadLine());

                    Calculator myobj = new Calculator(first, second);
                    myobj.Addition();

                    Console.WriteLine("please enter first number");
                    int first1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter second number");
                    int second2 = Convert.ToInt32(Console.ReadLine());
                    Calculator myobj2 = new Calculator(first1, second2);
                    myobj2.Subtraction();

                    Console.WriteLine("please enter the first number");
                    int first2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter the second number");
                    int second3 = Convert.ToInt32(Console.ReadLine());
                    Calculator myobj3 = new Calculator(first2, second3);
                    myobj3.Multiplication();

                    Console.WriteLine("Please enter the first number");
                    int first3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the second number");
                    int second4 = Convert.ToInt32(Console.ReadLine());
                    Calculator myObj4 = new Calculator(first3, second4);
                    myObj4.Dividing();
                    break;
                case 2:
                    Console.WriteLine("Please choose a number between 1 to 7");
                    int day = Convert.ToInt32(Console.ReadLine());
                    WeekDay.FindDayWhichFallsOnWeek(day);
                    break;
                case 10:
                    break;
                default:
                    Console.WriteLine("Please choose number within given options");
                    break;
            }  
            Console.ReadLine();
        }
    }
}