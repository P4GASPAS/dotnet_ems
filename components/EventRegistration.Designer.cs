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
            mainpanelEvent = new Panel();
            lblEventLocation = new Label();
            lbltxtevntname = new Label();
            lblTittle = new Label();
            txtbxEventName = new TextBox();
            txtbxEventDesc = new TextBox();
            lblEventDesc = new Label();
            txtbxEventLocation = new TextBox();
            nmrcEventCapacity = new NumericUpDown();
            label1 = new Label();
            datetimeEventStart = new DateTimePicker();
            datetimeEventEnd = new DateTimePicker();
            txtbxEventCategory = new TextBox();
            lblEventCategory = new Label();
            cmbbxEventAccessType = new ComboBox();
            label2 = new Label();
            btnAddUser = new Button();
            lblEventStart = new Label();
            lblEventEnd = new Label();
            mainpanelEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcEventCapacity).BeginInit();
            SuspendLayout();
            // 
            // mainpanelEvent
            // 
            mainpanelEvent.BackColor = Color.LightCyan;
            mainpanelEvent.Controls.Add(lblEventEnd);
            mainpanelEvent.Controls.Add(lblEventStart);
            mainpanelEvent.Controls.Add(btnAddUser);
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
            lblTittle.BackColor = Color.LightCyan;
            lblTittle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittle.ForeColor = SystemColors.Desktop;
            lblTittle.Location = new Point(326, 26);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(361, 28);
            lblTittle.TabIndex = 10;
            lblTittle.Text = "EVENT REGISTRATION FORM";
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
            // txtbxEventDesc
            // 
            txtbxEventDesc.BackColor = Color.Azure;
            txtbxEventDesc.ForeColor = SystemColors.WindowFrame;
            txtbxEventDesc.Location = new Point(59, 189);
            txtbxEventDesc.Name = "txtbxEventDesc";
            txtbxEventDesc.Size = new Size(880, 31);
            txtbxEventDesc.TabIndex = 14;
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
            // txtbxEventLocation
            // 
            txtbxEventLocation.BackColor = Color.Azure;
            txtbxEventLocation.ForeColor = SystemColors.WindowFrame;
            txtbxEventLocation.Location = new Point(59, 269);
            txtbxEventLocation.Name = "txtbxEventLocation";
            txtbxEventLocation.Size = new Size(880, 31);
            txtbxEventLocation.TabIndex = 16;
            // 
            // nmrcEventCapacity
            // 
            nmrcEventCapacity.BackColor = Color.Azure;
            nmrcEventCapacity.Location = new Point(759, 356);
            nmrcEventCapacity.Name = "nmrcEventCapacity";
            nmrcEventCapacity.Size = new Size(180, 31);
            nmrcEventCapacity.TabIndex = 17;
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
            // datetimeEventStart
            // 
            datetimeEventStart.Location = new Point(59, 356);
            datetimeEventStart.Name = "datetimeEventStart";
            datetimeEventStart.Size = new Size(301, 31);
            datetimeEventStart.TabIndex = 19;
            //datetimeEventStart.ValueChanged += datetimeEventStart_ValueChanged;
            // 
            // datetimeEventEnd
            // 
            datetimeEventEnd.Location = new Point(405, 355);
            datetimeEventEnd.Name = "datetimeEventEnd";
            datetimeEventEnd.Size = new Size(301, 31);
            datetimeEventEnd.TabIndex = 20;
            //datetimeEventEnd.ValueChanged += datetimeEventEnd_ValueChanged;
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
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.LimeGreen;
            btnAddUser.BackgroundImageLayout = ImageLayout.None;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = SystemColors.Desktop;
            btnAddUser.Location = new Point(746, 522);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(193, 34);
            btnAddUser.TabIndex = 25;
            btnAddUser.Text = "ADD EVENT";
            btnAddUser.UseVisualStyleBackColor = false;
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
            // Event
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainpanelEvent);
            Name = "Event";
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
        private Button btnAddUser;
    }
}
