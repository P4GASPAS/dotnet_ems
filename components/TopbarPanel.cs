using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace event_management_system.components
{
    public partial class TopbarPanel : UserControl
    {
        private Form1 form1;
        public TopbarPanel(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            form1?.Close();
        }
    }
}
