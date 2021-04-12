using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Work_Day4___1MAR
{
    //Task 1 Code: Structure (Coordinate Creation)
    struct Point
    {
        private int xCoord;
        private int yCoord;
        
        public Point (int xCoord, int yCoord)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }

        public void PrintCoord()
        {
            Console.WriteLine("X coordinate: {0} , Y coordinate: {1}", this.xCoord, this.yCoord);
        }

        public int _xCoordinate
        {
            get { return this.xCoord; }
            set { this.xCoord = value; }
        }

        public int _yCoordinate
        {
            get { return this.yCoord; }
            set { this.yCoord = value; }
        }

    }

    //Task 2 Code: Class (Student Creation)
    class Student
    {
        private int studentID;
        private string studentFname;
        private string studentLname;
        private int studentGrade;

        public Student ()
        {

        }
        public Student(int studID, string studFname, string studLname, int studGrade)
        {
            this.studentID = studID;
            this.studentFname = studFname;
            this.studentLname = studLname;
            this.studentGrade = studGrade;
        }

        public void PrintStud()
        {
            Console.WriteLine("Student Profile: {0}, {1}, {2}, {3}", this.studentID, this.studentFname, this.studentLname, this.studentGrade);
        }

        public int _studentID
        {
            get { return this.studentID; }
            set { this.studentID = value; }
        }

        public string _studentFname
        {
            get { return this.studentFname; }
            set { this.studentFname = value; }
        }

        public string _studentLname
        {
            get { return this.studentLname; }
            set { this.studentLname = value; }
        }

        public int _studentGrade
        {
            get { return this.studentGrade; }
            set { this.studentGrade = value; }
        }


    }
}
