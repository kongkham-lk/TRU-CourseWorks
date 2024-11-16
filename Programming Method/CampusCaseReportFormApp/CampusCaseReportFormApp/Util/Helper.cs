﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

        public static string[][] SearchText(string targetText)
        {
            string[][] targetField = GetTargetFormField(targetText);
            return null;
        }

        private static string[][] GetTargetFormField(string targetText)
        {
            string error = "";
            string output = " ";

            // this code is modify in - https://stackoverflow.com/questions/816566/how-do-you-get-the-current-project-directory-from-c-sharp-code-when-creating-a-c
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string targetScript = projectDirectory + "\\" + "SearchFeature.py";

            // initialize and config Process instance
            var pstartinfo = new ProcessStartInfo();
            pstartinfo.UseShellExecute = false;
            pstartinfo.CreateNoWindow = true;
            pstartinfo.RedirectStandardOutput = true;
            pstartinfo.RedirectStandardError = true;
            string allSaveForm = JsonConvert.SerializeObject(Admin.formInputKeyByValue);
            allSaveForm = "\"" + allSaveForm.Replace("\"", "\\\"") + "\""; // this code is modify in - https://chatgpt.com/

            // set file name and pass in argument
            pstartinfo.FileName = @"C:\Program Files\Python37\python.exe";
            pstartinfo.Arguments = $"\"{targetScript}\" {allSaveForm} {(targetText == "" ? "\" \"" : targetText)} "; // this code is modify in - https://chatgpt.com/

            // execute the process
            using (Process process = Process.Start(pstartinfo))
            {
                error = process.StandardError.ReadToEnd();
                output = process.StandardOutput.ReadLine();
            }

            if (output.Any())
                return JsonConvert.DeserializeObject<string[][]>(output);
            else
                return null;
        }
    }
}
