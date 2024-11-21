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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            DTSTaffEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            DTStaffStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lblContract = new Label();
            lblEndDate = new Label();
            btnAddStaff = new Guna.UI2.WinForms.Guna2Button();
            lblStartDate = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            lblLN = new Label();
            lblFN = new Label();
            lblTittle = new Label();
            txtbxFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            txtbxStaffLastName = new Guna.UI2.WinForms.Guna2TextBox();
            txtbxStaffUsernametxtbxStaffUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtbxStaffPassword = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(txtbxStaffPassword);
            panel1.Controls.Add(txtbxStaffUsernametxtbxStaffUsername);
            panel1.Controls.Add(txtbxStaffLastName);
            panel1.Controls.Add(txtbxFirstName);
            panel1.Controls.Add(DTSTaffEndDate);
            panel1.Controls.Add(DTStaffStartDate);
            panel1.Controls.Add(lblContract);
            panel1.Controls.Add(lblEndDate);
            panel1.Controls.Add(btnAddStaff);
            panel1.Controls.Add(lblStartDate);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblLN);
            panel1.Controls.Add(lblFN);
            panel1.Controls.Add(lblTittle);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 605);
            panel1.TabIndex = 0;
            // 
            // DTSTaffEndDate
            // 
            DTSTaffEndDate.BorderRadius = 10;
            DTSTaffEndDate.Checked = true;
            DTSTaffEndDate.CustomizableEdges = customizableEdges9;
            DTSTaffEndDate.FillColor = Color.SkyBlue;
            DTSTaffEndDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTSTaffEndDate.Format = DateTimePickerFormat.Long;
            DTSTaffEndDate.Location = new Point(509, 371);
            DTSTaffEndDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DTSTaffEndDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DTSTaffEndDate.Name = "DTSTaffEndDate";
            DTSTaffEndDate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            DTSTaffEndDate.Size = new Size(443, 40);
            DTSTaffEndDate.TabIndex = 53;
            DTSTaffEndDate.Value = new DateTime(2024, 11, 21, 14, 30, 22, 811);
            // 
            // DTStaffStartDate
            // 
            DTStaffStartDate.BorderRadius = 10;
            DTStaffStartDate.Checked = true;
            DTStaffStartDate.CustomizableEdges = customizableEdges11;
            DTStaffStartDate.FillColor = Color.SkyBlue;
            DTStaffStartDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTStaffStartDate.Format = DateTimePickerFormat.Long;
            DTStaffStartDate.Location = new Point(49, 371);
            DTStaffStartDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DTStaffStartDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DTStaffStartDate.Name = "DTStaffStartDate";
            DTStaffStartDate.ShadowDecoration.CustomizableEdges = customizableEdges12;
            DTStaffStartDate.Size = new Size(443, 40);
            DTStaffStartDate.TabIndex = 52;
            DTStaffStartDate.Value = new DateTime(2024, 11, 21, 14, 30, 22, 811);
            // 
            // lblContract
            // 
            lblContract.AutoSize = true;
            lblContract.Font = new Font("Arial", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblContract.ForeColor = Color.Red;
            lblContract.Location = new Point(49, 305);
            lblContract.Margin = new Padding(2, 0, 2, 0);
            lblContract.Name = "lblContract";
            lblContract.Size = new Size(100, 28);
            lblContract.TabIndex = 47;
            lblContract.Text = "Contract";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndDate.Location = new Point(509, 345);
            lblEndDate.Margin = new Padding(2, 0, 2, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(92, 23);
            lblEndDate.TabIndex = 45;
            lblEndDate.Text = "End Date";
            // 
            // btnAddStaff
            // 
            btnAddStaff.BorderRadius = 20;
            btnAddStaff.CustomizableEdges = customizableEdges13;
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
            btnAddStaff.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnAddStaff.Size = new Size(125, 40);
            btnAddStaff.TabIndex = 44;
            btnAddStaff.Text = "Add staff";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartDate.Location = new Point(49, 345);
            lblStartDate.Margin = new Padding(2, 0, 2, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(101, 23);
            lblStartDate.TabIndex = 42;
            lblStartDate.Text = "Start Date";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(509, 203);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 23);
            lblPassword.TabIndex = 39;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(47, 203);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(99, 23);
            lblUsername.TabIndex = 37;
            lblUsername.Text = "Username";
            // 
            // lblLN
            // 
            lblLN.AutoSize = true;
            lblLN.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLN.Location = new Point(505, 112);
            lblLN.Margin = new Padding(2, 0, 2, 0);
            lblLN.Name = "lblLN";
            lblLN.Size = new Size(102, 23);
            lblLN.TabIndex = 36;
            lblLN.Text = "Last name";
            // 
            // lblFN
            // 
            lblFN.AutoSize = true;
            lblFN.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFN.Location = new Point(47, 112);
            lblFN.Margin = new Padding(2, 0, 2, 0);
            lblFN.Name = "lblFN";
            lblFN.Size = new Size(103, 23);
            lblFN.TabIndex = 34;
            lblFN.Text = "First name";
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.BackColor = Color.Azure;
            lblTittle.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittle.ForeColor = SystemColors.Desktop;
            lblTittle.Location = new Point(47, 35);
            lblTittle.Margin = new Padding(2, 0, 2, 0);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(342, 27);
            lblTittle.TabIndex = 31;
            lblTittle.Text = "STAFF REGISTRATION FORM";
            // 
            // txtbxFirstName
            // 
            txtbxFirstName.BackColor = Color.Transparent;
            txtbxFirstName.BorderRadius = 10;
            txtbxFirstName.CustomizableEdges = customizableEdges7;
            txtbxFirstName.DefaultText = "";
            txtbxFirstName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxFirstName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxFirstName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxFirstName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxFirstName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxFirstName.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxFirstName.ForeColor = Color.Black;
            txtbxFirstName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxFirstName.Location = new Point(49, 139);
            txtbxFirstName.Margin = new Padding(3, 4, 3, 4);
            txtbxFirstName.Name = "txtbxFirstName";
            txtbxFirstName.PasswordChar = '\0';
            txtbxFirstName.PlaceholderForeColor = Color.LightCyan;
            txtbxFirstName.PlaceholderText = "";
            txtbxFirstName.SelectedText = "";
            txtbxFirstName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtbxFirstName.Size = new Size(443, 40);
            txtbxFirstName.TabIndex = 54;
            // 
            // txtbxStaffLastName
            // 
            txtbxStaffLastName.BackColor = Color.Transparent;
            txtbxStaffLastName.BorderRadius = 10;
            txtbxStaffLastName.CustomizableEdges = customizableEdges5;
            txtbxStaffLastName.DefaultText = "";
            txtbxStaffLastName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxStaffLastName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxStaffLastName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxStaffLastName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxStaffLastName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxStaffLastName.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxStaffLastName.ForeColor = Color.Black;
            txtbxStaffLastName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxStaffLastName.Location = new Point(509, 139);
            txtbxStaffLastName.Margin = new Padding(3, 4, 3, 4);
            txtbxStaffLastName.Name = "txtbxStaffLastName";
            txtbxStaffLastName.PasswordChar = '\0';
            txtbxStaffLastName.PlaceholderForeColor = Color.LightCyan;
            txtbxStaffLastName.PlaceholderText = "";
            txtbxStaffLastName.SelectedText = "";
            txtbxStaffLastName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtbxStaffLastName.Size = new Size(443, 40);
            txtbxStaffLastName.TabIndex = 55;
            // 
            // txtbxStaffUsernametxtbxStaffUsername
            // 
            txtbxStaffUsernametxtbxStaffUsername.BackColor = Color.Transparent;
            txtbxStaffUsernametxtbxStaffUsername.BorderRadius = 10;
            txtbxStaffUsernametxtbxStaffUsername.CustomizableEdges = customizableEdges3;
            txtbxStaffUsernametxtbxStaffUsername.DefaultText = "";
            txtbxStaffUsernametxtbxStaffUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxStaffUsernametxtbxStaffUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxStaffUsernametxtbxStaffUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxStaffUsernametxtbxStaffUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxStaffUsernametxtbxStaffUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxStaffUsernametxtbxStaffUsername.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxStaffUsernametxtbxStaffUsername.ForeColor = Color.Black;
            txtbxStaffUsernametxtbxStaffUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxStaffUsernametxtbxStaffUsername.Location = new Point(49, 230);
            txtbxStaffUsernametxtbxStaffUsername.Margin = new Padding(3, 4, 3, 4);
            txtbxStaffUsernametxtbxStaffUsername.Name = "txtbxStaffUsernametxtbxStaffUsername";
            txtbxStaffUsernametxtbxStaffUsername.PasswordChar = '\0';
            txtbxStaffUsernametxtbxStaffUsername.PlaceholderForeColor = Color.LightCyan;
            txtbxStaffUsernametxtbxStaffUsername.PlaceholderText = "";
            txtbxStaffUsernametxtbxStaffUsername.SelectedText = "";
            txtbxStaffUsernametxtbxStaffUsername.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtbxStaffUsernametxtbxStaffUsername.Size = new Size(443, 40);
            txtbxStaffUsernametxtbxStaffUsername.TabIndex = 56;
            // 
            // txtbxStaffPassword
            // 
            txtbxStaffPassword.BackColor = Color.Transparent;
            txtbxStaffPassword.BorderRadius = 10;
            txtbxStaffPassword.CustomizableEdges = customizableEdges1;
            txtbxStaffPassword.DefaultText = "";
            txtbxStaffPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxStaffPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxStaffPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxStaffPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxStaffPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxStaffPassword.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxStaffPassword.ForeColor = Color.Black;
            txtbxStaffPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxStaffPassword.Location = new Point(509, 230);
            txtbxStaffPassword.Margin = new Padding(3, 4, 3, 4);
            txtbxStaffPassword.Name = "txtbxStaffPassword";
            txtbxStaffPassword.PasswordChar = '\0';
            txtbxStaffPassword.PlaceholderForeColor = Color.LightCyan;
            txtbxStaffPassword.PlaceholderText = "";
            txtbxStaffPassword.SelectedText = "";
            txtbxStaffPassword.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtbxStaffPassword.Size = new Size(443, 40);
            txtbxStaffPassword.TabIndex = 57;
            // 
            // RegisterStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "RegisterStaff";
            Size = new Size(1010, 605);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTittle;
        private Label lblFN;
        private Label lblLN;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblStartDate;
        private DateTimePicker datetimeEventStart;
        private Guna.UI2.WinForms.Guna2Button btnAddStaff;
        private DateTimePicker dateTimePicker1;
        private Label lblEndDate;
        private Label lblContract;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTStaffStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTSTaffEndDate;
        private Guna.UI2.WinForms.Guna2TextBox txtbxStaffPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtbxStaffUsernametxtbxStaffUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtbxStaffLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtbxFirstName;
    }
}
