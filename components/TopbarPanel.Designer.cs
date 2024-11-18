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
            //btnLogOut = new PictureBox();
            panel1 = new Panel();
          //  ((System.ComponentModel.ISupportInitialize)btnLogOut).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(463, 23);
            label1.TabIndex = 0;
            label1.Text = "GATHERWELL EVENT MANAGEMENT SYSTEM";
            // 
            // btnLogOut
            // 
           // btnLogOut.Image = Properties.Resources.logout;
           // btnLogOut.Location = new Point(957, 13);
           // btnLogOut.Name = "btnLogOut";
          //  btnLogOut.Size = new Size(36, 36);
          //  btnLogOut.SizeMode = PictureBoxSizeMode.AutoSize;
           // btnLogOut.TabIndex = 1;
          //  btnLogOut.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
           // panel1.Controls.Add(btnLogOut);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 68);
            panel1.TabIndex = 0;
            // 
            // TopbarPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "TopbarPanel";
            Size = new Size(1010, 68);
          //  ((System.ComponentModel.ISupportInitialize)btnLogOut).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Label label1;
      //  private System.Windows.Forms.PictureBox btnLogOut;
        private Panel panel1;
    }
}
