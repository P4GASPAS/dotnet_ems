namespace event_management_system.components
{
    partial class ManageEvents
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label3 = new Label();
            searchEvent = new Guna.UI2.WinForms.Guna2TextBox();
            filter = new ComboBox();
            dataEvent = new DataGridView();
            EventID = new DataGridViewTextBoxColumn();
            EventName = new DataGridViewTextBoxColumn();
            EventCategory = new DataGridViewTextBoxColumn();
            EventDesc = new DataGridViewTextBoxColumn();
            EventAccess = new DataGridViewTextBoxColumn();
            EventLocation = new DataGridViewTextBoxColumn();
            EventCapacity = new DataGridViewTextBoxColumn();
            EventStatus = new DataGridViewTextBoxColumn();
            EventAction = new DataGridViewTextBoxColumn();
            btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataEvent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(btnAddEvent);
            panel1.Controls.Add(dataEvent);
            panel1.Controls.Add(searchEvent);
            panel1.Controls.Add(filter);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 605);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Azure;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(47, 36);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(170, 27);
            label3.TabIndex = 33;
            label3.Text = "Manage Event";
            // 
            // searchEvent
            // 
            searchEvent.BorderRadius = 20;
            searchEvent.CustomizableEdges = customizableEdges7;
            searchEvent.DefaultText = "search event";
            searchEvent.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchEvent.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchEvent.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchEvent.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchEvent.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchEvent.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchEvent.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchEvent.Location = new Point(723, 29);
            searchEvent.Name = "searchEvent";
            searchEvent.PasswordChar = '\0';
            searchEvent.PlaceholderText = "";
            searchEvent.SelectedText = "";
            searchEvent.ShadowDecoration.CustomizableEdges = customizableEdges8;
            searchEvent.Size = new Size(180, 34);
            searchEvent.TabIndex = 47;
            // 
            // filter
            // 
            filter.BackColor = Color.Azure;
            filter.FlatStyle = FlatStyle.Flat;
            filter.FormattingEnabled = true;
            filter.Items.AddRange(new object[] { "Private", "Public" });
            filter.Location = new Point(909, 32);
            filter.Name = "filter";
            filter.Size = new Size(72, 27);
            filter.TabIndex = 46;
            filter.Text = "Filter";
            // 
            // dataEvent
            // 
            dataEvent.BackgroundColor = Color.Azure;
            dataEvent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEvent.Columns.AddRange(new DataGridViewColumn[] { EventID, EventName, EventCategory, EventDesc, EventAccess, EventLocation, EventCapacity, EventStatus, EventAction });
            dataEvent.Location = new Point(1, 84);
            dataEvent.Name = "dataEvent";
            dataEvent.RowHeadersVisible = false;
            dataEvent.RowHeadersWidth = 51;
            dataEvent.Size = new Size(1009, 428);
            dataEvent.TabIndex = 49;
            // 
            // EventID
            // 
            EventID.HeaderText = "ID";
            EventID.MinimumWidth = 6;
            EventID.Name = "EventID";
            EventID.Width = 125;
            // 
            // EventName
            // 
            EventName.HeaderText = "Event Name";
            EventName.MinimumWidth = 6;
            EventName.Name = "EventName";
            EventName.Width = 125;
            // 
            // EventCategory
            // 
            EventCategory.HeaderText = "Category";
            EventCategory.MinimumWidth = 6;
            EventCategory.Name = "EventCategory";
            EventCategory.Width = 125;
            // 
            // EventDesc
            // 
            EventDesc.HeaderText = "Description";
            EventDesc.MinimumWidth = 6;
            EventDesc.Name = "EventDesc";
            EventDesc.Width = 125;
            // 
            // EventAccess
            // 
            EventAccess.HeaderText = "Access Type";
            EventAccess.MinimumWidth = 6;
            EventAccess.Name = "EventAccess";
            EventAccess.Width = 125;
            // 
            // EventLocation
            // 
            EventLocation.HeaderText = "Location";
            EventLocation.MinimumWidth = 6;
            EventLocation.Name = "EventLocation";
            EventLocation.Width = 125;
            // 
            // EventCapacity
            // 
            EventCapacity.HeaderText = "Capacity";
            EventCapacity.MinimumWidth = 6;
            EventCapacity.Name = "EventCapacity";
            EventCapacity.Width = 125;
            // 
            // EventStatus
            // 
            EventStatus.HeaderText = "Status";
            EventStatus.MinimumWidth = 6;
            EventStatus.Name = "EventStatus";
            EventStatus.Width = 125;
            // 
            // EventAction
            // 
            EventAction.HeaderText = "Actions";
            EventAction.MinimumWidth = 6;
            EventAction.Name = "EventAction";
            EventAction.Width = 125;
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
            btnAddEvent.Location = new Point(827, 529);
            btnAddEvent.Margin = new Padding(2);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddEvent.Size = new Size(125, 40);
            btnAddEvent.TabIndex = 50;
            btnAddEvent.Text = "Add event";
            // 
            // ManageEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ManageEvents";
            Size = new Size(1010, 605);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataEvent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox searchEvent;
        private ComboBox filter;
        private DataGridView dataEvent;
        private DataGridViewTextBoxColumn EventID;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn EventCategory;
        private DataGridViewTextBoxColumn EventDesc;
        private DataGridViewTextBoxColumn EventAccess;
        private DataGridViewTextBoxColumn EventLocation;
        private DataGridViewTextBoxColumn EventCapacity;
        private DataGridViewTextBoxColumn EventStatus;
        private DataGridViewTextBoxColumn EventAction;
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
    }
}
