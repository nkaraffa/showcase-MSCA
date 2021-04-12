
namespace Extra_Work___Week6Day1
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BinarySer = new System.Windows.Forms.Button();
            this.XMLSer = new System.Windows.Forms.Button();
            this.JSONSer = new System.Windows.Forms.Button();
            this.StudentBox = new System.Windows.Forms.GroupBox();
            this.EmpBox = new System.Windows.Forms.GroupBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpAge = new System.Windows.Forms.TextBox();
            this.txtEmpYear = new System.Windows.Forms.TextBox();
            this.txtEmpDep = new System.Windows.Forms.TextBox();
            this.txtStuGrd = new System.Windows.Forms.TextBox();
            this.txtStuYear = new System.Windows.Forms.TextBox();
            this.txtStuAge = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelYearStu = new System.Windows.Forms.Label();
            this.labelAgeStu = new System.Windows.Forms.Label();
            this.labelNameStu = new System.Windows.Forms.Label();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.textBoxMain = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.StudentBox.SuspendLayout();
            this.EmpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.typeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.typeToolStripMenuItem.Text = "Type";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // BinarySer
            // 
            this.BinarySer.Location = new System.Drawing.Point(225, 135);
            this.BinarySer.Name = "BinarySer";
            this.BinarySer.Size = new System.Drawing.Size(92, 45);
            this.BinarySer.TabIndex = 1;
            this.BinarySer.Text = "Binary";
            this.BinarySer.UseVisualStyleBackColor = true;
            this.BinarySer.Click += new System.EventHandler(this.BinarySer_Click);
            // 
            // XMLSer
            // 
            this.XMLSer.Location = new System.Drawing.Point(464, 135);
            this.XMLSer.Name = "XMLSer";
            this.XMLSer.Size = new System.Drawing.Size(92, 45);
            this.XMLSer.TabIndex = 2;
            this.XMLSer.Text = "XML";
            this.XMLSer.UseVisualStyleBackColor = true;
            this.XMLSer.Click += new System.EventHandler(this.XMLSer_Click);
            // 
            // JSONSer
            // 
            this.JSONSer.Location = new System.Drawing.Point(704, 135);
            this.JSONSer.Name = "JSONSer";
            this.JSONSer.Size = new System.Drawing.Size(92, 45);
            this.JSONSer.TabIndex = 3;
            this.JSONSer.Text = "JSON";
            this.JSONSer.UseVisualStyleBackColor = true;
            this.JSONSer.Click += new System.EventHandler(this.JSONSer_Click);
            // 
            // StudentBox
            // 
            this.StudentBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StudentBox.Controls.Add(this.btnStudent);
            this.StudentBox.Controls.Add(this.label1);
            this.StudentBox.Controls.Add(this.txtStuGrd);
            this.StudentBox.Controls.Add(this.labelYearStu);
            this.StudentBox.Controls.Add(this.txtStuAge);
            this.StudentBox.Controls.Add(this.labelAgeStu);
            this.StudentBox.Controls.Add(this.labelNameStu);
            this.StudentBox.Controls.Add(this.txtStuYear);
            this.StudentBox.Controls.Add(this.txtStuName);
            this.StudentBox.Location = new System.Drawing.Point(21, 353);
            this.StudentBox.Name = "StudentBox";
            this.StudentBox.Size = new System.Drawing.Size(424, 243);
            this.StudentBox.TabIndex = 4;
            this.StudentBox.TabStop = false;
            this.StudentBox.Text = "New Student";
            // 
            // EmpBox
            // 
            this.EmpBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EmpBox.Controls.Add(this.btnEmp);
            this.EmpBox.Controls.Add(this.labelDep);
            this.EmpBox.Controls.Add(this.labelYear);
            this.EmpBox.Controls.Add(this.labelAge);
            this.EmpBox.Controls.Add(this.labelName);
            this.EmpBox.Controls.Add(this.txtEmpDep);
            this.EmpBox.Controls.Add(this.txtEmpYear);
            this.EmpBox.Controls.Add(this.txtEmpAge);
            this.EmpBox.Controls.Add(this.txtEmpName);
            this.EmpBox.Location = new System.Drawing.Point(585, 353);
            this.EmpBox.Name = "EmpBox";
            this.EmpBox.Size = new System.Drawing.Size(404, 243);
            this.EmpBox.TabIndex = 5;
            this.EmpBox.TabStop = false;
            this.EmpBox.Text = "New Employee";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(241, 51);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(156, 22);
            this.txtEmpName.TabIndex = 0;
            // 
            // txtEmpAge
            // 
            this.txtEmpAge.Location = new System.Drawing.Point(241, 86);
            this.txtEmpAge.Name = "txtEmpAge";
            this.txtEmpAge.Size = new System.Drawing.Size(156, 22);
            this.txtEmpAge.TabIndex = 1;
            // 
            // txtEmpYear
            // 
            this.txtEmpYear.Location = new System.Drawing.Point(241, 121);
            this.txtEmpYear.Name = "txtEmpYear";
            this.txtEmpYear.Size = new System.Drawing.Size(156, 22);
            this.txtEmpYear.TabIndex = 2;
            // 
            // txtEmpDep
            // 
            this.txtEmpDep.Location = new System.Drawing.Point(241, 156);
            this.txtEmpDep.Name = "txtEmpDep";
            this.txtEmpDep.Size = new System.Drawing.Size(156, 22);
            this.txtEmpDep.TabIndex = 3;
            // 
            // txtStuGrd
            // 
            this.txtStuGrd.Location = new System.Drawing.Point(252, 156);
            this.txtStuGrd.Name = "txtStuGrd";
            this.txtStuGrd.Size = new System.Drawing.Size(156, 22);
            this.txtStuGrd.TabIndex = 7;
            // 
            // txtStuYear
            // 
            this.txtStuYear.Location = new System.Drawing.Point(252, 121);
            this.txtStuYear.Name = "txtStuYear";
            this.txtStuYear.Size = new System.Drawing.Size(156, 22);
            this.txtStuYear.TabIndex = 6;
            // 
            // txtStuAge
            // 
            this.txtStuAge.Location = new System.Drawing.Point(252, 86);
            this.txtStuAge.Name = "txtStuAge";
            this.txtStuAge.Size = new System.Drawing.Size(156, 22);
            this.txtStuAge.TabIndex = 5;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(252, 51);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(156, 22);
            this.txtStuName.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(67, 51);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(67, 86);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(37, 17);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Age:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(67, 128);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(72, 17);
            this.labelYear.TabIndex = 6;
            this.labelYear.Text = "Hire Year:";
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(67, 163);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(86, 17);
            this.labelDep.TabIndex = 7;
            this.labelDep.Text = "Department:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Class Grade:";
            // 
            // labelYearStu
            // 
            this.labelYearStu.AutoSize = true;
            this.labelYearStu.Location = new System.Drawing.Point(69, 128);
            this.labelYearStu.Name = "labelYearStu";
            this.labelYearStu.Size = new System.Drawing.Size(80, 17);
            this.labelYearStu.TabIndex = 10;
            this.labelYearStu.Text = "Class Year:";
            // 
            // labelAgeStu
            // 
            this.labelAgeStu.AutoSize = true;
            this.labelAgeStu.Location = new System.Drawing.Point(69, 86);
            this.labelAgeStu.Name = "labelAgeStu";
            this.labelAgeStu.Size = new System.Drawing.Size(37, 17);
            this.labelAgeStu.TabIndex = 9;
            this.labelAgeStu.Text = "Age:";
            // 
            // labelNameStu
            // 
            this.labelNameStu.AutoSize = true;
            this.labelNameStu.Location = new System.Drawing.Point(69, 51);
            this.labelNameStu.Name = "labelNameStu";
            this.labelNameStu.Size = new System.Drawing.Size(49, 17);
            this.labelNameStu.TabIndex = 8;
            this.labelNameStu.Text = "Name:";
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(142, 195);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(124, 32);
            this.btnStudent.TabIndex = 12;
            this.btnStudent.Text = "Create Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.Location = new System.Drawing.Point(150, 195);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(124, 32);
            this.btnEmp.TabIndex = 13;
            this.btnEmp.Text = "Create Employee";
            this.btnEmp.UseVisualStyleBackColor = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.Control;
            this.Title.Font = new System.Drawing.Font("Ink Free", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(322, 54);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(379, 47);
            this.Title.TabIndex = 7;
            this.Title.Text = "For-Profit University";
            // 
            // textBoxMain
            // 
            this.textBoxMain.Location = new System.Drawing.Point(21, 196);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(968, 142);
            this.textBoxMain.TabIndex = 8;
            this.textBoxMain.Text = "";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1006, 608);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.EmpBox);
            this.Controls.Add(this.StudentBox);
            this.Controls.Add(this.JSONSer);
            this.Controls.Add(this.XMLSer);
            this.Controls.Add(this.BinarySer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserForm";
            this.Text = "For-Profit University";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StudentBox.ResumeLayout(false);
            this.StudentBox.PerformLayout();
            this.EmpBox.ResumeLayout(false);
            this.EmpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button BinarySer;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.Button XMLSer;
        private System.Windows.Forms.Button JSONSer;
        private System.Windows.Forms.GroupBox StudentBox;
        private System.Windows.Forms.GroupBox EmpBox;
        private System.Windows.Forms.TextBox txtStuGrd;
        private System.Windows.Forms.TextBox txtStuAge;
        private System.Windows.Forms.TextBox txtStuYear;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtEmpDep;
        private System.Windows.Forms.TextBox txtEmpYear;
        private System.Windows.Forms.TextBox txtEmpAge;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelYearStu;
        private System.Windows.Forms.Label labelAgeStu;
        private System.Windows.Forms.Label labelNameStu;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RichTextBox textBoxMain;
    }
}

