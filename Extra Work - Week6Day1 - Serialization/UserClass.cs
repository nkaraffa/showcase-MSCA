using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Work___Week6Day1
{
    
    //Student Class
    [Serializable]
    class Student
    {        
        //Auto-properties
        public string name { get; set; }
        public int age { get; set; }
        public int classYear { get; set; } 
        public string classGrade { get; set; }
        //Constructors
        public Student()
        {

        }
        public Student (string Name, int Age, int clasYr, string clasGrd)
        {
            this.name = Name;
            this.age = Age;
            this.classYear = clasYr;
            this.classGrade = clasGrd;
        }
        public void Clear()
        {
            this.name = string.Empty;
            this.age = 0; ;
            this.classYear = 0;
            this.classGrade = string.Empty;
        }
    }

    //Employee Class
    [Serializable]
    class Employee
    {
        //Auto-properties
        public string name { get; set; }
        public int age { get; set; }
        public int hireYear { get; set; }
        public string departName { get; set; }
        //Constructors
        public Employee()
        {

        }
        public Employee(string Name, int Age, int hireYr, string depName)
        {
            this.name = Name;
            this.age = Age;
            this.hireYear = hireYr;
            this.departName = depName;
        }
        public void Clear()
        {
            this.name = string.Empty;
            this.age = 0; ;
            this.hireYear = 0;
            this.departName = string.Empty;
        }
    }
}
