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

        public void GenerateTerrain()
        {
            //TODO: Generate terrain and save to file in JSON format
        }
    }
}
