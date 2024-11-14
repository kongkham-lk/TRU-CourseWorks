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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.ExplainNo.Location = new System.Drawing.Point(257, 295);
            this.ExplainNo.Name = "ExplainNo";
            this.ExplainNo.Size = new System.Drawing.Size(525, 28);
            this.ExplainNo.TabIndex = 2;
            this.ExplainNo.Text = "";
            // 
            // Comments
            // 
            this.Comments.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Comments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Comments.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Comments.Location = new System.Drawing.Point(37, 344);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(746, 62);
            this.Comments.TabIndex = 3;
            this.Comments.Text = "";
            // 
            // SignDateDeptChair
            // 
            this.SignDateDeptChair.CustomFormat = "yyyy-MM-dd";
            this.SignDateDeptChair.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SignDateDeptChair.Location = new System.Drawing.Point(611, 454);
            this.SignDateDeptChair.Name = "SignDateDeptChair";
            this.SignDateDeptChair.Size = new System.Drawing.Size(173, 20);
            this.SignDateDeptChair.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubmit.Location = new System.Drawing.Point(368, 487);
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
            this.SignNameDeptChair.Location = new System.Drawing.Point(277, 443);
            this.SignNameDeptChair.Name = "SignNameDeptChair";
            this.SignNameDeptChair.Size = new System.Drawing.Size(328, 30);
            this.SignNameDeptChair.TabIndex = 5;
            this.SignNameDeptChair.Text = "";
            // 
            // SignDeptChair
            // 
            this.SignDeptChair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignDeptChair.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignDeptChair.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignDeptChair.Location = new System.Drawing.Point(37, 443);
            this.SignDeptChair.Name = "SignDeptChair";
            this.SignDeptChair.Size = new System.Drawing.Size(234, 30);
            this.SignDeptChair.TabIndex = 4;
            this.SignDeptChair.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(192, 273);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 51);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CampusCaseReportFormApp.Properties.Resources.form04;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 520);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(819, 518);
            this.Controls.Add(this.SignDateDeptChair);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.SignNameDeptChair);
            this.Controls.Add(this.SignDeptChair);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.ExplainNo);
            this.Controls.Add(this.rbtNo);
            this.Controls.Add(this.rbtYes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtYes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox ExplainNo;
        private System.Windows.Forms.RichTextBox Comments;
        private System.Windows.Forms.DateTimePicker SignDateDeptChair;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox SignNameDeptChair;
        private System.Windows.Forms.RichTextBox SignDeptChair;
    }
}