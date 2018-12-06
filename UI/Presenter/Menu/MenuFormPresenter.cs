using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.View.Menu.Interface;

namespace UI.Presenter.Menu
{
    class MenuFormPresenter
    {
        private IMenuView menuView;
        public MenuFormPresenter(IMenuView menuView)
        {
            this.menuView = menuView;
        }
    }
}
