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
            this.settingsPresenter.InitializeSettings();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.settingsPresenter.SaveSettings();
            CloseSettings();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseSettings();
        }

        private void CloseSettings()
        {
            SettingsClosed?.Invoke(this, null);
        }

        public int WaterLevel { get { return this.trBarWaterLevel.Value; } set { this.trBarWaterLevel.Value = value; } }
        public int Stepness { get { return this.trBarStepness.Value; } set { this.trBarStepness.Value = value; } }
        public int Mountainousness { get { return this.trBarMountainousness.Value; } set { this.trBarMountainousness.Value = value; } }
        public int EnvironmentElements { get { return this.trBarEnvironmentElements.Value; } set { this.trBarEnvironmentElements.Value = value; } }

    }

}
