using LandscapeGeneratorMenu.View.Settings.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeGeneratorMenu.Presenter.Settings
{
    class SettingsFormPresenter
    {
        ISettingsView settingsView;
        public SettingsFormPresenter(ISettingsView settingsView)
        {
            this.settingsView = settingsView;
        }
    }
}
