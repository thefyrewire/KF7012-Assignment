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
        int companyID { get; set; }
        string assetTag { get; set; }
        int sizeComplexity { get; set; }
        void setSizeComplexityLabel(int value);
        void closeForm();
    }
}
