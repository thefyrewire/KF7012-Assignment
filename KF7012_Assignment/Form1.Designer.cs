namespace KF7012_Assignment
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
            this.btn_RegisterCompany = new System.Windows.Forms.Button();
            this.btn_Jobs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_RegisterCompany
            // 
            this.btn_RegisterCompany.Location = new System.Drawing.Point(127, 142);
            this.btn_RegisterCompany.Name = "btn_RegisterCompany";
            this.btn_RegisterCompany.Size = new System.Drawing.Size(132, 23);
            this.btn_RegisterCompany.TabIndex = 0;
            this.btn_RegisterCompany.Text = "Register Company";
            this.btn_RegisterCompany.UseVisualStyleBackColor = true;
            this.btn_RegisterCompany.Click += new System.EventHandler(this.btn_RegisterCompany_Click);
            // 
            // btn_Jobs
            // 
            this.btn_Jobs.Location = new System.Drawing.Point(501, 142);
            this.btn_Jobs.Name = "btn_Jobs";
            this.btn_Jobs.Size = new System.Drawing.Size(75, 23);
            this.btn_Jobs.TabIndex = 1;
            this.btn_Jobs.Text = "Jobs";
            this.btn_Jobs.UseVisualStyleBackColor = true;
            this.btn_Jobs.Click += new System.EventHandler(this.btn_Jobs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NPD Consultancies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Jobs);
            this.Controls.Add(this.btn_RegisterCompany);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RegisterCompany;
        private System.Windows.Forms.Button btn_Jobs;
        private System.Windows.Forms.Label label1;
    }
}