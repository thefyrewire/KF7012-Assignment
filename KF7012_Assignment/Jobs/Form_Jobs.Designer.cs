namespace KF7012_Assignment
{
    partial class Form_Jobs
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
            this.dgv_Jobs = new System.Windows.Forms.DataGridView();
            this.JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReported = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Jobs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Jobs
            // 
            this.dgv_Jobs.AllowUserToAddRows = false;
            this.dgv_Jobs.AllowUserToDeleteRows = false;
            this.dgv_Jobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Jobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobID,
            this.CompanyID,
            this.MachineID,
            this.Fault,
            this.DateReported,
            this.Urgency,
            this.LastStartDate,
            this.State});
            this.dgv_Jobs.Location = new System.Drawing.Point(12, 12);
            this.dgv_Jobs.MultiSelect = false;
            this.dgv_Jobs.Name = "dgv_Jobs";
            this.dgv_Jobs.ReadOnly = true;
            this.dgv_Jobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Jobs.Size = new System.Drawing.Size(844, 440);
            this.dgv_Jobs.TabIndex = 0;
            this.dgv_Jobs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Jobs_CellDoubleClick);
            // 
            // JobID
            // 
            this.JobID.HeaderText = "Job ID";
            this.JobID.Name = "JobID";
            this.JobID.ReadOnly = true;
            // 
            // CompanyID
            // 
            this.CompanyID.HeaderText = "Company ID";
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.ReadOnly = true;
            // 
            // MachineID
            // 
            this.MachineID.HeaderText = "Machine ID";
            this.MachineID.Name = "MachineID";
            this.MachineID.ReadOnly = true;
            // 
            // Fault
            // 
            this.Fault.HeaderText = "Fault";
            this.Fault.Name = "Fault";
            this.Fault.ReadOnly = true;
            // 
            // DateReported
            // 
            this.DateReported.HeaderText = "Date Reported";
            this.DateReported.Name = "DateReported";
            this.DateReported.ReadOnly = true;
            // 
            // Urgency
            // 
            this.Urgency.HeaderText = "Urgency";
            this.Urgency.Name = "Urgency";
            this.Urgency.ReadOnly = true;
            // 
            // LastStartDate
            // 
            this.LastStartDate.HeaderText = "Last Start Date";
            this.LastStartDate.Name = "LastStartDate";
            this.LastStartDate.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(12, 463);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(193, 13);
            this.lbl_Info.TabIndex = 1;
            this.lbl_Info.Text = "Double-click a row for more information.";
            // 
            // Form_Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 485);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.dgv_Jobs);
            this.Name = "Form_Jobs";
            this.Text = "Jobs";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Jobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Jobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fault;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReported;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Label lbl_Info;


    }
}