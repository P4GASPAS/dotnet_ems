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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            dataEvent = new DataGridView();
            searchEvent = new Guna.UI2.WinForms.Guna2TextBox();
            filter = new ComboBox();
            label3 = new Label();
            EventID = new DataGridViewTextBoxColumn();
            EventName = new DataGridViewTextBoxColumn();
            EventType = new DataGridViewTextBoxColumn();
            EventCapacity = new DataGridViewTextBoxColumn();
            EventDesc = new DataGridViewTextBoxColumn();
            EventVenue = new DataGridViewTextBoxColumn();
            EventOrganizer = new DataGridViewTextBoxColumn();
            EventStart = new DataGridViewTextBoxColumn();
            EventEnd = new DataGridViewTextBoxColumn();
            EventStatus = new DataGridViewTextBoxColumn();
            EventAction = new DataGridViewTextBoxColumn();
            EventAvailability = new DataGridViewTextBoxColumn();
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
            // btnAddEvent
            // 
            btnAddEvent.BorderRadius = 20;
            btnAddEvent.CustomizableEdges = customizableEdges9;
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
            btnAddEvent.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAddEvent.Size = new Size(125, 40);
            btnAddEvent.TabIndex = 50;
            btnAddEvent.Text = "Add event";
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // dataEvent
            // 
            dataEvent.BackgroundColor = Color.Azure;
            dataEvent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEvent.Columns.AddRange(new DataGridViewColumn[] { EventID, EventName, EventType, EventCapacity, EventDesc, EventVenue, EventOrganizer, EventStart, EventEnd, EventStatus, EventAction, EventAvailability });
            dataEvent.Location = new Point(1, 84);
            dataEvent.Name = "dataEvent";
            dataEvent.RowHeadersVisible = false;
            dataEvent.RowHeadersWidth = 51;
            dataEvent.Size = new Size(1009, 428);
            dataEvent.TabIndex = 49;
            // 
            // searchEvent
            // 
            searchEvent.BorderRadius = 20;
            searchEvent.CustomizableEdges = customizableEdges11;
            searchEvent.DefaultText = "search event";
            searchEvent.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchEvent.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchEvent.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchEvent.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchEvent.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchEvent.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchEvent.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchEvent.Location = new Point(723, 29);
            searchEvent.Margin = new Padding(3, 4, 3, 4);
            searchEvent.Name = "searchEvent";
            searchEvent.PasswordChar = '\0';
            searchEvent.PlaceholderText = "";
            searchEvent.SelectedText = "";
            searchEvent.ShadowDecoration.CustomizableEdges = customizableEdges12;
            searchEvent.Size = new Size(180, 34);
            searchEvent.TabIndex = 47;
            // 
            // filter
            // 
            filter.BackColor = Color.Azure;
            filter.FlatStyle = FlatStyle.Flat;
            filter.FormattingEnabled = true;
            filter.Items.AddRange(new object[] { "Completed ", "In progress" });
            filter.Location = new Point(909, 32);
            filter.Name = "filter";
            filter.Size = new Size(72, 27);
            filter.TabIndex = 46;
            filter.Text = "Filter";
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
            // EventType
            // 
            EventType.HeaderText = "Event Type";
            EventType.MinimumWidth = 6;
            EventType.Name = "EventType";
            EventType.Width = 125;
            // 
            // EventCapacity
            // 
            EventCapacity.HeaderText = "Capacity";
            EventCapacity.MinimumWidth = 6;
            EventCapacity.Name = "EventCapacity";
            EventCapacity.Width = 125;
            // 
            // EventDesc
            // 
            EventDesc.HeaderText = "Description";
            EventDesc.MinimumWidth = 6;
            EventDesc.Name = "EventDesc";
            EventDesc.Width = 125;
            // 
            // EventVenue
            // 
            EventVenue.HeaderText = "Venue";
            EventVenue.MinimumWidth = 6;
            EventVenue.Name = "EventVenue";
            EventVenue.Width = 125;
            // 
            // EventOrganizer
            // 
            EventOrganizer.HeaderText = "Event organizer";
            EventOrganizer.MinimumWidth = 6;
            EventOrganizer.Name = "EventOrganizer";
            EventOrganizer.Width = 125;
            // 
            // EventStart
            // 
            EventStart.HeaderText = "Start";
            EventStart.MinimumWidth = 6;
            EventStart.Name = "EventStart";
            EventStart.Width = 125;
            // 
            // EventEnd
            // 
            EventEnd.HeaderText = "End";
            EventEnd.MinimumWidth = 6;
            EventEnd.Name = "EventEnd";
            EventEnd.Width = 125;
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
            // EventAvailability
            // 
            EventAvailability.HeaderText = "Ticket Availability";
            EventAvailability.MinimumWidth = 6;
            EventAvailability.Name = "EventAvailability";
            EventAvailability.Width = 125;
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
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
        private DataGridViewTextBoxColumn EventID;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn EventType;
        private DataGridViewTextBoxColumn EventCapacity;
        private DataGridViewTextBoxColumn EventDesc;
        private DataGridViewTextBoxColumn EventVenue;
        private DataGridViewTextBoxColumn EventOrganizer;
        private DataGridViewTextBoxColumn EventStart;
        private DataGridViewTextBoxColumn EventEnd;
        private DataGridViewTextBoxColumn EventStatus;
        private DataGridViewTextBoxColumn EventAction;
        private DataGridViewTextBoxColumn EventAvailability;
    }
}
