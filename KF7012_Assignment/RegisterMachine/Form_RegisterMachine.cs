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

        public string assetTag
        {
            set { txt_AssetTag.Text = value; }
            get { return txt_AssetTag.Text; }
        }

        public int sizeComplexity
        {
            set { trb_SizeComplexity.Value = value; }
            get { return trb_SizeComplexity.Value;  }
        }

        private void trb_SizeComplexity_ValueChanged(Object sender, EventArgs e)
        {
            presenter.trb_SizeComplexity_ValueChanged();
        }

        public void setSizeComplexityLabel(int value)
        {
            lbl_SizeComplexityValue.Text = value.ToString();
        }

        private void btn_Register_Click(Object sender, EventArgs e)
        {
            presenter.btn_Register_Click();
        }

        public void closeForm()
        {
            this.Close();
        }
    }
}
