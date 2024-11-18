namespace CampusCaseReportFormApp
{
    partial class Form3
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
            this.SignDateFacMem = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SignNameFacMem = new System.Windows.Forms.RichTextBox();
            this.SignFacMem = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignDateFacMem
            // 
            this.SignDateFacMem.CustomFormat = "yyyy-MM-dd";
            this.SignDateFacMem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SignDateFacMem.Location = new System.Drawing.Point(612, 299);
            this.SignDateFacMem.Name = "SignDateFacMem";
            this.SignDateFacMem.Size = new System.Drawing.Size(171, 20);
            this.SignDateFacMem.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSubmit.Location = new System.Drawing.Point(370, 335);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // SignNameFacMem
            // 
            this.SignNameFacMem.BackColor = System.Drawing.Color.Gainsboro;
            this.SignNameFacMem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignNameFacMem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignNameFacMem.Location = new System.Drawing.Point(333, 289);
            this.SignNameFacMem.Name = "SignNameFacMem";
            this.SignNameFacMem.Size = new System.Drawing.Size(273, 30);
            this.SignNameFacMem.TabIndex = 1;
            this.SignNameFacMem.Text = "";
            // 
            // SignFacMem
            // 
            this.SignFacMem.BackColor = System.Drawing.Color.Gainsboro;
            this.SignFacMem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignFacMem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SignFacMem.Location = new System.Drawing.Point(36, 289);
            this.SignFacMem.Name = "SignFacMem";
            this.SignFacMem.Size = new System.Drawing.Size(291, 30);
            this.SignFacMem.TabIndex = 0;
            this.SignFacMem.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CampusCaseReportFormApp.Properties.Resources.form03;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 370);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(814, 371);
            this.Controls.Add(this.SignDateFacMem);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.SignNameFacMem);
            this.Controls.Add(this.SignFacMem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SignDateFacMem;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox SignNameFacMem;
        private System.Windows.Forms.RichTextBox SignFacMem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}