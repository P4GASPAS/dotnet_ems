using System.Windows.Controls.Primitives;
using event_management_system.components;

namespace event_management_system
{
    public partial class Form1 : Form
    {
        private SidebarPanel sidebarPanel;
        private TopbarPanel topbarPanel;
        public Panel dynamicPanel;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ClearMainPanel()
        {
            mainPanel.Controls.Clear();
        }

        public void AddSideTopDynamicPanel()
        {
            sidebarPanel = new SidebarPanel(this);
            topbarPanel = new TopbarPanel(this);
            dynamicPanel = new Panel();
            this.mainPanel.Controls.Add(sidebarPanel);
            sidebarPanel.Location = new Point(0, 0);
            this.mainPanel.Controls.Add(topbarPanel);
            topbarPanel.Location = new Point(252, 0);
            this.mainPanel.Controls.Add(dynamicPanel);
            dynamicPanel.Location = new Point(252, 68);
            dynamicPanel.Size = new Size(1262, 673);
            this.mainPanel.ResumeLayout();
        }

        public void ClearDynamicPanel()
        {
            dynamicPanel.Controls.Clear();
        }
    }
}
