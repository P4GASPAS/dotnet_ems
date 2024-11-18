namespace event_management_system.components
{
    partial class RegisterStaff
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
            panel1 = new Panel();
            lblEventID = new Label();
            lblTittle = new Label();
            txtbxStaffFN = new TextBox();
            txtbxStaffID = new TextBox();
            lblFN = new Label();
            txtbxStaffLN = new TextBox();
            lblLN = new Label();
            lblUsername = new Label();
            txtbxStaffUsername = new TextBox();
            lblPassword = new Label();
            txtbxStaffPassword = new TextBox();
            btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            lblStartDate = new Label();
            datetimeEventStart = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(datetimeEventStart);
            panel1.Controls.Add(lblStartDate);
            panel1.Controls.Add(btnAddEvent);
            panel1.Controls.Add(txtbxStaffPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtbxStaffUsername);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblLN);
            panel1.Controls.Add(txtbxStaffLN);
            panel1.Controls.Add(lblFN);
            panel1.Controls.Add(txtbxStaffID);
            panel1.Controls.Add(txtbxStaffFN);
            panel1.Controls.Add(lblTittle);
            panel1.Controls.Add(lblEventID);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 605);
            panel1.TabIndex = 0;
            // 
            // lblEventID
            // 
            lblEventID.AutoSize = true;
            lblEventID.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventID.Location = new Point(59, 79);
            lblEventID.Name = "lblEventID";
            lblEventID.Size = new Size(27, 21);
            lblEventID.TabIndex = 30;
            lblEventID.Text = "ID";
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.BackColor = Color.Azure;
            lblTittle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittle.ForeColor = SystemColors.Desktop;
            lblTittle.Location = new Point(59, 26);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(355, 28);
            lblTittle.TabIndex = 31;
            lblTittle.Text = "STAFF REGISTRATION FORM";
            // 
            // txtbxStaffFN
            // 
            txtbxStaffFN.BackColor = Color.Azure;
            txtbxStaffFN.ForeColor = SystemColors.WindowFrame;
            txtbxStaffFN.Location = new Point(59, 191);
            txtbxStaffFN.Name = "txtbxStaffFN";
            txtbxStaffFN.Size = new Size(426, 31);
            txtbxStaffFN.TabIndex = 32;
            // 
            // txtbxStaffID
            // 
            txtbxStaffID.BackColor = Color.Azure;
            txtbxStaffID.ForeColor = SystemColors.WindowFrame;
            txtbxStaffID.Location = new Point(59, 103);
            txtbxStaffID.Name = "txtbxStaffID";
            txtbxStaffID.Size = new Size(182, 31);
            txtbxStaffID.TabIndex = 33;
            // 
            // lblFN
            // 
            lblFN.AutoSize = true;
            lblFN.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFN.Location = new Point(59, 167);
            lblFN.Name = "lblFN";
            lblFN.Size = new Size(94, 21);
            lblFN.TabIndex = 34;
            lblFN.Text = "First name";
            // 
            // txtbxStaffLN
            // 
            txtbxStaffLN.BackColor = Color.Azure;
            txtbxStaffLN.ForeColor = SystemColors.WindowFrame;
            txtbxStaffLN.Location = new Point(525, 191);
            txtbxStaffLN.Name = "txtbxStaffLN";
            txtbxStaffLN.Size = new Size(426, 31);
            txtbxStaffLN.TabIndex = 35;
            // 
            // lblLN
            // 
            lblLN.AutoSize = true;
            lblLN.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLN.Location = new Point(525, 167);
            lblLN.Name = "lblLN";
            lblLN.Size = new Size(93, 21);
            lblLN.TabIndex = 36;
            lblLN.Text = "Last name";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(59, 254);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 21);
            lblUsername.TabIndex = 37;
            lblUsername.Text = "Username";
            // 
            // txtbxStaffUsername
            // 
            txtbxStaffUsername.BackColor = Color.Azure;
            txtbxStaffUsername.ForeColor = SystemColors.WindowFrame;
            txtbxStaffUsername.Location = new Point(59, 278);
            txtbxStaffUsername.Name = "txtbxStaffUsername";
            txtbxStaffUsername.Size = new Size(426, 31);
            txtbxStaffUsername.TabIndex = 38;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(525, 254);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(89, 21);
            lblPassword.TabIndex = 39;
            lblPassword.Text = "Password";
            // 
            // txtbxStaffPassword
            // 
            txtbxStaffPassword.BackColor = Color.Azure;
            txtbxStaffPassword.ForeColor = SystemColors.WindowFrame;
            txtbxStaffPassword.Location = new Point(525, 278);
            txtbxStaffPassword.Name = "txtbxStaffPassword";
            txtbxStaffPassword.Size = new Size(426, 31);
            txtbxStaffPassword.TabIndex = 40;
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
            btnAddEvent.TabIndex = 41;
            btnAddEvent.Text = "Add staff";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartDate.Location = new Point(59, 346);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(91, 21);
            lblStartDate.TabIndex = 42;
            lblStartDate.Text = "Start Date";
            // 
            // datetimeEventStart
            // 
            datetimeEventStart.Location = new Point(59, 370);
            datetimeEventStart.Name = "datetimeEventStart";
            datetimeEventStart.Size = new Size(301, 31);
            datetimeEventStart.TabIndex = 43;
            // 
            // RegisterStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "RegisterStaff";
            Size = new Size(1010, 605);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblEventID;
        private Label lblTittle;
        private TextBox txtbxStaffFN;
        private TextBox txtbxStaffID;
        private Label lblFN;
        private Label lblLN;
        private TextBox txtbxStaffLN;
        private TextBox txtbxStaffPassword;
        private Label lblPassword;
        private TextBox txtbxStaffUsername;
        private Label lblUsername;
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
        private Label lblStartDate;
        private DateTimePicker datetimeEventStart;
    }
}
