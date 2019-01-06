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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.btn_RegisterCompany = new System.Windows.Forms.Button();
            this.lbl_ErrorMsg = new System.Windows.Forms.Label();
            this.chk_TermConditions = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location *";
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CompanyName.Location = new System.Drawing.Point(193, 41);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(100, 23);
            this.txt_CompanyName.TabIndex = 0;
            // 
            // txt_Location
            // 
            this.txt_Location.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Location.Location = new System.Drawing.Point(193, 77);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(100, 23);
            this.txt_Location.TabIndex = 1;
            // 
            // btn_RegisterCompany
            // 
            this.btn_RegisterCompany.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterCompany.Location = new System.Drawing.Point(198, 188);
            this.btn_RegisterCompany.Name = "btn_RegisterCompany";
            this.btn_RegisterCompany.Size = new System.Drawing.Size(95, 29);
            this.btn_RegisterCompany.TabIndex = 3;
            this.btn_RegisterCompany.Text = "Register";
            this.btn_RegisterCompany.UseVisualStyleBackColor = true;
            this.btn_RegisterCompany.Click += new System.EventHandler(this.btn_RegisterCompany_Click);
            // 
            // lbl_ErrorMsg
            // 
            this.lbl_ErrorMsg.AutoSize = true;
            this.lbl_ErrorMsg.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMsg.Location = new System.Drawing.Point(49, 155);
            this.lbl_ErrorMsg.Name = "lbl_ErrorMsg";
            this.lbl_ErrorMsg.Size = new System.Drawing.Size(130, 15);
            this.lbl_ErrorMsg.TabIndex = 27;
            this.lbl_ErrorMsg.Text = "All fields must be filled.";
            // 
            // chk_TermConditions
            // 
            this.chk_TermConditions.AutoSize = true;
            this.chk_TermConditions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_TermConditions.Location = new System.Drawing.Point(52, 117);
            this.chk_TermConditions.Name = "chk_TermConditions";
            this.chk_TermConditions.Size = new System.Drawing.Size(244, 19);
            this.chk_TermConditions.TabIndex = 2;
            this.chk_TermConditions.Text = "Company accepts terms and conditions *";
            this.chk_TermConditions.UseVisualStyleBackColor = true;
            // 
            // Form_RegisterCompany
            // 
            this.AcceptButton = this.btn_RegisterCompany;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 247);
            this.Controls.Add(this.chk_TermConditions);
            this.Controls.Add(this.lbl_ErrorMsg);
            this.Controls.Add(this.btn_RegisterCompany);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form_RegisterCompany";
            this.Text = "Register Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.Button btn_RegisterCompany;
        private System.Windows.Forms.Label lbl_ErrorMsg;
        private System.Windows.Forms.CheckBox chk_TermConditions;
    }
}

