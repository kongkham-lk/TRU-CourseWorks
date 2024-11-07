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
        Button[] btnFillList = null;
        Button[] btnViewList = null;
        Form[] formList = new Form[5];
        string[] formInputList = new string[5]; // storing each form's into the array
        int savedFormCount = 0;

        public Admin()
        {
            InitializeComponent();

            btnFillList = new Button[] { btnFill1, btnFill2, btnFill3, btnFill4, btnFill5 };
            btnViewList = new Button[] { btnView1, btnView2, btnView3, btnView4, btnView5 };
        }

        private void BtnFill1_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 0;
            if (CompletedForm(formList, savedFormCount))
                UpdateButtons(targetFormIndex);
        }

        private void BtnFill2_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 1;
            if (CompletedForm(formList, savedFormCount))
                UpdateButtons(targetFormIndex);
        }

        private void BtnFill3_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 2;
            if (CompletedForm(formList, savedFormCount))
                UpdateButtons(targetFormIndex);
        }

        private void BtnFill4_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 3;
            if (CompletedForm(formList, savedFormCount))
                UpdateButtons(targetFormIndex);
        }

        private void BtnFill5_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 4;
            if (CompletedForm(formList, savedFormCount))
                UpdateButtons(targetFormIndex);
        }

        private bool CompletedForm(Form[] forms, int targetFormIndex)
        {
            DialogResult result = forms[targetFormIndex].ShowDialog();
            if (result == DialogResult.OK)
            {
                SaveFormInputsToList(forms[targetFormIndex]);
                WriteFormToFile();
                return true;
            }
            else if (result == DialogResult.Cancel) // only invoke when is cancel and not close dialog
                forms[targetFormIndex] = GetTargetForm(targetFormIndex);

            return false;
        }

        private void UpdateButtons(int targetFormIndex)
        {
            if (targetFormIndex < 0)
                btnFillList[0].Enabled = true;
            else
            {
                btnFillList[targetFormIndex].Enabled = false;
                btnViewList[targetFormIndex].Enabled = true;
                if (targetFormIndex < btnFillList.Length)
                    btnFillList[targetFormIndex + 1].Enabled = true;
                btnSave.Enabled = true;
            }
            else
                forms[targetFormIndex] = GetTargetForm(targetFormIndex);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            GenerateNewForm();
            savedFormCount = 0;
            UpdateButtons(savedFormCount - 1);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            WriteFormToFile();
        }

        private void GenerateNewForm()
        {
            for (int i = savedFormCount; i < formList.Length; i++)
                    formList[i] = GetTargetForm(i);
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

        // Save input to file right away when user click submit on each form
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

                    StreamWriter streamWriter = new StreamWriter(targetPath, true);

                    if (savedFormCount > 0) // include comma when this is not the very first form's input set
                        streamWriter.Write(", ");

                    streamWriter.Write(formInputList[savedFormCount - 1]);
                    streamWriter.Close(); // need to close StreamWrter every time since we don't know when will user close the program
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

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = GetFileInputsDir();
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Form targetForm = null;

                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        savedFormCount = 0;
                        string fileContent = reader.ReadToEnd();
                        
                        Dictionary<string, string>[] savedFormList = JsonConvert.DeserializeObject<Dictionary<string, string>[]>("[" + fileContent + "]");

                        foreach (Dictionary<string, string> saveForm in savedFormList)
                        {
                            Form targetForm = formList[savedFormCount] = GetTargetForm(savedFormCount);
                            savedFormCount++;
                            
                            foreach (KeyValuePair<string, string> saveInput in saveForm)
                            {
                                if (targetForm.Controls[saveInput.Key] != null) // it equal to null when the key not match with any form's component's name
                                {
                                    if (targetForm.Controls[saveInput.Key].GetType() == typeof(CheckBox)) // assign value differently if is checkBox
                                        ((CheckBox)targetForm.Controls[saveInput.Key]).Checked = Boolean.Parse(saveInput.Value);
                                    else
                                        targetForm.Controls[saveInput.Key].Text = saveInput.Value;
                                }
                            }
                        }
                    }
                    GenerateNewForm();
                    UpdateButtons(savedFormCount - 1);
                    formList[0].ShowDialog();
                    btnSave.Enabled = true;
                }
            }
        }
    }
}

// WRITE LOGIC TO RESET ALL THE ENABLE STATE OF BUTTON
// WRITE LOGIC TO ENABLE AND FORM THAT NEED TO BE RESUME
    // -> GREY OUT ALL FILL BUTTON AND ENABLE ITS VIEW BUTTON FOR COMPLETED FORM
    // -> ENABLE FILL BUTTON ON THE NEXT INCOMPLETED FORM
    // -> REMOVE SAVE BUTTON