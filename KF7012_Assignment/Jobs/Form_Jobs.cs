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

        public void setCompanyID(int companyID)
        {
            txt_CompanyID.Text = companyID.ToString();
        }

        public void showRegisterMachineForm()
        {
            Form_RegisterMachine f1 = new Form_RegisterMachine();
            RegisterMachinePresenter FM = new RegisterMachinePresenter(f1);
            f1.ShowDialog();
        }
    }
}
