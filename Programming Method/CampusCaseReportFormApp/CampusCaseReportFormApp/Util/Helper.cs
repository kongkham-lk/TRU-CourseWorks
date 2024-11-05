using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusCaseReportFormApp
{
    public static class Helper
    {
        public static bool checkIfTextBoxIsEmpty(RichTextBox[] textBoxs)
        {
            foreach (RichTextBox textBox in textBoxs)
            {
                if (!textBox.Text.Any())
                {
                    return true;
                }
            }
            return false;
        }
        public static bool checkIfAllCheckboxIsChecked(CheckBox[] checkboxs)
        {
            foreach (CheckBox checkBox in checkboxs)
            {
                if (!checkBox.Checked)
                {
                    return false;
                }
            }
            return true;
        }

        public static DialogResult ConfirmMessage()
        {
            DialogResult result = MessageBox.Show("Are You Sure to Submit the Form?", "Error Detected in Input", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
                return DialogResult.OK; // use for sending back message to trigger button enabling
            else
                return DialogResult.Cancel;
        }
    }
}
