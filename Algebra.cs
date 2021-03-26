using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraWork___24MAR
{
    //Task 1 Class: Employee (Utilizes a interface to enable sorting)
    
    class Employee : IComparable
    {
        //Auto-Properties for the variables
        public string fName { get; set; }
        public string lName { get; set; }
        public int Age { get; set; }
        public int empID { get; set; }
        public string department { get; set; }

        //Constructors - Default & Overload
        public Employee()
        {
            fName = string.Empty;
            lName = string.Empty;
            Age = 0;
            empID = 0;
            department = string.Empty;
        }
        public Employee(string fname, string lname, int age, int empId, string depart)
        {
            fName = fname;
            lName = lname;
            Age = age;
            empID = empId;
            department = depart;
        }

        //Enables the sorting of Lists by (Name)
        public int CompareTo(object obj)
        {
            Employee temp = (Employee)obj;
            return (String.Compare(fName, temp.fName));
        }
    }


    //Task 2: Create  an interface for ICalculator for methods like add, subtract, divide , multiply. Implement these methods in a Math class.
    interface ICalculator
    {
        double add(double a = 0, double b = 0, double c = 0, double d = 0);
        double subtract(double a = 0, double b = 0, double c = 0, double d = 0);
        double divide(double a = 0, double b = 1, double c = 1, double d = 1);
        double multiply(double a = 0, double b = 1, double c = 1, double d = 1);

        void fun1();
        int fun2();

    }

    class Math : ICalculator
    {
        public double add(double a, double b, double c, double d)
        {
            double result = a + b + c + d;
            return result;
        }

        public double divide(double a, double b, double c, double d)
        {
            double result = (((a / b) / c) / d);
            return result;
        }

        public double multiply(double a, double b, double c, double d)
        {
            double result = a * b * c * d;
            return result;
        }

        public double subtract(double a, double b, double c, double d)
        {
            double result = a - b - c - d;
            return result;
        }

        void ICalculator.fun1()
    }
}
