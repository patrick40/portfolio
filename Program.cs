using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                int choice;
                var operation1 = new Calculate();
                Console.WriteLine("enter first number");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter first number");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("choose the operator");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("the result{0} and {1}is equal to {2}", num1, num2, operation1.Add(num1, num2));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("the result{0} and {1}is equal to {2}", num1, num2, operation1.Substract(num1, num2));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("the result{0} and {1}is equal to {2}", num1, num2, operation1.Multiply(num1, num2));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("the result{0} and {1}is equal to {2}", num1, num2, operation1.Divide(num1, num2));
                        Console.ReadKey();
                        break;
                }



                Console.WriteLine();
            }

        }


    }
}
