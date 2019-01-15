using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View.UserControls.Instructions
{
    public partial class InstructionsUC : UserControl
    {
        public event EventHandler InstructionsClosed;

        public InstructionsUC()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseInstructions();
        }

        private void CloseInstructions()
        {
            InstructionsClosed?.Invoke(this, null);
        }
    }
}
