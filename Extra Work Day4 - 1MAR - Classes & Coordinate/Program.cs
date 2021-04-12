using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Work_Day4___1MAR
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            //Task 1 code:  Coordinate Comparison
            #region 
            /*
            Console.WriteLine("Please enter 'P1' X-Coordinate:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter'P1' Y-Coordinate:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Point P1 = new Point(x1, y1);

            Console.WriteLine("Please enter a second set of coordinates 'P2'. 'P2' X-Coordinate:");
            Point P2 = new Point();
            P2._xCoordinate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 'P2' Y-Coordinate:");
            P2._yCoordinate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Below are the points you inputted:");
            P1.PrintCoord();
            P2.PrintCoord();

            //Method that will determine the placement of the two coordinates.
            Console.WriteLine("");
            if (P1._xCoordinate > P2._xCoordinate)
            {
                Console.WriteLine("P1 is to the right of P2");
            } 
            else if (P1._xCoordinate < P2._xCoordinate)
            {
                Console.WriteLine("P1 is to the left of P2");
            }
            else
            {
                Console.WriteLine("P1 is on the same the x-axis of P2");
            }
            */
            #endregion 

            //Task 2 code: Student Creation
            Student student1 = new Student(123, "Bob", "Right", 100);
            Student student2 = new Student(125, "Linda", "Worth", 85);
            Student student3 = new Student(207, "Rev", "Smith", 62);

            //User entry for new student
            Student stud4 = new Student();
            Console.WriteLine("Enter the new Student details:");
            Console.WriteLine("Student ID:");
            stud4._studentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student First Name:");
            stud4._studentFname = Console.ReadLine();
            Console.WriteLine("Student Last Name:");
            stud4._studentLname = Console.ReadLine();
            Console.WriteLine("Student Grade (0-100):");
            stud4._studentGrade = Convert.ToInt32(Console.ReadLine());

            //Print student record using class method
            Console.WriteLine("");
            Console.WriteLine("Printing Student Record:");
            student1.PrintStud();
            student2.PrintStud();
            student3.PrintStud();
            stud4.PrintStud();

        }
    }
}
