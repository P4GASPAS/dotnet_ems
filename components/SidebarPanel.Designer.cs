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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SidebarPanel));
            LogoPic = new PictureBox();
            Gatherwell = new Label();
            panel1 = new Panel();
            btnIconTransaction = new FontAwesome.Sharp.IconButton();
            btnIconRegistrants = new FontAwesome.Sharp.IconButton();
            btnIconTicket = new FontAwesome.Sharp.IconButton();
            btnIconEvents = new FontAwesome.Sharp.IconButton();
            btnIconStaff = new FontAwesome.Sharp.IconButton();
            btnIconHome = new FontAwesome.Sharp.IconButton();
            btnReports = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)LogoPic).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LogoPic
            // 
            LogoPic.ErrorImage = null;
            LogoPic.Image = (Image)resources.GetObject("LogoPic.Image");
            LogoPic.Location = new Point(26, 19);
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
            Gatherwell.Location = new Point(37, 191);
            Gatherwell.Name = "Gatherwell";
            Gatherwell.Size = new Size(173, 23);
            Gatherwell.TabIndex = 2;
            Gatherwell.Text = "Welcome, Admin";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnIconTransaction);
            panel1.Controls.Add(btnIconRegistrants);
            panel1.Controls.Add(btnIconTicket);
            panel1.Controls.Add(btnIconEvents);
            panel1.Controls.Add(btnIconStaff);
            panel1.Controls.Add(btnIconHome);
            panel1.Controls.Add(LogoPic);
            panel1.Controls.Add(Gatherwell);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 673);
            panel1.TabIndex = 14;
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
            btnIconTransaction.Location = new Point(2, 521);
            btnIconTransaction.Margin = new Padding(2);
            btnIconTransaction.Name = "btnIconTransaction";
            btnIconTransaction.Size = new Size(250, 54);
            btnIconTransaction.TabIndex = 19;
            btnIconTransaction.Text = "Transactions";
            btnIconTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconTransaction.UseVisualStyleBackColor = false;
            btnIconTransaction.Click += btnIconTransaction_Click;
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
            btnIconRegistrants.Location = new Point(1, 466);
            btnIconRegistrants.Margin = new Padding(2);
            btnIconRegistrants.Name = "btnIconRegistrants";
            btnIconRegistrants.Size = new Size(252, 54);
            btnIconRegistrants.TabIndex = 18;
            btnIconRegistrants.Text = "Registrants";
            btnIconRegistrants.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconRegistrants.UseVisualStyleBackColor = false;
            btnIconRegistrants.Click += btnIconRegistrants_Click;
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
            btnIconTicket.Location = new Point(2, 410);
            btnIconTicket.Margin = new Padding(2);
            btnIconTicket.Name = "btnIconTicket";
            btnIconTicket.Padding = new Padding(0, 0, 40, 0);
            btnIconTicket.Size = new Size(250, 54);
            btnIconTicket.TabIndex = 17;
            btnIconTicket.Text = "Tickets";
            btnIconTicket.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconTicket.UseVisualStyleBackColor = false;
            btnIconTicket.Click += btnIconTicket_Click;
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
            btnIconEvents.Location = new Point(2, 355);
            btnIconEvents.Margin = new Padding(2);
            btnIconEvents.Name = "btnIconEvents";
            btnIconEvents.Padding = new Padding(0, 0, 48, 0);
            btnIconEvents.Size = new Size(250, 54);
            btnIconEvents.TabIndex = 16;
            btnIconEvents.Text = "Events";
            btnIconEvents.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconEvents.UseVisualStyleBackColor = false;
            btnIconEvents.Click += btnIconEvents_Click;
            // 
            // btnIconStaff
            // 
            btnIconStaff.BackColor = Color.SkyBlue;
            btnIconStaff.FlatAppearance.BorderSize = 0;
            btnIconStaff.FlatStyle = FlatStyle.Flat;
            btnIconStaff.Font = new Font("Arial Rounded MT Bold", 12F);
            btnIconStaff.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            btnIconStaff.IconColor = Color.Black;
            btnIconStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIconStaff.Location = new Point(1, 300);
            btnIconStaff.Margin = new Padding(2);
            btnIconStaff.Name = "btnIconStaff";
            btnIconStaff.Padding = new Padding(0, 0, 56, 0);
            btnIconStaff.Size = new Size(252, 54);
            btnIconStaff.TabIndex = 15;
            btnIconStaff.Text = "Staff";
            btnIconStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconStaff.UseVisualStyleBackColor = false;
            btnIconStaff.Click += btnIconStaff_Click;
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
            btnIconHome.Location = new Point(0, 245);
            btnIconHome.Margin = new Padding(2);
            btnIconHome.Name = "btnIconHome";
            btnIconHome.Padding = new Padding(0, 0, 48, 0);
            btnIconHome.Size = new Size(252, 54);
            btnIconHome.TabIndex = 14;
            btnIconHome.Text = "Home";
            btnIconHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconHome.UseVisualStyleBackColor = false;
            btnIconHome.Click += btnIconHome_Click;
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
            btnReports.Location = new Point(2, 578);
            btnReports.Margin = new Padding(2);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(0, 0, 48, 0);
            btnReports.Size = new Size(250, 54);
            btnReports.TabIndex = 20;
            btnReports.Text = "Reports";
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = false;
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
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnIconHome;
        private FontAwesome.Sharp.IconButton btnIconStaff;
        private FontAwesome.Sharp.IconButton btnIconTicket;
        private FontAwesome.Sharp.IconButton btnIconEvents;
        private FontAwesome.Sharp.IconButton btnIconTransaction;
        private FontAwesome.Sharp.IconButton btnIconRegistrants;
        private FontAwesome.Sharp.IconButton btnReports;
    }
}
