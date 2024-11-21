namespace event_management_system.components
{
    partial class TicketRegistration
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            lblTittle = new Label();
            btnAddTicket = new Guna.UI2.WinForms.Guna2Button();
            lblTicketType = new Label();
            cckbxTypeVIP = new Guna.UI2.WinForms.Guna2CheckBox();
            chckbxTypeRegular = new Guna.UI2.WinForms.Guna2CheckBox();
            lblTicketPrice = new Label();
            txtbxTicketPrice = new Guna.UI2.WinForms.Guna2TextBox();
            lblQntity = new Label();
            NumericUDEventCapacity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUDEventCapacity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblQntity);
            panel1.Controls.Add(NumericUDEventCapacity);
            panel1.Controls.Add(txtbxTicketPrice);
            panel1.Controls.Add(lblTicketPrice);
            panel1.Controls.Add(chckbxTypeRegular);
            panel1.Controls.Add(cckbxTypeVIP);
            panel1.Controls.Add(lblTicketType);
            panel1.Controls.Add(btnAddTicket);
            panel1.Controls.Add(lblTittle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 605);
            panel1.TabIndex = 0;
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
            lblTittle.Size = new Size(352, 27);
            lblTittle.TabIndex = 32;
            lblTittle.Text = "TICKET REGISTRATION FORM";
            lblTittle.Click += lblTittle_Click;
            // 
            // btnAddTicket
            // 
            btnAddTicket.BorderRadius = 20;
            btnAddTicket.CustomizableEdges = customizableEdges5;
            btnAddTicket.DisabledState.BorderColor = Color.DarkGray;
            btnAddTicket.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddTicket.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddTicket.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddTicket.FillColor = Color.LimeGreen;
            btnAddTicket.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddTicket.ForeColor = Color.Black;
            btnAddTicket.Location = new Point(822, 529);
            btnAddTicket.Margin = new Padding(2);
            btnAddTicket.Name = "btnAddTicket";
            btnAddTicket.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddTicket.Size = new Size(130, 40);
            btnAddTicket.TabIndex = 52;
            btnAddTicket.Text = "Add ticket";
            // 
            // lblTicketType
            // 
            lblTicketType.AutoSize = true;
            lblTicketType.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicketType.Location = new Point(360, 154);
            lblTicketType.Margin = new Padding(2, 0, 2, 0);
            lblTicketType.Name = "lblTicketType";
            lblTicketType.Size = new Size(111, 23);
            lblTicketType.TabIndex = 53;
            lblTicketType.Text = "Ticket Type";
            // 
            // cckbxTypeVIP
            // 
            cckbxTypeVIP.AutoSize = true;
            cckbxTypeVIP.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cckbxTypeVIP.CheckedState.BorderRadius = 0;
            cckbxTypeVIP.CheckedState.BorderThickness = 0;
            cckbxTypeVIP.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cckbxTypeVIP.CheckMarkColor = Color.Black;
            cckbxTypeVIP.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cckbxTypeVIP.Location = new Point(360, 192);
            cckbxTypeVIP.Name = "cckbxTypeVIP";
            cckbxTypeVIP.Size = new Size(58, 23);
            cckbxTypeVIP.TabIndex = 54;
            cckbxTypeVIP.Text = "VIP";
            cckbxTypeVIP.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cckbxTypeVIP.UncheckedState.BorderRadius = 0;
            cckbxTypeVIP.UncheckedState.BorderThickness = 0;
            cckbxTypeVIP.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // chckbxTypeRegular
            // 
            chckbxTypeRegular.AutoSize = true;
            chckbxTypeRegular.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chckbxTypeRegular.CheckedState.BorderRadius = 0;
            chckbxTypeRegular.CheckedState.BorderThickness = 0;
            chckbxTypeRegular.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chckbxTypeRegular.CheckMarkColor = Color.Black;
            chckbxTypeRegular.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chckbxTypeRegular.Location = new Point(424, 192);
            chckbxTypeRegular.Name = "chckbxTypeRegular";
            chckbxTypeRegular.Size = new Size(87, 23);
            chckbxTypeRegular.TabIndex = 55;
            chckbxTypeRegular.Text = "Regular";
            chckbxTypeRegular.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chckbxTypeRegular.UncheckedState.BorderRadius = 0;
            chckbxTypeRegular.UncheckedState.BorderThickness = 0;
            chckbxTypeRegular.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // lblTicketPrice
            // 
            lblTicketPrice.AutoSize = true;
            lblTicketPrice.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicketPrice.Location = new Point(360, 259);
            lblTicketPrice.Margin = new Padding(2, 0, 2, 0);
            lblTicketPrice.Name = "lblTicketPrice";
            lblTicketPrice.Size = new Size(55, 23);
            lblTicketPrice.TabIndex = 56;
            lblTicketPrice.Text = "Price";
            // 
            // txtbxTicketPrice
            // 
            txtbxTicketPrice.BackColor = Color.Transparent;
            txtbxTicketPrice.BorderRadius = 10;
            txtbxTicketPrice.CustomizableEdges = customizableEdges3;
            txtbxTicketPrice.DefaultText = "";
            txtbxTicketPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxTicketPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxTicketPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxTicketPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxTicketPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxTicketPrice.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxTicketPrice.ForeColor = Color.Black;
            txtbxTicketPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxTicketPrice.Location = new Point(360, 286);
            txtbxTicketPrice.Margin = new Padding(3, 4, 3, 4);
            txtbxTicketPrice.Name = "txtbxTicketPrice";
            txtbxTicketPrice.PasswordChar = '\0';
            txtbxTicketPrice.PlaceholderForeColor = Color.LightCyan;
            txtbxTicketPrice.PlaceholderText = "";
            txtbxTicketPrice.SelectedText = "";
            txtbxTicketPrice.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtbxTicketPrice.Size = new Size(291, 40);
            txtbxTicketPrice.TabIndex = 57;
            // 
            // lblQntity
            // 
            lblQntity.AutoSize = true;
            lblQntity.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQntity.Location = new Point(675, 259);
            lblQntity.Margin = new Padding(2, 0, 2, 0);
            lblQntity.Name = "lblQntity";
            lblQntity.Size = new Size(83, 23);
            lblQntity.TabIndex = 63;
            lblQntity.Text = "Quantity";
            // 
            // NumericUDEventCapacity
            // 
            NumericUDEventCapacity.BackColor = Color.Transparent;
            NumericUDEventCapacity.BorderRadius = 10;
            NumericUDEventCapacity.CustomizableEdges = customizableEdges1;
            NumericUDEventCapacity.Font = new Font("Segoe UI", 9F);
            NumericUDEventCapacity.Location = new Point(675, 285);
            NumericUDEventCapacity.Margin = new Padding(3, 4, 3, 4);
            NumericUDEventCapacity.Name = "NumericUDEventCapacity";
            NumericUDEventCapacity.ShadowDecoration.CustomizableEdges = customizableEdges2;
            NumericUDEventCapacity.Size = new Size(291, 40);
            NumericUDEventCapacity.TabIndex = 62;
            NumericUDEventCapacity.UpDownButtonFillColor = Color.SkyBlue;
            // 
            // TicketRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel1);
            Name = "TicketRegistration";
            Size = new Size(1010, 605);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUDEventCapacity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTittle;
        private Guna.UI2.WinForms.Guna2Button btnAddTicket;
        private Guna.UI2.WinForms.Guna2CheckBox cckbxTypeVIP;
        private Label lblTicketType;
        private Label lblTicketPrice;
        private Guna.UI2.WinForms.Guna2CheckBox chckbxTypeRegular;
        private Guna.UI2.WinForms.Guna2TextBox txtbxTicketPrice;
        private Label lblQntity;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericUDEventCapacity;
    }
}
