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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTittle = new Label();
            mainpanelEvent = new Panel();
            lblEventType = new Label();
            txtbxEventCategory = new Guna.UI2.WinForms.Guna2TextBox();
            lblCapacity = new Label();
            NumericUDEventCapacity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            eventEnd = new Label();
            eventStart = new Label();
            DTEventEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            DTEventStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtbxEventVenue = new Guna.UI2.WinForms.Guna2TextBox();
            lblVenue = new Label();
            txtbxEventDesc = new Guna.UI2.WinForms.Guna2TextBox();
            lblEventDesc = new Label();
            btnAddStaff = new Guna.UI2.WinForms.Guna2Button();
            txtbxEventName = new Guna.UI2.WinForms.Guna2TextBox();
            lblEventName = new Label();
            lblEventOrganizer = new Label();
            txtbxEventOrganizer = new Guna.UI2.WinForms.Guna2TextBox();
            mainpanelEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUDEventCapacity).BeginInit();
            SuspendLayout();
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.BackColor = Color.Azure;
            lblTittle.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittle.ForeColor = SystemColors.Desktop;
            lblTittle.Location = new Point(47, 19);
            lblTittle.Margin = new Padding(2, 0, 2, 0);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(345, 27);
            lblTittle.TabIndex = 32;
            lblTittle.Text = "EVENT REGISTRATION FORM";
            // 
            // mainpanelEvent
            // 
            mainpanelEvent.BackColor = Color.Azure;
            mainpanelEvent.Controls.Add(txtbxEventOrganizer);
            mainpanelEvent.Controls.Add(lblEventOrganizer);
            mainpanelEvent.Controls.Add(lblEventType);
            mainpanelEvent.Controls.Add(txtbxEventCategory);
            mainpanelEvent.Controls.Add(lblCapacity);
            mainpanelEvent.Controls.Add(NumericUDEventCapacity);
            mainpanelEvent.Controls.Add(eventEnd);
            mainpanelEvent.Controls.Add(eventStart);
            mainpanelEvent.Controls.Add(DTEventEndDate);
            mainpanelEvent.Controls.Add(DTEventStartDate);
            mainpanelEvent.Controls.Add(txtbxEventVenue);
            mainpanelEvent.Controls.Add(lblVenue);
            mainpanelEvent.Controls.Add(txtbxEventDesc);
            mainpanelEvent.Controls.Add(lblEventDesc);
            mainpanelEvent.Controls.Add(btnAddStaff);
            mainpanelEvent.Controls.Add(txtbxEventName);
            mainpanelEvent.Controls.Add(lblEventName);
            mainpanelEvent.Controls.Add(lblTittle);
            mainpanelEvent.Dock = DockStyle.Fill;
            mainpanelEvent.Location = new Point(0, 0);
            mainpanelEvent.Margin = new Padding(2);
            mainpanelEvent.Name = "mainpanelEvent";
            mainpanelEvent.Size = new Size(1010, 605);
            mainpanelEvent.TabIndex = 0;
            // 
            // lblEventType
            // 
            lblEventType.AutoSize = true;
            lblEventType.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventType.Location = new Point(354, 83);
            lblEventType.Margin = new Padding(2, 0, 2, 0);
            lblEventType.Name = "lblEventType";
            lblEventType.Size = new Size(108, 23);
            lblEventType.TabIndex = 65;
            lblEventType.Text = "Event Type";
            // 
            // txtbxEventCategory
            // 
            txtbxEventCategory.BackColor = Color.Transparent;
            txtbxEventCategory.BorderRadius = 10;
            txtbxEventCategory.CustomizableEdges = customizableEdges3;
            txtbxEventCategory.DefaultText = "";
            txtbxEventCategory.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxEventCategory.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxEventCategory.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventCategory.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventCategory.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxEventCategory.ForeColor = Color.Black;
            txtbxEventCategory.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventCategory.Location = new Point(354, 110);
            txtbxEventCategory.Margin = new Padding(3, 4, 3, 4);
            txtbxEventCategory.Name = "txtbxEventCategory";
            txtbxEventCategory.PasswordChar = '\0';
            txtbxEventCategory.PlaceholderForeColor = Color.LightCyan;
            txtbxEventCategory.PlaceholderText = "";
            txtbxEventCategory.SelectedText = "";
            txtbxEventCategory.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtbxEventCategory.Size = new Size(291, 40);
            txtbxEventCategory.TabIndex = 62;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCapacity.Location = new Point(661, 83);
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
            NumericUDEventCapacity.CustomizableEdges = customizableEdges5;
            NumericUDEventCapacity.Font = new Font("Segoe UI", 9F);
            NumericUDEventCapacity.Location = new Point(661, 109);
            NumericUDEventCapacity.Margin = new Padding(3, 4, 3, 4);
            NumericUDEventCapacity.Name = "NumericUDEventCapacity";
            NumericUDEventCapacity.ShadowDecoration.CustomizableEdges = customizableEdges6;
            NumericUDEventCapacity.Size = new Size(291, 40);
            NumericUDEventCapacity.TabIndex = 60;
            NumericUDEventCapacity.UpDownButtonFillColor = Color.SkyBlue;
            // 
            // eventEnd
            // 
            eventEnd.AutoSize = true;
            eventEnd.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventEnd.Location = new Point(354, 434);
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
            eventStart.Location = new Point(47, 434);
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
            DTEventEndDate.CustomizableEdges = customizableEdges7;
            DTEventEndDate.FillColor = Color.SkyBlue;
            DTEventEndDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTEventEndDate.Format = DateTimePickerFormat.Long;
            DTEventEndDate.Location = new Point(354, 462);
            DTEventEndDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DTEventEndDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DTEventEndDate.Name = "DTEventEndDate";
            DTEventEndDate.ShadowDecoration.CustomizableEdges = customizableEdges8;
            DTEventEndDate.Size = new Size(291, 40);
            DTEventEndDate.TabIndex = 57;
            DTEventEndDate.Value = new DateTime(2024, 11, 21, 14, 30, 22, 811);
            // 
            // DTEventStartDate
            // 
            DTEventStartDate.BorderRadius = 10;
            DTEventStartDate.Checked = true;
            DTEventStartDate.CustomizableEdges = customizableEdges9;
            DTEventStartDate.FillColor = Color.SkyBlue;
            DTEventStartDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTEventStartDate.Format = DateTimePickerFormat.Long;
            DTEventStartDate.Location = new Point(47, 462);
            DTEventStartDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DTEventStartDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DTEventStartDate.Name = "DTEventStartDate";
            DTEventStartDate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            DTEventStartDate.Size = new Size(291, 40);
            DTEventStartDate.TabIndex = 56;
            DTEventStartDate.Value = new DateTime(2024, 11, 21, 14, 30, 22, 811);
            // 
            // txtbxEventVenue
            // 
            txtbxEventVenue.BackColor = Color.Transparent;
            txtbxEventVenue.BorderRadius = 10;
            txtbxEventVenue.CustomizableEdges = customizableEdges11;
            txtbxEventVenue.DefaultText = "";
            txtbxEventVenue.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxEventVenue.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxEventVenue.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventVenue.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventVenue.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventVenue.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxEventVenue.ForeColor = Color.Black;
            txtbxEventVenue.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventVenue.Location = new Point(47, 282);
            txtbxEventVenue.Margin = new Padding(3, 4, 3, 4);
            txtbxEventVenue.Name = "txtbxEventVenue";
            txtbxEventVenue.PasswordChar = '\0';
            txtbxEventVenue.PlaceholderForeColor = Color.LightCyan;
            txtbxEventVenue.PlaceholderText = "";
            txtbxEventVenue.SelectedText = "";
            txtbxEventVenue.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtbxEventVenue.Size = new Size(907, 40);
            txtbxEventVenue.TabIndex = 55;
            // 
            // lblVenue
            // 
            lblVenue.AutoSize = true;
            lblVenue.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVenue.Location = new Point(47, 255);
            lblVenue.Margin = new Padding(2, 0, 2, 0);
            lblVenue.Name = "lblVenue";
            lblVenue.Size = new Size(64, 23);
            lblVenue.TabIndex = 54;
            lblVenue.Text = "Venue";
            // 
            // txtbxEventDesc
            // 
            txtbxEventDesc.BackColor = Color.Transparent;
            txtbxEventDesc.BorderRadius = 10;
            txtbxEventDesc.CustomizableEdges = customizableEdges13;
            txtbxEventDesc.DefaultText = "";
            txtbxEventDesc.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxEventDesc.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxEventDesc.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventDesc.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventDesc.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventDesc.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxEventDesc.ForeColor = Color.Black;
            txtbxEventDesc.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventDesc.Location = new Point(47, 199);
            txtbxEventDesc.Margin = new Padding(3, 4, 3, 4);
            txtbxEventDesc.Name = "txtbxEventDesc";
            txtbxEventDesc.PasswordChar = '\0';
            txtbxEventDesc.PlaceholderForeColor = Color.LightCyan;
            txtbxEventDesc.PlaceholderText = "";
            txtbxEventDesc.SelectedText = "";
            txtbxEventDesc.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtbxEventDesc.Size = new Size(907, 40);
            txtbxEventDesc.TabIndex = 53;
            // 
            // lblEventDesc
            // 
            lblEventDesc.AutoSize = true;
            lblEventDesc.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventDesc.Location = new Point(47, 172);
            lblEventDesc.Margin = new Padding(2, 0, 2, 0);
            lblEventDesc.Name = "lblEventDesc";
            lblEventDesc.Size = new Size(160, 23);
            lblEventDesc.TabIndex = 52;
            lblEventDesc.Text = "Event description";
            // 
            // btnAddStaff
            // 
            btnAddStaff.BorderRadius = 20;
            btnAddStaff.CustomizableEdges = customizableEdges15;
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
            btnAddStaff.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnAddStaff.Size = new Size(125, 40);
            btnAddStaff.TabIndex = 51;
            btnAddStaff.Text = "Add staff";
            // 
            // txtbxEventName
            // 
            txtbxEventName.BackColor = Color.Transparent;
            txtbxEventName.BorderRadius = 10;
            txtbxEventName.CustomizableEdges = customizableEdges17;
            txtbxEventName.DefaultText = "";
            txtbxEventName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxEventName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxEventName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventName.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxEventName.ForeColor = Color.Black;
            txtbxEventName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventName.Location = new Point(47, 110);
            txtbxEventName.Margin = new Padding(3, 4, 3, 4);
            txtbxEventName.Name = "txtbxEventName";
            txtbxEventName.PasswordChar = '\0';
            txtbxEventName.PlaceholderForeColor = Color.LightCyan;
            txtbxEventName.PlaceholderText = "";
            txtbxEventName.SelectedText = "";
            txtbxEventName.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtbxEventName.Size = new Size(291, 40);
            txtbxEventName.TabIndex = 50;
            // 
            // lblEventName
            // 
            lblEventName.AutoSize = true;
            lblEventName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventName.Location = new Point(47, 83);
            lblEventName.Margin = new Padding(2, 0, 2, 0);
            lblEventName.Name = "lblEventName";
            lblEventName.Size = new Size(113, 23);
            lblEventName.TabIndex = 49;
            lblEventName.Text = "Event name";
            // 
            // lblEventOrganizer
            // 
            lblEventOrganizer.AutoSize = true;
            lblEventOrganizer.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventOrganizer.Location = new Point(47, 341);
            lblEventOrganizer.Margin = new Padding(2, 0, 2, 0);
            lblEventOrganizer.Name = "lblEventOrganizer";
            lblEventOrganizer.Size = new Size(146, 23);
            lblEventOrganizer.TabIndex = 66;
            lblEventOrganizer.Text = "Event organizer";
            // 
            // txtbxEventOrganizer
            // 
            txtbxEventOrganizer.BackColor = Color.Transparent;
            txtbxEventOrganizer.BorderRadius = 10;
            txtbxEventOrganizer.CustomizableEdges = customizableEdges1;
            txtbxEventOrganizer.DefaultText = "";
            txtbxEventOrganizer.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxEventOrganizer.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxEventOrganizer.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventOrganizer.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxEventOrganizer.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventOrganizer.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxEventOrganizer.ForeColor = Color.Black;
            txtbxEventOrganizer.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxEventOrganizer.Location = new Point(47, 368);
            txtbxEventOrganizer.Margin = new Padding(3, 4, 3, 4);
            txtbxEventOrganizer.Name = "txtbxEventOrganizer";
            txtbxEventOrganizer.PasswordChar = '\0';
            txtbxEventOrganizer.PlaceholderForeColor = Color.LightCyan;
            txtbxEventOrganizer.PlaceholderText = "";
            txtbxEventOrganizer.SelectedText = "";
            txtbxEventOrganizer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtbxEventOrganizer.Size = new Size(907, 40);
            txtbxEventOrganizer.TabIndex = 67;
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
        private Label lblEventOrganizer;
        private Label lblEventStart;
        private Label lblEventEnd;
        private Label lblTittle;
        private Panel mainpanelEvent;
        private DateTimePicker datetimeEventEnd;
        private DateTimePicker datetimeEventStart;
        private NumericUpDown nmrcEventCapacity;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEventName;
        private Label lblEventName;
        private Guna.UI2.WinForms.Guna2Button btnAddStaff;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEventVenue;
        private Label lblVenue;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEventDesc;
        private Label lblEventDesc;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTEventStartDate;
        private Label lblCapacity;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericUDEventCapacity;
        private Label eventEnd;
        private Label eventStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTEventEndDate;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEventCategory;
        private Label lblEventType;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEventOrganizer;
    }
}
