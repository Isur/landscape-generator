using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using landscape_generator.Views.Interfaces;
namespace landscape_generator.Views
{
    public partial class DataGeneratorUserControl : UserControl, IDataGenerator
    {
        public DataGeneratorUserControl()
        {
            InitializeComponent();
        }

        public event Func<bool> tempEvent;

        private void DataGeneratorUserControl_Load(object sender, EventArgs e)
        {
            Label testLabel = new Label();
            Controls.Add(testLabel);
            testLabel.Text = tempEvent.Invoke().ToString();
        }
    }
}
