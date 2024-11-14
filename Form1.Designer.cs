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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainPanel = new Panel();
            homePageBtn = new Button();
            title = new Label();
            pictureBox1 = new PictureBox();
            testPanel = new TestPanel();
            topbarPanel = new TopbarPanel();
            sidebarPanel = new SidebarPanel();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1262, 673);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += mainPanel_Paint;
            //
            // SidebarPanel
            //
            mainPanel.Controls.Add(sidebarPanel);
            sidebarPanel.Location = new Point(0, 0);
            mainPanel.ResumeLayout();
            // 
            // homePageBtn
            // 
            homePageBtn.BackColor = ColorTranslator.FromHtml("#007B7F");
            homePageBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homePageBtn.ForeColor = Color.FromArgb(228, 228, 228);
            homePageBtn.Location = new Point(0, 0);
            homePageBtn.Margin = new Padding(0);
            homePageBtn.Name = "homePageBtn";
            homePageBtn.Size = new Size(252, 50);
            homePageBtn.TabIndex = 0;
            homePageBtn.Text = "Home";
            homePageBtn.UseVisualStyleBackColor = false;
            homePageBtn.Click += homePageBtn_Click;
            //
            // topbarPanel
            //
            mainPanel.Controls.Add(topbarPanel);
            topbarPanel.Location = new Point(252, 0);
            mainPanel.ResumeLayout();
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 68);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            //
            // TestPanel
            //
            mainPanel.Controls.Add(testPanel);
            testPanel.Location = new Point(252, 68);
            mainPanel.ResumeLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(mainPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event Management System";
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Button homePageBtn;
        private PictureBox pictureBox1;
        private Label title;
        private TestPanel testPanel;
        private TopbarPanel topbarPanel;
        private SidebarPanel sidebarPanel;
    }
}
