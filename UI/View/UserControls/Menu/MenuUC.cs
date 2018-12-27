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

namespace UI.View.UserControls.MenuOptions
{
    public partial class MenuUC : UserControl, IMenuView
    {
        private MenuPresenter menuPresenter;
        public MenuUC()
        {
            InitializeComponent();
            CreatePresenter();
        }

        void CreatePresenter()
        {
            this.menuPresenter = new MenuPresenter(this);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

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
    }
}
