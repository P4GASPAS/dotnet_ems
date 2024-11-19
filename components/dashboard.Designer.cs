namespace event_management_system.components
{
    partial class dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            EventName = new DataGridViewTextBoxColumn();
            EventTime = new DataGridViewTextBoxColumn();
            EventDate = new DataGridViewTextBoxColumn();
            EventLocation = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel4 = new Panel();
            lblDashboardTicketSales = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblDashboardTotalRegistrants = new Label();
            lblDashboardregistrants = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 605);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(436, 307);
            panel5.Name = "panel5";
            panel5.Size = new Size(559, 258);
            panel5.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EventName, EventTime, EventDate, EventLocation });
            dataGridView1.Location = new Point(3, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(553, 208);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EventName
            // 
            EventName.HeaderText = "Event Name";
            EventName.MinimumWidth = 8;
            EventName.Name = "EventName";
            EventName.Width = 150;
            // 
            // EventTime
            // 
            EventTime.HeaderText = "Time";
            EventTime.MinimumWidth = 8;
            EventTime.Name = "EventTime";
            EventTime.Width = 150;
            // 
            // EventDate
            // 
            EventDate.HeaderText = "Date";
            EventDate.MinimumWidth = 8;
            EventDate.Name = "EventDate";
            EventDate.Width = 150;
            // 
            // EventLocation
            // 
            EventLocation.HeaderText = "Location";
            EventLocation.MinimumWidth = 8;
            EventLocation.Name = "EventLocation";
            EventLocation.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SkyBlue;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(2, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Padding = new Padding(95, 10, 95, 10);
            label2.Size = new Size(556, 48);
            label2.TabIndex = 3;
            label2.Text = "Upcoming Events (next 7 days)";
            label2.Click += label2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblDashboardTicketSales);
            panel4.Location = new Point(15, 306);
            panel4.Name = "panel4";
            panel4.Size = new Size(408, 258);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // lblDashboardTicketSales
            // 
            lblDashboardTicketSales.AutoSize = true;
            lblDashboardTicketSales.BackColor = Color.SkyBlue;
            lblDashboardTicketSales.Font = new Font("Arial Rounded MT Bold", 12F);
            lblDashboardTicketSales.Location = new Point(-1, 0);
            lblDashboardTicketSales.Margin = new Padding(0);
            lblDashboardTicketSales.Name = "lblDashboardTicketSales";
            lblDashboardTicketSales.Padding = new Padding(45, 10, 45, 10);
            lblDashboardTicketSales.Size = new Size(417, 48);
            lblDashboardTicketSales.TabIndex = 1;
            lblDashboardTicketSales.Text = "Ticket Sales (last 365 days)";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Location = new Point(436, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(559, 264);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SkyBlue;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(0, 1);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(148, 10, 148, 10);
            label1.Size = new Size(559, 48);
            label1.TabIndex = 2;
            label1.Text = "Events (last 365 days)";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(lblDashboardTotalRegistrants);
            panel2.Controls.Add(lblDashboardregistrants);
            panel2.Location = new Point(15, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 264);
            panel2.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Azure;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 124;
            iconPictureBox1.Location = new Point(235, 83);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(136, 124);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // lblDashboardTotalRegistrants
            // 
            lblDashboardTotalRegistrants.AutoSize = true;
            lblDashboardTotalRegistrants.Font = new Font("Arial Rounded MT Bold", 30F);
            lblDashboardTotalRegistrants.Location = new Point(36, 107);
            lblDashboardTotalRegistrants.Name = "lblDashboardTotalRegistrants";
            lblDashboardTotalRegistrants.Size = new Size(193, 70);
            lblDashboardTotalRegistrants.TabIndex = 1;
            lblDashboardTotalRegistrants.Text = "2,235";
            lblDashboardTotalRegistrants.Click += lblDashboardTotalRegistrants_Click;
            // 
            // lblDashboardregistrants
            // 
            lblDashboardregistrants.AutoSize = true;
            lblDashboardregistrants.BackColor = Color.SkyBlue;
            lblDashboardregistrants.Font = new Font("Arial Rounded MT Bold", 12F);
            lblDashboardregistrants.Location = new Point(1, 2);
            lblDashboardregistrants.Margin = new Padding(0);
            lblDashboardregistrants.Name = "lblDashboardregistrants";
            lblDashboardregistrants.Padding = new Padding(45, 10, 45, 10);
            lblDashboardregistrants.Size = new Size(409, 48);
            lblDashboardregistrants.TabIndex = 0;
            lblDashboardregistrants.Text = "Registrants (last 365 days)";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "dashboard";
            Size = new Size(1010, 605);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label lblDashboardregistrants;
        private Label lblDashboardTicketSales;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn EventTime;
        private DataGridViewTextBoxColumn EventDate;
        private DataGridViewTextBoxColumn EventLocation;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblDashboardTotalRegistrants;
    }
}
