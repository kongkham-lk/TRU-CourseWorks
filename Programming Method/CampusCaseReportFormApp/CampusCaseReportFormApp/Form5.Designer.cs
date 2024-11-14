namespace CampusCaseReportFormApp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignDateDean = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SignNameDean = new System.Windows.Forms.RichTextBox();
            this.SignDean = new System.Windows.Forms.RichTextBox();
            this.Comments = new System.Windows.Forms.RichTextBox();
            this.ExplainNo = new System.Windows.Forms.RichTextBox();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtYes = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CampusCaseReportFormApp.Properties.Resources.form05;
            this.pictureBox1.Location = new System.Drawing.Point(0, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 583);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // SignDateDean
            // 
            this.SignDateDean.CustomFormat = "yyyy-MM-dd";
            this.SignDateDean.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SignDateDean.Location = new System.Drawing.Point(612, 536);
            this.SignDateDean.Name = "SignDateDean";
            this.SignDateDean.Size = new System.Drawing.Size(173, 20);
            this.SignDateDean.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubmit.Location = new System.Drawing.Point(369, 568);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // SignNameDean
            // 
            this.SignNameDean.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignNameDean.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignNameDean.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignNameDean.Location = new System.Drawing.Point(278, 524);
            this.SignNameDean.Name = "SignNameDean";
            this.SignNameDean.Size = new System.Drawing.Size(328, 30);
            this.SignNameDean.TabIndex = 5;
            this.SignNameDean.Text = "";
            // 
            // SignDean
            // 
            this.SignDean.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignDean.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignDean.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignDean.Location = new System.Drawing.Point(37, 524);
            this.SignDean.Name = "SignDean";
            this.SignDean.Size = new System.Drawing.Size(235, 30);
            this.SignDean.TabIndex = 4;
            this.SignDean.Text = "";
            // 
            // Comments
            // 
            this.Comments.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Comments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Comments.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Comments.Location = new System.Drawing.Point(37, 427);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(747, 60);
            this.Comments.TabIndex = 3;
            this.Comments.Text = "";
            // 
            // ExplainNo
            // 
            this.ExplainNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExplainNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExplainNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ExplainNo.Location = new System.Drawing.Point(258, 376);
            this.ExplainNo.Name = "ExplainNo";
            this.ExplainNo.Size = new System.Drawing.Size(526, 28);
            this.ExplainNo.TabIndex = 2;
            this.ExplainNo.Text = "";
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtNo.Location = new System.Drawing.Point(204, 382);
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
            this.rbtYes.Location = new System.Drawing.Point(204, 359);
            this.rbtYes.Name = "rbtYes";
            this.rbtYes.Size = new System.Drawing.Size(43, 17);
            this.rbtYes.TabIndex = 0;
            this.rbtYes.Text = "Yes";
            this.rbtYes.UseVisualStyleBackColor = false;
            this.rbtYes.CheckedChanged += new System.EventHandler(this.rbtYes_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(194, 354);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 51);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(799, 535);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 65);
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(819, 600);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.ExplainNo);
            this.Controls.Add(this.rbtNo);
            this.Controls.Add(this.rbtYes);
            this.Controls.Add(this.SignDateDean);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.SignNameDean);
            this.Controls.Add(this.SignDean);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}