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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_AssetTag = new System.Windows.Forms.Label();
            this.lbl_SizeComplexity = new System.Windows.Forms.Label();
            this.txt_AssetTag = new System.Windows.Forms.TextBox();
            this.lbl_CompanyID = new System.Windows.Forms.Label();
            this.txt_CompanyID = new System.Windows.Forms.TextBox();
            this.trb_SizeComplexity = new System.Windows.Forms.TrackBar();
            this.lbl_SizeComplexityValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trb_SizeComplexity)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Register A Machine";
            // 
            // lbl_AssetTag
            // 
            this.lbl_AssetTag.AutoSize = true;
            this.lbl_AssetTag.Location = new System.Drawing.Point(27, 110);
            this.lbl_AssetTag.Name = "lbl_AssetTag";
            this.lbl_AssetTag.Size = new System.Drawing.Size(55, 13);
            this.lbl_AssetTag.TabIndex = 3;
            this.lbl_AssetTag.Text = "Asset Tag";
            // 
            // lbl_SizeComplexity
            // 
            this.lbl_SizeComplexity.Location = new System.Drawing.Point(27, 153);
            this.lbl_SizeComplexity.Name = "lbl_SizeComplexity";
            this.lbl_SizeComplexity.Size = new System.Drawing.Size(87, 30);
            this.lbl_SizeComplexity.TabIndex = 4;
            this.lbl_SizeComplexity.Text = "Machine Size and Complexity";
            // 
            // txt_AssetTag
            // 
            this.txt_AssetTag.Location = new System.Drawing.Point(120, 110);
            this.txt_AssetTag.Name = "txt_AssetTag";
            this.txt_AssetTag.Size = new System.Drawing.Size(229, 20);
            this.txt_AssetTag.TabIndex = 6;
            // 
            // lbl_CompanyID
            // 
            this.lbl_CompanyID.AutoSize = true;
            this.lbl_CompanyID.Location = new System.Drawing.Point(27, 64);
            this.lbl_CompanyID.Name = "lbl_CompanyID";
            this.lbl_CompanyID.Size = new System.Drawing.Size(65, 13);
            this.lbl_CompanyID.TabIndex = 9;
            this.lbl_CompanyID.Text = "Company ID";
            // 
            // txt_CompanyID
            // 
            this.txt_CompanyID.Location = new System.Drawing.Point(120, 61);
            this.txt_CompanyID.Name = "txt_CompanyID";
            this.txt_CompanyID.ReadOnly = true;
            this.txt_CompanyID.Size = new System.Drawing.Size(229, 20);
            this.txt_CompanyID.TabIndex = 10;
            // 
            // trb_SizeComplexity
            // 
            this.trb_SizeComplexity.LargeChange = 1;
            this.trb_SizeComplexity.Location = new System.Drawing.Point(148, 153);
            this.trb_SizeComplexity.Maximum = 5;
            this.trb_SizeComplexity.Minimum = 1;
            this.trb_SizeComplexity.Name = "trb_SizeComplexity";
            this.trb_SizeComplexity.Size = new System.Drawing.Size(201, 45);
            this.trb_SizeComplexity.TabIndex = 11;
            this.trb_SizeComplexity.Value = 1;
            this.trb_SizeComplexity.ValueChanged += new System.EventHandler(this.trb_SizeComplexity_ValueChanged);
            // 
            // lbl_SizeComplexityValue
            // 
            this.lbl_SizeComplexityValue.AutoSize = true;
            this.lbl_SizeComplexityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SizeComplexityValue.Location = new System.Drawing.Point(124, 158);
            this.lbl_SizeComplexityValue.Name = "lbl_SizeComplexityValue";
            this.lbl_SizeComplexityValue.Size = new System.Drawing.Size(16, 16);
            this.lbl_SizeComplexityValue.TabIndex = 12;
            this.lbl_SizeComplexityValue.Text = "1";
            // 
            // Form_RegisterMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 418);
            this.Controls.Add(this.lbl_SizeComplexityValue);
            this.Controls.Add(this.trb_SizeComplexity);
            this.Controls.Add(this.txt_CompanyID);
            this.Controls.Add(this.lbl_CompanyID);
            this.Controls.Add(this.txt_AssetTag);
            this.Controls.Add(this.lbl_SizeComplexity);
            this.Controls.Add(this.lbl_AssetTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form_RegisterMachine";
            this.Text = "Form_RegisterMachine";
            ((System.ComponentModel.ISupportInitialize)(this.trb_SizeComplexity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_AssetTag;
        private System.Windows.Forms.Label lbl_SizeComplexity;
        private System.Windows.Forms.TextBox txt_AssetTag;
        private System.Windows.Forms.Label lbl_CompanyID;
        private System.Windows.Forms.TextBox txt_CompanyID;
        private System.Windows.Forms.TrackBar trb_SizeComplexity;
        private System.Windows.Forms.Label lbl_SizeComplexityValue;
    }
}