using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public interface IRegisterMachineGUI
    {
        void register(RegisterMachinePresenter FM);
        void setCompanyID(int companyID);
        int getSizeComplexityValue();
        void setSizeComplexityLabel(int value);
    }
}
