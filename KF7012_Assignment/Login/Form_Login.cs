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

        public String getAttemptUsername()
        {
            return txt_Username.Text;
        }

        public String getAttemptPassword()
        {
            return txt_Password.Text;
        }

        public void showMainForm()
        {
            this.Hide();
            Form1 f1 = new Form1();
            FormPresenter FM = new FormPresenter(f1);
            f1.ShowDialog();
            this.Close();
        }
    }
}
