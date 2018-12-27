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
            this.ChckBxProperty = Properties.Settings.Default.chkBx;
            this.TrckBrProperty = Properties.Settings.Default.trckBr;
            this.CmbBxProperty = Properties.Settings.Default.cmbBx;
            this.ActiveControl = grpMainSettings;
        }

        void CreatePresenter()
        {
            this.settingsFormPresenter = new SettingsFormPresenter(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.chkBx = this.ChckBxProperty;
            Properties.Settings.Default.trckBr = this.TrckBrProperty;
            Properties.Settings.Default.cmbBx = this.CmbBxProperty;
            Properties.Settings.Default.Save();
            this.Close();
        }

        public string CmbBxProperty {
            get => this.cmbBxTemplate.Text;
            set => this.cmbBxTemplate.Text = value;
        }

        public int TrckBrProperty
        {
            get => this.trckBrTemplate.Value;
            set => this.trckBrTemplate.Value = value;
        }

        public bool ChckBxProperty
        {
            get => this.chkBxTemplate.Checked;
            set => this.chkBxTemplate.Checked = value;
        }
    }
}
