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
            // REFACTOR FUNCTION AND RETURN BOOL TO SET BUTTON
            int targetFormIndex = 0;
            if (forms[targetFormIndex].ShowDialog() == DialogResult.OK)
            {
                btnFill2.Enabled = true;
                btnView1.Enabled = true;
                Dictionary<String, String> inputs = retrieveInputsAsKeyValuePair(form1);
                var json = JsonConvert.SerializeObject(inputs);
                ExportInputsToFile(json, "form1.txt");
            }
            else
                forms[targetFormIndex] = GetTargetForm(targetFormIndex);
        }

        private void btnFill2_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 1;
            if (forms[targetFormIndex].ShowDialog() == DialogResult.OK)
            {
                btnFill2.Enabled = false;
                btnFill3.Enabled = true;
                btnView2.Enabled = true;
                btnSave.Enabled = true;
                SaveFormInputsToList(forms[targetFormIndex]);
            }
            else
                forms[targetFormIndex] = GetTargetForm(targetFormIndex);
        }

        private void btnFill3_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 2;
            if (forms[targetFormIndex].ShowDialog() == DialogResult.OK)
            {
                btnFill3.Enabled = false;
                btnFill4.Enabled = true;
                btnView3.Enabled = true;
                btnSave.Enabled = true;
                SaveFormInputsToList(forms[targetFormIndex]);
            }
            else
                forms[targetFormIndex] = GetTargetForm(targetFormIndex);
        }

        private void btnFill4_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 3;
            if (forms[targetFormIndex].ShowDialog() == DialogResult.OK)
            {
                btnFill4.Enabled = false;
                btnFill5.Enabled = true;
                btnView4.Enabled = true;
                btnSave.Enabled = true;
                SaveFormInputsToList(forms[targetFormIndex]);
            }
            else
                forms[targetFormIndex] = GetTargetForm(targetFormIndex);
        }

        private void btnFill5_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 4;
            if (forms[targetFormIndex].ShowDialog() == DialogResult.OK)
            {
                btnFill5.Enabled = false;
                btnView5.Enabled = true;
                btnSave.Enabled = true;
                SaveFormInputsToList(forms[targetFormIndex]);
            }
            else
                forms[targetFormIndex] = GetTargetForm(targetFormIndex);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            createNewForm();
            btnFill1.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteFormToFile();
        }

        private void createNewForm()
        {
            forms = new Form[5];
            for (int i = 0; i < forms.Length; i++)
                forms[i] = GetTargetForm(i);
        }

        private Dictionary<String, String> RetrieveInputsAsKeyValuePair(Form targetForm)
        {
            Dictionary<String, String> inputs = new Dictionary<string, string>();

            RichTextBox[] allRichTextBox = GetAllRichTxtBox(targetForm);
            foreach (var txtBox in allRichTextBox)
                inputs.Add(txtBox.Name, txtBox.Text);

            RadioButton[] allRadioButton = GetAllRadioButton(targetForm);
            foreach (var txtBox in allRadioButton)
                inputs.Add(txtBox.Name, txtBox.Text);

            DateTimePicker[] allDateTimePicker = GetAllDateTimePicker(targetForm);
            foreach (var txtBox in allDateTimePicker)
                inputs.Add(txtBox.Name, txtBox.Text);

            CheckBox[] allCheckBox = GetAllCheckBox(targetForm);
            foreach (var checkBox in allCheckBox)
                inputs.Add(checkBox.Name, checkBox.Checked.ToString());

            return inputs;
        }

        private RichTextBox[] GetAllRichTxtBox(Form targetForm)
        {
            return targetForm.Controls.OfType<RichTextBox>().ToArray();
        }

        private DateTimePicker[] GetAllDateTimePicker(Form targetForm)
        {
            return targetForm.Controls.OfType<DateTimePicker>().ToArray();
        }

        private RadioButton[] GetAllRadioButton(Form targetForm)
        {
            return targetForm.Controls.OfType<RadioButton>().ToArray();
        }

        private CheckBox[] GetAllCheckBox(Form targetForm)
        {
            return targetForm.Controls.OfType<CheckBox>().ToArray();
        }

        private Form GetTargetForm(int targetForm)
        {
            switch (targetForm)
            {
                case 0:
                    return new Form1();
                case 1:
                    return new Form2();
                case 2:
                    return new Form3();
                case 3:
                    return new Form4();
                case 4:
                    return new Form5();
                default:
                    throw new Exception("No Match Form!!!");
            }
        }

        private void SaveFormInputsToList(Form targetForm)
        {
            Dictionary<String, String> fieldNameByInputs = RetrieveInputsAsKeyValuePair(targetForm);
            var json = JsonConvert.SerializeObject(fieldNameByInputs);
            formInputList[savedFormCount] = json;
            savedFormCount++;
        }

        private void WriteFormToFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = GetFileInputsDir();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string targetPath = saveFileDialog.FileName;

                    StreamWriter streamWriter = new StreamWriter(targetPath, false);
                    streamWriter.Write("[\n");
                    for (int i = 0; i < savedFormCount; i++)
                    {
                        if (formInputList[i] == null)
                            break;
                        else if (i > 0)
                            streamWriter.Write(",\n");

                        streamWriter.Write(formInputList[i]);
                    }
                    streamWriter.Write("]");
                    streamWriter.Close();
                }
            }
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
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Form targetForm = new Form();

                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        int i = 0;
                        string fileContent = reader.ReadToEnd();
                        
                        Dictionary<string, string>[] savedFormList = JsonConvert.DeserializeObject<Dictionary<string, string>[]>(fileContent);

                        foreach (Dictionary<string, string> saveForm in savedFormList)
                        {
                            targetForm = GetTargetForm(i);
                            i++;
                            
                            foreach (KeyValuePair<string, string> entry in saveForm)
                            {
                                if (targetForm.Controls[entry.Key] != null) // it equal to null when the key not match with any form's component's name
                                {
                                    if (targetForm.Controls[entry.Key].GetType() == typeof(CheckBox)) // assign value differently if is checkBox
                                        ((CheckBox)targetForm.Controls[entry.Key]).Checked = Boolean.Parse(entry.Value);
                                    else
                                        targetForm.Controls[entry.Key].Text = entry.Value;
                                }
                            }
                        }
                    }
                    targetForm.ShowDialog();
                    btnSave.Enabled = true;
                }
            }
        }
    }
}
