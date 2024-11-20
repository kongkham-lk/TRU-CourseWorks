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
        List<RichTextBox> prevHighlightTextBoxList = new List<RichTextBox>();
        string[][] targetSearchFieldNameList;
        public Label[] displaySearchResultList { get; set; }

        public Form5()
        {
            InitializeComponent();
            displaySearchResultList = new Label[] { resultF1, resultF2, resultF3, resultF4, resultF5 };
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Helper.CheckIfFormComplete(this))
            {
                this.DialogResult = Helper.ConfirmMessage();
                this.Close();
            }
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
            Label[] displaySearchResultListLocal = displaySearchResultList;

            // Pass local variables as ref
            Helper.SearchText(this, ref targetSearchFieldNameList, ref displaySearchResultListLocal);

            // After the method, reassign the updated local variables back to the properties
            displaySearchResultList = displaySearchResultListLocal;

            Helper.HighlightTextBoxInForms(ref prevHighlightTextBoxList, targetSearchFieldNameList, searchText.Text);
        }
    }
}
