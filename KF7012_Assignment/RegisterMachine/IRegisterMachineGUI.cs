/*
 Patricia Fernandes
 Bogdana Grigore
 Michael Hay

 https://gitlab.com/thefyrewire/kf7012-assignment
*/

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
        string getAssetTag();
        int getSizeComplexity();
        string getDescription();
        void setSizeComplexityLabel(int value);
        void showError(bool boolean);
        void closeForm();
    }
}
