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

        public int jobID
        {
            set { txt_JobID.Text = value.ToString(); }
            get
            {
                int ID;
                int.TryParse(txt_JobID.Text, out ID);
                return ID;
            }
        }

        public string state
        {
            set { txt_State.Text = value; }
            get { return txt_State.Text; }
        }

        public void setDateReported(DateTime date)
        {
            txt_DateReported.Text = date.ToString();
        }

        public void setLastStartDate(DateTime date)
        {
            txt_LastStartDate.Text = date.ToString();
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

        public string companyName
        {
            set { txt_CompanyName.Text = value; }
            get { return txt_CompanyName.Text; }
        }

        public string location
        {
            set { txt_Location.Text = value; }
            get { return txt_Location.Text; }
        }

        public string machineID
        {
            set { txt_MachineID.Text = value; }
            get { return txt_MachineID.Text; }
        }

        public string assetTag
        {
            set { txt_AssetTag.Text = value; }
            get { return txt_AssetTag.Text; }
        }

        public int sizeComplexity
        {
            set { txt_SizeComplexity.Text = value.ToString(); }
            get
            {
                int sizeComplexity;
                int.TryParse(txt_SizeComplexity.Text, out sizeComplexity);
                return sizeComplexity;
            }
        }

        public string description
        {
            set { txt_Description.Text = value; }
            get { return txt_Description.Text; }
        }

        public string fault
        {
            set { txt_Fault.Text = value; }
            get { return txt_Fault.Text; }
        }

        public int urgency
        {
            set { txt_Urgency.Text = value.ToString(); }
            get
            {
                int urgency;
                int.TryParse(txt_Urgency.Text, out urgency);
                return urgency;
            }
        }

        public void setReadOnlyFields()
        {
            txt_JobID.ReadOnly = true;
            txt_State.ReadOnly = true;
            txt_DateReported.ReadOnly = true;
            txt_LastStartDate.ReadOnly = true;
            txt_CompanyID.ReadOnly = true;
            txt_CompanyName.ReadOnly = true;
            txt_Location.ReadOnly = true;
            txt_MachineID.ReadOnly = true;
            txt_AssetTag.ReadOnly = true;
            txt_SizeComplexity.ReadOnly = true;
            txt_Description.ReadOnly = true;
            txt_Fault.ReadOnly = true;
            txt_Urgency.ReadOnly = true;
        }
    }
}
