using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.View.UserControls.MenuOptions.Interface;
using UI.Presenter.UserControls.MenuOptions;
using UI.Model.Enumeration;
using System.Threading;

namespace UI.View.UserControls.MenuOptions
{
    public partial class MenuUC : UserControl, IMenuView
    {
        private MenuPresenter menuPresenter;
        public event EventHandler SettingsLaunched;

        public MenuUC()
        {
            InitializeComponent();
            CreatePresenter();
        }

        void CreatePresenter()
        {
            this.menuPresenter = new MenuPresenter(this);
        }

        [STAThread]
        private void btnLoadLandscape_Click(object sender, EventArgs e)
        {
            //Thread landscapeThread = new Thread(delegate ()
            //{
            //    new TerrainGenerator.Form1().Show();
            //});

            //landscapeThread.SetApartmentState(ApartmentState.STA);
            //landscapeThread.Start();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LaunchSettings();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instrukcje użytkowania", "Instrukcje");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informacje o programie Landscape Generator oraz silniku graficznym Insight", "About");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz wyjść z aplikacji?", "Wyjdź z aplikacji", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LaunchSettings()
        {
            SettingsLaunched?.Invoke(this, null);
        }
    }
}
