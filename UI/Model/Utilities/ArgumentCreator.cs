using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model.Utilities
{
    static class ArgumentCreator
    {
        internal static string CreateArgumentsStringFromSettings()
        {
            string arguments = string.Empty;
            arguments += InsightEngine.Properties.Settings.Default.LandscapeSize.ToString();
            arguments += " ";
            arguments += InsightEngine.Properties.Settings.Default.EnvironmentElements.ToString();
            arguments += " ";
            arguments += (5.20f + PerlinNoise.Properties.Settings.Default.Stepness / 100f).ToString();
            arguments += " ";
            arguments += PerlinNoise.Properties.Settings.Default.Mountainousness.ToString();

            return arguments;
        }
    }
}
