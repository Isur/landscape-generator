using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace landscape_generator.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var model = new Models.DataGeneratorModel();
            var view = new Views.DataGeneratorUserControl();
            var presenter = new Presenters.DataGeneratorPresenter(view, model);
            Controls.Add(view);
        }
    }
}
