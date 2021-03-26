using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraWork___24MAR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Create employee class and use type safe collections like stack, queue,list  to add employee objects and  display them by foreach loop
            #region
            //Queue
            Queue<Employee> emp = new Queue<Employee>();
            emp.Enqueue(new Employee { fName = "Jane", lName = "Doe", Age = 27, empID = 2567, department = "HR" });
            emp.Enqueue(new Employee { fName = "Jill", lName = "Dawn", Age = 50, empID = 6258, department = "Executive" });
            emp.Enqueue(new Employee { fName = "Bill", lName = "Dotrive", Age = 35, empID = 1234, department = "Janitoral" });
            emp.Enqueue(new Employee { fName = "Nadi", lName = "Kassim", Age = 31, empID = 8520, department = "Sales" });
            foreach (var e in emp)
            {
                Console.WriteLine("Employee Details:\tFirst Name: {0}, Last-Name: {1}, Age: {2}, ID#: {3}, Department: {4}", e.fName, e.lName, e.Age, e.empID, e.department);
            }
            Console.WriteLine("\n");
            //Stack
            Stack<Employee> emp1 = new Stack<Employee>();
            emp1.Push (new Employee { fName = "Andrea", lName = "Glasow", Age = 02, empID = 3216, department = "Acting" });
            emp1.Push (new Employee { fName = "Tom", lName = "Cruise", Age = 55, empID = 6589, department = "Producer" });
            emp1.Push (new Employee { fName = "Bill", lName = "Gates", Age = 35, empID = 2323, department = "Executive" });
            emp1.Push (new Employee { fName = "Chris", lName = "Tapper", Age = 46, empID = 7531, department = "Reporting  " });
            foreach (var e in emp1)
            {
                Console.WriteLine("Employee Details:\tFirst Name: {0}, Last-Name: {1}, Age: {2}, ID#: {3}, Department: {4}", e.fName, e.lName, e.Age, e.empID, e.department);
            }
            Console.WriteLine("\n");
            //List
            List<Employee> emp2 = new List<Employee>();
            emp2.Add(new Employee { fName = "Hu", lName = "Man", Age = 101, empID = 1111, department = "Acquisitions" });
            emp2.Add(new Employee { fName = "Ali", lName = "En", Age = 50, empID = 9775, department = "Strategy" });
            emp2.Add(new Employee { fName = "Fish", lName = "Man", Age = 35, empID = 9876, department = "Consumer Goods" });
            emp2.Add(new Employee { fName = "Goat", lName = "Person", Age = 31, empID = 3333, department = "Landscaping" });
            foreach (var e in emp2)
            {
                Console.WriteLine("Employee Details:\tFirst Name: {0}, Last-Name: {1}, Age: {2}, ID#: {3}, Department: {4}", e.fName, e.lName, e.Age, e.empID, e.department);
            }

            Console.WriteLine("\nSorted List (by Name)");   //Sorts the List by (first Name)
            emp2.Sort();
            foreach (var e in emp2)
            {
                Console.WriteLine("Employee Details:\tFirst-Name: {0}, Last-Name: {1}, Age: {2}, ID#: {3}, Department: {4}", e.fName, e.lName, e.Age, e.empID, e.department);
            }
            #endregion


            //Task 2: Create  an interface for ICalculator for methods like add, subtract, divide , multiply. Implement these methods in a Math class.
            ICalculator math = new Math();
            Console.WriteLine("\n2.0+3.3 = "+ math.add(2.0, 3.3));
            Console.WriteLine("2.0+3.3+4+6 = " + math.add(2.0, 3.3, 4, 6));
            Console.WriteLine("10-1-1-1 = " + math.subtract(10, 1, 1, 1));
            Console.WriteLine("5*10*1*1 = " + math.multiply(5, 10, 1, 1));
            Console.WriteLine("100/2 = " + math.divide(100, 2));
            Console.WriteLine("100/2/2 = " + math.divide(100, 2, 2));


            //Working in progress: Making a user interface with 'ref' variables 
            #region
            try
            {
                double a = 0, b = 0, c = 0, d = 0;
                Console.WriteLine("\nArthimetic Center:\nHow many number do you want to operate on (2-4)?");
                int user = int.Parse(Console.ReadLine());
                if (user >= 2 && user < 5)
                {
                    if (user == 2)
                    {
                        Console.WriteLine("Enter num1:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter num2:");
                        b = double.Parse(Console.ReadLine());
                    }
                    else if (user == 3)
                    {
                        Console.WriteLine("Enter num1:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter num2:");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter num3:");
                        c = double.Parse(Console.ReadLine());
                    }
                    else if (user == 4)
                    {
                        Console.WriteLine("Enter num1:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter num2:");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter num3:");
                        c = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter num4:");
                        d = double.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please retry.");
                }
                
                int user2=0;
                while (user2 != 5)
                {
                    Console.WriteLine("\nWhat arthimetic operation would you like to conduct\n1:Add, 2: Subtract, 3: Multiply, 4: Divide, 5: Exit");
                    user2 = int.Parse(Console.ReadLine());
                    if (user2 > 0 && user2 <= 5)
                    {
                        if (user2 == 1)
                        {
                            Console.WriteLine("Solution = " + math.add(a, b, c, d));
                        }
                        else if (user2 == 2)
                        {
                            Console.WriteLine("Solution = " + math.subtract(a, b, c, d));
                        }
                        else if (user2 == 3)
                        {
                            Console.WriteLine("Solution = " + math.multiply(a, b, c, d));
                        }
                        else if (user2 == 4)
                        {
                            Console.WriteLine("Solution = " + math.divide(a, b, c, d));
                        }
                        else if (user2 == 5)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input. Please retry.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion
        }

        public static void userEntry()
        {            
            
        }

    }
}
