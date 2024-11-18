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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            filter = new ComboBox();
            btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            dataGridView1 = new DataGridView();
            StaffID = new DataGridViewTextBoxColumn();
            StaffFN = new DataGridViewTextBoxColumn();
            StaffLN = new DataGridViewTextBoxColumn();
            StaffUsername = new DataGridViewTextBoxColumn();
            StaffStart = new DataGridViewTextBoxColumn();
            StaffEnd = new DataGridViewTextBoxColumn();
            StaffStatus = new DataGridViewTextBoxColumn();
            StaffAction = new DataGridViewTextBoxColumn();
            lblTittle = new Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(guna2TextBox1);
            panel1.Controls.Add(lblTittle);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnAddEvent);
            panel1.Controls.Add(filter);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 605);
            panel1.TabIndex = 0;
            // 
            // filter
            // 
            filter.FormattingEnabled = true;
            filter.Location = new Point(862, 47);
            filter.Margin = new Padding(4);
            filter.Name = "filter";
            filter.Size = new Size(125, 33);
            filter.TabIndex = 10;
            filter.Text = "Filter";
            // 
            // btnAddEvent
            // 
            btnAddEvent.BorderRadius = 20;
            btnAddEvent.CustomizableEdges = customizableEdges11;
            btnAddEvent.DisabledState.BorderColor = Color.DarkGray;
            btnAddEvent.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddEvent.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddEvent.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddEvent.FillColor = Color.LimeGreen;
            btnAddEvent.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEvent.ForeColor = Color.Black;
            btnAddEvent.Location = new Point(839, 546);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAddEvent.Size = new Size(148, 40);
            btnAddEvent.TabIndex = 42;
            btnAddEvent.Text = "Add staff";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StaffID, StaffFN, StaffLN, StaffUsername, StaffStart, StaffEnd, StaffStatus, StaffAction });
            dataGridView1.Location = new Point(1, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1007, 422);
            dataGridView1.TabIndex = 43;
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
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.BackColor = Color.Azure;
            lblTittle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittle.ForeColor = SystemColors.Desktop;
            lblTittle.Location = new Point(22, 47);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(163, 28);
            lblTittle.TabIndex = 44;
            lblTittle.Text = "Manage Staff";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.CustomizableEdges = customizableEdges9;
            guna2TextBox1.DefaultText = "search staff";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(620, 47);
            guna2TextBox1.Margin = new Padding(4, 5, 4, 5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2TextBox1.Size = new Size(225, 33);
            guna2TextBox1.TabIndex = 45;
            // 
            // ManageStaffs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel1);
            Name = "ManageStaffs";
            Size = new Size(1010, 605);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox filter;
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn StaffID;
        private DataGridViewTextBoxColumn StaffFN;
        private DataGridViewTextBoxColumn StaffLN;
        private DataGridViewTextBoxColumn StaffUsername;
        private DataGridViewTextBoxColumn StaffStart;
        private DataGridViewTextBoxColumn StaffEnd;
        private DataGridViewTextBoxColumn StaffStatus;
        private DataGridViewTextBoxColumn StaffAction;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Label lblTittle;
    }
}
