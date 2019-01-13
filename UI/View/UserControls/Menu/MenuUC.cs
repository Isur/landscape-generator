using System;
using System.Diagnostics;
using System.Windows.Forms;
using UI.Presenter.UserControls.MenuOptions;
using UI.View.UserControls.MenuOptions.Interface;

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

        private void btnLoadLandscape_Click(object sender, EventArgs e)
        {
            string filename = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "ton files (*.ton)|*.ton";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = "\"" + openFileDialog.FileName + "\"";
                    Process.Start("TerrainGenerator.exe", filename);
                }
            }
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
