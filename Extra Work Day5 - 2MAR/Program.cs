using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Work_Day5___2MAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome. Please select an option to compute area:");
            int user = 0;

            while (user != 4)
            {
                Console.WriteLine("1: Circle   2: Square  3: Color  4: Exit");
                try
                {
                    user = int.Parse(Console.ReadLine());

                    switch (user)
                    {
                        case 1:
                            calcCircle();
                            break;
                        case 2:
                            calcSquare();
                            break;
                        case 3:
                            colorShape();
                            break;
                        case 4:
                            Console.WriteLine("Thank you for coming");
                            user = 4;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                            
            }
        }

        //Method that creates a circle then calculates area
        static void calcCircle()
        {
            Circle circle1 = new Circle();
            Console.WriteLine("Input circle radius:");
            try
            {
                circle1._radius = double.Parse(Console.ReadLine());
                double area1 = circle1.CalcArea(circle1._radius);
                Console.WriteLine("The circle with radius {0} has area of {1}", circle1._radius, area1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                GC.Collect();
            }            
        }

        //Method that creates a square then calculates area
        static void calcSquare()
        {
            Square square1 = new Square();
            Console.WriteLine("Input square side length:");
            try
            {
                square1._length = double.Parse(Console.ReadLine());
                double area2 = square1.CalcArea(square1._length);
                Console.WriteLine("The square with length {0} has area of {1}", square1._length, area2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                GC.Collect();
            }            
        }

        //Method that creates a circle or square then colors it.
        static void colorShape()
        {
            int userSel = 0;
            Console.WriteLine("Select a shape:  1: Circle  2: Square");
            try 
            { 
                userSel = int.Parse(Console.ReadLine()); 

                if (userSel == 1)
                {
                    Circle circleA = new Circle();
                    Console.WriteLine("Type in your color below");
                    circleA._color = Console.ReadLine();
                    Console.WriteLine("Your circle is now the color {0}", circleA._color);
                }
                else if (userSel == 2)
                {
                    Square squareA = new Square();
                    Console.WriteLine("Type in your color below");
                    squareA._color = Console.ReadLine();
                    Console.WriteLine("Your square is now the color {0}", squareA._color);
                }
                else
                {
                    Console.WriteLine("Incorrect Selection.");
                    return;
                }            
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            finally
            {
                GC.Collect();
            }          
        }
 
    }
}
