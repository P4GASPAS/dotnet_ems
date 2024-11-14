namespace event_management_system.components
{
    partial class SidebarPanel
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
            LogoPic = new PictureBox();
            Gatherwell = new Label();
            btnEvent = new Button();
            btnUser = new Button();
            btnTicket = new Button();
            btnRegistrant = new Button();
            btnDashboard = new Button();
            btnTransaction = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)LogoPic).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LogoPic
            // 
            LogoPic.ErrorImage = null;
            LogoPic.Image = Properties.Resources.logo;
            LogoPic.Location = new Point(17, 7);
            LogoPic.Name = "LogoPic";
            LogoPic.Size = new Size(185, 169);
            LogoPic.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPic.TabIndex = 1;
            LogoPic.TabStop = false;
            // 
            // Gatherwell
            // 
            Gatherwell.AutoSize = true;
            Gatherwell.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gatherwell.Location = new Point(18, 184);
            Gatherwell.Name = "Gatherwell";
            Gatherwell.Size = new Size(173, 23);
            Gatherwell.TabIndex = 2;
            Gatherwell.Text = "Welcome, Admin";
            // 
            // btnEvent
            // 
            btnEvent.BackColor = Color.SkyBlue;
            btnEvent.FlatStyle = FlatStyle.Popup;
            btnEvent.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEvent.Image = Properties.Resources.calendar;
            btnEvent.ImageAlign = ContentAlignment.MiddleLeft;
            btnEvent.Location = new Point(0, 380);
            btnEvent.Name = "btnEvent";
            btnEvent.Padding = new Padding(27, 0, 49, 0);
            btnEvent.Size = new Size(252, 71);
            btnEvent.TabIndex = 9;
            btnEvent.Text = "Event";
            btnEvent.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.SkyBlue;
            btnUser.FlatStyle = FlatStyle.Popup;
            btnUser.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUser.Image = Properties.Resources.user2;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 313);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(27, 0, 49, 0);
            btnUser.Size = new Size(252, 71);
            btnUser.TabIndex = 10;
            btnUser.Text = "Staff";
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnTicket
            // 
            btnTicket.BackColor = Color.SkyBlue;
            btnTicket.FlatStyle = FlatStyle.Popup;
            btnTicket.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTicket.Image = Properties.Resources.ticket;
            btnTicket.ImageAlign = ContentAlignment.MiddleLeft;
            btnTicket.Location = new Point(0, 448);
            btnTicket.Name = "btnTicket";
            btnTicket.Padding = new Padding(27, 0, 49, 0);
            btnTicket.Size = new Size(252, 71);
            btnTicket.TabIndex = 11;
            btnTicket.Text = "Ticket";
            btnTicket.UseVisualStyleBackColor = false;
            // 
            // btnRegistrant
            // 
            btnRegistrant.BackColor = Color.SkyBlue;
            btnRegistrant.FlatStyle = FlatStyle.Popup;
            btnRegistrant.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrant.Image = Properties.Resources.user2;
            btnRegistrant.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrant.Location = new Point(0, 514);
            btnRegistrant.Name = "btnRegistrant";
            btnRegistrant.Padding = new Padding(27, 0, 0, 0);
            btnRegistrant.Size = new Size(252, 71);
            btnRegistrant.TabIndex = 12;
            btnRegistrant.Text = "Registrants";
            btnRegistrant.UseCompatibleTextRendering = true;
            btnRegistrant.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.SkyBlue;
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Image = Properties.Resources.home;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 247);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(27, 0, 49, 0);
            btnDashboard.Size = new Size(252, 71);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Home";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnTransaction
            // 
            btnTransaction.BackColor = Color.SkyBlue;
            btnTransaction.FlatStyle = FlatStyle.Popup;
            btnTransaction.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaction.Image = Properties.Resources.dollar;
            btnTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaction.Location = new Point(0, 584);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Padding = new Padding(27, 0, 0, 0);
            btnTransaction.Size = new Size(252, 71);
            btnTransaction.TabIndex = 13;
            btnTransaction.Text = "Transaction";
            btnTransaction.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(LogoPic);
            panel1.Controls.Add(Gatherwell);
            panel1.Controls.Add(btnEvent);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnTicket);
            panel1.Controls.Add(btnRegistrant);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnTransaction);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 673);
            panel1.TabIndex = 14;
            // 
            // SidebarPanel
            // 
            AccessibleName = "SideBar";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(panel1);
            Name = "SidebarPanel";
            Size = new Size(252, 673);
            ((System.ComponentModel.ISupportInitialize)LogoPic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.Label Gatherwell;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnRegistrant;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnTransaction;
        private Panel panel1;
    }
}
