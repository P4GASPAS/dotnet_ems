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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            mainpanelEvent = new Panel();
            lblEventEnd = new Label();
            lblEventStart = new Label();
            label2 = new Label();
            cmbbxEventAccessType = new ComboBox();
            lblEventCategory = new Label();
            txtbxEventCategory = new TextBox();
            datetimeEventEnd = new DateTimePicker();
            datetimeEventStart = new DateTimePicker();
            label1 = new Label();
            nmrcEventCapacity = new NumericUpDown();
            txtbxEventLocation = new TextBox();
            lblEventDesc = new Label();
            txtbxEventDesc = new TextBox();
            txtbxEventName = new TextBox();
            lblEventLocation = new Label();
            lbltxtevntname = new Label();
            lblTittle = new Label();
            lblEventID = new Label();
            txtbxEventID = new TextBox();
            btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            mainpanelEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcEventCapacity).BeginInit();
            SuspendLayout();
            // 
            // mainpanelEvent
            // 
            mainpanelEvent.BackColor = Color.Azure;
            mainpanelEvent.Controls.Add(btnAddEvent);
            mainpanelEvent.Controls.Add(txtbxEventID);
            mainpanelEvent.Controls.Add(lblEventID);
            mainpanelEvent.Controls.Add(lblEventEnd);
            mainpanelEvent.Controls.Add(lblEventStart);
            mainpanelEvent.Controls.Add(label2);
            mainpanelEvent.Controls.Add(cmbbxEventAccessType);
            mainpanelEvent.Controls.Add(lblEventCategory);
            mainpanelEvent.Controls.Add(txtbxEventCategory);
            mainpanelEvent.Controls.Add(datetimeEventEnd);
            mainpanelEvent.Controls.Add(datetimeEventStart);
            mainpanelEvent.Controls.Add(label1);
            mainpanelEvent.Controls.Add(nmrcEventCapacity);
            mainpanelEvent.Controls.Add(txtbxEventLocation);
            mainpanelEvent.Controls.Add(lblEventDesc);
            mainpanelEvent.Controls.Add(txtbxEventDesc);
            mainpanelEvent.Controls.Add(txtbxEventName);
            mainpanelEvent.Controls.Add(lblEventLocation);
            mainpanelEvent.Controls.Add(lbltxtevntname);
            mainpanelEvent.Controls.Add(lblTittle);
            mainpanelEvent.Dock = DockStyle.Fill;
            mainpanelEvent.Location = new Point(0, 0);
            mainpanelEvent.Name = "mainpanelEvent";
            mainpanelEvent.Size = new Size(1010, 605);
            mainpanelEvent.TabIndex = 0;
            // 
            // lblEventEnd
            // 
            lblEventEnd.AutoSize = true;
            lblEventEnd.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventEnd.Location = new Point(406, 325);
            lblEventEnd.Name = "lblEventEnd";
            lblEventEnd.Size = new Size(91, 21);
            lblEventEnd.TabIndex = 27;
            lblEventEnd.Text = "Event end";
            // 
            // lblEventStart
            // 
            lblEventStart.AutoSize = true;
            lblEventStart.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventStart.Location = new Point(61, 325);
            lblEventStart.Name = "lblEventStart";
            lblEventStart.Size = new Size(96, 21);
            lblEventStart.TabIndex = 26;
            lblEventStart.Text = "Event start";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(538, 418);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 24;
            label2.Text = "Access Type";
            // 
            // cmbbxEventAccessType
            // 
            cmbbxEventAccessType.BackColor = Color.Azure;
            cmbbxEventAccessType.FormattingEnabled = true;
            cmbbxEventAccessType.Items.AddRange(new object[] { "Public", "Private" });
            cmbbxEventAccessType.Location = new Point(538, 451);
            cmbbxEventAccessType.Name = "cmbbxEventAccessType";
            cmbbxEventAccessType.Size = new Size(182, 33);
            cmbbxEventAccessType.TabIndex = 23;
            // 
            // lblEventCategory
            // 
            lblEventCategory.AutoSize = true;
            lblEventCategory.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventCategory.Location = new Point(59, 416);
            lblEventCategory.Name = "lblEventCategory";
            lblEventCategory.Size = new Size(83, 21);
            lblEventCategory.TabIndex = 22;
            lblEventCategory.Text = "Category";
            // 
            // txtbxEventCategory
            // 
            txtbxEventCategory.BackColor = Color.Azure;
            txtbxEventCategory.ForeColor = SystemColors.WindowFrame;
            txtbxEventCategory.Location = new Point(59, 454);
            txtbxEventCategory.Name = "txtbxEventCategory";
            txtbxEventCategory.Size = new Size(442, 31);
            txtbxEventCategory.TabIndex = 21;
            // 
            // datetimeEventEnd
            // 
            datetimeEventEnd.Location = new Point(405, 355);
            datetimeEventEnd.Name = "datetimeEventEnd";
            datetimeEventEnd.Size = new Size(301, 31);
            datetimeEventEnd.TabIndex = 20;
            // 
            // datetimeEventStart
            // 
            datetimeEventStart.Location = new Point(59, 356);
            datetimeEventStart.Name = "datetimeEventStart";
            datetimeEventStart.Size = new Size(301, 31);
            datetimeEventStart.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(759, 325);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 18;
            label1.Text = "Capacity";
            // 
            // nmrcEventCapacity
            // 
            nmrcEventCapacity.BackColor = Color.Azure;
            nmrcEventCapacity.Location = new Point(759, 356);
            nmrcEventCapacity.Name = "nmrcEventCapacity";
            nmrcEventCapacity.Size = new Size(180, 31);
            nmrcEventCapacity.TabIndex = 17;
            // 
            // txtbxEventLocation
            // 
            txtbxEventLocation.BackColor = Color.Azure;
            txtbxEventLocation.ForeColor = SystemColors.WindowFrame;
            txtbxEventLocation.Location = new Point(59, 269);
            txtbxEventLocation.Name = "txtbxEventLocation";
            txtbxEventLocation.Size = new Size(880, 31);
            txtbxEventLocation.TabIndex = 16;
            // 
            // lblEventDesc
            // 
            lblEventDesc.AutoSize = true;
            lblEventDesc.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventDesc.Location = new Point(61, 162);
            lblEventDesc.Name = "lblEventDesc";
            lblEventDesc.Size = new Size(148, 21);
            lblEventDesc.TabIndex = 15;
            lblEventDesc.Text = "Event description";
            // 
            // txtbxEventDesc
            // 
            txtbxEventDesc.BackColor = Color.Azure;
            txtbxEventDesc.ForeColor = SystemColors.WindowFrame;
            txtbxEventDesc.Location = new Point(59, 189);
            txtbxEventDesc.Name = "txtbxEventDesc";
            txtbxEventDesc.Size = new Size(880, 31);
            txtbxEventDesc.TabIndex = 14;
            // 
            // txtbxEventName
            // 
            txtbxEventName.BackColor = Color.Azure;
            txtbxEventName.ForeColor = SystemColors.WindowFrame;
            txtbxEventName.Location = new Point(59, 103);
            txtbxEventName.Name = "txtbxEventName";
            txtbxEventName.Size = new Size(444, 31);
            txtbxEventName.TabIndex = 13;
            // 
            // lblEventLocation
            // 
            lblEventLocation.AutoSize = true;
            lblEventLocation.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventLocation.Location = new Point(61, 240);
            lblEventLocation.Name = "lblEventLocation";
            lblEventLocation.Size = new Size(78, 21);
            lblEventLocation.TabIndex = 12;
            lblEventLocation.Text = "Location";
            // 
            // lbltxtevntname
            // 
            lbltxtevntname.AutoSize = true;
            lbltxtevntname.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltxtevntname.Location = new Point(59, 79);
            lbltxtevntname.Name = "lbltxtevntname";
            lbltxtevntname.Size = new Size(105, 21);
            lbltxtevntname.TabIndex = 11;
            lbltxtevntname.Text = "Event name";
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.BackColor = Color.Azure;
            lblTittle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittle.ForeColor = SystemColors.Desktop;
            lblTittle.Location = new Point(59, 26);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(361, 28);
            lblTittle.TabIndex = 10;
            lblTittle.Text = "EVENT REGISTRATION FORM";
            // 
            // lblEventID
            // 
            lblEventID.AutoSize = true;
            lblEventID.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventID.Location = new Point(538, 79);
            lblEventID.Name = "lblEventID";
            lblEventID.Size = new Size(27, 21);
            lblEventID.TabIndex = 29;
            lblEventID.Text = "ID";
            // 
            // txtbxEventID
            // 
            txtbxEventID.BackColor = Color.Azure;
            txtbxEventID.ForeColor = SystemColors.WindowFrame;
            txtbxEventID.Location = new Point(538, 103);
            txtbxEventID.Name = "txtbxEventID";
            txtbxEventID.Size = new Size(182, 31);
            txtbxEventID.TabIndex = 30;
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
            btnAddEvent.Location = new Point(791, 514);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddEvent.Size = new Size(148, 40);
            btnAddEvent.TabIndex = 31;
            btnAddEvent.Text = "Add event";
            // 
            // EventRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainpanelEvent);
            Name = "EventRegistration";
            Size = new Size(1010, 605);
            mainpanelEvent.ResumeLayout(false);
            mainpanelEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcEventCapacity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanelEvent;
        private Label lblTittle;
        private Label lblEventLocation;
        private Label lbltxtevntname;
        private TextBox txtbxEventName;
        private TextBox txtbxEventDesc;
        private Label lblEventDesc;
        private NumericUpDown nmrcEventCapacity;
        private TextBox txtbxEventLocation;
        private DateTimePicker datetimeEventEnd;
        private DateTimePicker datetimeEventStart;
        private Label label1;
        private Label lblEventCategory;
        private TextBox txtbxEventCategory;
        private ComboBox cmbbxEventAccessType;
        private Label label2;
        private Label lblEventEnd;
        private Label lblEventStart;
        private TextBox txtbxEventID;
        private Label lblEventID;
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
    }
}
