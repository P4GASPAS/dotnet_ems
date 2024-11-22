namespace event_management_system.components
{
    partial class ManageStaffs
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
            searchStaff = new Guna.UI2.WinForms.Guna2TextBox();
            lblTittle = new Label();
            dataStaff = new DataGridView();
            StaffID = new DataGridViewTextBoxColumn();
            StaffFN = new DataGridViewTextBoxColumn();
            StaffLN = new DataGridViewTextBoxColumn();
            StaffUsername = new DataGridViewTextBoxColumn();
            StaffStart = new DataGridViewTextBoxColumn();
            StaffEnd = new DataGridViewTextBoxColumn();
            StaffStatus = new DataGridViewTextBoxColumn();
            StaffAction = new DataGridViewTextBoxColumn();
            btnAddStaff = new Guna.UI2.WinForms.Guna2Button();
            filter = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataStaff).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(searchStaff);
            panel1.Controls.Add(lblTittle);
            panel1.Controls.Add(dataStaff);
            panel1.Controls.Add(btnAddStaff);
            panel1.Controls.Add(filter);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 605);
            panel1.TabIndex = 0;
            // 
            // searchStaff
            // 
            searchStaff.BorderRadius = 20;
            searchStaff.CustomizableEdges = customizableEdges1;
            searchStaff.DefaultText = "search staff";
            searchStaff.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchStaff.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchStaff.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchStaff.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchStaff.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchStaff.Font = new Font("Arial", 9F);
            searchStaff.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchStaff.Location = new Point(721, 29);
            searchStaff.Margin = new Padding(3, 4, 3, 4);
            searchStaff.Name = "searchStaff";
            searchStaff.PasswordChar = '\0';
            searchStaff.PlaceholderText = "";
            searchStaff.SelectedText = "";
            searchStaff.ShadowDecoration.CustomizableEdges = customizableEdges2;
            searchStaff.Size = new Size(180, 34);
            searchStaff.TabIndex = 45;
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
            lblTittle.Size = new Size(160, 27);
            lblTittle.TabIndex = 44;
            lblTittle.Text = "Manage Staff";
            // 
            // dataStaff
            // 
            dataStaff.BackgroundColor = Color.Azure;
            dataStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataStaff.Columns.AddRange(new DataGridViewColumn[] { StaffID, StaffFN, StaffLN, StaffUsername, StaffStart, StaffEnd, StaffStatus, StaffAction });
            dataStaff.Location = new Point(1, 84);
            dataStaff.Margin = new Padding(2);
            dataStaff.Name = "dataStaff";
            dataStaff.RowHeadersVisible = false;
            dataStaff.RowHeadersWidth = 62;
            dataStaff.Size = new Size(1009, 428);
            dataStaff.TabIndex = 43;
            // 
            // StaffID
            // 
            StaffID.HeaderText = "ID";
            StaffID.MinimumWidth = 8;
            StaffID.Name = "StaffID";
            StaffID.Width = 150;
            // 
            // StaffFN
            // 
            StaffFN.HeaderText = "First Name";
            StaffFN.MinimumWidth = 8;
            StaffFN.Name = "StaffFN";
            StaffFN.Width = 150;
            // 
            // StaffLN
            // 
            StaffLN.HeaderText = "Last Name";
            StaffLN.MinimumWidth = 8;
            StaffLN.Name = "StaffLN";
            StaffLN.Width = 150;
            // 
            // StaffUsername
            // 
            StaffUsername.HeaderText = "Username";
            StaffUsername.MinimumWidth = 8;
            StaffUsername.Name = "StaffUsername";
            StaffUsername.Width = 150;
            // 
            // StaffStart
            // 
            StaffStart.HeaderText = "Start Date";
            StaffStart.MinimumWidth = 8;
            StaffStart.Name = "StaffStart";
            StaffStart.Width = 150;
            // 
            // StaffEnd
            // 
            StaffEnd.HeaderText = "End Date";
            StaffEnd.MinimumWidth = 8;
            StaffEnd.Name = "StaffEnd";
            StaffEnd.Width = 150;
            // 
            // StaffStatus
            // 
            StaffStatus.HeaderText = "Status";
            StaffStatus.MinimumWidth = 8;
            StaffStatus.Name = "StaffStatus";
            StaffStatus.Width = 150;
            // 
            // StaffAction
            // 
            StaffAction.HeaderText = "Actions";
            StaffAction.MinimumWidth = 8;
            StaffAction.Name = "StaffAction";
            StaffAction.Width = 150;
            // 
            // btnAddStaff
            // 
            btnAddStaff.BorderRadius = 20;
            btnAddStaff.CustomizableEdges = customizableEdges3;
            btnAddStaff.DisabledState.BorderColor = Color.DarkGray;
            btnAddStaff.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddStaff.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddStaff.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddStaff.FillColor = Color.LimeGreen;
            btnAddStaff.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddStaff.ForeColor = Color.Black;
            btnAddStaff.Location = new Point(827, 529);
            btnAddStaff.Margin = new Padding(2);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddStaff.Size = new Size(125, 40);
            btnAddStaff.TabIndex = 42;
            btnAddStaff.Text = "Add staff";
            btnAddStaff.Click += btnAddStaff_Click;
            // 
            // filter
            // 
            filter.BackColor = Color.Azure;
            filter.FlatStyle = FlatStyle.Flat;
            filter.Font = new Font("Arial", 9F);
            filter.FormattingEnabled = true;
            filter.Items.AddRange(new object[] { "Active", "Inactive" });
            filter.Location = new Point(907, 34);
            filter.Name = "filter";
            filter.Size = new Size(72, 25);
            filter.TabIndex = 10;
            filter.Text = "Filter";
            filter.SelectedIndexChanged += filter_SelectedIndexChanged;
            // 
            // ManageStaffs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ManageStaffs";
            Size = new Size(1010, 605);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataStaff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox filter;
        private Guna.UI2.WinForms.Guna2Button btnAddStaff;
        private DataGridView dataStaff;
        private DataGridViewTextBoxColumn StaffID;
        private DataGridViewTextBoxColumn StaffFN;
        private DataGridViewTextBoxColumn StaffLN;
        private DataGridViewTextBoxColumn StaffUsername;
        private DataGridViewTextBoxColumn StaffStart;
        private DataGridViewTextBoxColumn StaffEnd;
        private DataGridViewTextBoxColumn StaffStatus;
        private DataGridViewTextBoxColumn StaffAction;
        private Guna.UI2.WinForms.Guna2TextBox searchStaff;
        private Label lblTittle;
    }
}
