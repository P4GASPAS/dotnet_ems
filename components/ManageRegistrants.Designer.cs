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
            searchRegistrant = new Guna.UI2.WinForms.Guna2TextBox();
            lblTittle = new Label();
            registrantsData = new DataGridView();
            btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            ticketID = new DataGridViewTextBoxColumn();
            registantFN = new DataGridViewTextBoxColumn();
            registantLN = new DataGridViewTextBoxColumn();
            RegistrantEmail = new DataGridViewTextBoxColumn();
            RegistrantContactNumber = new DataGridViewTextBoxColumn();
            RegistrantAddress = new DataGridViewTextBoxColumn();
            registantAction = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)registrantsData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(searchRegistrant);
            panel1.Controls.Add(lblTittle);
            panel1.Controls.Add(registrantsData);
            panel1.Controls.Add(btnAddEvent);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 605);
            panel1.TabIndex = 0;
            // 
            // searchRegistrant
            // 
            searchRegistrant.BorderRadius = 20;
            searchRegistrant.CustomizableEdges = customizableEdges1;
            searchRegistrant.DefaultText = "search registrant";
            searchRegistrant.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchRegistrant.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchRegistrant.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchRegistrant.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchRegistrant.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchRegistrant.Font = new Font("Arial", 9F);
            searchRegistrant.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchRegistrant.Location = new Point(772, 29);
            searchRegistrant.Margin = new Padding(3, 4, 3, 4);
            searchRegistrant.Name = "searchRegistrant";
            searchRegistrant.PasswordChar = '\0';
            searchRegistrant.PlaceholderText = "";
            searchRegistrant.SelectedText = "";
            searchRegistrant.ShadowDecoration.CustomizableEdges = customizableEdges2;
            searchRegistrant.Size = new Size(180, 34);
            searchRegistrant.TabIndex = 58;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.BackColor = Color.Azure;
            lblTittle.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittle.ForeColor = SystemColors.Desktop;
            lblTittle.Location = new Point(47, 36);
            lblTittle.Margin = new Padding(2, 0, 2, 0);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(236, 27);
            lblTittle.TabIndex = 56;
            lblTittle.Text = "Manage Registrants";
            // 
            // registrantsData
            // 
            registrantsData.BackgroundColor = Color.Azure;
            registrantsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registrantsData.Columns.AddRange(new DataGridViewColumn[] { ticketID, registantFN, registantLN, RegistrantEmail, RegistrantContactNumber, RegistrantAddress, registantAction });
            registrantsData.Location = new Point(1, 84);
            registrantsData.Margin = new Padding(2);
            registrantsData.Name = "registrantsData";
            registrantsData.RowHeadersVisible = false;
            registrantsData.RowHeadersWidth = 62;
            registrantsData.Size = new Size(1009, 428);
            registrantsData.TabIndex = 53;
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
            btnAddEvent.Location = new Point(799, 529);
            btnAddEvent.Margin = new Padding(2);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddEvent.Size = new Size(153, 40);
            btnAddEvent.TabIndex = 52;
            btnAddEvent.Text = "Add Registrant";
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // ticketID
            // 
            ticketID.HeaderText = "ID";
            ticketID.MinimumWidth = 8;
            ticketID.Name = "ticketID";
            ticketID.Width = 150;
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
            // RegistrantEmail
            // 
            RegistrantEmail.HeaderText = "Email";
            RegistrantEmail.MinimumWidth = 6;
            RegistrantEmail.Name = "RegistrantEmail";
            RegistrantEmail.Width = 125;
            // 
            // RegistrantContactNumber
            // 
            RegistrantContactNumber.HeaderText = "Contact Number";
            RegistrantContactNumber.MinimumWidth = 6;
            RegistrantContactNumber.Name = "RegistrantContactNumber";
            RegistrantContactNumber.Width = 125;
            // 
            // RegistrantAddress
            // 
            RegistrantAddress.HeaderText = "Address";
            RegistrantAddress.MinimumWidth = 6;
            RegistrantAddress.Name = "RegistrantAddress";
            RegistrantAddress.Width = 125;
            // 
            // registantAction
            // 
            registantAction.HeaderText = "Actions";
            registantAction.MinimumWidth = 8;
            registantAction.Name = "registantAction";
            registantAction.Width = 150;
            // 
            // ManageRegistrants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ManageRegistrants";
            Size = new Size(1010, 605);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)registrantsData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView registrantsData;
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
        private Label lblTittle;
        private Guna.UI2.WinForms.Guna2TextBox searchRegistrant;
        private DataGridViewTextBoxColumn ticketID;
        private DataGridViewTextBoxColumn registantFN;
        private DataGridViewTextBoxColumn registantLN;
        private DataGridViewTextBoxColumn RegistrantEmail;
        private DataGridViewTextBoxColumn RegistrantContactNumber;
        private DataGridViewTextBoxColumn RegistrantAddress;
        private DataGridViewTextBoxColumn registantAction;
    }
}
