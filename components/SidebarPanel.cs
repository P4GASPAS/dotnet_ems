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
        public SidebarPanel(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnIconHome_Click(object sender, EventArgs e)
        {
            form1.ClearDynamicPanel();
            dashBoard = new dashboard();
            form1.dynamicPanel.Controls.Add(dashBoard);
            dashBoard.Dock = DockStyle.Fill;
            form1.dynamicPanel.ResumeLayout();
        }

        private void btnIconStaff_Click(object sender, EventArgs e)
        {
            form1.ClearDynamicPanel();
            manageStaffs = new ManageStaffs();
            form1.dynamicPanel.Controls.Add(manageStaffs);
            dashBoard.Dock = DockStyle.Fill;
            form1.dynamicPanel.ResumeLayout();
        }

        private void btnIconEvents_Click(object sender, EventArgs e)
        {
            form1.ClearDynamicPanel();
            manageEvents = new ManageEvents();
            form1.dynamicPanel.Controls.Add(manageEvents);
            dashBoard.Dock = DockStyle.Fill;
            form1.dynamicPanel.ResumeLayout();
        }

        private void btnIconTicket_Click(object sender, EventArgs e)
        {
            form1.ClearDynamicPanel();
            manageTicket = new ManageTicket();
            form1.dynamicPanel.Controls.Add(manageTicket);
            dashBoard.Dock = DockStyle.Fill;
            form1.dynamicPanel.ResumeLayout();
        }

        private void btnIconRegistrants_Click(object sender, EventArgs e)
        {
            form1.ClearDynamicPanel();
            manageRegistrants = new ManageRegistrants();
            form1.dynamicPanel.Controls.Add(manageRegistrants);
            dashBoard.Dock = DockStyle.Fill;
            form1.dynamicPanel.ResumeLayout();
        }

        private void btnIconTransaction_Click(object sender, EventArgs e)
        {
            form1.ClearDynamicPanel();
            manageStaffs = new ManageStaffs();
            form1.dynamicPanel.Controls.Add(manageStaffs);
            dashBoard.Dock = DockStyle.Fill;
            form1.dynamicPanel.ResumeLayout();
        }
    }
}
