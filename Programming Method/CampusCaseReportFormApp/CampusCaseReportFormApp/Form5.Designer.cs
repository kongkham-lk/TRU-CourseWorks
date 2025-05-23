﻿namespace CampusCaseReportFormApp
{
    partial class Form5
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
            this.SignDateDean = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SignNameDean = new System.Windows.Forms.RichTextBox();
            this.SignDean = new System.Windows.Forms.RichTextBox();
            this.Comments = new System.Windows.Forms.RichTextBox();
            this.ExplainNo = new System.Windows.Forms.RichTextBox();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtYes = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.RichTextBox();
            this.resultF5 = new System.Windows.Forms.Label();
            this.resultF4 = new System.Windows.Forms.Label();
            this.resultF3 = new System.Windows.Forms.Label();
            this.resultF2 = new System.Windows.Forms.Label();
            this.resultF1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignDateDean
            // 
            this.SignDateDean.CustomFormat = "yyyy-MM-dd";
            this.SignDateDean.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SignDateDean.Location = new System.Drawing.Point(612, 644);
            this.SignDateDean.Name = "SignDateDean";
            this.SignDateDean.Size = new System.Drawing.Size(171, 20);
            this.SignDateDean.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSubmit.Location = new System.Drawing.Point(370, 680);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // SignNameDean
            // 
            this.SignNameDean.BackColor = System.Drawing.Color.Gainsboro;
            this.SignNameDean.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignNameDean.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignNameDean.Location = new System.Drawing.Point(277, 631);
            this.SignNameDean.Name = "SignNameDean";
            this.SignNameDean.Size = new System.Drawing.Size(328, 33);
            this.SignNameDean.TabIndex = 7;
            this.SignNameDean.Text = "";
            // 
            // SignDean
            // 
            this.SignDean.BackColor = System.Drawing.Color.Gainsboro;
            this.SignDean.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignDean.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignDean.Location = new System.Drawing.Point(36, 631);
            this.SignDean.Name = "SignDean";
            this.SignDean.Size = new System.Drawing.Size(235, 33);
            this.SignDean.TabIndex = 6;
            this.SignDean.Text = "";
            // 
            // Comments
            // 
            this.Comments.BackColor = System.Drawing.Color.Gainsboro;
            this.Comments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Comments.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Comments.Location = new System.Drawing.Point(36, 433);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(747, 60);
            this.Comments.TabIndex = 3;
            this.Comments.Text = "";
            // 
            // ExplainNo
            // 
            this.ExplainNo.BackColor = System.Drawing.Color.Gainsboro;
            this.ExplainNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExplainNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ExplainNo.Location = new System.Drawing.Point(257, 380);
            this.ExplainNo.Name = "ExplainNo";
            this.ExplainNo.Size = new System.Drawing.Size(526, 30);
            this.ExplainNo.TabIndex = 2;
            this.ExplainNo.Text = "";
            // 
            // rbtNo
            // 
            this.rbtNo.BackColor = System.Drawing.Color.Transparent;
            this.rbtNo.Location = new System.Drawing.Point(200, 388);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.rbtNo.Size = new System.Drawing.Size(50, 19);
            this.rbtNo.TabIndex = 1;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = false;
            this.rbtNo.CheckedChanged += new System.EventHandler(this.rbtNo_CheckedChanged);
            // 
            // rbtYes
            // 
            this.rbtYes.BackColor = System.Drawing.Color.Transparent;
            this.rbtYes.Location = new System.Drawing.Point(200, 365);
            this.rbtYes.Name = "rbtYes";
            this.rbtYes.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.rbtYes.Size = new System.Drawing.Size(50, 19);
            this.rbtYes.TabIndex = 0;
            this.rbtYes.Text = "Yes";
            this.rbtYes.UseVisualStyleBackColor = false;
            this.rbtYes.CheckedChanged += new System.EventHandler(this.rbtYes_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Location = new System.Drawing.Point(370, 575);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.Color.Gainsboro;
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchText.Location = new System.Drawing.Point(37, 516);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(526, 43);
            this.searchText.TabIndex = 4;
            this.searchText.Text = "";
            // 
            // resultF5
            // 
            this.resultF5.AutoSize = true;
            this.resultF5.Location = new System.Drawing.Point(740, 531);
            this.resultF5.Name = "resultF5";
            this.resultF5.Size = new System.Drawing.Size(13, 13);
            this.resultF5.TabIndex = 71;
            this.resultF5.Text = "0";
            // 
            // resultF4
            // 
            this.resultF4.AutoSize = true;
            this.resultF4.Location = new System.Drawing.Point(740, 516);
            this.resultF4.Name = "resultF4";
            this.resultF4.Size = new System.Drawing.Size(13, 13);
            this.resultF4.TabIndex = 70;
            this.resultF4.Text = "0";
            // 
            // resultF3
            // 
            this.resultF3.AutoSize = true;
            this.resultF3.Location = new System.Drawing.Point(623, 546);
            this.resultF3.Name = "resultF3";
            this.resultF3.Size = new System.Drawing.Size(13, 13);
            this.resultF3.TabIndex = 69;
            this.resultF3.Text = "0";
            // 
            // resultF2
            // 
            this.resultF2.AutoSize = true;
            this.resultF2.Location = new System.Drawing.Point(623, 531);
            this.resultF2.Name = "resultF2";
            this.resultF2.Size = new System.Drawing.Size(13, 13);
            this.resultF2.TabIndex = 68;
            this.resultF2.Text = "0";
            // 
            // resultF1
            // 
            this.resultF1.AutoSize = true;
            this.resultF1.Location = new System.Drawing.Point(623, 516);
            this.resultF1.Name = "resultF1";
            this.resultF1.Size = new System.Drawing.Size(13, 13);
            this.resultF1.TabIndex = 67;
            this.resultF1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Form5:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Form4:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Form3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Form2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Form1:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CampusCaseReportFormApp.Properties.Resources.searchBox;
            this.pictureBox3.Location = new System.Drawing.Point(0, 495);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(819, 114);
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CampusCaseReportFormApp.Properties.Resources.form04_01;
            this.pictureBox4.Location = new System.Drawing.Point(0, 605);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(819, 108);
            this.pictureBox4.TabIndex = 58;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CampusCaseReportFormApp.Properties.Resources.form05;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 583);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(814, 711);
            this.Controls.Add(this.resultF5);
            this.Controls.Add(this.resultF4);
            this.Controls.Add(this.resultF3);
            this.Controls.Add(this.resultF2);
            this.Controls.Add(this.resultF1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.ExplainNo);
            this.Controls.Add(this.rbtNo);
            this.Controls.Add(this.rbtYes);
            this.Controls.Add(this.SignDateDean);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.SignNameDean);
            this.Controls.Add(this.SignDean);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker SignDateDean;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox SignNameDean;
        private System.Windows.Forms.RichTextBox SignDean;
        private System.Windows.Forms.RichTextBox Comments;
        private System.Windows.Forms.RichTextBox ExplainNo;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtYes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox searchText;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label resultF5;
        private System.Windows.Forms.Label resultF4;
        private System.Windows.Forms.Label resultF3;
        private System.Windows.Forms.Label resultF2;
        private System.Windows.Forms.Label resultF1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}