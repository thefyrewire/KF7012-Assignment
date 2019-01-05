namespace KF7012_Assignment
{
    partial class Form_RegisterJob
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
            this.lbl_FaultError = new System.Windows.Forms.Label();
            this.lbl_UrgencyValue = new System.Windows.Forms.Label();
            this.trb_Urgency = new System.Windows.Forms.TrackBar();
            this.lbl_Urgency = new System.Windows.Forms.Label();
            this.lbl_AssetTag = new System.Windows.Forms.Label();
            this.txt_AssetTag = new System.Windows.Forms.TextBox();
            this.cmb_MachineID = new System.Windows.Forms.ComboBox();
            this.txt_CompanyID = new System.Windows.Forms.TextBox();
            this.lbl_CompanyID = new System.Windows.Forms.Label();
            this.btn_RegisterJob = new System.Windows.Forms.Button();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.btn_RegisterMachine = new System.Windows.Forms.Button();
            this.lbl_SizeComplexity = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Fault = new System.Windows.Forms.Label();
            this.lbl_MachineID = new System.Windows.Forms.Label();
            this.txt_Fault = new System.Windows.Forms.TextBox();
            this.txt_SizeComplexity = new System.Windows.Forms.TextBox();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Urgency)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jobs";
            // 
            // lbl_FaultError
            // 
            this.lbl_FaultError.AutoSize = true;
            this.lbl_FaultError.ForeColor = System.Drawing.Color.Red;
            this.lbl_FaultError.Location = new System.Drawing.Point(401, 330);
            this.lbl_FaultError.Name = "lbl_FaultError";
            this.lbl_FaultError.Size = new System.Drawing.Size(103, 13);
            this.lbl_FaultError.TabIndex = 53;
            this.lbl_FaultError.Text = "This field is required.";
            // 
            // lbl_UrgencyValue
            // 
            this.lbl_UrgencyValue.AutoSize = true;
            this.lbl_UrgencyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UrgencyValue.Location = new System.Drawing.Point(170, 408);
            this.lbl_UrgencyValue.Name = "lbl_UrgencyValue";
            this.lbl_UrgencyValue.Size = new System.Drawing.Size(16, 16);
            this.lbl_UrgencyValue.TabIndex = 52;
            this.lbl_UrgencyValue.Text = "0";
            // 
            // trb_Urgency
            // 
            this.trb_Urgency.BackColor = System.Drawing.SystemColors.Control;
            this.trb_Urgency.LargeChange = 1;
            this.trb_Urgency.Location = new System.Drawing.Point(194, 403);
            this.trb_Urgency.Maximum = 5;
            this.trb_Urgency.Name = "trb_Urgency";
            this.trb_Urgency.Size = new System.Drawing.Size(201, 45);
            this.trb_Urgency.TabIndex = 4;
            this.trb_Urgency.ValueChanged += new System.EventHandler(this.trb_Urgency_ValueChanged);
            // 
            // lbl_Urgency
            // 
            this.lbl_Urgency.AutoSize = true;
            this.lbl_Urgency.Location = new System.Drawing.Point(30, 403);
            this.lbl_Urgency.Name = "lbl_Urgency";
            this.lbl_Urgency.Size = new System.Drawing.Size(54, 13);
            this.lbl_Urgency.TabIndex = 50;
            this.lbl_Urgency.Text = "Urgency *";
            // 
            // lbl_AssetTag
            // 
            this.lbl_AssetTag.AutoSize = true;
            this.lbl_AssetTag.Location = new System.Drawing.Point(30, 196);
            this.lbl_AssetTag.Name = "lbl_AssetTag";
            this.lbl_AssetTag.Size = new System.Drawing.Size(55, 13);
            this.lbl_AssetTag.TabIndex = 49;
            this.lbl_AssetTag.Text = "Asset Tag";
            // 
            // txt_AssetTag
            // 
            this.txt_AssetTag.Location = new System.Drawing.Point(170, 193);
            this.txt_AssetTag.Name = "txt_AssetTag";
            this.txt_AssetTag.Size = new System.Drawing.Size(144, 20);
            this.txt_AssetTag.TabIndex = 8;
            // 
            // cmb_MachineID
            // 
            this.cmb_MachineID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MachineID.FormattingEnabled = true;
            this.cmb_MachineID.Location = new System.Drawing.Point(170, 166);
            this.cmb_MachineID.Name = "cmb_MachineID";
            this.cmb_MachineID.Size = new System.Drawing.Size(144, 21);
            this.cmb_MachineID.TabIndex = 1;
            this.cmb_MachineID.SelectedIndexChanged += new System.EventHandler(this.cmb_MachineID_Leave);
            this.cmb_MachineID.Leave += new System.EventHandler(this.cmb_MachineID_Leave);
            // 
            // txt_CompanyID
            // 
            this.txt_CompanyID.Location = new System.Drawing.Point(170, 62);
            this.txt_CompanyID.Name = "txt_CompanyID";
            this.txt_CompanyID.Size = new System.Drawing.Size(144, 20);
            this.txt_CompanyID.TabIndex = 0;
            this.txt_CompanyID.Leave += new System.EventHandler(this.txt_CompanyID_Leave);
            // 
            // lbl_CompanyID
            // 
            this.lbl_CompanyID.AutoSize = true;
            this.lbl_CompanyID.Location = new System.Drawing.Point(30, 65);
            this.lbl_CompanyID.Name = "lbl_CompanyID";
            this.lbl_CompanyID.Size = new System.Drawing.Size(72, 13);
            this.lbl_CompanyID.TabIndex = 48;
            this.lbl_CompanyID.Text = "Company ID *";
            // 
            // btn_RegisterJob
            // 
            this.btn_RegisterJob.Location = new System.Drawing.Point(33, 473);
            this.btn_RegisterJob.Name = "btn_RegisterJob";
            this.btn_RegisterJob.Size = new System.Drawing.Size(94, 28);
            this.btn_RegisterJob.TabIndex = 5;
            this.btn_RegisterJob.Text = "Register";
            this.btn_RegisterJob.UseVisualStyleBackColor = true;
            this.btn_RegisterJob.Click += new System.EventHandler(this.btn_RegisterJob_Click);
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(170, 245);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(225, 56);
            this.txt_Description.TabIndex = 10;
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(30, 117);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(48, 13);
            this.lbl_Location.TabIndex = 47;
            this.lbl_Location.Text = "Location";
            // 
            // btn_RegisterMachine
            // 
            this.btn_RegisterMachine.Location = new System.Drawing.Point(337, 161);
            this.btn_RegisterMachine.Name = "btn_RegisterMachine";
            this.btn_RegisterMachine.Size = new System.Drawing.Size(94, 28);
            this.btn_RegisterMachine.TabIndex = 2;
            this.btn_RegisterMachine.Text = "Add a Machine";
            this.btn_RegisterMachine.UseVisualStyleBackColor = true;
            this.btn_RegisterMachine.Click += new System.EventHandler(this.btn_RegisterMachine_Click);
            // 
            // lbl_SizeComplexity
            // 
            this.lbl_SizeComplexity.AutoSize = true;
            this.lbl_SizeComplexity.Location = new System.Drawing.Point(30, 222);
            this.lbl_SizeComplexity.Name = "lbl_SizeComplexity";
            this.lbl_SizeComplexity.Size = new System.Drawing.Size(101, 13);
            this.lbl_SizeComplexity.TabIndex = 46;
            this.lbl_SizeComplexity.Text = "Size and Complexity";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(30, 248);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(60, 13);
            this.lbl_Description.TabIndex = 44;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_Fault
            // 
            this.lbl_Fault.AutoSize = true;
            this.lbl_Fault.Location = new System.Drawing.Point(30, 330);
            this.lbl_Fault.Name = "lbl_Fault";
            this.lbl_Fault.Size = new System.Drawing.Size(37, 13);
            this.lbl_Fault.TabIndex = 43;
            this.lbl_Fault.Text = "Fault *";
            // 
            // lbl_MachineID
            // 
            this.lbl_MachineID.AutoSize = true;
            this.lbl_MachineID.Location = new System.Drawing.Point(30, 169);
            this.lbl_MachineID.Name = "lbl_MachineID";
            this.lbl_MachineID.Size = new System.Drawing.Size(69, 13);
            this.lbl_MachineID.TabIndex = 42;
            this.lbl_MachineID.Text = "Machine ID *";
            // 
            // txt_Fault
            // 
            this.txt_Fault.Location = new System.Drawing.Point(170, 327);
            this.txt_Fault.Multiline = true;
            this.txt_Fault.Name = "txt_Fault";
            this.txt_Fault.Size = new System.Drawing.Size(225, 56);
            this.txt_Fault.TabIndex = 3;
            // 
            // txt_SizeComplexity
            // 
            this.txt_SizeComplexity.Location = new System.Drawing.Point(170, 219);
            this.txt_SizeComplexity.Name = "txt_SizeComplexity";
            this.txt_SizeComplexity.Size = new System.Drawing.Size(144, 20);
            this.txt_SizeComplexity.TabIndex = 9;
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(170, 114);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(144, 20);
            this.txt_Location.TabIndex = 7;
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Location = new System.Drawing.Point(170, 88);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(144, 20);
            this.txt_CompanyName.TabIndex = 6;
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AutoSize = true;
            this.lbl_CompanyName.Location = new System.Drawing.Point(30, 91);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(94, 13);
            this.lbl_CompanyName.TabIndex = 30;
            this.lbl_CompanyName.Text = "Name of Company";
            // 
            // Form_RegisterJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 520);
            this.Controls.Add(this.lbl_FaultError);
            this.Controls.Add(this.lbl_UrgencyValue);
            this.Controls.Add(this.trb_Urgency);
            this.Controls.Add(this.lbl_Urgency);
            this.Controls.Add(this.lbl_AssetTag);
            this.Controls.Add(this.txt_AssetTag);
            this.Controls.Add(this.cmb_MachineID);
            this.Controls.Add(this.txt_CompanyID);
            this.Controls.Add(this.lbl_CompanyID);
            this.Controls.Add(this.btn_RegisterJob);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.btn_RegisterMachine);
            this.Controls.Add(this.lbl_SizeComplexity);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Fault);
            this.Controls.Add(this.lbl_MachineID);
            this.Controls.Add(this.txt_Fault);
            this.Controls.Add(this.txt_SizeComplexity);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.lbl_CompanyName);
            this.Controls.Add(this.label1);
            this.Name = "Form_RegisterJob";
            this.Text = "Register a Job";
            ((System.ComponentModel.ISupportInitialize)(this.trb_Urgency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_FaultError;
        private System.Windows.Forms.Label lbl_UrgencyValue;
        private System.Windows.Forms.TrackBar trb_Urgency;
        private System.Windows.Forms.Label lbl_Urgency;
        private System.Windows.Forms.Label lbl_AssetTag;
        private System.Windows.Forms.TextBox txt_AssetTag;
        private System.Windows.Forms.ComboBox cmb_MachineID;
        private System.Windows.Forms.TextBox txt_CompanyID;
        private System.Windows.Forms.Label lbl_CompanyID;
        private System.Windows.Forms.Button btn_RegisterJob;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Button btn_RegisterMachine;
        private System.Windows.Forms.Label lbl_SizeComplexity;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Fault;
        private System.Windows.Forms.Label lbl_MachineID;
        private System.Windows.Forms.TextBox txt_Fault;
        private System.Windows.Forms.TextBox txt_SizeComplexity;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private System.Windows.Forms.Label lbl_CompanyName;

    }
}