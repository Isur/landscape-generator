using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.View.UserControls.MenuOptions.Interface;

namespace UI.Presenter.UserControls.MenuOptions
{
    class MenuPresenter
    {
        private IMenuView menuView;
        public MenuPresenter(IMenuView menuView)
        {
            this.menuView = menuView;
        }
    }
}
