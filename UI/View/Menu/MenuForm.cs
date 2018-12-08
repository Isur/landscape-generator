using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Presenter.Menu;
using UI.View.Menu.Interface;
using UI.View.UserControls.MenuOptions;

namespace UI.View.Menu
{
    public partial class MenuForm : Form, IMenuView
    {
        private MenuFormPresenter menuFormPresenter;
        public MenuForm()
        {
            InitializeComponent();
            CreatePresenter();
            InitializeMenuOptions();
        }

        void CreatePresenter()
        {
            this.menuFormPresenter = new MenuFormPresenter(this);
        }

        private void InitializeMenuOptions()
        {
            UserControl menuOptionsUC = new MenuOptionsUC
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(menuOptionsUC);
        }
    }
}
