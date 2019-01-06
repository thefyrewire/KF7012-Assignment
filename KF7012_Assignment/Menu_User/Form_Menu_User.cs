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
    public partial class Form_Menu_User : Form, IFormGUI
    {
        private FormPresenter presenter;
        public Form_Menu_User()
        {
            this.InitializeComponent();
        }

        public void register(FormPresenter FP)
        {
            presenter = FP;
        }

        private void btn_RegisterCompany_Click(Object sender, EventArgs e)
        {
            presenter.showRegisterCompanyForm();
        }

        private void btn_RegisterJob_Click(Object sender, EventArgs e)
        {
            presenter.showRegisterJobForm();
        }

        private void btn_Jobs_Click(Object sender, EventArgs e)
        {
            presenter.showJobsForm();
        }

        public void showRegisterCompanyForm()
        {
            this.Hide();
            Form_RegisterCompany f1 = new Form_RegisterCompany();
            RegisterCompanyPresenter FM = new RegisterCompanyPresenter(f1);
            f1.ShowDialog();
            this.Show();
        }

        public void showRegisterJobForm()
        {
            this.Hide();
            Form_RegisterJob f1 = new Form_RegisterJob();
            RegisterJobPresenter FM = new RegisterJobPresenter(f1);
            f1.ShowDialog();
            this.Show();
        }

        public void showJobsForm()
        {
            this.Hide();
            Form_Jobs f1 = new Form_Jobs();
            JobsPresenter FM = new JobsPresenter(f1);
            f1.ShowDialog();
            this.Show();
        }
    }
}
