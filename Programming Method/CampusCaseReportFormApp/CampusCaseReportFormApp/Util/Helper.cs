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
    }
}
