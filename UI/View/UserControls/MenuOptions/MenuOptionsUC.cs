using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.View.UserControls.MenuOptions.Interface;
using UI.Presenter.UserControls.MenuOptions;

namespace UI.View.UserControls.MenuOptions
{
    public partial class MenuOptionsUC : UserControl, IMenuOptionsView
    {
        private MenuOptionsPresenter menuOptionsPresenter;
        public MenuOptionsUC()
        {
            InitializeComponent();
            CreatePresenter();
        }

        void CreatePresenter()
        {
            this.menuOptionsPresenter = new MenuOptionsPresenter(this);
        }
    }
}
