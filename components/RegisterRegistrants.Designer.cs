namespace event_management_system.components
{
    partial class RegisterRegistrants
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            maskedTextBox1 = new MaskedTextBox();
            lblPhoneNumber = new Label();
            lblLN = new Label();
            txtbxStaffLN = new TextBox();
            lblFN = new Label();
            txtbxStaffFN = new TextBox();
            btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            txtbxEventID = new TextBox();
            lbltxtevntname = new Label();
            lblTittle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(lblPhoneNumber);
            panel1.Controls.Add(lblLN);
            panel1.Controls.Add(txtbxStaffLN);
            panel1.Controls.Add(lblFN);
            panel1.Controls.Add(txtbxStaffFN);
            panel1.Controls.Add(btnAddEvent);
            panel1.Controls.Add(txtbxEventID);
            panel1.Controls.Add(lbltxtevntname);
            panel1.Controls.Add(lblTittle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 605);
            panel1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.Azure;
            maskedTextBox1.Location = new Point(52, 236);
            maskedTextBox1.Margin = new Padding(2, 2, 2, 2);
            maskedTextBox1.Mask = "(+63) 000-000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(144, 27);
            maskedTextBox1.TabIndex = 57;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(52, 205);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(115, 17);
            lblPhoneNumber.TabIndex = 56;
            lblPhoneNumber.Text = "Contact Number";
            // 
            // lblLN
            // 
            lblLN.AutoSize = true;
            lblLN.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLN.Location = new Point(422, 138);
            lblLN.Margin = new Padding(2, 0, 2, 0);
            lblLN.Name = "lblLN";
            lblLN.Size = new Size(77, 17);
            lblLN.TabIndex = 55;
            lblLN.Text = "Last name";
            // 
            // txtbxStaffLN
            // 
            txtbxStaffLN.BackColor = Color.Azure;
            txtbxStaffLN.ForeColor = SystemColors.WindowFrame;
            txtbxStaffLN.Location = new Point(422, 158);
            txtbxStaffLN.Margin = new Padding(2, 2, 2, 2);
            txtbxStaffLN.Name = "txtbxStaffLN";
            txtbxStaffLN.Size = new Size(342, 27);
            txtbxStaffLN.TabIndex = 54;
            // 
            // lblFN
            // 
            lblFN.AutoSize = true;
            lblFN.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFN.Location = new Point(50, 138);
            lblFN.Margin = new Padding(2, 0, 2, 0);
            lblFN.Name = "lblFN";
            lblFN.Size = new Size(78, 17);
            lblFN.TabIndex = 53;
            lblFN.Text = "First name";
            // 
            // txtbxStaffFN
            // 
            txtbxStaffFN.BackColor = Color.Azure;
            txtbxStaffFN.ForeColor = SystemColors.WindowFrame;
            txtbxStaffFN.Location = new Point(50, 158);
            txtbxStaffFN.Margin = new Padding(2, 2, 2, 2);
            txtbxStaffFN.Name = "txtbxStaffFN";
            txtbxStaffFN.Size = new Size(342, 27);
            txtbxStaffFN.TabIndex = 52;
            // 
            // btnAddEvent
            // 
            btnAddEvent.BorderRadius = 20;
            btnAddEvent.CustomizableEdges = customizableEdges1;
            btnAddEvent.DisabledState.BorderColor = Color.DarkGray;
            btnAddEvent.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddEvent.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddEvent.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddEvent.FillColor = Color.LimeGreen;
            btnAddEvent.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEvent.ForeColor = Color.Black;
            btnAddEvent.Location = new Point(608, 421);
            btnAddEvent.Margin = new Padding(2, 2, 2, 2);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddEvent.Size = new Size(148, 32);
            btnAddEvent.TabIndex = 51;
            btnAddEvent.Text = "Add registrants";
            // 
            // txtbxEventID
            // 
            txtbxEventID.BackColor = Color.Azure;
            txtbxEventID.ForeColor = SystemColors.WindowFrame;
            txtbxEventID.Location = new Point(50, 93);
            txtbxEventID.Margin = new Padding(2, 2, 2, 2);
            txtbxEventID.Name = "txtbxEventID";
            txtbxEventID.Size = new Size(146, 27);
            txtbxEventID.TabIndex = 50;
            // 
            // lbltxtevntname
            // 
            lbltxtevntname.AutoSize = true;
            lbltxtevntname.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltxtevntname.Location = new Point(52, 71);
            lbltxtevntname.Margin = new Padding(2, 0, 2, 0);
            lbltxtevntname.Name = "lbltxtevntname";
            lbltxtevntname.Size = new Size(86, 17);
            lbltxtevntname.TabIndex = 33;
            lbltxtevntname.Text = "Event name";
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.BackColor = Color.Azure;
            lblTittle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittle.ForeColor = SystemColors.Desktop;
            lblTittle.Location = new Point(52, 30);
            lblTittle.Margin = new Padding(2, 0, 2, 0);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(318, 23);
            lblTittle.TabIndex = 32;
            lblTittle.Text = "EVENT REGISTRATANTS FORM";
            // 
            // RegisterRegistrants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RegisterRegistrants";
            Size = new Size(1010, 605);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddEvent;
        private TextBox txtbxEventID;
        private Label lbltxtevntname;
        private Label lblTittle;
        private Label lblLN;
        private TextBox txtbxStaffLN;
        private Label lblFN;
        private TextBox txtbxStaffFN;
        private MaskedTextBox maskedTextBox1;
        private Label lblPhoneNumber;
    }
}
