namespace event_management_system.components
{
    partial class ManageTicket
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            searchTicket = new Guna.UI2.WinForms.Guna2TextBox();
            filter = new ComboBox();
            label1 = new Label();
            ticketData = new DataGridView();
            btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            ticketID = new DataGridViewTextBoxColumn();
            eventID = new DataGridViewTextBoxColumn();
            registrantID = new DataGridViewTextBoxColumn();
            ticketType = new DataGridViewTextBoxColumn();
            TicketAccess = new DataGridViewTextBoxColumn();
            ticketPrice = new DataGridViewTextBoxColumn();
            ticketQuantity = new DataGridViewTextBoxColumn();
            ticketAction = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ticketData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(searchTicket);
            panel1.Controls.Add(filter);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ticketData);
            panel1.Controls.Add(btnAddEvent);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 605);
            panel1.TabIndex = 0;
            // 
            // searchTicket
            // 
            searchTicket.BorderRadius = 20;
            searchTicket.CustomizableEdges = customizableEdges1;
            searchTicket.DefaultText = "search ticket";
            searchTicket.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchTicket.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchTicket.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchTicket.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchTicket.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchTicket.Font = new Font("Arial", 9F);
            searchTicket.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchTicket.Location = new Point(694, 27);
            searchTicket.Margin = new Padding(3, 4, 3, 4);
            searchTicket.Name = "searchTicket";
            searchTicket.PasswordChar = '\0';
            searchTicket.PlaceholderText = "";
            searchTicket.SelectedText = "";
            searchTicket.ShadowDecoration.CustomizableEdges = customizableEdges2;
            searchTicket.Size = new Size(180, 34);
            searchTicket.TabIndex = 53;
            // 
            // filter
            // 
            filter.BackColor = Color.Azure;
            filter.FlatStyle = FlatStyle.Flat;
            filter.Font = new Font("Arial", 9F);
            filter.FormattingEnabled = true;
            filter.Location = new Point(880, 36);
            filter.Name = "filter";
            filter.Size = new Size(72, 25);
            filter.TabIndex = 52;
            filter.Text = "Filter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Azure;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(47, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 27);
            label1.TabIndex = 51;
            label1.Text = "Manage Ticket";
            // 
            // ticketData
            // 
            ticketData.BackgroundColor = Color.Azure;
            ticketData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ticketData.Columns.AddRange(new DataGridViewColumn[] { ticketID, eventID, registrantID, ticketType, TicketAccess, ticketPrice, ticketQuantity, ticketAction });
            ticketData.Location = new Point(1, 84);
            ticketData.Margin = new Padding(2);
            ticketData.Name = "ticketData";
            ticketData.RowHeadersVisible = false;
            ticketData.RowHeadersWidth = 62;
            ticketData.Size = new Size(1009, 428);
            ticketData.TabIndex = 48;
            // 
            // btnAddEvent
            // 
            btnAddEvent.BorderRadius = 20;
            btnAddEvent.CustomizableEdges = customizableEdges3;
            btnAddEvent.DisabledState.BorderColor = Color.DarkGray;
            btnAddEvent.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddEvent.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddEvent.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddEvent.FillColor = Color.LimeGreen;
            btnAddEvent.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEvent.ForeColor = Color.Black;
            btnAddEvent.Location = new Point(827, 529);
            btnAddEvent.Margin = new Padding(2);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddEvent.Size = new Size(125, 40);
            btnAddEvent.TabIndex = 47;
            btnAddEvent.Text = "Add ticket";
            // 
            // ticketID
            // 
            ticketID.HeaderText = "ID";
            ticketID.MinimumWidth = 6;
            ticketID.Name = "ticketID";
            ticketID.Width = 150;
            // 
            // eventID
            // 
            eventID.HeaderText = "Event ID";
            eventID.MinimumWidth = 8;
            eventID.Name = "eventID";
            eventID.Width = 150;
            // 
            // registrantID
            // 
            registrantID.HeaderText = "Registrant ID";
            registrantID.MinimumWidth = 8;
            registrantID.Name = "registrantID";
            registrantID.Width = 150;
            // 
            // ticketType
            // 
            ticketType.HeaderText = "Type";
            ticketType.MinimumWidth = 8;
            ticketType.Name = "ticketType";
            ticketType.Width = 125;
            // 
            // TicketAccess
            // 
            TicketAccess.HeaderText = "Access";
            TicketAccess.MinimumWidth = 6;
            TicketAccess.Name = "TicketAccess";
            TicketAccess.Width = 125;
            // 
            // ticketPrice
            // 
            ticketPrice.HeaderText = "Price";
            ticketPrice.MinimumWidth = 8;
            ticketPrice.Name = "ticketPrice";
            ticketPrice.Width = 150;
            // 
            // ticketQuantity
            // 
            ticketQuantity.HeaderText = "Quantity";
            ticketQuantity.MinimumWidth = 8;
            ticketQuantity.Name = "ticketQuantity";
            ticketQuantity.Width = 125;
            // 
            // ticketAction
            // 
            ticketAction.HeaderText = "Actions";
            ticketAction.MinimumWidth = 8;
            ticketAction.Name = "ticketAction";
            ticketAction.Width = 150;
            // 
            // ManageTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ManageTicket";
            Size = new Size(1010, 605);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ticketData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView ticketData;
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox searchTicket;
        private ComboBox filter;
        private DataGridViewTextBoxColumn ticketID;
        private DataGridViewTextBoxColumn eventID;
        private DataGridViewTextBoxColumn registrantID;
        private DataGridViewTextBoxColumn ticketType;
        private DataGridViewTextBoxColumn TicketAccess;
        private DataGridViewTextBoxColumn ticketPrice;
        private DataGridViewTextBoxColumn ticketQuantity;
        private DataGridViewTextBoxColumn ticketAction;
    }
}
