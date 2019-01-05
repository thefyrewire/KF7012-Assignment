namespace KF7012_Assignment
{
    partial class Form_JobDetails
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
            this.txt_CompanyID = new System.Windows.Forms.TextBox();
            this.lbl_CompanyID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_CompanyID
            // 
            this.txt_CompanyID.Location = new System.Drawing.Point(158, 22);
            this.txt_CompanyID.Name = "txt_CompanyID";
            this.txt_CompanyID.Size = new System.Drawing.Size(144, 20);
            this.txt_CompanyID.TabIndex = 24;
            // 
            // lbl_CompanyID
            // 
            this.lbl_CompanyID.AutoSize = true;
            this.lbl_CompanyID.Location = new System.Drawing.Point(18, 25);
            this.lbl_CompanyID.Name = "lbl_CompanyID";
            this.lbl_CompanyID.Size = new System.Drawing.Size(72, 13);
            this.lbl_CompanyID.TabIndex = 25;
            this.lbl_CompanyID.Text = "Company ID *";
            // 
            // Form_JobDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 459);
            this.Controls.Add(this.txt_CompanyID);
            this.Controls.Add(this.lbl_CompanyID);
            this.Name = "Form_JobDetails";
            this.Text = "Form_JobDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CompanyID;
        private System.Windows.Forms.Label lbl_CompanyID;
    }
}