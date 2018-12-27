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
    public partial class MainForm : Form, IMainView
    {
        private MainFormPresenter mainFormPresenter;
        public MainForm()
        {
            InitializeComponent();
            CreatePresenter();
            InitializeMenuOptions();
        }

        void CreatePresenter()
        {
            this.mainFormPresenter = new MainFormPresenter(this);
        }

        private void InitializeMenuOptions()
        {
            this.UserControlContainer = new MenuUC
            {
                Dock = DockStyle.Fill
            };
        }

        public ContainerControl UserControlContainer
        {
            set
            {
                this.Controls.Clear();
                this.Controls.Add(value);
            }
        }

        public event PropertyChangedEventHandler CurrentUserControChanged;
    }
}
