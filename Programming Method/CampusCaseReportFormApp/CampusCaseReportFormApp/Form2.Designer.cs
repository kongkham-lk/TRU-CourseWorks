namespace CampusCaseReportFormApp
{
    partial class Form2
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
            this.rbtYes = new System.Windows.Forms.RadioButton();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.StudentName = new System.Windows.Forms.RichTextBox();
            this.TRUEmail = new System.Windows.Forms.RichTextBox();
            this.SignStudent = new System.Windows.Forms.RichTextBox();
            this.SignDateStudent = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtYes
            // 
            this.rbtYes.AutoSize = true;
            this.rbtYes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtYes.Location = new System.Drawing.Point(278, 499);
            this.rbtYes.Name = "rbtYes";
            this.rbtYes.Size = new System.Drawing.Size(43, 17);
            this.rbtYes.TabIndex = 1;
            this.rbtYes.TabStop = true;
            this.rbtYes.Text = "Yes";
            this.rbtYes.UseVisualStyleBackColor = false;
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtNo.Location = new System.Drawing.Point(340, 499);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(39, 17);
            this.rbtNo.TabIndex = 2;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = false;
            // 
            // StudentName
            // 
            this.StudentName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StudentName.Location = new System.Drawing.Point(43, 264);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(316, 18);
            this.StudentName.TabIndex = 0;
            this.StudentName.Text = "";
            // 
            // TRUEmail
            // 
            this.TRUEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TRUEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TRUEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TRUEmail.Location = new System.Drawing.Point(38, 554);
            this.TRUEmail.Name = "TRUEmail";
            this.TRUEmail.Size = new System.Drawing.Size(448, 28);
            this.TRUEmail.TabIndex = 3;
            this.TRUEmail.Text = "";
            // 
            // SignStudent
            // 
            this.SignStudent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignStudent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignStudent.Location = new System.Drawing.Point(38, 623);
            this.SignStudent.Name = "SignStudent";
            this.SignStudent.Size = new System.Drawing.Size(569, 28);
            this.SignStudent.TabIndex = 4;
            this.SignStudent.Text = "";
            // 
            // SignDateStudent
            // 
            this.SignDateStudent.CustomFormat = "yyyy-MM-dd";
            this.SignDateStudent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SignDateStudent.Location = new System.Drawing.Point(612, 631);
            this.SignDateStudent.Name = "SignDateStudent";
            this.SignDateStudent.Size = new System.Drawing.Size(173, 20);
            this.SignDateStudent.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubmit.Location = new System.Drawing.Point(377, 683);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(72, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(228, 484);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 45);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CampusCaseReportFormApp.Properties.Resources.form02;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 715);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(814, 696);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.SignDateStudent);
            this.Controls.Add(this.SignStudent);
            this.Controls.Add(this.TRUEmail);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.rbtNo);
            this.Controls.Add(this.rbtYes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbtYes;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RichTextBox StudentName;
        private System.Windows.Forms.RichTextBox TRUEmail;
        private System.Windows.Forms.RichTextBox SignStudent;
        private System.Windows.Forms.DateTimePicker SignDateStudent;
        private System.Windows.Forms.Button btnSubmit;
    }
}