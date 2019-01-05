using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public interface ITechnicalManagerGUI
    {
        void register(TechnicalManagerPresenter FM);
        void populateRequestJob(Job job, Machine machine);
        void populateProblemJob(Job job, Machine machine);
    }
}
