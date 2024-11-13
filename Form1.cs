using event_management_system.components;

namespace event_management_system
{
    public partial class Form1 : Form
    {
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

        private void homePageBtn_Click(object sender, EventArgs e)
        {
            TestPanel testPanel = new TestPanel();
            mainPanel.SuspendLayout();
            mainPanel.Controls.Add(testPanel);
            testPanel.Location = new Point(252, 68);
            mainPanel.ResumeLayout();
        }
    }
}
