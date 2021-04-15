using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Work_Day5___2MAR
{
    //Base Class: Shape
    class Shapes
    {
        private int id;
        private string name;
        private string description;
        private string color;

        public int _id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string _name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string _desription
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public string _color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public virtual double CalcArea(double length)
        {
            return length;
        }
    }

    //Sub-Class: Circle
    class Circle:Shapes
    {
        private double radius;

        public double _radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        //Constructors (Blank & Filled in)
        public Circle()
        {

        }
        public Circle(int id, string name, string descrip, string color, double radius)
        {
            this._id = id;
            this._name = name;
            this._desription = _desription;
            this._color = color;
            this.radius = radius;
        }

        //Calculates area of circles
        public override double CalcArea(double length)
        {
            double area = 0;
            area = 3.14159 * (length * length);
            return area;
        }
    }

    //Sub-Class: Square
    class Square : Shapes
    {
        private double length;

        public double _length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        //Constructors (Blank & Filled in)
        public Square()
        {

        }
        public Square(int id, string name, string descrip, string color, double length)
        {
            this._id = id;
            this._name = name;
            this._desription = _desription;
            this._color = color;
            this.length = length;
        }

        //Calculates area of squares
        public override double CalcArea(double length)
        {
            double area = 0;
            area = (length * length);
            return area;
        }
    }
}
