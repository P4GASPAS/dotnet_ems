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
    public partial class ManageStaffs : UserControl
    {
        private Form1 form1;
        private RegisterStaff registerStaff;
        public ManageStaffs(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            registerStaff = new RegisterStaff();
            form1.ClearDynamicPanel();
            form1.AddDynamicPanel(registerStaff);
        }
    }
}
