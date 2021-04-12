using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;

namespace Extra_Work___Week6Day1
{
    public partial class UserForm : Form
    {
        //Class Instantiation - For use for serializtion
        Student newstud = new Student();
        Employee newEmp = new Employee();
        //Student newstud = new Student() { age = 35, name = "Jane", classYear = 2021, classGrade = "A" };
        //Employee newEmp = new Employee() { age = 26, name = "Bill", hireYear = 1999, departName = "HR" };

        public UserForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentBox.Visible = false;
            EmpBox.Visible = false;
        }

        //Refreshes the Data set.
        private void RefreshData()
        {
            txtStuName.Text= string.Empty;
            txtStuAge.Text= string.Empty;
            txtStuYear.Text= string.Empty;
            txtStuGrd.Text= string.Empty;

            txtEmpName.Text = string.Empty;
            txtEmpAge.Text = string.Empty;
            txtEmpYear.Text = string.Empty;
            txtEmpDep.Text = string.Empty;
        }

        //File Menu Options (New, Save, Open, Exit)
        #region File Menu Options
        //Save Function
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.ShowDialog();
            Stream sw = sf.OpenFile();
            StreamWriter swnew = new StreamWriter(sw);
            swnew.WriteLine(textBoxMain.Text);
            swnew.Close();
            sw.Close();
        }
        //Open File Function
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|";
            openFileDialog.ShowDialog();
            textBoxMain.Text = File.ReadAllText(openFileDialog.FileName);   //Reads all text from the selected file above.
        }
        //Exit Function
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //New Function
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMain.Clear();
            RefreshData();
        }

        #endregion

        //Type Menu Options (Student, Employee)  - Makes the entry boxes Visible
        #region Type Menu Options
        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentBox.Visible = true;
            EmpBox.Visible = false;
            newEmp.Clear();  //Prevents code malfunction when serializing. Clears Employee OBJ
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpBox.Visible = true;
            StudentBox.Visible = false;
            newstud.Clear();  //Prevents code malfunction when serializing. Clears Student OBJ
        }
        #endregion

        //Create Class Obj - either Student or Employee Object
        #region Class Instantiation
        //Instantiate Student OBJ
        private void btnStudent_Click(object sender, EventArgs e)
        {
            if (txtStuName.Text != string.Empty && txtStuAge.Text != string.Empty && txtStuYear.Text != string.Empty && txtStuGrd.Text != string.Empty)
            {                
                newstud.name = txtStuName.Text;
                newstud.age = int.Parse(txtStuAge.Text);
                newstud.classYear = int.Parse(txtStuYear.Text);
                newstud.classGrade = txtStuGrd.Text;
                MessageBox.Show("Student Created.");
            }
            else
            {
                MessageBox.Show("Invalid Input. Please fill out every box.");
            }
            RefreshData();  //Clear the User inputs from the display
        }

        //Instantiate Employee OBJ
        private void btnEmp_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text != string.Empty && txtEmpAge.Text != string.Empty && txtEmpYear.Text != string.Empty && txtEmpDep.Text != string.Empty)
            {                
                newEmp.name = txtEmpName.Text;
                newEmp.age = int.Parse(txtEmpAge.Text);
                newEmp.hireYear = int.Parse(txtEmpYear.Text);
                newEmp.departName = txtEmpDep.Text;
            }
            else
            {
                MessageBox.Show("Invalid Input. Please fill out every box.");
            }
            RefreshData();  //Clear the User inputs from the display
        }


        #endregion

        //Serialization Methods
        #region Serialization Methods
        //Binary
        private void BinarySer_Click(object sender, EventArgs e)
        {
            if (newstud.name != string.Empty)
            {
                FileStream binStream = new FileStream(@"C:\Users\Nik\Desktop\Coding\MSCA - Extra Work\Extra Work - Week6Day1\Notepads - Serialization\BinaryNotepad.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                //Binary Serialization
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(binStream, newstud);

                //Binary Deserialization
                binStream.Close();
                FileStream binStreamNew = new FileStream(@"C:\Users\Nik\Desktop\Coding\MSCA - Extra Work\Extra Work - Week6Day1\Notepads - Serialization\BinaryNotepad.txt", FileMode.Open, FileAccess.ReadWrite);
                Student obj = binaryFormatter.Deserialize(binStreamNew) as Student;
                binStreamNew.Close();
                //Message Output
                MessageBox.Show("Student Info Deserialized (Binary)");
                textBoxMain.AppendText("\nStudent Info (Binary): Name" + obj.name + ", Age:" + obj.age.ToString() + ", ClassYear:" + obj.classYear.ToString() + ", Grade:" + obj.classGrade);
            }
            else if (newEmp.name != string.Empty)
            {
                FileStream binStream = new FileStream(@"C:\Users\Nik\Desktop\Coding\MSCA - Extra Work\Extra Work - Week6Day1\Notepads - Serialization\BinaryNotepad.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                //Binary Serialization
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(binStream, newEmp);

                //Binary Deserialization
                binStream.Close();
                FileStream binStreamNew = new FileStream(@"C:\Users\Nik\Desktop\Coding\MSCA - Extra Work\Extra Work - Week6Day1\Notepads - Serialization\BinaryNotepad.txt", FileMode.Open, FileAccess.ReadWrite);
                Employee obj = binaryFormatter.Deserialize(binStreamNew) as Employee;
                binStreamNew.Close();
                //Message Output
                MessageBox.Show("Employee Info Deserialized (Binary)");
                textBoxMain.AppendText("\nEmployee Info (Binary): Name:" + obj.name + ", Age:" + obj.age.ToString() + ", HireYear:" + obj.hireYear.ToString() + ", Department:" + obj.departName);
            }
            else
            {
                MessageBox.Show("No Values Inputted.  Please input Student or Employee.");
            }
        }

        //XML
        private void XMLSer_Click(object sender, EventArgs e)
        {        
            if (newstud.name != string.Empty)
            {
                //XML Serialization
                SoapFormatter soapFormatter = new SoapFormatter();
                FileStream xmlStream = new FileStream(@"C:\Users\Nik\Desktop\Coding\MSCA - Extra Work\Extra Work - Week6Day1\Notepads - Serialization\XMLNotepad.xml", FileMode.OpenOrCreate, FileAccess.Write);
                soapFormatter.Serialize(xmlStream, newstud);

                //XML Deserialization
                xmlStream.Close();
                FileStream bufferXML = File.OpenRead(@"C:\Users\Nik\Desktop\Coding\MSCA - Extra Work\Extra Work - Week6Day1\Notepads - Serialization\XMLNotepad.xml");
                Student objX = soapFormatter.Deserialize(bufferXML) as Student;
                bufferXML.Close();
                //Message Output
                MessageBox.Show("Student Info Deserialized (XML)");
                textBoxMain.AppendText("\nStudent Info (XML): Name:" + objX.name + ", Age:" + objX.age.ToString() + ", ClassYear:" + objX.classYear.ToString() + ", Grade:" + objX.classGrade);
            }
            else if (newEmp.name != string.Empty)
            {
                //XML Serialization
                SoapFormatter soapFormatter = new SoapFormatter();
                FileStream xmlStream = new FileStream(@"C:\Users\Nik\Desktop\Coding\MSCA - Extra Work\Extra Work - Week6Day1\Notepads - Serialization\XMLNotepad.xml", FileMode.OpenOrCreate, FileAccess.Write);
                soapFormatter.Serialize(xmlStream, newEmp);

                //XML Deserialization
                xmlStream.Close();
                FileStream bufferXML = File.OpenRead(@"C:\Users\Nik\Desktop\Coding\MSCA - Extra Work\Extra Work - Week6Day1\Notepads - Serialization\XMLNotepad.xml");
                Employee objX = soapFormatter.Deserialize(bufferXML) as Employee;
                bufferXML.Close();
                //Message Output
                MessageBox.Show("Employee Info Deserialized (XML)");
                textBoxMain.AppendText("\nEmployee Info (XML): Name:" + objX.name + ", Age:" + objX.age.ToString() + ", HireYear:" + objX.hireYear.ToString() + ", Department:" + objX.departName);
            }
            else
            {
                MessageBox.Show("No Values Inputted.  Please input Student or Employee.");
            }
        }

        //JSON
        private void JSONSer_Click(object sender, EventArgs e)
        {          
            if(newstud.name != string.Empty)  //Check if Student OBJ has been created.
            {
                //JSON Serialization
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(newstud.GetType());
                FileStream bufferJS = File.Create(@"C:\Users\Nik\Desktop\Coding\MSCA - Extra Work\Extra Work - Week6Day1\Notepads - Serialization\JSONNotepad.txt");
                jsonSerializer.WriteObject(bufferJS, newstud);
                bufferJS.Close();

                //JSON Deserialization
                FileStream bufferJSnew = File.OpenRead(@"C:\Users\Nik\Desktop\Coding\MSCA - Extra Work\Extra Work - Week6Day1\Notepads - Serialization\JSONNotepad.txt");
                Student objJS = jsonSerializer.ReadObject(bufferJSnew) as Student;
                bufferJSnew.Close();
                //Message Output
                MessageBox.Show("Student Info Deserialized (JSON)");
                textBoxMain.AppendText("\nStudent Info (JSON): Name:" + objJS.name + ", Age:" + objJS.age.ToString() + ", ClassYear:" + objJS.classYear.ToString() + ", Grade:" + objJS.classGrade);
            }
            else if (newEmp.name != string.Empty) //Check if Employee OBJ has been created.
            {
                //JSON Serialization
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(newEmp.GetType());
                FileStream bufferJS = File.Create(@"C:\Users\Nik\Desktop\Coding\MSCA - Extra Work\Extra Work - Week6Day1\Notepads - Serialization\JSONNotepad.txt");
                jsonSerializer.WriteObject(bufferJS, newEmp);
                bufferJS.Close();

                //JSON Deserialization
                FileStream bufferJSnew = File.OpenRead(@"C:\Users\Nik\Desktop\Coding\MSCA - Extra Work\Extra Work - Week6Day1\Notepads - Serialization\JSONNotepad.txt");
                Employee objJS = jsonSerializer.ReadObject(bufferJSnew) as Employee;
                bufferJSnew.Close();
                //Message Output
                MessageBox.Show("Employee Info Deserialized (JSON)");
                textBoxMain.AppendText("\nEmployee Info (JSON): Name" + objJS.name + ", Age:" + objJS.age.ToString() + ", HireYear" + objJS.hireYear.ToString() + ", Department" + objJS.departName);
            }
            else
            {
                MessageBox.Show("No Values Inputted.  Please input Student or Employee.");
            }
        }
        #endregion

    }
}
