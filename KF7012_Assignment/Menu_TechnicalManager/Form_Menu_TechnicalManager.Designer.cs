namespace KF7012_Assignment
{
    partial class Form_Menu_TechnicalManager
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
            this.dgv_RequestJobs = new System.Windows.Forms.DataGridView();
            this.lbl_RequestForEstimate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ProblemJobs = new System.Windows.Forms.DataGridView();
            this.prob_JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob_CompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob_Complexity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob_Fault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob_LastStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estim_JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estim_CompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estim_Complexity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estim_Fault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estim_DateReported = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RequestJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProblemJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_RequestJobs
            // 
            this.dgv_RequestJobs.AllowUserToAddRows = false;
            this.dgv_RequestJobs.AllowUserToDeleteRows = false;
            this.dgv_RequestJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RequestJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estim_JobID,
            this.estim_CompanyID,
            this.estim_Complexity,
            this.estim_Fault,
            this.estim_DateReported});
            this.dgv_RequestJobs.Location = new System.Drawing.Point(12, 48);
            this.dgv_RequestJobs.Name = "dgv_RequestJobs";
            this.dgv_RequestJobs.ReadOnly = true;
            this.dgv_RequestJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_RequestJobs.Size = new System.Drawing.Size(544, 177);
            this.dgv_RequestJobs.TabIndex = 0;
            // 
            // lbl_RequestForEstimate
            // 
            this.lbl_RequestForEstimate.AutoSize = true;
            this.lbl_RequestForEstimate.Location = new System.Drawing.Point(12, 20);
            this.lbl_RequestForEstimate.Name = "lbl_RequestForEstimate";
            this.lbl_RequestForEstimate.Size = new System.Drawing.Size(109, 13);
            this.lbl_RequestForEstimate.TabIndex = 1;
            this.lbl_RequestForEstimate.Text = "Request for estimates";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Problem jobs";
            // 
            // dgv_ProblemJobs
            // 
            this.dgv_ProblemJobs.AllowUserToAddRows = false;
            this.dgv_ProblemJobs.AllowUserToDeleteRows = false;
            this.dgv_ProblemJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProblemJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prob_JobID,
            this.prob_CompanyID,
            this.prob_Complexity,
            this.prob_Fault,
            this.prob_LastStartDate});
            this.dgv_ProblemJobs.Location = new System.Drawing.Point(12, 303);
            this.dgv_ProblemJobs.Name = "dgv_ProblemJobs";
            this.dgv_ProblemJobs.ReadOnly = true;
            this.dgv_ProblemJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProblemJobs.Size = new System.Drawing.Size(544, 177);
            this.dgv_ProblemJobs.TabIndex = 3;
            // 
            // prob_JobID
            // 
            this.prob_JobID.HeaderText = "Job ID";
            this.prob_JobID.Name = "prob_JobID";
            this.prob_JobID.ReadOnly = true;
            // 
            // prob_CompanyID
            // 
            this.prob_CompanyID.HeaderText = "Company ID";
            this.prob_CompanyID.Name = "prob_CompanyID";
            this.prob_CompanyID.ReadOnly = true;
            // 
            // prob_Complexity
            // 
            this.prob_Complexity.HeaderText = "Machine Complexity";
            this.prob_Complexity.Name = "prob_Complexity";
            this.prob_Complexity.ReadOnly = true;
            // 
            // prob_Fault
            // 
            this.prob_Fault.HeaderText = "Fault";
            this.prob_Fault.Name = "prob_Fault";
            this.prob_Fault.ReadOnly = true;
            // 
            // prob_LastStartDate
            // 
            this.prob_LastStartDate.HeaderText = "Last Start Date";
            this.prob_LastStartDate.Name = "prob_LastStartDate";
            this.prob_LastStartDate.ReadOnly = true;
            // 
            // estim_JobID
            // 
            this.estim_JobID.HeaderText = "Job ID";
            this.estim_JobID.Name = "estim_JobID";
            this.estim_JobID.ReadOnly = true;
            // 
            // estim_CompanyID
            // 
            this.estim_CompanyID.HeaderText = "Company ID";
            this.estim_CompanyID.Name = "estim_CompanyID";
            this.estim_CompanyID.ReadOnly = true;
            // 
            // estim_Complexity
            // 
            this.estim_Complexity.HeaderText = "Machine Complexity";
            this.estim_Complexity.Name = "estim_Complexity";
            this.estim_Complexity.ReadOnly = true;
            // 
            // estim_Fault
            // 
            this.estim_Fault.HeaderText = "Fault";
            this.estim_Fault.Name = "estim_Fault";
            this.estim_Fault.ReadOnly = true;
            // 
            // estim_DateReported
            // 
            this.estim_DateReported.HeaderText = "Date Reported";
            this.estim_DateReported.Name = "estim_DateReported";
            this.estim_DateReported.ReadOnly = true;
            // 
            // Form_Menu_TechnicalManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 492);
            this.Controls.Add(this.dgv_ProblemJobs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_RequestForEstimate);
            this.Controls.Add(this.dgv_RequestJobs);
            this.Name = "Form_Menu_TechnicalManager";
            this.Text = "Menu - Logged in as Technical Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RequestJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProblemJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_RequestJobs;
        private System.Windows.Forms.Label lbl_RequestForEstimate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ProblemJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn estim_JobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn estim_CompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn estim_Complexity;
        private System.Windows.Forms.DataGridViewTextBoxColumn estim_Fault;
        private System.Windows.Forms.DataGridViewTextBoxColumn estim_DateReported;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob_JobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob_CompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob_Complexity;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob_Fault;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob_LastStartDate;
    }
}