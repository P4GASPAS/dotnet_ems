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
    public partial class LogIn : UserControl
    {
        private Form1 form1;
        private SidebarPanel sidebarPanel;
        private TopbarPanel topbarPanel;
        public LogIn(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            form1.ClearMainPanel();
            form1.AddSideTopDynamicPanel();
        }
    }
}
