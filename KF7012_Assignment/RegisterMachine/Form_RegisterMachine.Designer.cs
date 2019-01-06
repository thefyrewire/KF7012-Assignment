namespace KF7012_Assignment
{
    partial class Form_RegisterMachine
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
            this.btn_Register = new System.Windows.Forms.Button();
            this.lbl_AssetTag = new System.Windows.Forms.Label();
            this.lbl_SizeComplexity = new System.Windows.Forms.Label();
            this.txt_AssetTag = new System.Windows.Forms.TextBox();
            this.lbl_CompanyID = new System.Windows.Forms.Label();
            this.txt_CompanyID = new System.Windows.Forms.TextBox();
            this.trb_SizeComplexity = new System.Windows.Forms.TrackBar();
            this.lbl_SizeComplexityValue = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trb_SizeComplexity)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(27, 260);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 3;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // lbl_AssetTag
            // 
            this.lbl_AssetTag.AutoSize = true;
            this.lbl_AssetTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AssetTag.Location = new System.Drawing.Point(24, 75);
            this.lbl_AssetTag.Name = "lbl_AssetTag";
            this.lbl_AssetTag.Size = new System.Drawing.Size(57, 15);
            this.lbl_AssetTag.TabIndex = 3;
            this.lbl_AssetTag.Text = "Asset Tag";
            // 
            // lbl_SizeComplexity
            // 
            this.lbl_SizeComplexity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SizeComplexity.Location = new System.Drawing.Point(24, 118);
            this.lbl_SizeComplexity.Name = "lbl_SizeComplexity";
            this.lbl_SizeComplexity.Size = new System.Drawing.Size(96, 45);
            this.lbl_SizeComplexity.TabIndex = 4;
            this.lbl_SizeComplexity.Text = "Machine Size and Complexity";
            // 
            // txt_AssetTag
            // 
            this.txt_AssetTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AssetTag.Location = new System.Drawing.Point(152, 75);
            this.txt_AssetTag.Name = "txt_AssetTag";
            this.txt_AssetTag.Size = new System.Drawing.Size(229, 23);
            this.txt_AssetTag.TabIndex = 0;
            // 
            // lbl_CompanyID
            // 
            this.lbl_CompanyID.AutoSize = true;
            this.lbl_CompanyID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompanyID.Location = new System.Drawing.Point(24, 29);
            this.lbl_CompanyID.Name = "lbl_CompanyID";
            this.lbl_CompanyID.Size = new System.Drawing.Size(73, 15);
            this.lbl_CompanyID.TabIndex = 9;
            this.lbl_CompanyID.Text = "Company ID";
            // 
            // txt_CompanyID
            // 
            this.txt_CompanyID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CompanyID.Location = new System.Drawing.Point(152, 26);
            this.txt_CompanyID.Name = "txt_CompanyID";
            this.txt_CompanyID.ReadOnly = true;
            this.txt_CompanyID.Size = new System.Drawing.Size(229, 23);
            this.txt_CompanyID.TabIndex = 4;
            // 
            // trb_SizeComplexity
            // 
            this.trb_SizeComplexity.LargeChange = 1;
            this.trb_SizeComplexity.Location = new System.Drawing.Point(180, 118);
            this.trb_SizeComplexity.Maximum = 5;
            this.trb_SizeComplexity.Name = "trb_SizeComplexity";
            this.trb_SizeComplexity.Size = new System.Drawing.Size(201, 45);
            this.trb_SizeComplexity.TabIndex = 1;
            this.trb_SizeComplexity.ValueChanged += new System.EventHandler(this.trb_SizeComplexity_ValueChanged);
            // 
            // lbl_SizeComplexityValue
            // 
            this.lbl_SizeComplexityValue.AutoSize = true;
            this.lbl_SizeComplexityValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SizeComplexityValue.Location = new System.Drawing.Point(155, 118);
            this.lbl_SizeComplexityValue.Name = "lbl_SizeComplexityValue";
            this.lbl_SizeComplexityValue.Size = new System.Drawing.Size(19, 21);
            this.lbl_SizeComplexityValue.TabIndex = 12;
            this.lbl_SizeComplexityValue.Text = "0";
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.Location = new System.Drawing.Point(152, 169);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(229, 61);
            this.txt_Description.TabIndex = 2;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(24, 169);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(67, 15);
            this.lbl_Description.TabIndex = 14;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(156, 265);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(130, 15);
            this.lbl_Error.TabIndex = 15;
            this.lbl_Error.Text = "All fields must be filled.";
            // 
            // Form_RegisterMachine
            // 
            this.AcceptButton = this.btn_Register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 306);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_SizeComplexityValue);
            this.Controls.Add(this.trb_SizeComplexity);
            this.Controls.Add(this.txt_CompanyID);
            this.Controls.Add(this.lbl_CompanyID);
            this.Controls.Add(this.txt_AssetTag);
            this.Controls.Add(this.lbl_SizeComplexity);
            this.Controls.Add(this.lbl_AssetTag);
            this.Controls.Add(this.btn_Register);
            this.Name = "Form_RegisterMachine";
            this.Text = "Register Machine";
            ((System.ComponentModel.ISupportInitialize)(this.trb_SizeComplexity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label lbl_AssetTag;
        private System.Windows.Forms.Label lbl_SizeComplexity;
        private System.Windows.Forms.TextBox txt_AssetTag;
        private System.Windows.Forms.Label lbl_CompanyID;
        private System.Windows.Forms.TextBox txt_CompanyID;
        private System.Windows.Forms.TrackBar trb_SizeComplexity;
        private System.Windows.Forms.Label lbl_SizeComplexityValue;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Error;
    }
}