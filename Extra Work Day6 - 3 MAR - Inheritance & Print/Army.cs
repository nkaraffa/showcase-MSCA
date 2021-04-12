using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Work_Day6___3MAR
{
    //Base Class: Army
    abstract class Army
    {
        private string rank;
        private string Lname;
        private int age;
        private int id;

        public string _rank
        {
            get { return this.rank; }
            set { this.rank = value; }
        }
        public string _Lname
        {
            get { return this.Lname; }
            set { this.Lname = value; }
        }
        public int _age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public int _id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public abstract void Work();
        public virtual void Train()
        {
            Console.WriteLine("I like to train");
        }
    }

    //Sub-Class: Soldier
    class Soldier : Army 
    {
        //Constructors
        public Soldier()
        {

        }

        //Inherited Abstract Method
        public override void Work()
        {
            Console.WriteLine("I work everyday");
        }

        //Methods
        public virtual void Commute()
        {

        }

        public void Print()
        {
            Console.WriteLine("\n Solider: {0}, {1}, {2}, {3}",this._rank,this._Lname,this._age,this._id);
        }
    }

    //Sub-Class: Enlisted
    class Enlisted : Soldier
    {
        private int barrackRoom;
        public int _barrackRoom
        {
            get { return this.barrackRoom; }
            set { this.barrackRoom = value; }
        }
        //Constructors
        public Enlisted ()
        {

        }
        public Enlisted (string rank, string lname, int age, int id, int barrackRm)
        {
            this._rank = rank;
            this._Lname = lname;
            this._age = age;
            this._id = id;
            this.barrackRoom = barrackRm;
        }        

        //Methods: Override inherited methods
        public override void Work()
        {
            Console.WriteLine("I work outside everyday");
        }

        public override void Commute()
        {
            Console.WriteLine("I walk or drive to work everyday");
        }

        public void Print()
        {
            Console.WriteLine("\n Enlisted: {0}, {1}, {2}, {3}, Barracks Num: {4}", this._rank, this._Lname, this._age, this._id,this._barrackRoom);
        }
    }

    //Sub-Class: Officer
    class Officer : Soldier
    {
        private int houseNumber;
        public int _houseNumber
        {
            get { return this.houseNumber; }
            set { this.houseNumber = value; }
        }
        //Constructors
        public Officer()
        {

        }
        public Officer(string rank, string lname, int age, int id, int houseNum)
        {
            this._rank = rank;
            this._Lname = lname;
            this._age = age;
            this._id = id;
            this._houseNumber = houseNum;
        }
        
        //Methods: Override inherited methods
        public override void Work()
        {
            Console.WriteLine("I work inside an office.");
        }

        public override void Commute()
        {
            Console.WriteLine("I drive to work everyday.");
        }

        public void Print()
        {
            Console.WriteLine("\n Officer: {0}, {1}, {2}, {3}, House Num: {4}", this._rank, this._Lname, this._age, this._id, this._houseNumber);
        }
    }
}
