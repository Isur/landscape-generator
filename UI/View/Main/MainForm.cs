using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Model.Enumeration;
using UI.Presenter.Menu;
using UI.View.Menu.Interface;
using UI.View.UserControls.MenuOptions;
using UI.View.UserControls.Settings;

namespace UI.View.Menu
{
    public partial class MainForm : Form, IMainView
    {
        private MainFormPresenter mainFormPresenter;
        private MenuUC menuUC;
        private SettingsUC settingsUC;

        public MainForm()
        {
            InitializeComponent();
            CreatePresenter();
            InitializeUserControls();
        }

        void CreatePresenter()
        {
            this.mainFormPresenter = new MainFormPresenter(this);
        }

        private void InitializeUserControls()
        {
            this.menuUC = new MenuUC
            {
                Dock = DockStyle.Fill,
                Enabled = false
            };
            this.menuUC.SettingsLaunched += SetSettingsUserControl;

            this.settingsUC = new SettingsUC
            {
                Dock = DockStyle.Fill,
                Enabled = false
            };
            this.settingsUC.SettingsClosed += SetMenuUserControl;

            this.Controls.Add(this.menuUC);
            this.Controls.Add(this.settingsUC);

            SetActiveUserControl((int)MainFormUserControls.Menu);
        }

        public void SetActiveUserControl(int activeUserControl)
        {
            foreach (UserControl userControl in this.Controls)
            {
                if ((userControl is MenuUC && activeUserControl == (int)MainFormUserControls.Menu) ||
                    (userControl is SettingsUC && activeUserControl == (int)MainFormUserControls.Settings))
                {
                    userControl.Visible = true;
                    userControl.Enabled = true;
                }
                else
                {
                    userControl.Visible = false;
                    userControl.Enabled = false;
                }
            }
        }

        private void SetSettingsUserControl(object sender, EventArgs e)
        {
            SetActiveUserControl((int)MainFormUserControls.Settings);
        }

        private void SetMenuUserControl(object sender, EventArgs e)
        {
            SetActiveUserControl((int)MainFormUserControls.Menu);
        }
    }
}
