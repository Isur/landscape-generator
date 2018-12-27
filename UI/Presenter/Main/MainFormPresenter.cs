using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Model.Enumeration;
using UI.Presenter.UserControls.MenuOptions;
using UI.View.Menu;
using UI.View.Menu.Interface;

namespace UI.Presenter.Menu
{
    class MainFormPresenter
    {
        private MainForm mainView;

        public MainFormPresenter(MainForm mainView)
        {
            this.mainView = mainView;
        }
    }
}
