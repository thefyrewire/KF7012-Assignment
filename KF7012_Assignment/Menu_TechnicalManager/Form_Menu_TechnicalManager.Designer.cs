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
            this.lbl_EstimatedDays = new System.Windows.Forms.Label();
            this.lbl_AssignedEngineer = new System.Windows.Forms.Label();
            this.lbl_JobID = new System.Windows.Forms.Label();
            this.txt_JobID = new System.Windows.Forms.TextBox();
            this.nud_EstimatedDays = new System.Windows.Forms.NumericUpDown();
            this.btn_ScheduleJob = new System.Windows.Forms.Button();
            this.cmb_AssignedEngineer = new System.Windows.Forms.ComboBox();
            this.txt_Skills = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.estim_JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estim_CompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estim_Complexity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estim_Fault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estim_Urgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estim_DateReported = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob_JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob_CompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob_Complexity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob_Fault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob_Urgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob_LastStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RequestJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProblemJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EstimatedDays)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_RequestJobs
            // 
            this.dgv_RequestJobs.AllowUserToAddRows = false;
            this.dgv_RequestJobs.AllowUserToDeleteRows = false;
            this.dgv_RequestJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_RequestJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RequestJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estim_JobID,
            this.estim_CompanyID,
            this.estim_Complexity,
            this.estim_Fault,
            this.estim_Urgency,
            this.estim_DateReported});
            this.dgv_RequestJobs.Location = new System.Drawing.Point(12, 48);
            this.dgv_RequestJobs.MultiSelect = false;
            this.dgv_RequestJobs.Name = "dgv_RequestJobs";
            this.dgv_RequestJobs.ReadOnly = true;
            this.dgv_RequestJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_RequestJobs.Size = new System.Drawing.Size(572, 177);
            this.dgv_RequestJobs.TabIndex = 0;
            this.dgv_RequestJobs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RequestJobs_CellClick);
            this.dgv_RequestJobs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RequestJobs_CellDoubleClick);
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
            this.dgv_ProblemJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ProblemJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProblemJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prob_JobID,
            this.prob_CompanyID,
            this.prob_Complexity,
            this.prob_Fault,
            this.prob_Urgency,
            this.prob_LastStartDate});
            this.dgv_ProblemJobs.Location = new System.Drawing.Point(12, 303);
            this.dgv_ProblemJobs.MultiSelect = false;
            this.dgv_ProblemJobs.Name = "dgv_ProblemJobs";
            this.dgv_ProblemJobs.ReadOnly = true;
            this.dgv_ProblemJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProblemJobs.Size = new System.Drawing.Size(572, 177);
            this.dgv_ProblemJobs.TabIndex = 3;
            this.dgv_ProblemJobs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProblemJobs_CellDoubleClick);
            // 
            // lbl_EstimatedDays
            // 
            this.lbl_EstimatedDays.AutoSize = true;
            this.lbl_EstimatedDays.Location = new System.Drawing.Point(614, 160);
            this.lbl_EstimatedDays.Name = "lbl_EstimatedDays";
            this.lbl_EstimatedDays.Size = new System.Drawing.Size(80, 13);
            this.lbl_EstimatedDays.TabIndex = 55;
            this.lbl_EstimatedDays.Text = "Estimated Days";
            // 
            // lbl_AssignedEngineer
            // 
            this.lbl_AssignedEngineer.AutoSize = true;
            this.lbl_AssignedEngineer.Location = new System.Drawing.Point(614, 108);
            this.lbl_AssignedEngineer.Name = "lbl_AssignedEngineer";
            this.lbl_AssignedEngineer.Size = new System.Drawing.Size(95, 13);
            this.lbl_AssignedEngineer.TabIndex = 54;
            this.lbl_AssignedEngineer.Text = "Assigned Engineer";
            // 
            // lbl_JobID
            // 
            this.lbl_JobID.AutoSize = true;
            this.lbl_JobID.Location = new System.Drawing.Point(614, 82);
            this.lbl_JobID.Name = "lbl_JobID";
            this.lbl_JobID.Size = new System.Drawing.Size(38, 13);
            this.lbl_JobID.TabIndex = 53;
            this.lbl_JobID.Text = "Job ID";
            // 
            // txt_JobID
            // 
            this.txt_JobID.Location = new System.Drawing.Point(758, 79);
            this.txt_JobID.Name = "txt_JobID";
            this.txt_JobID.Size = new System.Drawing.Size(180, 20);
            this.txt_JobID.TabIndex = 50;
            // 
            // nud_EstimatedDays
            // 
            this.nud_EstimatedDays.Location = new System.Drawing.Point(758, 158);
            this.nud_EstimatedDays.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nud_EstimatedDays.Name = "nud_EstimatedDays";
            this.nud_EstimatedDays.Size = new System.Drawing.Size(180, 20);
            this.nud_EstimatedDays.TabIndex = 56;
            // 
            // btn_ScheduleJob
            // 
            this.btn_ScheduleJob.Location = new System.Drawing.Point(839, 195);
            this.btn_ScheduleJob.Name = "btn_ScheduleJob";
            this.btn_ScheduleJob.Size = new System.Drawing.Size(99, 23);
            this.btn_ScheduleJob.TabIndex = 57;
            this.btn_ScheduleJob.Text = "Schedule Job";
            this.btn_ScheduleJob.UseVisualStyleBackColor = true;
            this.btn_ScheduleJob.Click += new System.EventHandler(this.btn_ScheduleJob_Click);
            // 
            // cmb_AssignedEngineer
            // 
            this.cmb_AssignedEngineer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AssignedEngineer.FormattingEnabled = true;
            this.cmb_AssignedEngineer.Location = new System.Drawing.Point(758, 105);
            this.cmb_AssignedEngineer.Name = "cmb_AssignedEngineer";
            this.cmb_AssignedEngineer.Size = new System.Drawing.Size(180, 21);
            this.cmb_AssignedEngineer.TabIndex = 58;
            this.cmb_AssignedEngineer.SelectedIndexChanged += new System.EventHandler(this.txt_Skills_Leave);
            this.cmb_AssignedEngineer.Leave += new System.EventHandler(this.txt_Skills_Leave);
            // 
            // txt_Skills
            // 
            this.txt_Skills.Location = new System.Drawing.Point(758, 132);
            this.txt_Skills.Name = "txt_Skills";
            this.txt_Skills.Size = new System.Drawing.Size(180, 20);
            this.txt_Skills.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Engineer\'s Skills";
            // 
            // estim_JobID
            // 
            this.estim_JobID.HeaderText = "Job ID";
            this.estim_JobID.Name = "estim_JobID";
            this.estim_JobID.ReadOnly = true;
            this.estim_JobID.Width = 63;
            // 
            // estim_CompanyID
            // 
            this.estim_CompanyID.HeaderText = "Company ID";
            this.estim_CompanyID.Name = "estim_CompanyID";
            this.estim_CompanyID.ReadOnly = true;
            this.estim_CompanyID.Width = 90;
            // 
            // estim_Complexity
            // 
            this.estim_Complexity.HeaderText = "Machine Complexity";
            this.estim_Complexity.Name = "estim_Complexity";
            this.estim_Complexity.ReadOnly = true;
            this.estim_Complexity.Width = 115;
            // 
            // estim_Fault
            // 
            this.estim_Fault.HeaderText = "Fault";
            this.estim_Fault.Name = "estim_Fault";
            this.estim_Fault.ReadOnly = true;
            this.estim_Fault.Width = 55;
            // 
            // estim_Urgency
            // 
            this.estim_Urgency.HeaderText = "Urgency";
            this.estim_Urgency.Name = "estim_Urgency";
            this.estim_Urgency.ReadOnly = true;
            this.estim_Urgency.Width = 72;
            // 
            // estim_DateReported
            // 
            this.estim_DateReported.HeaderText = "Date Reported";
            this.estim_DateReported.Name = "estim_DateReported";
            this.estim_DateReported.ReadOnly = true;
            this.estim_DateReported.Width = 94;
            // 
            // prob_JobID
            // 
            this.prob_JobID.HeaderText = "Job ID";
            this.prob_JobID.Name = "prob_JobID";
            this.prob_JobID.ReadOnly = true;
            this.prob_JobID.Width = 63;
            // 
            // prob_CompanyID
            // 
            this.prob_CompanyID.HeaderText = "Company ID";
            this.prob_CompanyID.Name = "prob_CompanyID";
            this.prob_CompanyID.ReadOnly = true;
            this.prob_CompanyID.Width = 90;
            // 
            // prob_Complexity
            // 
            this.prob_Complexity.HeaderText = "Machine Complexity";
            this.prob_Complexity.Name = "prob_Complexity";
            this.prob_Complexity.ReadOnly = true;
            this.prob_Complexity.Width = 115;
            // 
            // prob_Fault
            // 
            this.prob_Fault.HeaderText = "Fault";
            this.prob_Fault.Name = "prob_Fault";
            this.prob_Fault.ReadOnly = true;
            this.prob_Fault.Width = 55;
            // 
            // prob_Urgency
            // 
            this.prob_Urgency.HeaderText = "Urgency";
            this.prob_Urgency.Name = "prob_Urgency";
            this.prob_Urgency.ReadOnly = true;
            this.prob_Urgency.Width = 72;
            // 
            // prob_LastStartDate
            // 
            this.prob_LastStartDate.HeaderText = "Last Start Date";
            this.prob_LastStartDate.Name = "prob_LastStartDate";
            this.prob_LastStartDate.ReadOnly = true;
            this.prob_LastStartDate.Width = 95;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(617, 200);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(144, 13);
            this.lbl_Error.TabIndex = 61;
            this.lbl_Error.Text = "Select an engineer to assign!";
            // 
            // Form_Menu_TechnicalManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 492);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Skills);
            this.Controls.Add(this.cmb_AssignedEngineer);
            this.Controls.Add(this.btn_ScheduleJob);
            this.Controls.Add(this.nud_EstimatedDays);
            this.Controls.Add(this.lbl_EstimatedDays);
            this.Controls.Add(this.lbl_AssignedEngineer);
            this.Controls.Add(this.lbl_JobID);
            this.Controls.Add(this.txt_JobID);
            this.Controls.Add(this.dgv_ProblemJobs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_RequestForEstimate);
            this.Controls.Add(this.dgv_RequestJobs);
            this.Name = "Form_Menu_TechnicalManager";
            this.Text = "Menu - Logged in as Technical Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RequestJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProblemJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EstimatedDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_RequestJobs;
        private System.Windows.Forms.Label lbl_RequestForEstimate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ProblemJobs;
        private System.Windows.Forms.Label lbl_EstimatedDays;
        private System.Windows.Forms.Label lbl_AssignedEngineer;
        private System.Windows.Forms.Label lbl_JobID;
        private System.Windows.Forms.TextBox txt_JobID;
        private System.Windows.Forms.NumericUpDown nud_EstimatedDays;
        private System.Windows.Forms.Button btn_ScheduleJob;
        private System.Windows.Forms.ComboBox cmb_AssignedEngineer;
        private System.Windows.Forms.TextBox txt_Skills;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn estim_JobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn estim_CompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn estim_Complexity;
        private System.Windows.Forms.DataGridViewTextBoxColumn estim_Fault;
        private System.Windows.Forms.DataGridViewTextBoxColumn estim_Urgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn estim_DateReported;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob_JobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob_CompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob_Complexity;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob_Fault;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob_Urgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob_LastStartDate;
        private System.Windows.Forms.Label lbl_Error;
    }
}