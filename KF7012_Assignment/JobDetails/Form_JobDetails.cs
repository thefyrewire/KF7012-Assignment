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
    public partial class Form_JobDetails : Form, IJobDetailsGUI
    {
        private JobDetailsPresenter presenter;

        public Form_JobDetails()
        {
            this.InitializeComponent();
        }

        public void register(JobDetailsPresenter FP)
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
    }
}
