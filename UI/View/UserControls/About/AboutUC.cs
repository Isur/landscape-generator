using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.View.UserControls.About.Interface;

namespace UI.View.UserControls.About
{
    public partial class AboutUC : UserControl, IAboutView
    {
        public AboutUC()
        {
            InitializeComponent();
        }
    }
}
