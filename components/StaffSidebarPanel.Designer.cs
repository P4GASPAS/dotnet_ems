namespace event_management_system.components
{
    partial class StaffSidebarPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffSidebarPanel));
            panelStaff = new Panel();
            LogoPic = new PictureBox();
            Gatherwell = new Label();
            btnReports = new FontAwesome.Sharp.IconButton();
            btnIconTransaction = new FontAwesome.Sharp.IconButton();
            btnIconRegistrants = new FontAwesome.Sharp.IconButton();
            btnIconTicket = new FontAwesome.Sharp.IconButton();
            btnIconEvents = new FontAwesome.Sharp.IconButton();
            btnIconHome = new FontAwesome.Sharp.IconButton();
            StaffUsername = new Label();
            panelStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPic).BeginInit();
            SuspendLayout();
            // 
            // panelStaff
            // 
            panelStaff.Controls.Add(StaffUsername);
            panelStaff.Controls.Add(btnReports);
            panelStaff.Controls.Add(btnIconTransaction);
            panelStaff.Controls.Add(btnIconRegistrants);
            panelStaff.Controls.Add(btnIconTicket);
            panelStaff.Controls.Add(btnIconEvents);
            panelStaff.Controls.Add(btnIconHome);
            panelStaff.Controls.Add(Gatherwell);
            panelStaff.Controls.Add(LogoPic);
            panelStaff.Dock = DockStyle.Fill;
            panelStaff.Location = new Point(0, 0);
            panelStaff.Name = "panelStaff";
            panelStaff.Size = new Size(252, 673);
            panelStaff.TabIndex = 0;
            // 
            // LogoPic
            // 
            LogoPic.ErrorImage = null;
            LogoPic.Image = (Image)resources.GetObject("LogoPic.Image");
            LogoPic.Location = new Point(26, 19);
            LogoPic.Name = "LogoPic";
            LogoPic.Size = new Size(185, 169);
            LogoPic.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPic.TabIndex = 2;
            LogoPic.TabStop = false;
            // 
            // Gatherwell
            // 
            Gatherwell.AutoSize = true;
            Gatherwell.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gatherwell.Location = new Point(27, 191);
            Gatherwell.Name = "Gatherwell";
            Gatherwell.Size = new Size(106, 23);
            Gatherwell.TabIndex = 3;
            Gatherwell.Text = "Welcome,";
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.SkyBlue;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Arial Rounded MT Bold", 12F);
            btnReports.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            btnReports.IconColor = Color.Black;
            btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReports.Location = new Point(3, 518);
            btnReports.Margin = new Padding(2);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(0, 0, 48, 0);
            btnReports.Size = new Size(250, 54);
            btnReports.TabIndex = 27;
            btnReports.Text = "Reports";
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnIconTransaction
            // 
            btnIconTransaction.BackColor = Color.SkyBlue;
            btnIconTransaction.FlatAppearance.BorderSize = 0;
            btnIconTransaction.FlatStyle = FlatStyle.Flat;
            btnIconTransaction.Font = new Font("Arial Rounded MT Bold", 12F);
            btnIconTransaction.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btnIconTransaction.IconColor = Color.Black;
            btnIconTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIconTransaction.Location = new Point(3, 461);
            btnIconTransaction.Margin = new Padding(2);
            btnIconTransaction.Name = "btnIconTransaction";
            btnIconTransaction.Size = new Size(250, 54);
            btnIconTransaction.TabIndex = 26;
            btnIconTransaction.Text = "Transactions";
            btnIconTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconTransaction.UseVisualStyleBackColor = false;
            // 
            // btnIconRegistrants
            // 
            btnIconRegistrants.BackColor = Color.SkyBlue;
            btnIconRegistrants.FlatAppearance.BorderSize = 0;
            btnIconRegistrants.FlatStyle = FlatStyle.Flat;
            btnIconRegistrants.Font = new Font("Arial Rounded MT Bold", 12F);
            btnIconRegistrants.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnIconRegistrants.IconColor = Color.Black;
            btnIconRegistrants.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIconRegistrants.Location = new Point(2, 406);
            btnIconRegistrants.Margin = new Padding(2);
            btnIconRegistrants.Name = "btnIconRegistrants";
            btnIconRegistrants.Size = new Size(252, 54);
            btnIconRegistrants.TabIndex = 25;
            btnIconRegistrants.Text = "Registrants";
            btnIconRegistrants.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconRegistrants.UseVisualStyleBackColor = false;
            // 
            // btnIconTicket
            // 
            btnIconTicket.BackColor = Color.SkyBlue;
            btnIconTicket.FlatAppearance.BorderSize = 0;
            btnIconTicket.FlatStyle = FlatStyle.Flat;
            btnIconTicket.Font = new Font("Arial Rounded MT Bold", 12F);
            btnIconTicket.IconChar = FontAwesome.Sharp.IconChar.TicketSimple;
            btnIconTicket.IconColor = Color.Black;
            btnIconTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIconTicket.Location = new Point(3, 350);
            btnIconTicket.Margin = new Padding(2);
            btnIconTicket.Name = "btnIconTicket";
            btnIconTicket.Padding = new Padding(0, 0, 40, 0);
            btnIconTicket.Size = new Size(250, 54);
            btnIconTicket.TabIndex = 24;
            btnIconTicket.Text = "Tickets";
            btnIconTicket.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconTicket.UseVisualStyleBackColor = false;
            // 
            // btnIconEvents
            // 
            btnIconEvents.BackColor = Color.SkyBlue;
            btnIconEvents.FlatAppearance.BorderSize = 0;
            btnIconEvents.FlatStyle = FlatStyle.Flat;
            btnIconEvents.Font = new Font("Arial Rounded MT Bold", 12F);
            btnIconEvents.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            btnIconEvents.IconColor = Color.Black;
            btnIconEvents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIconEvents.Location = new Point(3, 295);
            btnIconEvents.Margin = new Padding(2);
            btnIconEvents.Name = "btnIconEvents";
            btnIconEvents.Padding = new Padding(0, 0, 48, 0);
            btnIconEvents.Size = new Size(250, 54);
            btnIconEvents.TabIndex = 23;
            btnIconEvents.Text = "Events";
            btnIconEvents.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconEvents.UseVisualStyleBackColor = false;
            // 
            // btnIconHome
            // 
            btnIconHome.BackColor = Color.SkyBlue;
            btnIconHome.FlatAppearance.BorderSize = 0;
            btnIconHome.FlatStyle = FlatStyle.Flat;
            btnIconHome.Font = new Font("Arial Rounded MT Bold", 12F);
            btnIconHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnIconHome.IconColor = Color.Black;
            btnIconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIconHome.Location = new Point(1, 241);
            btnIconHome.Margin = new Padding(2);
            btnIconHome.Name = "btnIconHome";
            btnIconHome.Padding = new Padding(0, 0, 48, 0);
            btnIconHome.Size = new Size(252, 54);
            btnIconHome.TabIndex = 21;
            btnIconHome.Text = "Home";
            btnIconHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconHome.UseVisualStyleBackColor = false;
            // 
            // StaffUsername
            // 
            StaffUsername.AutoSize = true;
            StaffUsername.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StaffUsername.Location = new Point(124, 191);
            StaffUsername.Name = "StaffUsername";
            StaffUsername.Size = new Size(108, 23);
            StaffUsername.TabIndex = 28;
            StaffUsername.Text = "username";
            // 
            // StaffSidebarPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(panelStaff);
            Name = "StaffSidebarPanel";
            Size = new Size(252, 673);
            panelStaff.ResumeLayout(false);
            panelStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelStaff;
        private PictureBox LogoPic;
        private Label Gatherwell;
        private FontAwesome.Sharp.IconButton btnReports;
        private FontAwesome.Sharp.IconButton btnIconTransaction;
        private FontAwesome.Sharp.IconButton btnIconRegistrants;
        private FontAwesome.Sharp.IconButton btnIconTicket;
        private FontAwesome.Sharp.IconButton btnIconEvents;
        private FontAwesome.Sharp.IconButton btnIconHome;
        private Label StaffUsername;
    }
}
