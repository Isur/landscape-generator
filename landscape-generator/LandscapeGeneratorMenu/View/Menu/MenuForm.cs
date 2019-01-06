using LandscapeGeneratorMenu.Presenter;
using LandscapeGeneratorMenu.View.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeGeneratorMenu.View
{
    public partial class MenuForm : Form, IMenuView
    {
        private MenuFormPresenter menuFormPresenter;
        public MenuForm()
        {
            InitializeComponent();
            CreatePresenter();
            this.ActiveControl = lblTitle;
        }

        void CreatePresenter()
        {
            this.menuFormPresenter = new MenuFormPresenter(this);
        }

        private void btnGenerationSettings_Click(object sender, EventArgs e)
        {
            using (Settings.SettingsForm settings = new Settings.SettingsForm())
            {
                this.Hide();
                settings.ShowDialog(this);
                this.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
            {
                Application.Exit();
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
