using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
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
        string targetPath;
        string fileName;
        bool isPrevSavedFormUpdated = false;

        public Admin()
        {
            InitializeComponent();

            btnFillList = new Button[] { btnFill1, btnFill2, btnFill3, btnFill4, btnFill5 };
            btnViewList = new Button[] { btnView1, btnView2, btnView3, btnView4, btnView5 };
        }

        private void BtnFill1_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 0;
            if (CompletedForm(targetFormIndex))
            {
                SaveFormInputsToList(targetFormIndex);
                WriteFormToFile();
                UpdateButtons(targetFormIndex);
            }
        }

        private void BtnFill2_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 1;
            if (CompletedForm(targetFormIndex))
            {
                SaveFormInputsToList(targetFormIndex);
                WriteFormToFile();
                UpdateButtons(targetFormIndex);
            }
        }

        private void BtnFill3_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 2;
            if (CompletedForm(targetFormIndex))
            {
                SaveFormInputsToList(targetFormIndex);
                WriteFormToFile();
                UpdateButtons(targetFormIndex);
            }
        }

        private void BtnFill4_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 3;
            if (CompletedForm(targetFormIndex))
            {
                SaveFormInputsToList(targetFormIndex);
                WriteFormToFile();
                UpdateButtons(targetFormIndex);
            }
        }

        private void BtnFill5_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 4;
            if (CompletedForm(targetFormIndex))
            {
                SaveFormInputsToList(targetFormIndex);
                WriteFormToFile();
                UpdateButtons(targetFormIndex);
            }
        }

        private bool CompletedForm(int targetFormIndex)
        {
            DialogResult result = formList[targetFormIndex].ShowDialog();
            if (result == DialogResult.OK)
            {
                if (targetFormIndex < savedFormCount)
                    isPrevSavedFormUpdated = true;

                return true;
            }
            else if (result == DialogResult.Cancel) // only invoke when is cancel and not close dialog
                formList[targetFormIndex] = GetTargetForm(targetFormIndex);

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
                //btnSave.Enabled = true;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (GetSaveFilePath())
            {
                GenerateNewForm();
                savedFormCount = 0;
                UpdateButtons(savedFormCount - 1);
            }
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

        private bool GetSaveFilePath()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    targetPath = saveFileDialog.FileName;
                    fileName = Path.GetFileName(targetPath);
                    return true;
                }
            }
            return false;
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

        private void SaveFormInputsToList(int targetFormIndex)
        {
            Dictionary<String, String> fieldNameByInputs = RetrieveInputsAsKeyValuePair(formList[targetFormIndex]);
            var json = JsonConvert.SerializeObject(fieldNameByInputs);
            formInputList[targetFormIndex] = json;
            savedFormCount++;
        }

        // Save input to file right away when user click submit on each form
        private void WriteFormToFile()
        {
            StreamWriter streamWriter = new StreamWriter(targetPath, append: !isPrevSavedFormUpdated && savedFormCount > 1);

            if (savedFormCount > 1) // include comma when this is not the very first form's input set
                streamWriter.Write(", ");

            if (isPrevSavedFormUpdated) // re-write the whole form to txt file if any prev. saved form is edited
            {
                for (int i = 0; i < savedFormCount; i++)
                    streamWriter.Write(formInputList[i]);
            }
            else // only append new form to the bottom of the file (no need to rewrite the whole thing again)
                streamWriter.Write(formInputList[savedFormCount - 1]);
            streamWriter.Close(); // need to close StreamWrter every time since we don't know when will user close the program
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
                    //btnSave.Enabled = true;
                }
            }
        }
    }
}

// ADDED BRACKET ADD FRONT AND REMOVE THE LAST BRACKET BEFORE ADD THE NEXT FORM AND CLOSE THE LAST BRACKET

// DONE -> OPEN DIALOG WHEN CLICK "NEW" TO GET THE SAVE LOCATION, THEN WHEN SUBMIT EACH FORM, IT WILL WRITE TO THAT LOCATION:
    // DONE -> OPEN DIALOG -> IDENTIFY THE FOLDER + FILE NAME
        // DONE -> CHECK IF FOLDER EXIST? -> CREATE IF FOLDER NOT EXISTED
        // DONE -> THE GET FILE NAME AND STORE GLOBALLY TO WRITE LATER.

// VIEW BUTTON LOGIC
// ALL THE RICHBOX TEXT SHOULD NOT FLOAT IF ONLY HAVE 1 LINE INPUTS
// WRITE LOGIC TO RESET ALL THE ENABLE STATE OF BUTTON
// WRITE LOGIC TO ENABLE AND FORM THAT NEED TO BE RESUME
    // -> GREY OUT ALL FILL BUTTON AND ENABLE ITS VIEW BUTTON FOR COMPLETED FORM
    // -> ENABLE FILL BUTTON ON THE NEXT INCOMPLETED FORM
    // -> REMOVE SAVE BUTTON

// resizing the input field
