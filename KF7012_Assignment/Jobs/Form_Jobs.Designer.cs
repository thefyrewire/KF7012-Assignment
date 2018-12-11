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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_CompanyID = new System.Windows.Forms.TextBox();
            this.lbl_CompanyID = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_RegisterJob = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.btn_RegisterMachine = new System.Windows.Forms.Button();
            this.lbl_SizeComplexity = new System.Windows.Forms.Label();
            this.lbl_Attachments = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Fault = new System.Windows.Forms.Label();
            this.lbl_MachineID = new System.Windows.Forms.Label();
            this.txt_Fault = new System.Windows.Forms.TextBox();
            this.txt_SizeComplexity = new System.Windows.Forms.TextBox();
            this.txt_MachineID = new System.Windows.Forms.TextBox();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_MachineID = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jobs";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(63, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 579);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmb_MachineID);
            this.tabPage1.Controls.Add(this.txt_CompanyID);
            this.tabPage1.Controls.Add(this.lbl_CompanyID);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.btn_RegisterJob);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.txt_Description);
            this.tabPage1.Controls.Add(this.lbl_Location);
            this.tabPage1.Controls.Add(this.btn_RegisterMachine);
            this.tabPage1.Controls.Add(this.lbl_SizeComplexity);
            this.tabPage1.Controls.Add(this.lbl_Attachments);
            this.tabPage1.Controls.Add(this.lbl_Description);
            this.tabPage1.Controls.Add(this.lbl_Fault);
            this.tabPage1.Controls.Add(this.lbl_MachineID);
            this.tabPage1.Controls.Add(this.txt_Fault);
            this.tabPage1.Controls.Add(this.txt_SizeComplexity);
            this.tabPage1.Controls.Add(this.txt_MachineID);
            this.tabPage1.Controls.Add(this.txt_Location);
            this.tabPage1.Controls.Add(this.txt_CompanyName);
            this.tabPage1.Controls.Add(this.lbl_CompanyName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_CompanyID
            // 
            this.txt_CompanyID.Location = new System.Drawing.Point(155, 17);
            this.txt_CompanyID.Name = "txt_CompanyID";
            this.txt_CompanyID.Size = new System.Drawing.Size(100, 20);
            this.txt_CompanyID.TabIndex = 0;
            this.txt_CompanyID.Leave += new System.EventHandler(this.txt_CompanyID_Leave);
            // 
            // lbl_CompanyID
            // 
            this.lbl_CompanyID.AutoSize = true;
            this.lbl_CompanyID.Location = new System.Drawing.Point(15, 20);
            this.lbl_CompanyID.Name = "lbl_CompanyID";
            this.lbl_CompanyID.Size = new System.Drawing.Size(72, 13);
            this.lbl_CompanyID.TabIndex = 23;
            this.lbl_CompanyID.Text = "Company ID *";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(286, 363);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 28);
            this.button7.TabIndex = 9;
            this.button7.Text = "Attach a file";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btn_RegisterJob
            // 
            this.btn_RegisterJob.Location = new System.Drawing.Point(18, 461);
            this.btn_RegisterJob.Name = "btn_RegisterJob";
            this.btn_RegisterJob.Size = new System.Drawing.Size(94, 28);
            this.btn_RegisterJob.TabIndex = 10;
            this.btn_RegisterJob.Text = "Register";
            this.btn_RegisterJob.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(155, 289);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(225, 56);
            this.txt_Description.TabIndex = 7;
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(15, 82);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(48, 13);
            this.lbl_Location.TabIndex = 17;
            this.lbl_Location.Text = "Location";
            // 
            // btn_RegisterMachine
            // 
            this.btn_RegisterMachine.Location = new System.Drawing.Point(286, 116);
            this.btn_RegisterMachine.Name = "btn_RegisterMachine";
            this.btn_RegisterMachine.Size = new System.Drawing.Size(94, 28);
            this.btn_RegisterMachine.TabIndex = 4;
            this.btn_RegisterMachine.Text = "Add a Machine";
            this.btn_RegisterMachine.UseVisualStyleBackColor = true;
            this.btn_RegisterMachine.Click += new System.EventHandler(this.btn_RegisterMachine_Click);
            // 
            // lbl_SizeComplexity
            // 
            this.lbl_SizeComplexity.AutoSize = true;
            this.lbl_SizeComplexity.Location = new System.Drawing.Point(15, 171);
            this.lbl_SizeComplexity.Name = "lbl_SizeComplexity";
            this.lbl_SizeComplexity.Size = new System.Drawing.Size(101, 13);
            this.lbl_SizeComplexity.TabIndex = 15;
            this.lbl_SizeComplexity.Text = "Size and Complexity";
            // 
            // lbl_Attachments
            // 
            this.lbl_Attachments.AutoSize = true;
            this.lbl_Attachments.Location = new System.Drawing.Point(15, 371);
            this.lbl_Attachments.Name = "lbl_Attachments";
            this.lbl_Attachments.Size = new System.Drawing.Size(66, 13);
            this.lbl_Attachments.TabIndex = 14;
            this.lbl_Attachments.Text = "Attachments";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(15, 292);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(60, 13);
            this.lbl_Description.TabIndex = 13;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_Fault
            // 
            this.lbl_Fault.AutoSize = true;
            this.lbl_Fault.Location = new System.Drawing.Point(15, 213);
            this.lbl_Fault.Name = "lbl_Fault";
            this.lbl_Fault.Size = new System.Drawing.Size(37, 13);
            this.lbl_Fault.TabIndex = 12;
            this.lbl_Fault.Text = "Fault *";
            // 
            // lbl_MachineID
            // 
            this.lbl_MachineID.AutoSize = true;
            this.lbl_MachineID.Location = new System.Drawing.Point(15, 124);
            this.lbl_MachineID.Name = "lbl_MachineID";
            this.lbl_MachineID.Size = new System.Drawing.Size(69, 13);
            this.lbl_MachineID.TabIndex = 11;
            this.lbl_MachineID.Text = "Machine ID *";
            // 
            // txt_Fault
            // 
            this.txt_Fault.Location = new System.Drawing.Point(155, 210);
            this.txt_Fault.Multiline = true;
            this.txt_Fault.Name = "txt_Fault";
            this.txt_Fault.Size = new System.Drawing.Size(225, 56);
            this.txt_Fault.TabIndex = 6;
            // 
            // txt_SizeComplexity
            // 
            this.txt_SizeComplexity.Location = new System.Drawing.Point(155, 168);
            this.txt_SizeComplexity.Name = "txt_SizeComplexity";
            this.txt_SizeComplexity.Size = new System.Drawing.Size(100, 20);
            this.txt_SizeComplexity.TabIndex = 5;
            // 
            // txt_MachineID
            // 
            this.txt_MachineID.Location = new System.Drawing.Point(155, 121);
            this.txt_MachineID.Name = "txt_MachineID";
            this.txt_MachineID.Size = new System.Drawing.Size(100, 20);
            this.txt_MachineID.TabIndex = 3;
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(155, 79);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(100, 20);
            this.txt_Location.TabIndex = 2;
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Location = new System.Drawing.Point(155, 47);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(100, 20);
            this.txt_CompanyName.TabIndex = 1;
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AutoSize = true;
            this.lbl_CompanyName.Location = new System.Drawing.Point(15, 50);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(94, 13);
            this.lbl_CompanyName.TabIndex = 0;
            this.lbl_CompanyName.Text = "Name of Company";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.textBox10);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.textBox11);
            this.tabPage3.Controls.Add(this.textBox12);
            this.tabPage3.Controls.Add(this.textBox13);
            this.tabPage3.Controls.Add(this.textBox14);
            this.tabPage3.Controls.Add(this.textBox15);
            this.tabPage3.Controls.Add(this.textBox16);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(825, 553);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View/Edit";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(293, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 28);
            this.button4.TabIndex = 38;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(168, 444);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 28);
            this.button8.TabIndex = 37;
            this.button8.Text = "Attach a file";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(162, 361);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(225, 56);
            this.textBox10.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Complexity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Location";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Size";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 452);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Attachments";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Description";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 302);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Fault";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Machine ID";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(162, 295);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(225, 56);
            this.textBox11.TabIndex = 28;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(162, 252);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 27;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(162, 206);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 26;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(162, 152);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 25;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(162, 103);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 24;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(162, 58);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Name of Company";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(419, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 28);
            this.button6.TabIndex = 18;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 508);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 28);
            this.button5.TabIndex = 17;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(162, 9);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Job ID";
            // 
            // cmb_MachineID
            // 
            this.cmb_MachineID.FormattingEnabled = true;
            this.cmb_MachineID.Location = new System.Drawing.Point(386, 120);
            this.cmb_MachineID.Name = "cmb_MachineID";
            this.cmb_MachineID.Size = new System.Drawing.Size(142, 21);
            this.cmb_MachineID.TabIndex = 24;
            // 
            // Form_Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 733);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Jobs";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Button btn_RegisterMachine;
        private System.Windows.Forms.Label lbl_SizeComplexity;
        private System.Windows.Forms.Label lbl_Attachments;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Fault;
        private System.Windows.Forms.Label lbl_MachineID;
        private System.Windows.Forms.TextBox txt_Fault;
        private System.Windows.Forms.TextBox txt_SizeComplexity;
        private System.Windows.Forms.TextBox txt_MachineID;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_RegisterJob;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txt_CompanyID;
        private System.Windows.Forms.Label lbl_CompanyID;
        private System.Windows.Forms.ComboBox cmb_MachineID;

    }
}