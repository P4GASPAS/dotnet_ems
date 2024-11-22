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
    public partial class SidebarPanel : UserControl
    {
        private Form1 form1;
        private dashboard dashBoard;
        private ManageStaffs manageStaffs;
        private ManageEvents manageEvents;
        private ManageTicket manageTicket;
        private ManageRegistrants manageRegistrants;
        private Transactions transactions;
        public SidebarPanel(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnIconHome_Click(object sender, EventArgs e)
        {
            form1.ClearDynamicPanel();
            dashBoard = new dashboard();
            form1.AddDynamicPanel(dashBoard);
        }

        private void btnIconStaff_Click(object sender, EventArgs e)
        {
            form1.ClearDynamicPanel();
            manageStaffs = new ManageStaffs(this.form1);
            form1.AddDynamicPanel(manageStaffs);
        }

        private void btnIconEvents_Click(object sender, EventArgs e)
        {
            form1.ClearDynamicPanel();
            manageEvents = new ManageEvents(this.form1);
            form1.AddDynamicPanel(manageEvents);
        }

        private void btnIconTicket_Click(object sender, EventArgs e)
        {
            form1.ClearDynamicPanel();
            manageTicket = new ManageTicket(this.form1);
            form1.AddDynamicPanel(manageTicket);
        }

        private void btnIconRegistrants_Click(object sender, EventArgs e)
        {
            form1.ClearDynamicPanel();
            manageRegistrants = new ManageRegistrants(this.form1);
            form1.AddDynamicPanel(manageRegistrants);
        }

        private void btnIconTransaction_Click(object sender, EventArgs e)
        {
            form1.ClearDynamicPanel();
            transactions = new Transactions();
            form1.AddDynamicPanel(transactions);
        }
    }
}
