namespace CampusCaseReportFormApp
{
    partial class Form4
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
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtYes = new System.Windows.Forms.RadioButton();
            this.ExplainNo = new System.Windows.Forms.RichTextBox();
            this.Comments = new System.Windows.Forms.RichTextBox();
            this.SignDateDeptChair = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SignNameDeptChair = new System.Windows.Forms.RichTextBox();
            this.SignDeptChair = new System.Windows.Forms.RichTextBox();
            this.searchText = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultF5 = new System.Windows.Forms.Label();
            this.resultF4 = new System.Windows.Forms.Label();
            this.resultF3 = new System.Windows.Forms.Label();
            this.resultF2 = new System.Windows.Forms.Label();
            this.resultF1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtNo.Location = new System.Drawing.Point(203, 301);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(39, 17);
            this.rbtNo.TabIndex = 1;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = false;
            this.rbtNo.CheckedChanged += new System.EventHandler(this.rbtNo_CheckedChanged);
            // 
            // rbtYes
            // 
            this.rbtYes.AutoSize = true;
            this.rbtYes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtYes.Location = new System.Drawing.Point(203, 278);
            this.rbtYes.Name = "rbtYes";
            this.rbtYes.Size = new System.Drawing.Size(43, 17);
            this.rbtYes.TabIndex = 0;
            this.rbtYes.Text = "Yes";
            this.rbtYes.UseVisualStyleBackColor = false;
            this.rbtYes.CheckedChanged += new System.EventHandler(this.rbtYes_CheckedChanged);
            // 
            // ExplainNo
            // 
            this.ExplainNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExplainNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExplainNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ExplainNo.Location = new System.Drawing.Point(257, 291);
            this.ExplainNo.Name = "ExplainNo";
            this.ExplainNo.Size = new System.Drawing.Size(525, 32);
            this.ExplainNo.TabIndex = 2;
            this.ExplainNo.Text = "";
            // 
            // Comments
            // 
            this.Comments.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Comments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Comments.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Comments.Location = new System.Drawing.Point(37, 345);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(746, 60);
            this.Comments.TabIndex = 3;
            this.Comments.Text = "";
            // 
            // SignDateDeptChair
            // 
            this.SignDateDeptChair.CustomFormat = "yyyy-MM-dd";
            this.SignDateDeptChair.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SignDateDeptChair.Location = new System.Drawing.Point(611, 556);
            this.SignDateDeptChair.Name = "SignDateDeptChair";
            this.SignDateDeptChair.Size = new System.Drawing.Size(172, 20);
            this.SignDateDeptChair.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubmit.Location = new System.Drawing.Point(368, 589);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // SignNameDeptChair
            // 
            this.SignNameDeptChair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignNameDeptChair.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignNameDeptChair.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignNameDeptChair.Location = new System.Drawing.Point(277, 543);
            this.SignNameDeptChair.Name = "SignNameDeptChair";
            this.SignNameDeptChair.Size = new System.Drawing.Size(328, 33);
            this.SignNameDeptChair.TabIndex = 5;
            this.SignNameDeptChair.Text = "";
            // 
            // SignDeptChair
            // 
            this.SignDeptChair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignDeptChair.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignDeptChair.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignDeptChair.Location = new System.Drawing.Point(37, 543);
            this.SignDeptChair.Name = "SignDeptChair";
            this.SignDeptChair.Size = new System.Drawing.Size(234, 33);
            this.SignDeptChair.TabIndex = 4;
            this.SignDeptChair.Text = "";
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchText.Location = new System.Drawing.Point(37, 428);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(527, 43);
            this.searchText.TabIndex = 39;
            this.searchText.Text = "";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Location = new System.Drawing.Point(368, 481);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Form1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Form2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Form3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Form5:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Form4:";
            // 
            // resultF5
            // 
            this.resultF5.AutoSize = true;
            this.resultF5.Location = new System.Drawing.Point(740, 442);
            this.resultF5.Name = "resultF5";
            this.resultF5.Size = new System.Drawing.Size(13, 13);
            this.resultF5.TabIndex = 50;
            this.resultF5.Text = "0";
            // 
            // resultF4
            // 
            this.resultF4.AutoSize = true;
            this.resultF4.Location = new System.Drawing.Point(740, 427);
            this.resultF4.Name = "resultF4";
            this.resultF4.Size = new System.Drawing.Size(13, 13);
            this.resultF4.TabIndex = 49;
            this.resultF4.Text = "0";
            // 
            // resultF3
            // 
            this.resultF3.AutoSize = true;
            this.resultF3.Location = new System.Drawing.Point(623, 457);
            this.resultF3.Name = "resultF3";
            this.resultF3.Size = new System.Drawing.Size(13, 13);
            this.resultF3.TabIndex = 48;
            this.resultF3.Text = "0";
            // 
            // resultF2
            // 
            this.resultF2.AutoSize = true;
            this.resultF2.Location = new System.Drawing.Point(623, 442);
            this.resultF2.Name = "resultF2";
            this.resultF2.Size = new System.Drawing.Size(13, 13);
            this.resultF2.TabIndex = 47;
            this.resultF2.Text = "0";
            // 
            // resultF1
            // 
            this.resultF1.AutoSize = true;
            this.resultF1.Location = new System.Drawing.Point(623, 427);
            this.resultF1.Name = "resultF1";
            this.resultF1.Size = new System.Drawing.Size(13, 13);
            this.resultF1.TabIndex = 46;
            this.resultF1.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CampusCaseReportFormApp.Properties.Resources.searchBox;
            this.pictureBox2.Location = new System.Drawing.Point(0, 407);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(810, 114);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CampusCaseReportFormApp.Properties.Resources.form04_01;
            this.pictureBox3.Location = new System.Drawing.Point(0, 515);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(810, 108);
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CampusCaseReportFormApp.Properties.Resources.form04;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 570);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(814, 621);
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
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SignDateDeptChair);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.SignNameDeptChair);
            this.Controls.Add(this.SignDeptChair);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.ExplainNo);
            this.Controls.Add(this.rbtNo);
            this.Controls.Add(this.rbtYes);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtYes;
        private System.Windows.Forms.RichTextBox ExplainNo;
        private System.Windows.Forms.RichTextBox Comments;
        private System.Windows.Forms.DateTimePicker SignDateDeptChair;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox SignNameDeptChair;
        private System.Windows.Forms.RichTextBox SignDeptChair;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox searchText;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultF5;
        private System.Windows.Forms.Label resultF4;
        private System.Windows.Forms.Label resultF3;
        private System.Windows.Forms.Label resultF2;
        private System.Windows.Forms.Label resultF1;
    }
}