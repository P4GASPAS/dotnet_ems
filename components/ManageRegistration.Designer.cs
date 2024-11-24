namespace event_management_system.components
{
    partial class ManageRegistration
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelRegistration = new Panel();
            lblTittle = new Label();
            registrationData = new DataGridView();
            ticketID = new DataGridViewTextBoxColumn();
            eventName = new DataGridViewTextBoxColumn();
            ticketsID = new DataGridViewTextBoxColumn();
            registrationDate = new DataGridViewTextBoxColumn();
            ticketType = new DataGridViewTextBoxColumn();
            TicketStatus = new DataGridViewTextBoxColumn();
            ticketAction = new DataGridViewTextBoxColumn();
            btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            searchTicket = new Guna.UI2.WinForms.Guna2TextBox();
            panelRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)registrationData).BeginInit();
            SuspendLayout();
            // 
            // panelRegistration
            // 
            panelRegistration.Controls.Add(searchTicket);
            panelRegistration.Controls.Add(btnAddEvent);
            panelRegistration.Controls.Add(registrationData);
            panelRegistration.Controls.Add(lblTittle);
            panelRegistration.Dock = DockStyle.Fill;
            panelRegistration.Location = new Point(0, 0);
            panelRegistration.Name = "panelRegistration";
            panelRegistration.Size = new Size(1010, 605);
            panelRegistration.TabIndex = 0;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.BackColor = Color.Azure;
            lblTittle.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittle.ForeColor = SystemColors.Desktop;
            lblTittle.Location = new Point(47, 35);
            lblTittle.Margin = new Padding(2, 0, 2, 0);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(297, 27);
            lblTittle.TabIndex = 60;
            lblTittle.Text = "MANAGE REGISTRATION";
            // 
            // registrationData
            // 
            registrationData.BackgroundColor = Color.Azure;
            registrationData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registrationData.Columns.AddRange(new DataGridViewColumn[] { ticketID, eventName, ticketsID, registrationDate, ticketType, TicketStatus, ticketAction });
            registrationData.Location = new Point(1, 88);
            registrationData.Margin = new Padding(2);
            registrationData.Name = "registrationData";
            registrationData.RowHeadersVisible = false;
            registrationData.RowHeadersWidth = 62;
            registrationData.Size = new Size(1009, 428);
            registrationData.TabIndex = 61;
            // 
            // ticketID
            // 
            ticketID.HeaderText = "ID";
            ticketID.MinimumWidth = 6;
            ticketID.Name = "ticketID";
            ticketID.Width = 150;
            // 
            // eventName
            // 
            eventName.HeaderText = "Event Name";
            eventName.MinimumWidth = 8;
            eventName.Name = "eventName";
            eventName.Width = 150;
            // 
            // ticketsID
            // 
            ticketsID.HeaderText = "Ticket ID";
            ticketsID.MinimumWidth = 8;
            ticketsID.Name = "ticketsID";
            ticketsID.Width = 150;
            // 
            // registrationDate
            // 
            registrationDate.HeaderText = "Registration Date";
            registrationDate.MinimumWidth = 8;
            registrationDate.Name = "registrationDate";
            registrationDate.Width = 125;
            // 
            // ticketType
            // 
            ticketType.HeaderText = "Ticket Type";
            ticketType.MinimumWidth = 8;
            ticketType.Name = "ticketType";
            ticketType.Width = 125;
            // 
            // TicketStatus
            // 
            TicketStatus.HeaderText = "Status";
            TicketStatus.MinimumWidth = 6;
            TicketStatus.Name = "TicketStatus";
            TicketStatus.Width = 125;
            // 
            // ticketAction
            // 
            ticketAction.HeaderText = "Actions";
            ticketAction.MinimumWidth = 8;
            ticketAction.Name = "ticketAction";
            ticketAction.Width = 150;
            // 
            // btnAddEvent
            // 
            btnAddEvent.BorderRadius = 20;
            btnAddEvent.CustomizableEdges = customizableEdges5;
            btnAddEvent.DisabledState.BorderColor = Color.DarkGray;
            btnAddEvent.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddEvent.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddEvent.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddEvent.FillColor = Color.LimeGreen;
            btnAddEvent.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEvent.ForeColor = Color.Black;
            btnAddEvent.Location = new Point(800, 531);
            btnAddEvent.Margin = new Padding(2);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddEvent.Size = new Size(157, 40);
            btnAddEvent.TabIndex = 77;
            btnAddEvent.Text = "Add registrants";
            // 
            // searchTicket
            // 
            searchTicket.BorderRadius = 20;
            searchTicket.CustomizableEdges = customizableEdges3;
            searchTicket.DefaultText = "search ticket";
            searchTicket.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchTicket.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchTicket.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchTicket.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchTicket.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchTicket.Font = new Font("Arial", 9F);
            searchTicket.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchTicket.Location = new Point(777, 28);
            searchTicket.Margin = new Padding(3, 4, 3, 4);
            searchTicket.Name = "searchTicket";
            searchTicket.PasswordChar = '\0';
            searchTicket.PlaceholderText = "";
            searchTicket.SelectedText = "";
            searchTicket.ShadowDecoration.CustomizableEdges = customizableEdges4;
            searchTicket.Size = new Size(180, 34);
            searchTicket.TabIndex = 78;
            // 
            // ManageRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panelRegistration);
            Name = "ManageRegistration";
            Size = new Size(1010, 605);
            panelRegistration.ResumeLayout(false);
            panelRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)registrationData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRegistration;
        private Label lblTittle;
        private DataGridView registrationData;
        private DataGridViewTextBoxColumn ticketID;
        private DataGridViewTextBoxColumn eventName;
        private DataGridViewTextBoxColumn ticketsID;
        private DataGridViewTextBoxColumn registrationDate;
        private DataGridViewTextBoxColumn ticketType;
        private DataGridViewTextBoxColumn TicketStatus;
        private DataGridViewTextBoxColumn ticketAction;
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
        private Guna.UI2.WinForms.Guna2TextBox searchTicket;
    }
}
