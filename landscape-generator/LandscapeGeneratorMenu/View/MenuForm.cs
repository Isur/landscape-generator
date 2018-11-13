using LandscapeGeneratorMenu.Presenter;
using LandscapeGeneratorMenu.View.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeGeneratorMenu.View
{
    public partial class MenuForm : Form, IMenuView
    {
        private MenuFormPresenter menuFormPresenter;
        public MenuForm()
        {
            InitializeComponent();
            CreatePresenter();
        }

        void CreatePresenter()
        {
            this.menuFormPresenter = new MenuFormPresenter(this);
        }
    }
}
