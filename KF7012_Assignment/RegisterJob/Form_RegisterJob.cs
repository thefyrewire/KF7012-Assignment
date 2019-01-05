using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KF7012_Assignment
{
    public partial class Form_RegisterJob : Form, IRegisterJobGUI
    {
        private RegisterJobPresenter presenter;

        public Form_RegisterJob()
        {
            this.InitializeComponent();
        }
        public void register(RegisterJobPresenter FP)
        {
            presenter = FP;
        }

        public void setReadOnlyFields()
        {
            txt_CompanyName.ReadOnly = true;
            txt_Location.ReadOnly = true;
            txt_AssetTag.ReadOnly = true;
            txt_SizeComplexity.ReadOnly = true;
            txt_Description.ReadOnly = true;
        }

        private void btn_RegisterMachine_Click(Object sender, EventArgs e) {
            presenter.btn_RegisterMachine_Click();
        }

        private void cmb_MachineID_Leave(Object sender, EventArgs e)
        {
            presenter.cmb_MachineID_Leave();
        }

        private void txt_CompanyID_Leave(Object sender, EventArgs e)
        {
            presenter.txt_CompanyID_Leave();
        }

        private void btn_RegisterJob_Click(Object sender, EventArgs e)
        {
            presenter.btn_RegisterJob_Click();
        }

        public int companyID
        {
            set { txt_CompanyID.Text = value.ToString(); }
            get
            {
                int ID;
                int.TryParse(txt_CompanyID.Text, out ID);
                return ID;
            }
        }

        public string companyName
        {
            set { txt_CompanyName.Text = value; }
            get { return txt_CompanyName.Text; }
        }

        public string location
        {
            set { txt_Location.Text = value; }
            get { return txt_Location.Text; }
        }

        public void clearCompanyDetails()
        {
            txt_CompanyName.Clear();
            txt_Location.Clear();
        }

        public void showFaultError(bool boolean)
        {
            lbl_FaultError.Visible = boolean;
        }

        public void btn_RegisterMachineEnabled(bool allowed)
        {
            btn_RegisterMachine.Enabled = allowed;
        }

        public void btn_RegisterJobEnabled(bool allowed)
        {
            btn_RegisterJob.Enabled = allowed;
        }

        public void cmb_MachineIDEnabled(bool allowed)
        {
            cmb_MachineID.Enabled = allowed;
        }

        public void jobDetailsEnabled(bool allowed)
        {
            txt_Fault.Enabled = allowed;
            trb_Urgency.Enabled = allowed;
            lbl_UrgencyValue.Enabled = allowed;
        }

        public void clearMachineIDs()
        {
            cmb_MachineID.ResetText();
            cmb_MachineID.Items.Clear();
        }

        public void addMachineIDs(string machineID)
        {
            cmb_MachineID.Items.Add(machineID);
        }

        public void setMachineIndex(int index)
        {
            cmb_MachineID.SelectedIndex = index;
        }

        public string getMachineID()
        {
            return cmb_MachineID.Text;
        }

        public string machineID
        {
            set { cmb_MachineID.Text = value; }
            get { return cmb_MachineID.Text; }
        }

        public string assetTag
        {
            set { txt_AssetTag.Text = value; }
            get { return txt_AssetTag.Text; }
        }

        public int sizeComplexity
        {
            set { txt_SizeComplexity.Text = value.ToString(); }
            get
            {
                int sizeComplexity;
                int.TryParse(txt_SizeComplexity.Text, out sizeComplexity);
                return sizeComplexity;
            }
        }

        public string description
        {
            set { txt_Description.Text = value; }
            get { return txt_Description.Text; }
        }

        public string fault
        {
            set { txt_Fault.Text = value; }
            get { return txt_Fault.Text; }
        }

        public int urgency
        {
            set { trb_Urgency.Value = value; }
            get { return trb_Urgency.Value; }
        }

        public void clearMachineDetails()
        {
            txt_AssetTag.Clear();
            txt_SizeComplexity.Clear();
            txt_Description.Clear();
        }

        public void clearForm()
        {
            txt_CompanyID.Clear();
            clearCompanyDetails();
            clearMachineIDs();
            clearMachineDetails();
            txt_Fault.Clear();
            txt_Description.Clear();
            trb_Urgency.Value = 0;
        }

        private void trb_Urgency_ValueChanged(Object sender, EventArgs e)
        {
            presenter.trb_Urgency_ValueChanged();
        }

        public void setUrgencyLabel(int value)
        {
            lbl_UrgencyValue.Text = value.ToString();
        }

        public void showAddedJobDialog()
        {
            DialogResult response = MessageBox.Show("Job successfully added. Would you like to view all current jobs?", "Added job!", MessageBoxButtons.YesNo);
            presenter.addedJobDialog(response);

        }

        public void showRegisterMachineForm(int companyID)
        {
            Form_RegisterMachine f1 = new Form_RegisterMachine();
            RegisterMachinePresenter FM = new RegisterMachinePresenter(f1);
            FM.setCompanyID(companyID);
            f1.ShowDialog();
            presenter.updateView();
        }

        public void showJobsForm()
        {
            this.Hide();
            Form_Jobs f1 = new Form_Jobs();
            JobsPresenter FM = new JobsPresenter(f1);
            f1.ShowDialog();
            this.Close();
        }
    }
}
