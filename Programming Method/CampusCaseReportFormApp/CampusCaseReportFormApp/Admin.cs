using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CampusCaseReportFormApp
{
    public partial class Admin : Form
    {
        Form1 form1;
        Form2 form2;
        Form3 form3;
        Form4 form4;
        Form5 form5;
        String[] formInputs = new String[5];

        public Admin()
        {
            InitializeComponent();
        }

        private void btnFill1_Click(object sender, EventArgs e)
        {
            if (form1.ShowDialog() == DialogResult.OK)
            {
                btnFill2.Enabled = true;
                btnView1.Enabled = true;
                Dictionary<String, String> inputs = retrieveInputsAsKeyValuePair(form1);
                var json = JsonConvert.SerializeObject(inputs);
                ExportInputsToFile(json, "form1.txt");
            }
        }

        private void btnFill2_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void btnFill3_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }

        private void btnFill4_Click(object sender, EventArgs e)
        {
            form4.ShowDialog();
        }

        private void btnFill5_Click(object sender, EventArgs e)
        {
            form5.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            createNewForm();
            btnFill1.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void createNewForm()
        {
            form1 = new Form1();
            form2 = new Form2();
            form3 = new Form3();
            form4 = new Form4();
            form5 = new Form5();
        }

        private Dictionary<String, String> retrieveInputsAsKeyValuePair(Form targetForm)
        {
            RichTextBox[] allRichTextBox = getAllRichTxtBox(targetForm);
            Dictionary<String, String> inputs = new Dictionary<string, string>();
            foreach (var txtBox in allRichTextBox)
                inputs.Add(txtBox.Name, txtBox.Text);
            return inputs;
        }

        private RichTextBox[] getAllRichTxtBox(Form targetForm)
        {
            return targetForm.Controls.OfType<RichTextBox>().ToArray();
        }

        private Form getTargetForm(string targetForm)
        {
            switch (targetForm)
            {
                case "form1.txt":
                    return new Form1();
                case "form2.txt":
                    return new Form2();
                case "form3.txt":
                    return new Form3();
                case "form4.txt":
                    return new Form4();
                case "form5.txt":
                    return new Form5();
                default:
                    throw new Exception("No Match Form!!!");
            }
        }

        private void ExportInputsToFile(string json, string fileName)
        {
            string directory = GetFileInputsDir();

            if (!fileName.Contains(".txt"))
                fileName += ".txt";

            string targetPath = directory + fileName;
            
            StreamWriter streamWriter = new StreamWriter(directory + fileName, false);
            streamWriter.Write(json);
            streamWriter.Close();
        }

        private string GetFileInputsDir()
        {
            string directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\FormInputs\\";

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            return directory;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = GetFileInputsDir();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);
                    Form targetForm = getTargetForm(fileName);

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string fileContent = reader.ReadToEnd();
                        
                        RichTextBox[] targetFormTxtBoxes = getAllRichTxtBox(targetForm);
                        Dictionary<string, string> targetSavedForm = JsonConvert.DeserializeObject<Dictionary<string, string>>(fileContent);

                        foreach (KeyValuePair<string, string> entry in targetSavedForm)
                        {
                            if (targetForm.Controls[entry.Key] != null) // it equal to null when the key not match with any form's component's name
                                targetForm.Controls[entry.Key].Text = entry.Value;
                        }
                    }
                    targetForm.ShowDialog();
                }
            }
        }
    }
}
