﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class JobDetailsPresenter
    {
        private IJobDetailsGUI screen;
        ModelRepository repository = new ModelRepository();

        public JobDetailsPresenter(IJobDetailsGUI screen)
        {
            this.screen = screen;
            screen.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            // updateView();
        }

        /*public void updateView()
        {
        }*/

        public void populateDetails(Job job)
        {
            screen.companyID = job.companyID;
        }
    }
}
