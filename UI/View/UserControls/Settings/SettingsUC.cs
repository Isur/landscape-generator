using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.View.UserControls.Settings.Interface;
using UI.Presenter.UserControls.Settings;
using System.Diagnostics;
using UI.Model.Utilities;

namespace UI.View.UserControls.Settings
{
    public partial class SettingsUC : UserControl, ISettingsView
    {
        private SettingsPresenter settingsPresenter;
        public event EventHandler SettingsClosed;
        public SettingsUC()
        {
            InitializeComponent();
            CreaterPresenter();
            InitializeSettingsValues();
        }


        private void CreaterPresenter()
        {
            this.settingsPresenter = new SettingsPresenter(this);
        }

        private void InitializeSettingsValues()
        {
            this.settingsPresenter.LoadSettings();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.settingsPresenter.SaveSettings();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseSettings();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.settingsPresenter.SaveSettings();
            string generatorArguments = ArgumentCreator.CreateArgumentsStringFromSettings();
            Process.Start("TerrainGenerator.exe", generatorArguments);
        }

        private void CloseSettings()
        {
            SettingsClosed?.Invoke(this, null);
        }

        public int Stepness { get { return this.trBarStepness.Value; } set { this.trBarStepness.Value = value; } }
        public int Mountainousness { get { return this.trBarMountainousness.Value; } set { this.trBarMountainousness.Value = value; } }
        public int EnvironmentElements { get { return this.trBarEnvironmentElements.Value; } set { this.trBarEnvironmentElements.Value = value; } }
        public int LandscapeSize { get { return int.Parse(this.cmbBoxLandscapeSize.SelectedItem.ToString()); }set { this.cmbBoxLandscapeSize.SelectedIndex = this.cmbBoxLandscapeSize.FindStringExact(value.ToString()); } }

    }

}
