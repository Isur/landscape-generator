using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View.UserControls.About
{
    public partial class AboutUC : UserControl
    {
        public event EventHandler AboutClosed;

        public AboutUC()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseAbout();
        }

        private void CloseAbout()
        {
            AboutClosed?.Invoke(this, null);
        }
    }
}
