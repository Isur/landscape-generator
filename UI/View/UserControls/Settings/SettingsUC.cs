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
        public SettingsUC()
        {
            InitializeComponent();
            CreaterPresenter();
        }

        private void CreaterPresenter()
        {
            this.settingsPresenter = new SettingsPresenter(this);
        }
    }
}
