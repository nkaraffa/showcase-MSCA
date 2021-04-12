using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Extra_Work_Day6___3MAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Army.");
            char user = 'A';

            while (user != 'Q')
            {
                
                try
                {
                    Console.WriteLine("Select an option: \nS-Soldier  E-Enlisted  O-Officer  R-Record  Q-Quit");
                    user = char.Parse(Console.ReadLine());
                    switch (user)
                    {
                        case 's':
                        case 'S':
                            CreateSold();
                            break;
                        case 'e':
                        case 'E':
                            CreateEnlist();
                            break;
                        case 'o':
                        case 'O':
                            CreateOff();
                            break;
                        case 'r':
                        case 'R':
                            Officer officer1 = new Officer("LTC", "Bullard", 45, 8520, 9999);
                            string entry1 = "This is the first Officer entry:";
                            string fileName = @"E:\10975Allfiles\Extra Work\Extra Work Day6 - 3MAR\RosterDummy";
                            //WriteContents(entry1, fileName, officer1);

                            Console.WriteLine("\nEnter your new Officer record details:");
                            Officer officer2 = new Officer();
                            officer2 = NewRecord(officer2);
                            string entry2 = "This is the new Officer entry:";
                            WriteContents(entry2, fileName,officer2);
                            break;
                        case 'q':
                        case 'Q':
                            Console.WriteLine("Thanks for joining.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            
        }

        //Creates and saves an Officer object to use in the Record process
        static Officer NewRecord (Officer officer)
        {
            try
            {
                Console.WriteLine("Enter your rank:");
                officer._rank = Console.ReadLine();
                Console.WriteLine("Enter your Last name:");
                officer._Lname = Console.ReadLine();
                Console.WriteLine("Enter your age:");
                officer._age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your house number:");
                officer._houseNumber = int.Parse(Console.ReadLine());

                return officer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return officer ;
        }
        //This method writes the given Officer object to the Text File
        static void WriteContents (string header, string filename, Officer officer)
        {
            if (!File.Exists(filename))
            {
                StreamWriter writer = new StreamWriter(filename);
                writer.WriteLine(header);
                writer.WriteLine(officer._rank + " " + officer._Lname + ", ");
                writer.WriteLine("Age: " + officer._age + ", ");
                writer.WriteLine("House number is: " + officer._houseNumber);
                writer.Close();
            }
            else
            {
                StreamWriter writer = File.AppendText(filename);
                writer.WriteLine("\n" + "{0} \n{1} {2}, Age {3}, House Number {4}", header, officer._rank, officer._Lname, officer._age, officer._houseNumber);
                writer.Close();
            }

            ReadFile(filename);
        }
        //This method reads the Text File that was just written on by the WriteContents method
        static void ReadFile (string filename)
        {
            Console.WriteLine("The file was saved with the following content:");
            StreamReader reader = new StreamReader(filename);
            Console.WriteLine("\n" + reader.ReadToEnd());
        }

        //Method creates sub-class of Army called Soldier. Can Print & Work.
        static void CreateSold()
        {
            try
            {
                Soldier sold1 = new Soldier();
                Console.WriteLine("Input your rank:");
                sold1._rank = Console.ReadLine();
                Console.WriteLine("Input your last name:");
                sold1._Lname = Console.ReadLine();
                Console.WriteLine("Input your age:");
                sold1._age = int.Parse(Console.ReadLine());
                Console.WriteLine("Input your ID:");
                sold1._id = int.Parse(Console.ReadLine());
                sold1.Print();
                sold1.Work();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message );
            }            
        }

        //Method creates sub-class of Soldier called Enlisted. Can Print, Work, & Commute.
        static void CreateEnlist()
        {
            try
            {
                Console.WriteLine("Input your rank:");
                string rank = Console.ReadLine();
                Console.WriteLine("Input your last name:");
                string lName = Console.ReadLine();
                Console.WriteLine("Input your age:");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Input your ID:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Input your Barracks Number:");
                int barrackNum = int.Parse(Console.ReadLine());
                Enlisted enlist = new Enlisted(rank, lName, age, id, barrackNum);
                enlist.Print();
                enlist.Work();
                enlist.Commute();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message );
            }            
        }

        //Method creates sub-class of Soldier called Officer. Can Print, Work, & Commute.
        static void CreateOff()
        {
            try
            {
                Console.WriteLine("Input your rank:");
                string rank = Console.ReadLine();
                Console.WriteLine("Input your last name:");
                string lName = Console.ReadLine();
                Console.WriteLine("Input your age:");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Input your ID:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Input your House Number:");
                int houseNum = int.Parse(Console.ReadLine());
                Officer officer = new Officer(rank, lName, age, id, houseNum);
                officer.Print();
                officer.Work();
                officer.Commute();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message );
            }            
        }
    }
}
