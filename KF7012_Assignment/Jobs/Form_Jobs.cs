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
            txt_SizeComplexity.ReadOnly = true;
        }

        private void btn_RegisterMachine_Click(Object sender, EventArgs e) {
            presenter.btn_RegisterMachine_Click();
        }

        private void cmb_MachineID_SelectedIndexChanged(Object sender, EventArgs e)
        {
            presenter.cmb_MachineID_SelectedIndexChanged();
        }

        private void txt_CompanyID_Leave(Object sender, EventArgs e)
        {
            presenter.txt_CompanyID_Leave();
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

        public void addMachine(string machineID, string assetTag)
        {
            cmb_MachineID.Items.Add(machineID + " (" + assetTag + ")");
        }

        public void setMachineIndex(int index)
        {
            cmb_MachineID.SelectedIndex = index;
        }

        public string getMachineID()
        {
            return cmb_MachineID.Text;
        }

        public void setSizeComplexity(int sizeComplexity)
        {
            txt_SizeComplexity.Text = sizeComplexity.ToString();
        }

        public void showRegisterMachineForm()
        {
            Form_RegisterMachine f1 = new Form_RegisterMachine();
            RegisterMachinePresenter FM = new RegisterMachinePresenter(f1);
            f1.ShowDialog();
        }
    }
}
