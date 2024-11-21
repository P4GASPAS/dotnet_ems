using System.Windows.Forms;
using System.Xml.Linq;

namespace event_management_system.components
{
    partial class EventRegistration
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            mainpanelEvent = new Panel();
            lblCapacity = new Label();
            NumericUDEventCapacity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            eventEnd = new Label();
            eventStart = new Label();
            DTEventEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            DTEventStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtbxEventLoc = new Guna.UI2.WinForms.Guna2TextBox();
            lblLocation = new Label();
            txtbxEventDesc = new Guna.UI2.WinForms.Guna2TextBox();
            lblEventDesc = new Label();
            btnAddStaff = new Guna.UI2.WinForms.Guna2Button();
            txtbxEventName = new Guna.UI2.WinForms.Guna2TextBox();
            lblEventName = new Label();
            txtbxEventCategory = new Guna.UI2.WinForms.Guna2TextBox();
            lblEventAccess = new Label();
            txtbxEventAccessType = new Guna.UI2.WinForms.Guna2TextBox();
            lblEventCategory = new Label();
            mainpanelEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUDEventCapacity).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Azure;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(47, 35);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(345, 27);
            label3.TabIndex = 32;
            label3.Text = "EVENT REGISTRATION FORM";
            // 
            // mainpanelEvent
            // 
            mainpanelEvent.BackColor = Color.Azure;
            mainpanelEvent.Controls.Add(lblEventCategory);
            mainpanelEvent.Controls.Add(txtbxEventAccessType);
            mainpanelEvent.Controls.Add(lblEventAccess);
            mainpanelEvent.Controls.Add(txtbxEventCategory);
            mainpanelEvent.Controls.Add(lblCapacity);
            mainpanelEvent.Controls.Add(NumericUDEventCapacity);
            mainpanelEvent.Controls.Add(eventEnd);
            mainpanelEvent.Controls.Add(eventStart);
            mainpanelEvent.Controls.Add(DTEventEndDate);
            mainpanelEvent.Controls.Add(DTEventStartDate);
            mainpanelEvent.Controls.Add(txtbxEventLoc);
            mainpanelEvent.Controls.Add(lblLocation);
            mainpanelEvent.Controls.Add(txtbxEventDesc);
            mainpanelEvent.Controls.Add(lblEventDesc);
            mainpanelEvent.Controls.Add(btnAddStaff);
            mainpanelEvent.Controls.Add(txtbxEventName);
            mainpanelEvent.Controls.Add(lblEventName);
            mainpanelEvent.Controls.Add(label3);
            mainpanelEvent.Dock = DockStyle.Fill;
            mainpanelEvent.Location = new Point(0, 0);
            mainpanelEvent.Margin = new Padding(2);
            mainpanelEvent.Name = "mainpanelEvent";
            mainpanelEvent.Size = new Size(1010, 605);
            mainpanelEvent.TabIndex = 0;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCapacity.Location = new Point(661, 112);
            lblCapacity.Margin = new Padding(2, 0, 2, 0);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(87, 23);
            lblCapacity.TabIndex = 61;
            lblCapacity.Text = "Capacity";
            // 
            // NumericUDEventCapacity
            // 
            NumericUDEventCapacity.BackColor = Color.Transparent;
            NumericUDEventCapacity.BorderRadius = 10;
            NumericUDEventCapacity.CustomizableEdges = customizableEdges19;
            NumericUDEventCapacity.Font = new Font("Segoe UI", 9F);
            NumericUDEventCapacity.Location = new Point(661, 138);
            NumericUDEventCapacity.Margin = new Padding(3, 4, 3, 4);
            NumericUDEventCapacity.Name = "NumericUDEventCapacity";
            NumericUDEventCapacity.ShadowDecoration.CustomizableEdges = customizableEdges20;
            NumericUDEventCapacity.Size = new Size(291, 40);
            NumericUDEventCapacity.TabIndex = 60;
            NumericUDEventCapacity.UpDownButtonFillColor = Color.SkyBlue;
            // 
            // eventEnd
            // 
            eventEnd.AutoSize = true;
            eventEnd.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventEnd.Location = new Point(354, 404);
            eventEnd.Margin = new Padding(2, 0, 2, 0);
            eventEnd.Name = "eventEnd";
            eventEnd.Size = new Size(99, 23);
            eventEnd.TabIndex = 59;
            eventEnd.Text = "Event End";
            // 
            // eventStart
            // 
            eventStart.AutoSize = true;
            eventStart.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventStart.Location = new Point(47, 404);
            eventStart.Margin = new Padding(2, 0, 2, 0);
            eventStart.Name = "eventStart";
            eventStart.Size = new Size(108, 23);
            eventStart.TabIndex = 58;
            eventStart.Text = "Event Start";
            // 
            // DTEventEndDate
            // 
            DTEventEndDate.BorderRadius = 10;
            DTEventEndDate.Checked = true;
            DTEventEndDate.CustomizableEdges = customizableEdges21;
            DTEventEndDate.FillColor = Color.SkyBlue;
            DTEventEndDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTEventEndDate.Format = DateTimePickerFormat.Long;
            DTEventEndDate.Location = new Point(354, 432);
            DTEventEndDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DTEventEndDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DTEventEndDate.Name = "DTEventEndDate";
            DTEventEndDate.ShadowDecoration.CustomizableEdges = customizableEdges22;
            DTEventEndDate.Size = new Size(291, 40);
            DTEventEndDate.TabIndex = 57;
            DTEventEndDate.Value = new DateTime(2024, 11, 21, 14, 30, 22, 811);
            // 
            // DTEventStartDate
            // 
            DTEventStartDate.BorderRadius = 10;
            DTEventStartDate.Checked = true;
            DTEventStartDate.CustomizableEdges = customizableEdges23;
            DTEventStartDate.FillColor = Color.SkyBlue;
            DTEventStartDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTEventStartDate.Format = DateTimePickerFormat.Long;
            DTEventStartDate.Location = new Point(47, 432);
            DTEventStartDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DTEventStartDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DTEventStartDate.Name = "DTEventStartDate";
            DTEventStartDate.ShadowDecoration.CustomizableEdges = customizableEdges24;
            DTEventStartDate.Size = new Size(291, 40);
            DTEventStartDate.TabIndex = 56;
            DTEventStartDate.Value = new DateTime(2024, 11, 21, 14, 30, 22, 811);
            // 
            // txtbxEventLoc
            // 
            txtbxEventLoc.BackColor = Color.Transparent;
            txtbxEventLoc.BorderRadius = 10;
            txtbxEventLoc.CustomizableEdges = customizableEdges25;
            txtbxEventLoc.DefaultText = "";
            txtbxEventLoc.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxEventLoc.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxEventLoc.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventLoc.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventLoc.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventLoc.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxEventLoc.ForeColor = Color.Black;
            txtbxEventLoc.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventLoc.Location = new Point(47, 330);
            txtbxEventLoc.Margin = new Padding(3, 4, 3, 4);
            txtbxEventLoc.Name = "txtbxEventLoc";
            txtbxEventLoc.PasswordChar = '\0';
            txtbxEventLoc.PlaceholderForeColor = Color.LightCyan;
            txtbxEventLoc.PlaceholderText = "";
            txtbxEventLoc.SelectedText = "";
            txtbxEventLoc.ShadowDecoration.CustomizableEdges = customizableEdges26;
            txtbxEventLoc.Size = new Size(907, 40);
            txtbxEventLoc.TabIndex = 55;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(47, 303);
            lblLocation.Margin = new Padding(2, 0, 2, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(84, 23);
            lblLocation.TabIndex = 54;
            lblLocation.Text = "Location";
            // 
            // txtbxEventDesc
            // 
            txtbxEventDesc.BackColor = Color.Transparent;
            txtbxEventDesc.BorderRadius = 10;
            txtbxEventDesc.CustomizableEdges = customizableEdges27;
            txtbxEventDesc.DefaultText = "";
            txtbxEventDesc.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxEventDesc.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxEventDesc.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventDesc.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventDesc.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventDesc.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxEventDesc.ForeColor = Color.Black;
            txtbxEventDesc.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventDesc.Location = new Point(47, 237);
            txtbxEventDesc.Margin = new Padding(3, 4, 3, 4);
            txtbxEventDesc.Name = "txtbxEventDesc";
            txtbxEventDesc.PasswordChar = '\0';
            txtbxEventDesc.PlaceholderForeColor = Color.LightCyan;
            txtbxEventDesc.PlaceholderText = "";
            txtbxEventDesc.SelectedText = "";
            txtbxEventDesc.ShadowDecoration.CustomizableEdges = customizableEdges28;
            txtbxEventDesc.Size = new Size(907, 40);
            txtbxEventDesc.TabIndex = 53;
            // 
            // lblEventDesc
            // 
            lblEventDesc.AutoSize = true;
            lblEventDesc.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventDesc.Location = new Point(47, 210);
            lblEventDesc.Margin = new Padding(2, 0, 2, 0);
            lblEventDesc.Name = "lblEventDesc";
            lblEventDesc.Size = new Size(160, 23);
            lblEventDesc.TabIndex = 52;
            lblEventDesc.Text = "Event description";
            // 
            // btnAddStaff
            // 
            btnAddStaff.BorderRadius = 20;
            btnAddStaff.CustomizableEdges = customizableEdges29;
            btnAddStaff.DisabledState.BorderColor = Color.DarkGray;
            btnAddStaff.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddStaff.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddStaff.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddStaff.FillColor = Color.LimeGreen;
            btnAddStaff.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddStaff.ForeColor = Color.Black;
            btnAddStaff.Location = new Point(827, 529);
            btnAddStaff.Margin = new Padding(2);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btnAddStaff.Size = new Size(125, 40);
            btnAddStaff.TabIndex = 51;
            btnAddStaff.Text = "Add staff";
            // 
            // txtbxEventName
            // 
            txtbxEventName.BackColor = Color.Transparent;
            txtbxEventName.BorderRadius = 10;
            txtbxEventName.CustomizableEdges = customizableEdges31;
            txtbxEventName.DefaultText = "";
            txtbxEventName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxEventName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxEventName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventName.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxEventName.ForeColor = Color.Black;
            txtbxEventName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventName.Location = new Point(47, 139);
            txtbxEventName.Margin = new Padding(3, 4, 3, 4);
            txtbxEventName.Name = "txtbxEventName";
            txtbxEventName.PasswordChar = '\0';
            txtbxEventName.PlaceholderForeColor = Color.LightCyan;
            txtbxEventName.PlaceholderText = "";
            txtbxEventName.SelectedText = "";
            txtbxEventName.ShadowDecoration.CustomizableEdges = customizableEdges32;
            txtbxEventName.Size = new Size(291, 40);
            txtbxEventName.TabIndex = 50;
            // 
            // lblEventName
            // 
            lblEventName.AutoSize = true;
            lblEventName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventName.Location = new Point(47, 112);
            lblEventName.Margin = new Padding(2, 0, 2, 0);
            lblEventName.Name = "lblEventName";
            lblEventName.Size = new Size(113, 23);
            lblEventName.TabIndex = 49;
            lblEventName.Text = "Event name";
            // 
            // txtbxEventCategory
            // 
            txtbxEventCategory.BackColor = Color.Transparent;
            txtbxEventCategory.BorderRadius = 10;
            txtbxEventCategory.CustomizableEdges = customizableEdges33;
            txtbxEventCategory.DefaultText = "";
            txtbxEventCategory.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxEventCategory.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxEventCategory.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventCategory.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventCategory.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxEventCategory.ForeColor = Color.Black;
            txtbxEventCategory.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventCategory.Location = new Point(354, 139);
            txtbxEventCategory.Margin = new Padding(3, 4, 3, 4);
            txtbxEventCategory.Name = "txtbxEventCategory";
            txtbxEventCategory.PasswordChar = '\0';
            txtbxEventCategory.PlaceholderForeColor = Color.LightCyan;
            txtbxEventCategory.PlaceholderText = "";
            txtbxEventCategory.SelectedText = "";
            txtbxEventCategory.ShadowDecoration.CustomizableEdges = customizableEdges34;
            txtbxEventCategory.Size = new Size(291, 40);
            txtbxEventCategory.TabIndex = 62;
            // 
            // lblEventAccess
            // 
            lblEventAccess.AutoSize = true;
            lblEventAccess.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventAccess.Location = new Point(661, 404);
            lblEventAccess.Margin = new Padding(2, 0, 2, 0);
            lblEventAccess.Name = "lblEventAccess";
            lblEventAccess.Size = new Size(118, 23);
            lblEventAccess.TabIndex = 63;
            lblEventAccess.Text = "Access type";
            // 
            // txtbxEventAccessType
            // 
            txtbxEventAccessType.BackColor = Color.Transparent;
            txtbxEventAccessType.BorderRadius = 10;
            txtbxEventAccessType.CustomizableEdges = customizableEdges35;
            txtbxEventAccessType.DefaultText = "";
            txtbxEventAccessType.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxEventAccessType.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxEventAccessType.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventAccessType.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventAccessType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventAccessType.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxEventAccessType.ForeColor = Color.Black;
            txtbxEventAccessType.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventAccessType.Location = new Point(661, 432);
            txtbxEventAccessType.Margin = new Padding(3, 4, 3, 4);
            txtbxEventAccessType.Name = "txtbxEventAccessType";
            txtbxEventAccessType.PasswordChar = '\0';
            txtbxEventAccessType.PlaceholderForeColor = Color.LightCyan;
            txtbxEventAccessType.PlaceholderText = "";
            txtbxEventAccessType.SelectedText = "";
            txtbxEventAccessType.ShadowDecoration.CustomizableEdges = customizableEdges36;
            txtbxEventAccessType.Size = new Size(291, 40);
            txtbxEventAccessType.TabIndex = 64;
            // 
            // lblEventCategory
            // 
            lblEventCategory.AutoSize = true;
            lblEventCategory.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventCategory.Location = new Point(354, 112);
            lblEventCategory.Margin = new Padding(2, 0, 2, 0);
            lblEventCategory.Name = "lblEventCategory";
            lblEventCategory.Size = new Size(91, 23);
            lblEventCategory.TabIndex = 65;
            lblEventCategory.Text = "Category";
            // 
            // EventRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainpanelEvent);
            Margin = new Padding(2);
            Name = "EventRegistration";
            Size = new Size(1010, 605);
            mainpanelEvent.ResumeLayout(false);
            mainpanelEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUDEventCapacity).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label lblEventStart;
        private Label lblEventEnd;
        private Label label3;
        private Panel mainpanelEvent;
        private DateTimePicker datetimeEventEnd;
        private DateTimePicker datetimeEventStart;
        private NumericUpDown nmrcEventCapacity;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEventName;
        private Label lblEventName;
        private Guna.UI2.WinForms.Guna2Button btnAddStaff;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEventLoc;
        private Label lblLocation;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEventDesc;
        private Label lblEventDesc;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTEventStartDate;
        private Label lblCapacity;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericUDEventCapacity;
        private Label eventEnd;
        private Label eventStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTEventEndDate;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEventAccessType;
        private Label lblEventAccess;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEventCategory;
        private Label lblEventCategory;
    }
}
