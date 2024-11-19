namespace event_management_system.components
{
    partial class TopbarPanel
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
            label1 = new Label();
            panel1 = new Panel();
            btnLogOut = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(555, 28);
            label1.TabIndex = 0;
            label1.Text = "GATHERWELL EVENT MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(1010, 68);
            panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.PowderBlue;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnLogOut.IconColor = Color.Black;
            btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogOut.Location = new Point(914, 7);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(82, 55);
            btnLogOut.TabIndex = 1;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // TopbarPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "TopbarPanel";
            Size = new Size(1010, 68);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Label label1;
      //  private System.Windows.Forms.PictureBox btnLogOut;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnLogOut;
    }
}
