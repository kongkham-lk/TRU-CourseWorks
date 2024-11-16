using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusCaseReportFormApp
{
    public partial class Form4 : Form
    {
        public Form4()
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

            this.DialogResult = Helper.ConfirmMessage();
            this.Close();

            //}
            //else
            //    MessageBox.Show("Please fill up all the text field");
        }

        private void rbtYes_CheckedChanged(object sender, EventArgs e)
        {
            ExplainNo.Enabled = false;
            ExplainNo.Text = "";
        }

        private void rbtNo_CheckedChanged(object sender, EventArgs e)
        {
            ExplainNo.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Helper.SearchText(searchText.Text);

            // 1. implement logic to highlight text
            // 2. update UI to show result count + update field
            // find out how to: 
                // 1. highlight individual text of a richbox text
                // 2. reset text color
        }
    }
}
