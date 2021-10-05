using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for number 1
            Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //asks for second number
            Console.WriteLine("Please enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            //has player select an option below from a list
            Console.WriteLine("< Please choose from a list below >");
            Console.WriteLine(" 1 - Add");
            Console.WriteLine(" 2 - Subtract");
            Console.WriteLine(" 3 - Multiply");
            Console.WriteLine(" 4 - Divide");
            //gathers input and converts to integer
            int input = Convert.ToInt32(Console.ReadLine());
            //proceeds into a switch statment returning an answer depending on input case
            switch (input)
            {
                case 1:
                    Console.WriteLine(num + num2);
                    break;
                case 2:
                    Console.WriteLine(num - num2);
                    break;
                case 3:
                    Console.WriteLine(num * num2);
                    break;
                case 4:
                    Console.WriteLine(num / num2);
                    break;
            }
            Console.ReadKey();
        }
    }
}
