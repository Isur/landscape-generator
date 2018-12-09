using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.View.Menu.Interface;

namespace UI.Presenter.Menu
{
    class MainFormPresenter
    {
        private IMainView mainView;
        public MainFormPresenter(IMainView mainView)
        {
            this.mainView = mainView;
        }
    }
}
