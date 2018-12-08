using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Presenter.UserControls.Interface
{
    public interface IUserControl
    {
        void CloseUserControl();
        void InitializeUserControl();
    }
}
