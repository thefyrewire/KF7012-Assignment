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
    public partial class Form_Jobs : Form, IJobsGUI
    {
        private JobsPresenter presenter;

        public Form_Jobs()
        {
            this.InitializeComponent();
        }
        public void register(JobsPresenter FP)
        {
            presenter = FP;
        }

        public void setReadOnlyFields()
        {
            txt_CompanyName.ReadOnly = true;
            txt_Location.ReadOnly = true;
            txt_AssetTag.ReadOnly = true;
            txt_SizeComplexity.ReadOnly = true;
        }

        private void btn_RegisterMachine_Click(Object sender, EventArgs e) {
            presenter.btn_RegisterMachine_Click();
        }

        /*private void cmb_MachineID_SelectedIndexChanged(Object sender, EventArgs e)
        {
            presenter.cmb_MachineID_SelectedIndexChanged();
        }*/

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

        public string companyID
        {
            set { txt_CompanyID.Text = value; }
            get { return txt_CompanyID.Text; }
        }

        public void setCompanyName(string companyName)
        {
            txt_CompanyName.Text = companyName;
        }

        public void setLocation(string location)
        {
            txt_Location.Text = location;
        }

        public void clearCompanyNameLocation()
        {
            txt_CompanyName.Clear();
            txt_Location.Clear();
        }

        public void registerMachineEnabled(bool allowed)
        {
            btn_RegisterMachine.Enabled = allowed;
        }

        public void clearMachineIDs()
        {
            cmb_MachineID.ResetText();
            cmb_MachineID.Items.Clear();
        }

        public void addMachine(string machineID)
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

        public string assetTag
        {
            set { txt_AssetTag.Text = value; }
            get { return txt_AssetTag.Text; }
        }

        public void setSizeComplexity(int sizeComplexity)
        {
            txt_SizeComplexity.Text = sizeComplexity.ToString();
        }

        public void clearSizeComplexity()
        {
            txt_SizeComplexity.Clear();
        }

        public void showRegisterMachineForm(int companyID)
        {
            Form_RegisterMachine f1 = new Form_RegisterMachine();
            RegisterMachinePresenter FM = new RegisterMachinePresenter(f1);
            FM.setCompanyID(companyID);
            f1.ShowDialog();
            presenter.updateView();
        }
    }
}
