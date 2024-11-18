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
            btnIconHome = new FontAwesome.Sharp.IconButton();
            btnIconStaff = new FontAwesome.Sharp.IconButton();
            btnIconEvents = new FontAwesome.Sharp.IconButton();
            btnIconTicket = new FontAwesome.Sharp.IconButton();
            btnIconRegistrants = new FontAwesome.Sharp.IconButton();
            btnIconTransaction = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)LogoPic).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LogoPic
            // 
            LogoPic.ErrorImage = null;
            LogoPic.Image = (Image)resources.GetObject("LogoPic.Image");
            LogoPic.Location = new Point(32, 24);
            LogoPic.Margin = new Padding(4, 4, 4, 4);
            LogoPic.Name = "LogoPic";
            LogoPic.Size = new Size(231, 211);
            LogoPic.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPic.TabIndex = 1;
            LogoPic.TabStop = false;
            // 
            // Gatherwell
            // 
            Gatherwell.AutoSize = true;
            Gatherwell.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gatherwell.Location = new Point(46, 239);
            Gatherwell.Margin = new Padding(4, 0, 4, 0);
            Gatherwell.Name = "Gatherwell";
            Gatherwell.Size = new Size(207, 28);
            Gatherwell.TabIndex = 2;
            Gatherwell.Text = "Welcome, Admin";
            // 
            // panel1
            // 
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
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 841);
            panel1.TabIndex = 14;
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
            btnIconHome.Location = new Point(0, 306);
            btnIconHome.Name = "btnIconHome";
            btnIconHome.Padding = new Padding(0, 0, 60, 0);
            btnIconHome.Size = new Size(315, 68);
            btnIconHome.TabIndex = 14;
            btnIconHome.Text = "Home";
            btnIconHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconHome.UseVisualStyleBackColor = false;
            btnIconHome.Click += btnIconHome_Click;
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
            btnIconStaff.Location = new Point(1, 375);
            btnIconStaff.Name = "btnIconStaff";
            btnIconStaff.Padding = new Padding(0, 0, 70, 0);
            btnIconStaff.Size = new Size(315, 68);
            btnIconStaff.TabIndex = 15;
            btnIconStaff.Text = "Staff";
            btnIconStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconStaff.UseVisualStyleBackColor = false;
            btnIconStaff.Click += btnIconStaff_Click;
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
            btnIconEvents.Location = new Point(2, 444);
            btnIconEvents.Name = "btnIconEvents";
            btnIconEvents.Padding = new Padding(0, 0, 60, 0);
            btnIconEvents.Size = new Size(312, 68);
            btnIconEvents.TabIndex = 16;
            btnIconEvents.Text = "Events";
            btnIconEvents.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconEvents.UseVisualStyleBackColor = false;
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
            btnIconTicket.Location = new Point(2, 513);
            btnIconTicket.Name = "btnIconTicket";
            btnIconTicket.Padding = new Padding(0, 0, 50, 0);
            btnIconTicket.Size = new Size(313, 68);
            btnIconTicket.TabIndex = 17;
            btnIconTicket.Text = "Tickets";
            btnIconTicket.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconTicket.UseVisualStyleBackColor = false;
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
            btnIconRegistrants.Location = new Point(1, 582);
            btnIconRegistrants.Name = "btnIconRegistrants";
            btnIconRegistrants.Size = new Size(315, 68);
            btnIconRegistrants.TabIndex = 18;
            btnIconRegistrants.Text = "Registrants";
            btnIconRegistrants.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconRegistrants.UseVisualStyleBackColor = false;
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
            btnIconTransaction.Location = new Point(2, 651);
            btnIconTransaction.Name = "btnIconTransaction";
            btnIconTransaction.Size = new Size(312, 68);
            btnIconTransaction.TabIndex = 19;
            btnIconTransaction.Text = "Transactions";
            btnIconTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIconTransaction.UseVisualStyleBackColor = false;
            // 
            // SidebarPanel
            // 
            AccessibleName = "SideBar";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "SidebarPanel";
            Size = new Size(315, 841);
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
    }
}
