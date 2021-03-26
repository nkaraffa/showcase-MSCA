using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MSCA_Uni
{
    public partial class Form1 : Form
    {
        //Global Variables
        ArrayList studList;
        monthofadmission m;
        acdMajor a;

        public Form1()
        {
            InitializeComponent();
        }        

        //Refreshes the Data set.
        private void RefreshData()
        {
            StudentGrid.DataSource = null;
            StudentGrid.DataSource = studList;

            txtID.Text = string.Empty;
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            txtAdr.Text = string.Empty;
            txtGrade.Text = string.Empty;
        }
        //Adds student data into the Grid.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewStudEntry.Visible = true;
            if (txtID.Text != string.Empty && txtFName.Text != string.Empty && txtLName.Text != string.Empty)
            {
                Student newStud = new Student();
                newStud.studID = Int32.Parse(txtID.Text);
                newStud.firstName = txtFName.Text;
                newStud.lastName = txtLName.Text;
                newStud.address = txtAdr.Text;
                newStud.joinMonth = (monthofadmission) cbMonth.SelectedValue;
                newStud.studMajor = (acdMajor)cbAdMajor.SelectedValue;
                newStud.grade = txtGrade.Text;
                studList.Add(newStud);
                MessageBox.Show("The Student Entry was Added.");
            }
            RefreshData();            
        }

        //Deletes student information from the Grid
        private void btnDelete_Click(object sender, EventArgs e)
        {
            studList.RemoveAt(StudentGrid.CurrentRow.Index);
            RefreshData();
            MessageBox.Show("The Student Entry was Deleted.");
        }

        //Displays the Data-Grid information
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            RefreshData();
            StudentGrid.Visible = true;
            MessageBox.Show("Data is now displayed.");            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studList = new ArrayList();
            studList.Add(new Student(1, fName: "Bill", lName: "Smith", addr: "NC", monthofadmission.Apr, acdMajor.Business,"A"));
            studList.Add(new Student(2, "Jill", "Smith", "NY", monthofadmission.Jul, acdMajor.PreLaw, "B"));
            StudentGrid.DataSource = studList;
            StudentGrid.Visible = false;
            //NewStudEntry.Visible = false;

            cbMonth.DataSource = Enum.GetValues(typeof(monthofadmission));
            cbAdMajor.DataSource = Enum.GetValues(typeof(acdMajor));
        }
    }
}
