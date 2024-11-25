using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CampusCaseReportFormApp
{
    public partial class Admin : Form
    {
        Button[] btnFillList = null;
        Button[] btnViewList = null;
        string[] formInputList = new string[5]; // storing each form's into the array
        int savedFormCount = 0;
        string targetPath;
        string fileName;
        bool isPrevSavedFormUpdated = false;

        public static Form[] formList { get; set; } = new Form[5];
        public static Dictionary<String, String>[] formInputKeyByValue { get; set; } = new Dictionary<String, String>[5];

        public static List<RichTextBox> prevHighlightTextBoxList = new List<RichTextBox>();

        public Admin()
        {
            InitializeComponent();

            btnFillList = new Button[] { btnFill1, btnFill2, btnFill3, btnFill4, btnFill5 };
            btnViewList = new Button[] { btnView1, btnView2, btnView3, btnView4, btnView5 };
        }

        #region Window Form Component

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
                //HighlightSearchForm();
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

        private void BtnView1_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 0;
            DisableFormUpdate(targetFormIndex);
        }

        private void BtnView2_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 1;
            DisableFormUpdate(targetFormIndex);
        }

        private void BtnView3_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 2;
            DisableFormUpdate(targetFormIndex);
        }

        private void BtnView4_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 3;
            DisableFormUpdate(targetFormIndex);
        }

        private void BtnView5_Click(object sender, EventArgs e)
        {
            int targetFormIndex = 4;
            DisableFormUpdate(targetFormIndex);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (GetSaveFilePath())
            {
                savedFormCount = 0; // reset savedFormCount, in case btnLoad is clicked earlier
                GenerateNewForm(); // generate a new instance of each form
                ResetButtons();
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            // this code is modify from - https://www.c-sharpcorner.com/UploadFile/mahesh/openfiledialog-in-C-Sharp/ 
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ResetButtons();

                    //Get the path of specified file
                    targetPath = openFileDialog.FileName;
                    fileName = Path.GetFileName(targetPath);

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        savedFormCount = 0;
                        GenerateNewForm();
                        string fileContent = reader.ReadToEnd();

                        // this code is modify from - https://stackoverflow.com/questions/6201529/how-do-i-turn-a-c-sharp-object-into-a-json-string-in-net
                        Dictionary<string, string>[] saveFormList = JsonConvert.DeserializeObject<Dictionary<string, string>[]>("[" + fileContent + "]");

                        foreach (Dictionary<string, string> saveForm in saveFormList)
                        {
                            formInputKeyByValue[savedFormCount] = saveForm;
                            Form targetForm = formList[savedFormCount] = GetTargetForm(savedFormCount); // create new form instance

                            // load all save inputs to form
                            // this code is modify from - https://stackoverflow.com/questions/141088/how-to-iterate-over-a-dictionary
                            foreach (KeyValuePair<string, string> saveInput in saveForm)
                            {
                                if (targetForm.Controls[saveInput.Key] != null) // it equal to null when the key not match with any form's component's name
                                {
                                    if (targetForm.Controls[saveInput.Key].GetType() == typeof(CheckBox)) // assign value differently if is checkBox
                                        ((CheckBox)targetForm.Controls[saveInput.Key]).Checked = Boolean.Parse(saveInput.Value);
                                    else if (targetForm.Controls[saveInput.Key].GetType() == typeof(RadioButton))
                                        ((RadioButton)targetForm.Controls[saveInput.Key]).Checked = Boolean.Parse(saveInput.Value);
                                    else
                                        targetForm.Controls[saveInput.Key].Text = saveInput.Value;
                                }
                            }

                            UpdateButtons(savedFormCount);
                            savedFormCount++;
                        }
                    }
                }
            }
        }

        #endregion

        #region Manipulate Form Functions

        private void GenerateNewForm()
        {
            for (int i = savedFormCount; i < formList.Length; i++)
                formList[i] = GetTargetForm(i);
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

        private void DisableFormUpdate(int targetFormIndex)
        {
            Dictionary<String, String> fieldNameByInputs = RetrieveInputsAsKeyValuePair(targetFormIndex);

            foreach (KeyValuePair<String, String> input in fieldNameByInputs)
                formList[targetFormIndex].Controls[input.Key].Enabled = false;

            formList[targetFormIndex].Controls["btnSubmit"].Enabled = false;

            if (targetFormIndex > 2)
                formList[targetFormIndex].Controls["btnSearch"].Enabled = false;

            formList[targetFormIndex].ShowDialog();
        }

        #endregion

        #region Update Button Functions

        private void ResetButtons()
        {
            // turn off all the btn
            for (int i = 0; i < btnFillList.Length || i < btnViewList.Length; i++)
            {
                btnFillList[i].Enabled = false;
                btnViewList[i].Enabled = false;
            }
            btnFillList[0].Enabled = true; // only turn on the step 1 btn
        }

        private void UpdateButtons(int targetFormIndex)
        {
            btnFillList[targetFormIndex].Enabled = false;
            btnViewList[targetFormIndex].Enabled = true;
            if (targetFormIndex < btnFillList.Length - 1)
                btnFillList[targetFormIndex + 1].Enabled = true;
        }

        #endregion

        #region Saved and Retrieved Data Functions

        private bool GetSaveFilePath()
        {
            // this code is modify from - https://www.c-sharpcorner.com/uploadfile/mahesh/savefiledialog-in-C-Sharp/
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
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

        private Dictionary<String, String> RetrieveInputsAsKeyValuePair(int targetFormIndex)
        {
            Dictionary<String, String> inputs = new Dictionary<string, string>();

            RichTextBox[] allRichTextBox = GetAllRichTxtBox(targetFormIndex);
            foreach (var txtBox in allRichTextBox)
                inputs.Add(txtBox.Name, txtBox.Text);

            RadioButton[] allRadioButton = GetAllRadioButton(targetFormIndex);
            foreach (var radioBtn in allRadioButton)
                inputs.Add(radioBtn.Name, radioBtn.Checked.ToString());

            DateTimePicker[] allDateTimePicker = GetAllDateTimePicker(targetFormIndex);
            foreach (var dateTimePicker in allDateTimePicker)
                inputs.Add(dateTimePicker.Name, dateTimePicker.Text);

            CheckBox[] allCheckBox = GetAllCheckBox(targetFormIndex);
            foreach (var checkBox in allCheckBox)
                inputs.Add(checkBox.Name, checkBox.Checked.ToString());

            if (targetFormIndex >= 3)
            {
                switch (targetFormIndex)
                {
                    case 3:
                        Label[] resultSearchList = ((Form4)formList[3]).displaySearchResultList;
                        foreach (var label in resultSearchList)
                            inputs.Add(label.Name, label.Text);
                        break;
                    case 4:
                        resultSearchList = ((Form5)formList[4]).displaySearchResultList;
                        foreach (var label in resultSearchList)
                            inputs.Add(label.Name, label.Text);
                        break;
                }
            }

            return inputs;
        }

        private RichTextBox[] GetAllRichTxtBox(int targetFormIndex)
        {
            // this code is modify from - https://stackoverflow.com/questions/42005544/get-all-textboxes-of-an-form-with-their-name-in-ascending-order
            return formList[targetFormIndex].Controls.OfType<RichTextBox>().ToArray();
        }

        private DateTimePicker[] GetAllDateTimePicker(int targetFormIndex)
        {
            // this code is modify from - https://stackoverflow.com/questions/42005544/get-all-textboxes-of-an-form-with-their-name-in-ascending-order
            return formList[targetFormIndex].Controls.OfType<DateTimePicker>().ToArray();
        }

        private RadioButton[] GetAllRadioButton(int targetFormIndex)
        {
            // this code is modify from - https://stackoverflow.com/questions/42005544/get-all-textboxes-of-an-form-with-their-name-in-ascending-order
            return formList[targetFormIndex].Controls.OfType<RadioButton>().ToArray();
        }

        private CheckBox[] GetAllCheckBox(int targetFormIndex)
        {
            // this code is modify from - https://stackoverflow.com/questions/42005544/get-all-textboxes-of-an-form-with-their-name-in-ascending-order
            return formList[targetFormIndex].Controls.OfType<CheckBox>().ToArray();
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
            formInputKeyByValue[targetFormIndex] = RetrieveInputsAsKeyValuePair(targetFormIndex);

            // this code is modify from - https://stackoverflow.com/questions/6201529/how-do-i-turn-a-c-sharp-object-into-a-json-string-in-net
            var json = JsonConvert.SerializeObject(formInputKeyByValue[targetFormIndex]);
            formInputList[targetFormIndex] = json;
            savedFormCount++;
        }

        // Save input to file right away when user click submit on each form
        private void WriteFormToFile()
        {
            // this code is modify from - https://stackoverflow.com/questions/7306214/append-lines-to-a-file-using-a-streamwriter
            StreamWriter streamWriter = new StreamWriter(targetPath, append: !isPrevSavedFormUpdated && savedFormCount > 1);

            if (savedFormCount > 1) // include comma when this is not the very first form's input set
                streamWriter.Write("\n, ");

            if (isPrevSavedFormUpdated) // re-write the whole form to txt file if any prev. saved form is edited
            {
                for (int i = 0; i < savedFormCount; i++)
                    streamWriter.Write(formInputList[i]);
            }
            else // only append new form to the bottom of the file (no need to rewrite the whole thing again)
                streamWriter.Write(formInputList[savedFormCount - 1]);
            streamWriter.Close(); // need to close StreamWrter every time since we don't know when will user close the program
        }

        #endregion
    }
}