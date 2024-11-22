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
    public partial class ManageEvents : UserControl
    {
        private Form1 form1;
        private EventRegistration eventRegistration;
        public ManageEvents(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            eventRegistration = new EventRegistration();
            this.form1.ClearDynamicPanel();
            this.form1.AddDynamicPanel(eventRegistration);
        }
    }
}
