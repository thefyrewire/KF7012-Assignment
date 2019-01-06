/*
 Patricia Fernandes
 Bogdana Grigore
 Michael Hay

 https://gitlab.com/thefyrewire/kf7012-assignment
*/

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
    public partial class Form_RegisterCompany : Form, IRegisterCompanyGUI
    {
        private RegisterCompanyPresenter presenter;

        public Form_RegisterCompany()
        {
            this.InitializeComponent();
        }

        public void register(RegisterCompanyPresenter FP)
        {
            presenter = FP;
        }

        public void message(string msg)
        {
            MessageBox.Show(msg);
        }

        private void btn_RegisterCompany_Click(Object sender, EventArgs e)
        {
            presenter.btn_RegisterCompany_Click();
        }

        public bool validateFields()
        {
            if (!string.IsNullOrEmpty(txt_CompanyName.Text) && !string.IsNullOrEmpty(txt_Location.Text))
                return true;
            return false;
        }

        public string getCompanyName()
        {
            return txt_CompanyName.Text;
        }

        public string getLocation()
        {
            return txt_Location.Text;
        }

        public void hideError()
        {
            lbl_ErrorMsg.Visible = false;
        }

        public void showError(string error)
        {
            lbl_ErrorMsg.Text = error;
            lbl_ErrorMsg.Visible = true;
        }

        public bool getTermsConditionsChecked()
        {
            return chk_TermConditions.Checked;
        }

        public void showJobsForm(int companyID)
        {
            this.Hide();
            Form_RegisterJob f1 = new Form_RegisterJob();
            RegisterJobPresenter FM = new RegisterJobPresenter(f1);
            FM.setCompanyID(companyID);
            FM.updateView();
            f1.ShowDialog();
        }
    }
}
