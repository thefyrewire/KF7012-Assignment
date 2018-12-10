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
    public partial class Form_RegisterMachine : Form, IRegisterMachineGUI
    {
        private RegisterMachinePresenter presenter;
        public Form_RegisterMachine()
        {
            this.InitializeComponent();
        }

        public void register(RegisterMachinePresenter FP)
        {
            presenter = FP;
        }

        public void setCompanyID(int companyID)
        {
            txt_CompanyID.Text = companyID.ToString();
        }

        private void trb_SizeComplexity_ValueChanged(Object sender, EventArgs e)
        {
            presenter.trb_SizeComplexity_ValueChanged();
        }

        public int getSizeComplexityValue()
        {
            return trb_SizeComplexity.Value;
        }

        public void setSizeComplexityLabel(int value)
        {
            lbl_SizeComplexityValue.Text = value.ToString();
        }
    }
}
