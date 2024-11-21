using System.Windows.Forms;
using event_management_system.components;

namespace event_management_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            logIn = new LogIn();
            title = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(logIn);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1249, 659);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // logIn
            // 
            logIn.BackColor = Color.LightCyan;
            logIn.Location = new Point(0, 0);
            logIn.Margin = new Padding(2);
            logIn.Name = "logIn";
            logIn.Size = new Size(1249, 657);
            logIn.TabIndex = 0;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(450, 15);
            title.Name = "title";
            title.Size = new Size(363, 38);
            title.TabIndex = 1;
            title.Text = "Event Management System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 659);
            Controls.Add(mainPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event Management System";
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel mainPanel;
        private Label title;
        private LogIn logIn;
    }
}
