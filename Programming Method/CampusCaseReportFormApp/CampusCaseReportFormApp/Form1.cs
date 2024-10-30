using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CampusCaseReportFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if (!Helper.checkIfTextBoxIsEmpty(new RichTextBox[] { 
            //        txtStudentName, txtStudentID, txtStudentEmail, txtFacMemName, txtCourse, txtCourseContent, 
            //    txtDepartment, txtTerm, txtDescription,txtSign, txtSignName 
            //}) && Helper.checkIfAllCheckboxIsChecked(new CheckBox[] { checkBox3 , checkBox4}))
            //{
            this.DialogResult = DialogResult.OK;
            this.Close();
            //}
            //else
            //    MessageBox.Show("Please fill up all the text field");

        }
    }
}
