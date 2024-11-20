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
            btnAddEvent = new Guna.UI2.WinForms.Guna2Button();
            txtbxEventID = new TextBox();
            lbltxtevntname = new Label();
            lblTittle = new Label();
            lblLN = new Label();
            txtbxStaffLN = new TextBox();
            lblFN = new Label();
            txtbxStaffFN = new TextBox();
            lblPhoneNumber = new Label();
            maskedTextBox1 = new MaskedTextBox();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 605);
            panel1.TabIndex = 0;
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
            btnAddEvent.Location = new Point(760, 526);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddEvent.Size = new Size(185, 40);
            btnAddEvent.TabIndex = 51;
            btnAddEvent.Text = "Add registrants";
            // 
            // txtbxEventID
            // 
            txtbxEventID.BackColor = Color.Azure;
            txtbxEventID.ForeColor = SystemColors.WindowFrame;
            txtbxEventID.Location = new Point(62, 116);
            txtbxEventID.Name = "txtbxEventID";
            txtbxEventID.Size = new Size(182, 31);
            txtbxEventID.TabIndex = 50;
            // 
            // lbltxtevntname
            // 
            lbltxtevntname.AutoSize = true;
            lbltxtevntname.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltxtevntname.Location = new Point(65, 89);
            lbltxtevntname.Name = "lbltxtevntname";
            lbltxtevntname.Size = new Size(105, 21);
            lbltxtevntname.TabIndex = 33;
            lbltxtevntname.Text = "Event name";
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.BackColor = Color.Azure;
            lblTittle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittle.ForeColor = SystemColors.Desktop;
            lblTittle.Location = new Point(65, 38);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(382, 28);
            lblTittle.TabIndex = 32;
            lblTittle.Text = "EVENT REGISTRATANTS FORM";
            // 
            // lblLN
            // 
            lblLN.AutoSize = true;
            lblLN.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLN.Location = new Point(528, 173);
            lblLN.Name = "lblLN";
            lblLN.Size = new Size(93, 21);
            lblLN.TabIndex = 55;
            lblLN.Text = "Last name";
            // 
            // txtbxStaffLN
            // 
            txtbxStaffLN.BackColor = Color.Azure;
            txtbxStaffLN.ForeColor = SystemColors.WindowFrame;
            txtbxStaffLN.Location = new Point(528, 197);
            txtbxStaffLN.Name = "txtbxStaffLN";
            txtbxStaffLN.Size = new Size(426, 31);
            txtbxStaffLN.TabIndex = 54;
            // 
            // lblFN
            // 
            lblFN.AutoSize = true;
            lblFN.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFN.Location = new Point(62, 173);
            lblFN.Name = "lblFN";
            lblFN.Size = new Size(94, 21);
            lblFN.TabIndex = 53;
            lblFN.Text = "First name";
            // 
            // txtbxStaffFN
            // 
            txtbxStaffFN.BackColor = Color.Azure;
            txtbxStaffFN.ForeColor = SystemColors.WindowFrame;
            txtbxStaffFN.Location = new Point(62, 197);
            txtbxStaffFN.Name = "txtbxStaffFN";
            txtbxStaffFN.Size = new Size(426, 31);
            txtbxStaffFN.TabIndex = 52;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(65, 256);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(140, 21);
            lblPhoneNumber.TabIndex = 56;
            lblPhoneNumber.Text = "Contact Number";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.Azure;
            maskedTextBox1.Location = new Point(65, 295);
            maskedTextBox1.Mask = "(+63) 000-000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(179, 31);
            maskedTextBox1.TabIndex = 57;
            // 
            // RegisterRegistrants
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(panel1);
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
