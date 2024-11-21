using System.Windows.Controls.Primitives;
using event_management_system.components;

namespace event_management_system
{
    public partial class Form1 : Form
    {
        private SidebarPanel sidebarPanel;
        private TopbarPanel topbarPanel;
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

        public void AddSideTopPanel()
        {
            sidebarPanel = new SidebarPanel();
            topbarPanel = new TopbarPanel();
            this.mainPanel.Controls.Add(sidebarPanel);
            sidebarPanel.Location = new Point(0, 0);
            this.mainPanel.Controls.Add(topbarPanel);
            topbarPanel.Location = new Point(252, 0);
            this.mainPanel.ResumeLayout();
        }
    }
}
