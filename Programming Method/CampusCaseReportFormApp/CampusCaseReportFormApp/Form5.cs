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
    public partial class Form5 : Form
    {
        public Label[] displaySearchResultList { get; set; }
        public string[][] targetSearchFieldNameList { get; set; }

        public Form5()
        {
            InitializeComponent();
            displaySearchResultList = new Label[] { resultF1, resultF2, resultF3, resultF4, resultF5 };
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
            // Assign to local variables before passing them as ref
            string[][] targetSearchFieldNameListLocal = targetSearchFieldNameList;
            Label[] displaySearchResultListLocal = displaySearchResultList;

            // Pass local variables as ref
            Helper.SearchText(this, ref targetSearchFieldNameListLocal, ref displaySearchResultListLocal);

            // After the method, reassign the updated local variables back to the properties
            targetSearchFieldNameList = targetSearchFieldNameListLocal;
            displaySearchResultList = displaySearchResultListLocal;
        }
    }
}
