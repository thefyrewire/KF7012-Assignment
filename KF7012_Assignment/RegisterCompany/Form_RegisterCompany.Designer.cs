namespace KF7012_Assignment
{
    partial class Form_RegisterCompany
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_RegisterCompany = new System.Windows.Forms.Button();
            this.lbl_ErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Machine ID";
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Location = new System.Drawing.Point(156, 35);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(100, 20);
            this.txt_CompanyName.TabIndex = 4;
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(156, 76);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(100, 20);
            this.txt_Location.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(156, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btn_RegisterCompany
            // 
            this.btn_RegisterCompany.Location = new System.Drawing.Point(91, 184);
            this.btn_RegisterCompany.Name = "btn_RegisterCompany";
            this.btn_RegisterCompany.Size = new System.Drawing.Size(75, 23);
            this.btn_RegisterCompany.TabIndex = 7;
            this.btn_RegisterCompany.Text = "Register";
            this.btn_RegisterCompany.UseVisualStyleBackColor = true;
            this.btn_RegisterCompany.Click += new System.EventHandler(this.btn_RegisterCompany_Click);
            // 
            // lbl_ErrorMsg
            // 
            this.lbl_ErrorMsg.AutoSize = true;
            this.lbl_ErrorMsg.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMsg.Location = new System.Drawing.Point(12, 155);
            this.lbl_ErrorMsg.Name = "lbl_ErrorMsg";
            this.lbl_ErrorMsg.Size = new System.Drawing.Size(171, 13);
            this.lbl_ErrorMsg.TabIndex = 27;
            this.lbl_ErrorMsg.Text = "Username and password incorrect!";
            // 
            // Form_RegisterCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 259);
            this.Controls.Add(this.lbl_ErrorMsg);
            this.Controls.Add(this.btn_RegisterCompany);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_RegisterCompany";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_RegisterCompany;
        private System.Windows.Forms.Label lbl_ErrorMsg;
    }
}

