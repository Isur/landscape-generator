using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.View.UserControls.Settings.Interface
{
    interface ISettingsView
    {
        int WaterLevel { get; set; }
        int Stepness { get; set; }
        int Mountainousness { get; set; }
        int EnvironmentElements { get; set; }
    }
}
