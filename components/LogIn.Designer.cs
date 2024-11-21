namespace event_management_system.components
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnLogIn = new Guna.UI2.WinForms.Guna2Button();
            txtbxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtbxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            lblPassword = new Label();
            iconPicturePass = new FontAwesome.Sharp.IconPictureBox();
            iconPictureUsername = new FontAwesome.Sharp.IconPictureBox();
            lbUsername = new Label();
            tagline = new Label();
            Gatherwell = new Label();
            LogoPic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPicturePass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(txtbxPassword);
            panel1.Controls.Add(txtbxUsername);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(iconPicturePass);
            panel1.Controls.Add(iconPictureUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(tagline);
            panel1.Controls.Add(Gatherwell);
            panel1.Controls.Add(LogoPic);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 673);
            panel1.TabIndex = 0;
            // 
            // btnLogIn
            // 
            btnLogIn.BorderRadius = 20;
            btnLogIn.CustomizableEdges = customizableEdges1;
            btnLogIn.DisabledState.BorderColor = Color.DarkGray;
            btnLogIn.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogIn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogIn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogIn.FillColor = Color.DodgerBlue;
            btnLogIn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.Black;
            btnLogIn.Location = new Point(574, 513);
            btnLogIn.Margin = new Padding(2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogIn.Size = new Size(125, 40);
            btnLogIn.TabIndex = 11;
            btnLogIn.Text = "LOG IN";
            btnLogIn.Click += btnLogIn_Click;
            // 
            // txtbxPassword
            // 
            txtbxPassword.BackColor = Color.Transparent;
            txtbxPassword.BorderRadius = 10;
            txtbxPassword.CustomizableEdges = customizableEdges3;
            txtbxPassword.DefaultText = "";
            txtbxPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxPassword.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxPassword.ForeColor = Color.Black;
            txtbxPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxPassword.Location = new Point(493, 449);
            txtbxPassword.Margin = new Padding(3, 4, 3, 4);
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.PasswordChar = '●';
            txtbxPassword.PlaceholderForeColor = Color.LightCyan;
            txtbxPassword.PlaceholderText = "";
            txtbxPassword.SelectedText = "";
            txtbxPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtbxPassword.Size = new Size(300, 40);
            txtbxPassword.TabIndex = 10;
            txtbxPassword.UseSystemPasswordChar = true;
            // 
            // txtbxUsername
            // 
            txtbxUsername.BackColor = Color.Transparent;
            txtbxUsername.BorderRadius = 10;
            txtbxUsername.CustomizableEdges = customizableEdges5;
            txtbxUsername.DefaultText = "";
            txtbxUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbxUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbxUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbxUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbxUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxUsername.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxUsername.ForeColor = Color.Black;
            txtbxUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbxUsername.Location = new Point(493, 364);
            txtbxUsername.Margin = new Padding(3, 4, 3, 4);
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.PasswordChar = '\0';
            txtbxUsername.PlaceholderForeColor = Color.LightCyan;
            txtbxUsername.PlaceholderText = "";
            txtbxUsername.SelectedText = "";
            txtbxUsername.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtbxUsername.Size = new Size(300, 40);
            txtbxUsername.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(524, 423);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 23);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // iconPicturePass
            // 
            iconPicturePass.BackColor = Color.LightCyan;
            iconPicturePass.ForeColor = SystemColors.ControlText;
            iconPicturePass.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPicturePass.IconColor = SystemColors.ControlText;
            iconPicturePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPicturePass.IconSize = 34;
            iconPicturePass.Location = new Point(493, 414);
            iconPicturePass.Margin = new Padding(2);
            iconPicturePass.Name = "iconPicturePass";
            iconPicturePass.Size = new Size(34, 35);
            iconPicturePass.TabIndex = 7;
            iconPicturePass.TabStop = false;
            // 
            // iconPictureUsername
            // 
            iconPictureUsername.BackColor = Color.LightCyan;
            iconPictureUsername.ForeColor = SystemColors.ControlText;
            iconPictureUsername.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            iconPictureUsername.IconColor = SystemColors.ControlText;
            iconPictureUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureUsername.IconSize = 34;
            iconPictureUsername.Location = new Point(493, 329);
            iconPictureUsername.Margin = new Padding(2);
            iconPictureUsername.Name = "iconPictureUsername";
            iconPictureUsername.Size = new Size(34, 35);
            iconPictureUsername.TabIndex = 6;
            iconPictureUsername.TabStop = false;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(522, 340);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(99, 23);
            lbUsername.TabIndex = 5;
            lbUsername.Text = "Username";
            // 
            // tagline
            // 
            tagline.AutoSize = true;
            tagline.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagline.Location = new Point(547, 298);
            tagline.Name = "tagline";
            tagline.Size = new Size(203, 23);
            tagline.TabIndex = 4;
            tagline.Text = "Your event companion";
            // 
            // Gatherwell
            // 
            Gatherwell.AutoSize = true;
            Gatherwell.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gatherwell.Location = new Point(542, 266);
            Gatherwell.Name = "Gatherwell";
            Gatherwell.Size = new Size(213, 32);
            Gatherwell.TabIndex = 3;
            Gatherwell.Text = "GATHERWELL";
            // 
            // LogoPic
            // 
            LogoPic.ErrorImage = null;
            LogoPic.Image = (Image)resources.GetObject("LogoPic.Image");
            LogoPic.Location = new Point(493, 33);
            LogoPic.Name = "LogoPic";
            LogoPic.Size = new Size(298, 222);
            LogoPic.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPic.TabIndex = 2;
            LogoPic.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "LogIn";
            Size = new Size(1262, 673);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPicturePass).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox LogoPic;
        private Label Gatherwell;
        private Label tagline;
        private Label lbUsername;
        private FontAwesome.Sharp.IconPictureBox iconPictureUsername;
        private FontAwesome.Sharp.IconPictureBox iconPicturePass;
        private Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtbxUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtbxPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogIn;
    }
}
