﻿using System;
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
    }
}