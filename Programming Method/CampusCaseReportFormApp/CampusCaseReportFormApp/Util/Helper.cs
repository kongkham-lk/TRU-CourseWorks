using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusCaseReportFormApp
{
    public static class Helper
    {
        public static DialogResult ConfirmMessage()
        {
            DialogResult result = MessageBox.Show("Are You Sure to Submit the Form?", "Error Detected in Input", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
                return DialogResult.OK; // use for sending back message to trigger button enabling
            else
                return DialogResult.Cancel;
        }

        public static string[][] GetTargetFormField(string targetText)
        {
            string error = "";
            string output = " ";

            // this code is modify from - https://stackoverflow.com/questions/816566/how-do-you-get-the-current-project-directory-from-c-sharp-code-when-creating-a-c
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string targetScript = projectDirectory + "\\" + "SearchFeature.py";

            // initialize and config Process instance
            var pstartinfo = new ProcessStartInfo();
            pstartinfo.UseShellExecute = false;
            pstartinfo.CreateNoWindow = true;
            pstartinfo.RedirectStandardOutput = true;
            pstartinfo.RedirectStandardError = true;
            string allSaveForm = JsonConvert.SerializeObject(Admin.formInputKeyByValue);
            allSaveForm = "\"" + allSaveForm.Replace("\"", "\\\"") + "\""; // this code is modify from - https://chatgpt.com/

            // set file name and pass in argument
            pstartinfo.FileName = GetPythonExePath();
            pstartinfo.Arguments = $"\"{targetScript}\" {allSaveForm} {(targetText == "" ? "\" \"" : targetText)} "; // this code is modify from - https://chatgpt.com/

            // execute the process
            using (Process process = Process.Start(pstartinfo))
            {
                error = process.StandardError.ReadToEnd();
                output = process.StandardOutput.ReadLine();
            }

            if (output != null && output.Any())
                return JsonConvert.DeserializeObject<string[][]>(output);
            else
                return null;
        }

        // get relative path of Python execution file
        // this code is modify from - https://stackoverflow.com/questions/41920032/automatically-find-the-path-of-the-python-executable
        private static string GetPythonExePath()
        {
            var entries = Environment.GetEnvironmentVariable("path").Split(';');
            string python_location = null;

            foreach (string entry in entries)
            {
                if (entry.ToLower().Contains("python"))
                {
                    var dirs = entry.Split('\\');
                    foreach (string dir in dirs)
                    {
                        if (dir.ToLower().Contains("python"))
                        {
                            python_location += dir + '\\';
                            break;
                        }
                        python_location += dir + '\\';
                    }
                    break;
                }
            }
            return python_location + "python.exe";
        }

        public static void SearchText(Form targetForm, ref string[][] targetSearchFieldNameList, ref Label[] displaySearchResultList)
        {
            targetSearchFieldNameList = Helper.GetTargetFormField(targetForm.Controls["searchText"].Text);

            if (targetSearchFieldNameList != null)
            {
                for (int i = 0; i < targetSearchFieldNameList.Length; i++)
                    displaySearchResultList[i].Text = targetSearchFieldNameList[i].Length.ToString();

                for (int i = targetSearchFieldNameList.Length; i < displaySearchResultList.Length; i++) // set the rest of the stage's result to 0, in case earlier seach updated
                    displaySearchResultList[i].Text = "0";
            }
        }

        public static bool CheckIfFormComplete(Form targetForm)
        {
            // this code is modify from - https://stackoverflow.com/questions/6016456/set-system-drawing-color-values
            Color errorColor = Color.FromArgb(255, 192, 192);
            bool isComplete = true;

            var targetCBs = targetForm.Controls.OfType<CheckBox>().ToArray();
            if (targetCBs != null && targetCBs.Any())
                foreach (var rbt in targetCBs)
                {
                    if (!rbt.Checked)
                    {
                        rbt.BackColor = errorColor;
                        isComplete = false;
                    }
                    else
                        rbt.BackColor = Color.Transparent;
                }

            var targetRBs = targetForm.Controls.OfType<RadioButton>().ToArray();
            if (targetRBs != null && targetRBs.Any())
            {
                Color targetColor = Color.Transparent;

                int checkedRbsCount = targetRBs.Count(rb => rb.Checked);
                if (checkedRbsCount == 0 || checkedRbsCount > 1)
                {
                    targetColor = errorColor;
                    isComplete = false; // return false if none of the radio button is selected
                }

                foreach (var rb in targetRBs)
                    rb.BackColor = targetColor;
            }

            var targetRTBs = targetForm.Controls.OfType<RichTextBox>().ToArray();
            if (targetRTBs != null && targetRTBs.Any())
                foreach (var rbt in targetRTBs)
                {
                    if (!rbt.Name.ToLower().Contains("search") && !rbt.Text.Any() && rbt.Enabled)
                    {
                        rbt.BackColor = errorColor;
                        isComplete = false;
                    }
                    else
                        rbt.BackColor = Color.Gainsboro;
                }

            if (!isComplete)
                MessageBox.Show("Cannot Submit, Please Complete This Step!");

            return isComplete;
        }

        public static void HighlightTextBoxInForms(ref List<RichTextBox> prevHighlightTextBoxList, string[][] targetSearchFieldList, string searchText)
        {
            ResetHighlightTextBoxInForms(ref prevHighlightTextBoxList);

            Form[] formList = Admin.formList;
            GetAllTargetSearchField(prevHighlightTextBoxList, formList, targetSearchFieldList);

            foreach (RichTextBox targetTxtBox in prevHighlightTextBoxList)
                HighlightTextInTextBox(targetTxtBox, searchText);
        }

        public static void ResetHighlightTextBoxInForms(ref List<RichTextBox> prevHighlightTextBoxList)
        {
            if (prevHighlightTextBoxList.Any())
                foreach (RichTextBox prevHightlight in prevHighlightTextBoxList)
                    ClearHighlightTextInTextBox(prevHightlight);

            prevHighlightTextBoxList = new List<RichTextBox>(); // reset previous save search field
        }

        private static void GetAllTargetSearchField(List<RichTextBox> prevHighlightTextBoxList, Form[] formList, string[][] targetSearchField)
        {
            if (targetSearchField != null && targetSearchField.Any())
            {
                for (int i = 0; i < targetSearchField.Length; i++)
                {
                    foreach (string targetFieldName in targetSearchField[i])
                    {
                        RichTextBox targetField = (RichTextBox)formList[i].Controls[targetFieldName];
                        prevHighlightTextBoxList.Add(targetField);
                    }
                }
            }
        }

        // this code is modify from - https://stackoverflow.com/questions/63747334/highlight-text-in-a-richtextbox-control
        private static void HighlightTextInTextBox(RichTextBox rtb, string searchTextt)
        {
            //ClearHighlight(rtb);
            //string pattern = string.Join("|", phrases.Select(phr => Regex.Escape(phr)));

            var matches = Regex.Matches(rtb.Text, searchTextt, RegexOptions.IgnoreCase);
            foreach (Match m in matches)
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionBackColor = Color.Yellow;
            }
        }

        // this code is modify from - https://stackoverflow.com/questions/63747334/highlight-text-in-a-richtextbox-control
        private static void ClearHighlightTextInTextBox(RichTextBox rtb)
        {
            int selStart = rtb.SelectionStart;
            rtb.SelectAll();
            rtb.SelectionBackColor = Color.Transparent;
            rtb.SelectionStart = selStart;
            rtb.SelectionLength = 0;
        }
    }
}
