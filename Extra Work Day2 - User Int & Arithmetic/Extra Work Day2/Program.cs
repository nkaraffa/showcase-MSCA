using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Work_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            
            //Program entry and number selection
            Console.WriteLine("Please input two numbers");
            Console.WriteLine("Number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Calculation (while loop for menu selection)
            while (userInput != 7)
            {
                Console.WriteLine("");
                Console.WriteLine("Please select one of the functions:");
                Console.WriteLine("1 = Addition");
                Console.WriteLine("2 = Subtraction");
                Console.WriteLine("3 = Multiply");
                Console.WriteLine("4 = Divide");
                Console.WriteLine("5 = Equality Check");
                Console.WriteLine("6 = Sum of 1-10");
                Console.WriteLine("7 = Exit");
                userInput = Convert.ToInt32(Console.ReadLine());

                //Calculation Selection & Response
                switch (userInput)
                {
                    case 1:
                        addition(num1, num2);
                        break;
                    case 2:
                        subtraction(num1, num2);
                        break;
                    case 3:
                        mult(num1, num2);
                        break;
                    case 4:
                        divide(num1, num2);
                        break;
                    case 5:
                        equality(num1, num2);
                        break;
                    case 6:
                        sumTen();
                        break;
                    case 7:
                        Console.WriteLine("");
                        Console.WriteLine("Thanks, come again!");
                        break;
                    default:
                        Console.WriteLine("Incorrect Input.");
                        break;
                }
            }
        }

        static void addition (int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("");
            Console.WriteLine("Addition result is " + result);
        }

        static void subtraction (int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("");
            Console.WriteLine("Subtraction result is " + result);
        }

        static void mult (int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("");
            Console.WriteLine("Multiply result is " + result);
        }

        static void divide (int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine("");
            Console.WriteLine("Divide result is " + result);
        }

        //Checking for equality
        static void equality (int num1, int num2)
        {
            Console.WriteLine("");
            Console.WriteLine("Let's check the equality of your numbers: {0} & {1}", num1, num2);

            if (num1 == num2)
            {
                Console.WriteLine("Your numbers are equal!");
            }
            else
            {
                Console.WriteLine("These numbers are different.");
            }
        }

        //Calculates the sum from 1-10
        static void sumTen()
        {
            Console.WriteLine("");
            Console.WriteLine("Let's calculate the sum of the first 10 whole numbers.");

            int sum = 0;
            for(int count = 0; count <= 10; count++)
            {
                sum = sum + count;
            }

            Console.WriteLine("The sum of the first 10 numbers is " + sum );
        }

    }
}
