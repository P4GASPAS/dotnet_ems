namespace event_management_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            addEventBtn = new Button();
            filter = new ComboBox();
            events = new DataGridView();
            eName = new DataGridViewTextBoxColumn();
            location = new DataGridViewTextBoxColumn();
            startDate = new DataGridViewTextBoxColumn();
            endDate = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            actions = new DataGridViewTextBoxColumn();
            sidePanel = new Panel();
            homePageBtn = new Button();
            topBar = new Panel();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)events).BeginInit();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(addEventBtn);
            mainPanel.Controls.Add(filter);
            mainPanel.Controls.Add(events);
            mainPanel.Controls.Add(sidePanel);
            mainPanel.Controls.Add(topBar);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1262, 673);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // addEventBtn
            // 
            addEventBtn.Location = new Point(1158, 76);
            addEventBtn.Name = "addEventBtn";
            addEventBtn.Size = new Size(101, 40);
            addEventBtn.TabIndex = 7;
            addEventBtn.Text = "Add Event";
            addEventBtn.UseVisualStyleBackColor = true;
            // 
            // filter
            // 
            filter.FormattingEnabled = true;
            filter.Location = new Point(1051, 83);
            filter.Name = "filter";
            filter.Size = new Size(101, 28);
            filter.TabIndex = 8;
            filter.Text = "Filter";
            // 
            // events
            // 
            events.AllowUserToOrderColumns = true;
            events.BackgroundColor = SystemColors.ControlLight;
            events.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            events.Columns.AddRange(new DataGridViewColumn[] { eName, location, startDate, endDate, status, type, actions });
            events.Location = new Point(252, 189);
            events.Name = "events";
            events.RowHeadersWidth = 51;
            events.Size = new Size(1010, 484);
            events.TabIndex = 6;
            // 
            // eName
            // 
            eName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            eName.HeaderText = "Event Name";
            eName.MinimumWidth = 6;
            eName.Name = "eName";
            eName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // location
            // 
            location.HeaderText = "Location";
            location.MinimumWidth = 6;
            location.Name = "location";
            location.Width = 125;
            // 
            // startDate
            // 
            startDate.HeaderText = "Start Date";
            startDate.MinimumWidth = 6;
            startDate.Name = "startDate";
            startDate.Width = 125;
            // 
            // endDate
            // 
            endDate.HeaderText = "End Date";
            endDate.MinimumWidth = 6;
            endDate.Name = "endDate";
            endDate.Width = 125;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 125;
            // 
            // type
            // 
            type.HeaderText = "Type";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.Width = 125;
            // 
            // actions
            // 
            actions.HeaderText = "Actions";
            actions.MinimumWidth = 6;
            actions.Name = "actions";
            actions.Width = 125;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = SystemColors.ButtonShadow;
            sidePanel.Controls.Add(homePageBtn);
            sidePanel.Location = new Point(0, 68);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(252, 605);
            sidePanel.TabIndex = 1;
            // 
            // homePageBtn
            // 
            homePageBtn.BackColor = SystemColors.ActiveCaption;
            homePageBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homePageBtn.Location = new Point(0, 0);
            homePageBtn.Name = "homePageBtn";
            homePageBtn.Size = new Size(252, 50);
            homePageBtn.TabIndex = 0;
            homePageBtn.Text = "Home";
            homePageBtn.UseVisualStyleBackColor = false;
            // 
            // topBar
            // 
            topBar.BackColor = SystemColors.ControlLight;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(1262, 68);
            topBar.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(mainPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)events).EndInit();
            sidePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel topBar;
        private Panel sidePanel;
        private Button homePageBtn;
        private ComboBox filter;
        private Button addEventBtn;
        private DataGridView events;
        private DataGridViewTextBoxColumn eName;
        private DataGridViewTextBoxColumn location;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn actions;
    }
}
