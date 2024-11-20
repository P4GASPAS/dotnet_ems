namespace event_management_system.components
{
    partial class ManageRegistrants
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
            txtbxSearchRegistrants = new Guna.UI2.WinForms.Guna2TextBox();
            lblTittle = new Label();
            registrantsData = new DataGridView();
            ticketID = new DataGridViewTextBoxColumn();
            eventID = new DataGridViewTextBoxColumn();
            registantFN = new DataGridViewTextBoxColumn();
            registantLN = new DataGridViewTextBoxColumn();
            registantTicketype = new DataGridViewTextBoxColumn();
            registantAction = new DataGridViewTextBoxColumn();
            btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            filter = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)registrantsData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtbxSearchRegistrants);
            panel1.Controls.Add(lblTittle);
            panel1.Controls.Add(registrantsData);
            panel1.Controls.Add(btnAddEvent);
            panel1.Controls.Add(filter);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 605);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtbxSearchRegistrants
            // 
            txtbxSearchRegistrants.CustomizableEdges = customizableEdges1;
            txtbxSearchRegistrants.DefaultText = "search registrants";
            txtbxSearchRegistrants.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxSearchRegistrants.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxSearchRegistrants.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxSearchRegistrants.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxSearchRegistrants.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxSearchRegistrants.Font = new Font("Segoe UI", 9F);
            txtbxSearchRegistrants.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxSearchRegistrants.Location = new Point(621, 33);
            txtbxSearchRegistrants.Margin = new Padding(4, 5, 4, 5);
            txtbxSearchRegistrants.Name = "txtbxSearchRegistrants";
            txtbxSearchRegistrants.PasswordChar = '\0';
            txtbxSearchRegistrants.PlaceholderText = "";
            txtbxSearchRegistrants.SelectedText = "";
            txtbxSearchRegistrants.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtbxSearchRegistrants.Size = new Size(225, 33);
            txtbxSearchRegistrants.TabIndex = 55;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.BackColor = Color.Azure;
            lblTittle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittle.ForeColor = SystemColors.Desktop;
            lblTittle.Location = new Point(23, 33);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(243, 28);
            lblTittle.TabIndex = 54;
            lblTittle.Text = "Manage Registrants";
            // 
            // registrantsData
            // 
            registrantsData.BackgroundColor = Color.Azure;
            registrantsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registrantsData.Columns.AddRange(new DataGridViewColumn[] { ticketID, eventID, registantFN, registantLN, registantTicketype, registantAction });
            registrantsData.Location = new Point(1, 91);
            registrantsData.Name = "registrantsData";
            registrantsData.RowHeadersWidth = 62;
            registrantsData.Size = new Size(1007, 422);
            registrantsData.TabIndex = 53;
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
            // registantFN
            // 
            registantFN.HeaderText = "First Name";
            registantFN.MinimumWidth = 8;
            registantFN.Name = "registantFN";
            registantFN.Width = 150;
            // 
            // registantLN
            // 
            registantLN.HeaderText = "Last Name";
            registantLN.MinimumWidth = 8;
            registantLN.Name = "registantLN";
            registantLN.Width = 150;
            // 
            // registantTicketype
            // 
            registantTicketype.HeaderText = "Ticket Type";
            registantTicketype.MinimumWidth = 8;
            registantTicketype.Name = "registantTicketype";
            registantTicketype.Width = 150;
            // 
            // registantAction
            // 
            registantAction.HeaderText = "Actions";
            registantAction.MinimumWidth = 8;
            registantAction.Name = "registantAction";
            registantAction.Width = 150;
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
            btnAddEvent.Location = new Point(798, 532);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddEvent.Size = new Size(190, 40);
            btnAddEvent.TabIndex = 52;
            btnAddEvent.Text = "Add Registrant";
            // 
            // filter
            // 
            filter.FormattingEnabled = true;
            filter.Items.AddRange(new object[] { "VIP", "Regular" });
            filter.Location = new Point(863, 33);
            filter.Margin = new Padding(4);
            filter.Name = "filter";
            filter.Size = new Size(125, 33);
            filter.TabIndex = 51;
            filter.Text = "Filter";
            // 
            // ManageRegistrants
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel1);
            Name = "ManageRegistrants";
            Size = new Size(1010, 605);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)registrantsData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtbxSearchRegistrants;
        private Label lblTittle;
        private DataGridView registrantsData;
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
        private ComboBox filter;
        private DataGridViewTextBoxColumn ticketID;
        private DataGridViewTextBoxColumn eventID;
        private DataGridViewTextBoxColumn registantFN;
        private DataGridViewTextBoxColumn registantLN;
        private DataGridViewTextBoxColumn registantTicketype;
        private DataGridViewTextBoxColumn registantAction;
    }
}
