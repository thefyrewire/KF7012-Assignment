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

        public void message(String msg)
        {
            MessageBox.Show(msg);
        }

        private void btn_RegisterCompany_Click(Object sender, EventArgs e)
        {
            // check company doesn't exist in database already (otherwise return its ID)
            // generate unique company ID
            // add company to database
            // display company ID
            presenter.message("Registered!");
        }

    }
}
