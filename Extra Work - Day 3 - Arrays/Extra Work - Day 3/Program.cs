using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Work___Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;

            while(userInput != 4)
            {
                Console.WriteLine("");
                Console.WriteLine("Hello. Please choose an option:");
                Console.WriteLine("1: Calculate Area, 2: Display Array, 3: Order Array, 4: Exit");
                userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        calcArea();
                        break;
                    case 2:
                        disArray();
                        break;
                    case 3:
                        ordArray();
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Thanks for coming!");
                        break;
                    default:
                        Console.WriteLine("Incorrect Input. Please renter menu key.");
                        break;
            }
            }
           
        }

        //Calculates area based on user input (triangle, square, rectangle)
        static void calcArea()
        {
            Console.WriteLine("Please select which area you want to calulate:");
            Console.WriteLine("1: Triangle, 2: Square, 3: Rectangle");
            int input = int.Parse(Console.ReadLine());

            if(input == 1) //Triangle
            {
                Console.WriteLine("Input your triangle base length:");
                double baseL = double.Parse(Console.ReadLine());
                Console.WriteLine("Input your triangle height:");
                double heightL = double.Parse(Console.ReadLine());
                double area = .5 * baseL * heightL;
                Console.WriteLine("Your triangle area is " + area.ToString());
            }

            else if(input == 2)  //Square
            {
                Console.WriteLine("Input your square side length:");
                double height1 = double.Parse(Console.ReadLine());
                double area = height1 * height1;
                Console.WriteLine("Your square area is " + area.ToString());
            }

            else if (input == 3) //Rectangle
            {
                Console.WriteLine("Input your rectangle base length:");
                double base1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Input your rectangle height:");
                double height2 = double.Parse(Console.ReadLine());
                double area = base1 * height2;
                Console.WriteLine("Your rectangle area is " + area.ToString());
            }
            else
            {
                Console.WriteLine("Incorrect Input.");
            }
          
        }

        //Accepts user input then displays and reverses array order
        static void disArray()
        {
            Console.WriteLine("Please input how large your array will be:");
            int user = int.Parse(Console.ReadLine());
            int[] myArray = new int [user];
            Console.WriteLine("Your array will have size: {0}", user.ToString());

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Enter your array number {0}:", i );
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your array values:");
            for(int j=0; j<myArray.Length; j++)
            {
                int valueA = myArray[j];
                Console.WriteLine(valueA.ToString() );
            }

            Console.WriteLine("Your array values in reverse are:");
            for (int k = myArray.Length-1; 0 <= k; k--)
            {
                int valueB = myArray[k];
                Console.WriteLine(valueB.ToString());
            }

        }

        //Orders an array in ascending and descending order
        static void ordArray()
        {
            Console.WriteLine("We will order the following array:");
            int[] myArray = new int[] { 7, 12, 2, 6 };
            
            for (int i = 0; i < myArray.Length; i++)
            {
                int valueC = myArray[i];
                Console.WriteLine(valueC.ToString());
            }

            Console.WriteLine("Below is the array in ascending order:");
            Array.Sort(myArray);
            foreach(int j in myArray)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("Below is the array in descending order:");
            Array.Reverse(myArray);
            foreach(int k in myArray)
            {
                Console.WriteLine(k);
            }

        }


    }
}
