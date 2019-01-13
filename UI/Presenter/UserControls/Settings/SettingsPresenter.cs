using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.View.UserControls.Settings.Interface;

namespace UI.Presenter.UserControls.Settings
{
    class SettingsPresenter
    {
        private ISettingsView settingsView;
        public SettingsPresenter(ISettingsView settingsView)
        {
            this.settingsView = settingsView;
        }

        public void LoadSettings()
        {
            settingsView.Stepness = PerlinNoise.Properties.Settings.Default.Stepness;
            settingsView.Mountainousness = PerlinNoise.Properties.Settings.Default.Mountainousness;
            settingsView.LandscapeSize = InsightEngine.Properties.Settings.Default.LandscapeSize;
            settingsView.EnvironmentElements = InsightEngine.Properties.Settings.Default.EnvironmentElements;
        }

        public void SaveSettings()
        {
            PerlinNoise.Properties.Settings.Default.Stepness = settingsView.Stepness;
            PerlinNoise.Properties.Settings.Default.Mountainousness = settingsView.Mountainousness;
            InsightEngine.Properties.Settings.Default.LandscapeSize = settingsView.LandscapeSize;
            InsightEngine.Properties.Settings.Default.EnvironmentElements = settingsView.EnvironmentElements;
        }
    }
}
