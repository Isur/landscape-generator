using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Presenter.Menu;
using UI.View.Menu.Interface;

namespace UI.View.Menu
{
    public partial class MenuForm : Form, IMenuView
    {
        private MenuFormPresenter menuFormPresenter;
        public MenuForm()
        {
            InitializeComponent();
            CreatePresenter();
            //this.ActiveControl = lblTitle;
        }

        void CreatePresenter()
        {
            this.menuFormPresenter = new MenuFormPresenter(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TestSetting = "CHECK";
            Properties.Settings.Default.Save();
            this.button1.Text = Properties.Settings.Default.TestSetting;
        }
    }
}
