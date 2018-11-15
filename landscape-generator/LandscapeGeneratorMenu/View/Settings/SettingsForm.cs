using LandscapeGeneratorMenu.Presenter.Settings;
using LandscapeGeneratorMenu.View.Settings.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeGeneratorMenu.View.Settings
{
    public partial class SettingsForm : Form, ISettingsView
    {
        private SettingsFormPresenter settingsFormPresenter;
        public SettingsForm()
        {
            InitializeComponent();
            CreatePresenter();
            this.chkBoxDrawTextures.Checked = Properties.Settings.Default.DrawTextures;
            this.ActiveControl = grpMainSettings;
        }

        void CreatePresenter()
        {
            this.settingsFormPresenter = new SettingsFormPresenter(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
