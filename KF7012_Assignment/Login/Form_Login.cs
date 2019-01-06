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
    public partial class Form_Login : Form, ILoginGUI
    {
        private LoginPresenter presenter;
        public Form_Login()
        {
            this.InitializeComponent();
        }

        public void register(LoginPresenter FP)
        {
            presenter = FP;
        }

        private void btn_Login_Click(Object sender, EventArgs e)
        {
            presenter.btn_Login_Click();
        }

        public string getAttemptUsername()
        {
            return txt_Username.Text;
        }

        public string getAttemptPassword()
        {
            return txt_Password.Text;
        }

        public void showUserMenu()
        {
            this.Hide();
            Form_Menu_User f1 = new Form_Menu_User();
            FormPresenter FM = new FormPresenter(f1);
            f1.ShowDialog();
            this.Close();
        }

        public void showTechMngrMenu()
        {
            this.Hide();
            Form_Menu_TechnicalManager f1 = new Form_Menu_TechnicalManager();
            TechnicalManagerPresenter FM = new TechnicalManagerPresenter(f1);
            f1.ShowDialog();
            this.Close();
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
    }
}
