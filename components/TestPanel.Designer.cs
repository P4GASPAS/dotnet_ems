using System.Windows.Forms;

namespace event_management_system.components
{
    partial class TestPanel
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
            homePanel = new Panel();
            filter = new ComboBox();
            addEventBtn = new Button();
            events = new DataGridView();
            eName = new DataGridViewTextBoxColumn();
            location = new DataGridViewTextBoxColumn();
            startDate = new DataGridViewTextBoxColumn();
            endDate = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            actions = new DataGridViewTextBoxColumn();
            label1 = new Label();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)events).BeginInit();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.BackColor = Color.FromArgb(241, 241, 241);
            homePanel.Controls.Add(filter);
            homePanel.Controls.Add(addEventBtn);
            homePanel.Controls.Add(events);
            homePanel.Controls.Add(label1);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(1010, 605);
            homePanel.TabIndex = 0;
            // 
            // filter
            // 
            filter.FormattingEnabled = true;
            filter.Location = new Point(758, 26);
            filter.Name = "filter";
            filter.Size = new Size(101, 28);
            filter.TabIndex = 9;
            filter.Text = "Filter";
            // 
            // addEventBtn
            // 
            addEventBtn.Location = new Point(890, 19);
            addEventBtn.Name = "addEventBtn";
            addEventBtn.Size = new Size(101, 40);
            addEventBtn.TabIndex = 8;
            addEventBtn.Text = "Add Event";
            addEventBtn.UseVisualStyleBackColor = true;
            addEventBtn.Click += addEventBtn_Click;
            // 
            // events
            // 
            events.AllowUserToOrderColumns = true;
            events.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            events.Columns.AddRange(new DataGridViewColumn[] { eName, location, startDate, endDate, status, type, actions });
            events.Location = new Point(0, 121);
            events.Name = "events";
            events.RowHeadersWidth = 51;
            events.Size = new Size(1010, 484);
            events.TabIndex = 7;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 112);
            label1.Name = "label1";
            label1.Size = new Size(151, 41);
            label1.TabIndex = 0;
            label1.Text = "Test panel";
            // 
            // TestPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(homePanel);
            Name = "TestPanel";
            Size = new Size(1010, 605);
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)events).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel homePanel;
        private Label label1;
        private DataGridView events;
        private DataGridViewTextBoxColumn eName;
        private DataGridViewTextBoxColumn location;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn actions;
        private Button addEventBtn;
        private ComboBox filter;
    }
}
