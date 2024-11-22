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
    public partial class ManageRegistrants : UserControl
    {
        private Form1 form1;
        private RegisterRegistrants registerRegistrants;
        public ManageRegistrants(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            registerRegistrants = new RegisterRegistrants();
            form1.ClearDynamicPanel();
            form1.AddDynamicPanel(registerRegistrants);
        }
    }
}
