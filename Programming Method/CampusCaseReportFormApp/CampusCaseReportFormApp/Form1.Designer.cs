using System.Windows.Forms;

namespace CampusCaseReportFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OSAUseOnly = new System.Windows.Forms.RichTextBox();
            this.StudentID = new System.Windows.Forms.RichTextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.FacultyMemberName = new System.Windows.Forms.RichTextBox();
            this.StudentEmail = new System.Windows.Forms.RichTextBox();
            this.Course = new System.Windows.Forms.RichTextBox();
            this.Term = new System.Windows.Forms.RichTextBox();
            this.Assignment = new System.Windows.Forms.RichTextBox();
            this.Department = new System.Windows.Forms.RichTextBox();
            this.ViolatedDescription = new System.Windows.Forms.RichTextBox();
            this.IsWritenStatementChecked = new System.Windows.Forms.CheckBox();
            this.IsSupportPersonChecked = new System.Windows.Forms.CheckBox();
            this.SignFacMem = new System.Windows.Forms.RichTextBox();
            this.SignNameFacMem = new System.Windows.Forms.RichTextBox();
            this.SignDateFacMem = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.StudentName = new System.Windows.Forms.RichTextBox();
            this.imgFormStep1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFormStep1)).BeginInit();
            this.SuspendLayout();
            // 
            // OSAUseOnly
            // 
            this.OSAUseOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.OSAUseOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OSAUseOnly.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OSAUseOnly.Location = new System.Drawing.Point(35, 60);
            this.OSAUseOnly.Name = "OSAUseOnly";
            this.OSAUseOnly.Size = new System.Drawing.Size(747, 43);
            this.OSAUseOnly.TabIndex = 0;
            this.OSAUseOnly.Text = "";
            // 
            // StudentID
            // 
            this.StudentID.BackColor = System.Drawing.Color.Gainsboro;
            this.StudentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StudentID.Location = new System.Drawing.Point(358, 484);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(167, 24);
            this.StudentID.TabIndex = 2;
            this.StudentID.Text = "";
            // 
            // Date
            // 
            this.Date.CustomFormat = "yyyy-MM-dd";
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.Location = new System.Drawing.Point(357, 536);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(168, 20);
            this.Date.TabIndex = 5;
            // 
            // FacultyMemberName
            // 
            this.FacultyMemberName.BackColor = System.Drawing.Color.Gainsboro;
            this.FacultyMemberName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FacultyMemberName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FacultyMemberName.Location = new System.Drawing.Point(35, 531);
            this.FacultyMemberName.Name = "FacultyMemberName";
            this.FacultyMemberName.Size = new System.Drawing.Size(317, 24);
            this.FacultyMemberName.TabIndex = 4;
            this.FacultyMemberName.Text = "";
            // 
            // StudentEmail
            // 
            this.StudentEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.StudentEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StudentEmail.Location = new System.Drawing.Point(531, 484);
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.Size = new System.Drawing.Size(251, 24);
            this.StudentEmail.TabIndex = 3;
            this.StudentEmail.Text = "";
            // 
            // Course
            // 
            this.Course.BackColor = System.Drawing.Color.Gainsboro;
            this.Course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Course.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Course.Location = new System.Drawing.Point(531, 531);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(251, 24);
            this.Course.TabIndex = 6;
            this.Course.Text = "";
            // 
            // Term
            // 
            this.Term.BackColor = System.Drawing.Color.Gainsboro;
            this.Term.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Term.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Term.Location = new System.Drawing.Point(584, 577);
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(198, 24);
            this.Term.TabIndex = 9;
            this.Term.Text = "";
            // 
            // Assignment
            // 
            this.Assignment.BackColor = System.Drawing.Color.Gainsboro;
            this.Assignment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Assignment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Assignment.Location = new System.Drawing.Point(35, 577);
            this.Assignment.Name = "Assignment";
            this.Assignment.Size = new System.Drawing.Size(201, 24);
            this.Assignment.TabIndex = 7;
            this.Assignment.Text = "";
            // 
            // Department
            // 
            this.Department.BackColor = System.Drawing.Color.Gainsboro;
            this.Department.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Department.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Department.Location = new System.Drawing.Point(242, 577);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(336, 24);
            this.Department.TabIndex = 8;
            this.Department.Text = "";
            // 
            // ViolatedDescription
            // 
            this.ViolatedDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.ViolatedDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViolatedDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ViolatedDescription.Location = new System.Drawing.Point(35, 652);
            this.ViolatedDescription.Name = "ViolatedDescription";
            this.ViolatedDescription.Size = new System.Drawing.Size(747, 67);
            this.ViolatedDescription.TabIndex = 10;
            this.ViolatedDescription.Text = "";
            // 
            // IsWritenStatementChecked
            // 
            this.IsWritenStatementChecked.Location = new System.Drawing.Point(740, 925);
            this.IsWritenStatementChecked.Name = "IsWritenStatementChecked";
            this.IsWritenStatementChecked.Padding = new System.Windows.Forms.Padding(3);
            this.IsWritenStatementChecked.Size = new System.Drawing.Size(19, 19);
            this.IsWritenStatementChecked.TabIndex = 12;
            this.IsWritenStatementChecked.UseVisualStyleBackColor = true;
            // 
            // IsSupportPersonChecked
            // 
            this.IsSupportPersonChecked.BackColor = System.Drawing.Color.Transparent;
            this.IsSupportPersonChecked.Location = new System.Drawing.Point(740, 885);
            this.IsSupportPersonChecked.Name = "IsSupportPersonChecked";
            this.IsSupportPersonChecked.Padding = new System.Windows.Forms.Padding(3);
            this.IsSupportPersonChecked.Size = new System.Drawing.Size(19, 19);
            this.IsSupportPersonChecked.TabIndex = 11;
            this.IsSupportPersonChecked.UseVisualStyleBackColor = false;
            // 
            // SignFacMem
            // 
            this.SignFacMem.BackColor = System.Drawing.Color.Gainsboro;
            this.SignFacMem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignFacMem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignFacMem.Location = new System.Drawing.Point(36, 1008);
            this.SignFacMem.Name = "SignFacMem";
            this.SignFacMem.Size = new System.Drawing.Size(290, 33);
            this.SignFacMem.TabIndex = 13;
            this.SignFacMem.Text = "";
            // 
            // SignNameFacMem
            // 
            this.SignNameFacMem.BackColor = System.Drawing.Color.Gainsboro;
            this.SignNameFacMem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignNameFacMem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignNameFacMem.Location = new System.Drawing.Point(331, 1008);
            this.SignNameFacMem.Name = "SignNameFacMem";
            this.SignNameFacMem.Size = new System.Drawing.Size(273, 33);
            this.SignNameFacMem.TabIndex = 14;
            this.SignNameFacMem.Text = "";
            // 
            // SignDateFacMem
            // 
            this.SignDateFacMem.CustomFormat = "yyyy-MM-dd";
            this.SignDateFacMem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SignDateFacMem.Location = new System.Drawing.Point(610, 1021);
            this.SignDateFacMem.Name = "SignDateFacMem";
            this.SignDateFacMem.Size = new System.Drawing.Size(172, 20);
            this.SignDateFacMem.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSubmit.Location = new System.Drawing.Point(370, 1055);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // StudentName
            // 
            this.StudentName.BackColor = System.Drawing.Color.Gainsboro;
            this.StudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StudentName.Location = new System.Drawing.Point(35, 484);
            this.StudentName.Margin = new System.Windows.Forms.Padding(500);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(317, 24);
            this.StudentName.TabIndex = 1;
            this.StudentName.Text = "";
            // 
            // imgFormStep1
            // 
            this.imgFormStep1.Image = global::CampusCaseReportFormApp.Properties.Resources.form01;
            this.imgFormStep1.Location = new System.Drawing.Point(0, 17);
            this.imgFormStep1.Name = "imgFormStep1";
            this.imgFormStep1.Size = new System.Drawing.Size(810, 1070);
            this.imgFormStep1.TabIndex = 0;
            this.imgFormStep1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(824, 761);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.SignDateFacMem);
            this.Controls.Add(this.SignNameFacMem);
            this.Controls.Add(this.SignFacMem);
            this.Controls.Add(this.IsWritenStatementChecked);
            this.Controls.Add(this.IsSupportPersonChecked);
            this.Controls.Add(this.ViolatedDescription);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Term);
            this.Controls.Add(this.Assignment);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.StudentEmail);
            this.Controls.Add(this.FacultyMemberName);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.OSAUseOnly);
            this.Controls.Add(this.imgFormStep1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgFormStep1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFormStep1;
        private System.Windows.Forms.RichTextBox OSAUseOnly;
        private System.Windows.Forms.RichTextBox StudentName;
        private System.Windows.Forms.RichTextBox StudentID;
        private System.Windows.Forms.RichTextBox StudentEmail;
        private System.Windows.Forms.RichTextBox FacultyMemberName;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.RichTextBox Course;
        private System.Windows.Forms.RichTextBox Assignment;
        private System.Windows.Forms.RichTextBox Department;
        private System.Windows.Forms.RichTextBox Term;
        private System.Windows.Forms.RichTextBox ViolatedDescription;
        private System.Windows.Forms.CheckBox IsSupportPersonChecked;
        private System.Windows.Forms.CheckBox IsWritenStatementChecked;
        private System.Windows.Forms.RichTextBox SignFacMem;
        private System.Windows.Forms.RichTextBox SignNameFacMem;
        private System.Windows.Forms.DateTimePicker SignDateFacMem;
        private System.Windows.Forms.Button btnSubmit;
    }
}

