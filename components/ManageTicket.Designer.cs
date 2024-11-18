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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            txtbxSearchTicket = new Guna.UI2.WinForms.Guna2TextBox();
            lblTittle = new Label();
            ticketData = new DataGridView();
            btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            filter = new ComboBox();
            ticketID = new DataGridViewTextBoxColumn();
            eventID = new DataGridViewTextBoxColumn();
            registrantID = new DataGridViewTextBoxColumn();
            ticketType = new DataGridViewTextBoxColumn();
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
            panel1.Controls.Add(txtbxSearchTicket);
            panel1.Controls.Add(lblTittle);
            panel1.Controls.Add(ticketData);
            panel1.Controls.Add(btnAddEvent);
            panel1.Controls.Add(filter);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 605);
            panel1.TabIndex = 0;
            // 
            // txtbxSearchTicket
            // 
            txtbxSearchTicket.CustomizableEdges = customizableEdges5;
            txtbxSearchTicket.DefaultText = "search ticket";
            txtbxSearchTicket.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxSearchTicket.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxSearchTicket.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxSearchTicket.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxSearchTicket.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxSearchTicket.Font = new Font("Segoe UI", 9F);
            txtbxSearchTicket.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxSearchTicket.Location = new Point(621, 33);
            txtbxSearchTicket.Margin = new Padding(4, 5, 4, 5);
            txtbxSearchTicket.Name = "txtbxSearchTicket";
            txtbxSearchTicket.PasswordChar = '\0';
            txtbxSearchTicket.PlaceholderText = "";
            txtbxSearchTicket.SelectedText = "";
            txtbxSearchTicket.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtbxSearchTicket.Size = new Size(225, 33);
            txtbxSearchTicket.TabIndex = 50;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.BackColor = Color.Azure;
            lblTittle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittle.ForeColor = SystemColors.Desktop;
            lblTittle.Location = new Point(23, 33);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(181, 28);
            lblTittle.TabIndex = 49;
            lblTittle.Text = "Manage Ticket";
            // 
            // ticketData
            // 
            ticketData.BackgroundColor = Color.Azure;
            ticketData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ticketData.Columns.AddRange(new DataGridViewColumn[] { ticketID, eventID, registrantID, ticketType, ticketPrice, ticketQuantity, ticketAction });
            ticketData.Location = new Point(2, 91);
            ticketData.Name = "ticketData";
            ticketData.RowHeadersWidth = 62;
            ticketData.Size = new Size(1007, 422);
            ticketData.TabIndex = 48;
            // 
            // btnAddEvent
            // 
            btnAddEvent.BorderRadius = 20;
            btnAddEvent.CustomizableEdges = customizableEdges7;
            btnAddEvent.DisabledState.BorderColor = Color.DarkGray;
            btnAddEvent.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddEvent.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddEvent.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddEvent.FillColor = Color.LimeGreen;
            btnAddEvent.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEvent.ForeColor = Color.Black;
            btnAddEvent.Location = new Point(840, 532);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddEvent.Size = new Size(148, 40);
            btnAddEvent.TabIndex = 47;
            btnAddEvent.Text = "Add ticket";
            // 
            // filter
            // 
            filter.FormattingEnabled = true;
            filter.Items.AddRange(new object[] { "VIP", "Regular" });
            filter.Location = new Point(863, 33);
            filter.Margin = new Padding(4);
            filter.Name = "filter";
            filter.Size = new Size(125, 33);
            filter.TabIndex = 46;
            filter.Text = "Filter";
            // 
            // ticketID
            // 
            ticketID.HeaderText = "ID";
            ticketID.MinimumWidth = 8;
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
            ticketType.Width = 150;
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
            ticketQuantity.Width = 150;
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ManageTicket";
            Size = new Size(1010, 605);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ticketData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtbxSearchTicket;
        private Label lblTittle;
        private DataGridView ticketData;
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
        private ComboBox filter;
        private DataGridViewTextBoxColumn ticketID;
        private DataGridViewTextBoxColumn eventID;
        private DataGridViewTextBoxColumn registrantID;
        private DataGridViewTextBoxColumn ticketType;
        private DataGridViewTextBoxColumn ticketPrice;
        private DataGridViewTextBoxColumn ticketQuantity;
        private DataGridViewTextBoxColumn ticketAction;
    }
}
