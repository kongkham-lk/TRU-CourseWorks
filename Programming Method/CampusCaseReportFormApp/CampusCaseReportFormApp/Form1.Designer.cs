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
            this.imgHidden2 = new System.Windows.Forms.PictureBox();
            this.imgHidden1 = new System.Windows.Forms.PictureBox();
            this.imgHidden3 = new System.Windows.Forms.PictureBox();
            this.imgFormStep1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgHidden2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHidden1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHidden3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFormStep1)).BeginInit();
            this.SuspendLayout();
            // 
            // OSAUseOnly
            // 
            this.OSAUseOnly.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OSAUseOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OSAUseOnly.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OSAUseOnly.Location = new System.Drawing.Point(35, 43);
            this.OSAUseOnly.Name = "OSAUseOnly";
            this.OSAUseOnly.Size = new System.Drawing.Size(746, 43);
            this.OSAUseOnly.TabIndex = 0;
            this.OSAUseOnly.Text = "";
            // 
            // StudentID
            // 
            this.StudentID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StudentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StudentID.Location = new System.Drawing.Point(358, 467);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(167, 24);
            this.StudentID.TabIndex = 2;
            this.StudentID.Text = "";
            // 
            // Date
            // 
            this.Date.CustomFormat = "yyyy-MM-dd";
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.Location = new System.Drawing.Point(357, 519);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(168, 20);
            this.Date.TabIndex = 5;
            // 
            // FacultyMemberName
            // 
            this.FacultyMemberName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FacultyMemberName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FacultyMemberName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FacultyMemberName.Location = new System.Drawing.Point(35, 514);
            this.FacultyMemberName.Name = "FacultyMemberName";
            this.FacultyMemberName.Size = new System.Drawing.Size(317, 24);
            this.FacultyMemberName.TabIndex = 4;
            this.FacultyMemberName.Text = "";
            // 
            // StudentEmail
            // 
            this.StudentEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StudentEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StudentEmail.Location = new System.Drawing.Point(531, 467);
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.Size = new System.Drawing.Size(251, 24);
            this.StudentEmail.TabIndex = 3;
            this.StudentEmail.Text = "";
            // 
            // Course
            // 
            this.Course.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Course.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Course.Location = new System.Drawing.Point(531, 514);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(251, 24);
            this.Course.TabIndex = 6;
            this.Course.Text = "";
            // 
            // Term
            // 
            this.Term.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Term.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Term.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Term.Location = new System.Drawing.Point(584, 560);
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(198, 24);
            this.Term.TabIndex = 9;
            this.Term.Text = "";
            // 
            // Assignment
            // 
            this.Assignment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Assignment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Assignment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Assignment.Location = new System.Drawing.Point(35, 560);
            this.Assignment.Name = "Assignment";
            this.Assignment.Size = new System.Drawing.Size(201, 24);
            this.Assignment.TabIndex = 7;
            this.Assignment.Text = "";
            // 
            // Department
            // 
            this.Department.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Department.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Department.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Department.Location = new System.Drawing.Point(242, 560);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(336, 24);
            this.Department.TabIndex = 8;
            this.Department.Text = "";
            // 
            // ViolatedDescription
            // 
            this.ViolatedDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ViolatedDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViolatedDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ViolatedDescription.Location = new System.Drawing.Point(35, 635);
            this.ViolatedDescription.Name = "ViolatedDescription";
            this.ViolatedDescription.Size = new System.Drawing.Size(747, 67);
            this.ViolatedDescription.TabIndex = 10;
            this.ViolatedDescription.Text = "";
            // 
            // IsWritenStatementChecked
            // 
            this.IsWritenStatementChecked.AutoSize = true;
            this.IsWritenStatementChecked.Location = new System.Drawing.Point(741, 912);
            this.IsWritenStatementChecked.Name = "IsWritenStatementChecked";
            this.IsWritenStatementChecked.Size = new System.Drawing.Size(15, 14);
            this.IsWritenStatementChecked.TabIndex = 12;
            this.IsWritenStatementChecked.UseVisualStyleBackColor = true;
            // 
            // IsSupportPersonChecked
            // 
            this.IsSupportPersonChecked.AutoSize = true;
            this.IsSupportPersonChecked.Location = new System.Drawing.Point(740, 872);
            this.IsSupportPersonChecked.Name = "IsSupportPersonChecked";
            this.IsSupportPersonChecked.Size = new System.Drawing.Size(15, 14);
            this.IsSupportPersonChecked.TabIndex = 11;
            this.IsSupportPersonChecked.UseVisualStyleBackColor = true;
            // 
            // SignFacMem
            // 
            this.SignFacMem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignFacMem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignFacMem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignFacMem.Location = new System.Drawing.Point(36, 991);
            this.SignFacMem.Name = "SignFacMem";
            this.SignFacMem.Size = new System.Drawing.Size(290, 33);
            this.SignFacMem.TabIndex = 13;
            this.SignFacMem.Text = "";
            // 
            // SignNameFacMem
            // 
            this.SignNameFacMem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignNameFacMem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignNameFacMem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignNameFacMem.Location = new System.Drawing.Point(331, 991);
            this.SignNameFacMem.Name = "SignNameFacMem";
            this.SignNameFacMem.Size = new System.Drawing.Size(273, 33);
            this.SignNameFacMem.TabIndex = 14;
            this.SignNameFacMem.Text = "";
            // 
            // SignDateFacMem
            // 
            this.SignDateFacMem.CustomFormat = "yyyy-MM-dd";
            this.SignDateFacMem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SignDateFacMem.Location = new System.Drawing.Point(610, 1004);
            this.SignDateFacMem.Name = "SignDateFacMem";
            this.SignDateFacMem.Size = new System.Drawing.Size(172, 20);
            this.SignDateFacMem.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubmit.Location = new System.Drawing.Point(373, 1036);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // StudentName
            // 
            this.StudentName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StudentName.Location = new System.Drawing.Point(35, 467);
            this.StudentName.Margin = new System.Windows.Forms.Padding(500);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(317, 24);
            this.StudentName.TabIndex = 1;
            this.StudentName.Text = "";
            // 
            // imgHidden2
            // 
            this.imgHidden2.Image = global::CampusCaseReportFormApp.Properties.Resources.form01;
            this.imgHidden2.Location = new System.Drawing.Point(798, 902);
            this.imgHidden2.Name = "imgHidden2";
            this.imgHidden2.Size = new System.Drawing.Size(20, 158);
            this.imgHidden2.TabIndex = 32;
            this.imgHidden2.TabStop = false;
            // 
            // imgHidden1
            // 
            this.imgHidden1.Image = global::CampusCaseReportFormApp.Properties.Resources.form01;
            this.imgHidden1.Location = new System.Drawing.Point(731, 859);
            this.imgHidden1.Name = "imgHidden1";
            this.imgHidden1.Size = new System.Drawing.Size(32, 78);
            this.imgHidden1.TabIndex = 24;
            this.imgHidden1.TabStop = false;
            // 
            // imgHidden3
            // 
            this.imgHidden3.Image = global::CampusCaseReportFormApp.Properties.Resources.form01;
            this.imgHidden3.Location = new System.Drawing.Point(118, 1030);
            this.imgHidden3.Name = "imgHidden3";
            this.imgHidden3.Size = new System.Drawing.Size(608, 23);
            this.imgHidden3.TabIndex = 31;
            this.imgHidden3.TabStop = false;
            // 
            // imgFormStep1
            // 
            this.imgFormStep1.Image = global::CampusCaseReportFormApp.Properties.Resources.form01;
            this.imgFormStep1.Location = new System.Drawing.Point(0, 0);
            this.imgFormStep1.Name = "imgFormStep1";
            this.imgFormStep1.Size = new System.Drawing.Size(819, 1065);
            this.imgFormStep1.TabIndex = 0;
            this.imgFormStep1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(834, 761);
            this.Controls.Add(this.imgHidden2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.SignDateFacMem);
            this.Controls.Add(this.SignNameFacMem);
            this.Controls.Add(this.SignFacMem);
            this.Controls.Add(this.IsWritenStatementChecked);
            this.Controls.Add(this.IsSupportPersonChecked);
            this.Controls.Add(this.imgHidden1);
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
            this.Controls.Add(this.imgHidden3);
            this.Controls.Add(this.imgFormStep1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgHidden2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHidden1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHidden3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFormStep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFormStep1;
        private System.Windows.Forms.PictureBox imgHidden1;
        private System.Windows.Forms.PictureBox imgHidden2;
        private System.Windows.Forms.PictureBox imgHidden3;
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

