namespace KF7012_Assignment
{
    partial class Form_Menu_User
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
            this.btn_RegisterJob = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_RegisterCompany
            // 
            this.btn_RegisterCompany.Location = new System.Drawing.Point(89, 87);
            this.btn_RegisterCompany.Name = "btn_RegisterCompany";
            this.btn_RegisterCompany.Size = new System.Drawing.Size(132, 23);
            this.btn_RegisterCompany.TabIndex = 0;
            this.btn_RegisterCompany.Text = "Register Company";
            this.btn_RegisterCompany.UseVisualStyleBackColor = true;
            this.btn_RegisterCompany.Click += new System.EventHandler(this.btn_RegisterCompany_Click);
            // 
            // btn_RegisterJob
            // 
            this.btn_RegisterJob.Location = new System.Drawing.Point(89, 116);
            this.btn_RegisterJob.Name = "btn_RegisterJob";
            this.btn_RegisterJob.Size = new System.Drawing.Size(132, 23);
            this.btn_RegisterJob.TabIndex = 1;
            this.btn_RegisterJob.Text = "Register Job";
            this.btn_RegisterJob.UseVisualStyleBackColor = true;
            this.btn_RegisterJob.Click += new System.EventHandler(this.btn_RegisterJob_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NPD Consultancies";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "View All Jobs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Jobs_Click);
            // 
            // Form_Menu_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 217);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_RegisterJob);
            this.Controls.Add(this.btn_RegisterCompany);
            this.Name = "Form_Menu_User";
            this.Text = "Menu - Logged in as User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RegisterCompany;
        private System.Windows.Forms.Button btn_RegisterJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}