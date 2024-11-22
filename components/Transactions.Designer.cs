namespace event_management_system.components
{
    partial class Transactions
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            PanelTransaction = new Panel();
            lblOutputTotalSales = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblTotalAmount = new Label();
            lblTittle = new Label();
            dataTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            DTStaffStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            IDRegistrant = new DataGridViewTextBoxColumn();
            IDEvent = new DataGridViewTextBoxColumn();
            IDTransaction = new DataGridViewTextBoxColumn();
            IDTicket = new DataGridViewTextBoxColumn();
            TypeTicket = new DataGridViewTextBoxColumn();
            QntyTicket = new DataGridViewTextBoxColumn();
            TotalTicketAmount = new DataGridViewTextBoxColumn();
            TransactionStatus = new DataGridViewTextBoxColumn();
            btnLogIn = new Guna.UI2.WinForms.Guna2Button();
            searchTransaction = new Guna.UI2.WinForms.Guna2TextBox();
            cmbobxAllSucFail = new ComboBox();
            PanelTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataTransactions).BeginInit();
            SuspendLayout();
            // 
            // PanelTransaction
            // 
            PanelTransaction.Controls.Add(cmbobxAllSucFail);
            PanelTransaction.Controls.Add(searchTransaction);
            PanelTransaction.Controls.Add(btnLogIn);
            PanelTransaction.Controls.Add(label2);
            PanelTransaction.Controls.Add(label1);
            PanelTransaction.Controls.Add(guna2DateTimePicker1);
            PanelTransaction.Controls.Add(DTStaffStartDate);
            PanelTransaction.Controls.Add(dataTransactions);
            PanelTransaction.Controls.Add(lblOutputTotalSales);
            PanelTransaction.Controls.Add(iconPictureBox1);
            PanelTransaction.Controls.Add(lblTotalAmount);
            PanelTransaction.Controls.Add(lblTittle);
            PanelTransaction.Dock = DockStyle.Fill;
            PanelTransaction.Location = new Point(0, 0);
            PanelTransaction.Name = "PanelTransaction";
            PanelTransaction.Size = new Size(1010, 605);
            PanelTransaction.TabIndex = 0;
            // 
            // lblOutputTotalSales
            // 
            lblOutputTotalSales.AutoSize = true;
            lblOutputTotalSales.Font = new Font("Arial", 11F);
            lblOutputTotalSales.ForeColor = SystemColors.ControlText;
            lblOutputTotalSales.Location = new Point(896, 44);
            lblOutputTotalSales.Margin = new Padding(2, 0, 2, 0);
            lblOutputTotalSales.Name = "lblOutputTotalSales";
            lblOutputTotalSales.Size = new Size(70, 22);
            lblOutputTotalSales.TabIndex = 36;
            lblOutputTotalSales.Text = "15,200";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Azure;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PesoSign;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 24;
            iconPictureBox1.Location = new Point(877, 42);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(24, 24);
            iconPictureBox1.TabIndex = 37;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Arial", 10F);
            lblTotalAmount.ForeColor = SystemColors.ControlDarkDark;
            lblTotalAmount.Location = new Point(778, 49);
            lblTotalAmount.Margin = new Padding(2, 0, 2, 0);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(104, 19);
            lblTotalAmount.TabIndex = 35;
            lblTotalAmount.Text = "Total amount:";
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
            lblTittle.Size = new Size(158, 27);
            lblTittle.TabIndex = 33;
            lblTittle.Text = "Transactions";
            // 
            // dataTransactions
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(189, 223, 251);
            dataTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(33, 150, 242);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTransactions.Columns.AddRange(new DataGridViewColumn[] { IDRegistrant, IDEvent, IDTransaction, IDTicket, TypeTicket, QntyTicket, TotalTicketAmount, TransactionStatus });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(211, 233, 252);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataTransactions.DefaultCellStyle = dataGridViewCellStyle6;
            dataTransactions.GridColor = Color.FromArgb(187, 222, 251);
            dataTransactions.Location = new Point(2, 131);
            dataTransactions.Name = "dataTransactions";
            dataTransactions.RowHeadersVisible = false;
            dataTransactions.RowHeadersWidth = 51;
            dataTransactions.Size = new Size(1009, 410);
            dataTransactions.TabIndex = 38;
            dataTransactions.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            dataTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(189, 223, 251);
            dataTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataTransactions.ThemeStyle.BackColor = Color.White;
            dataTransactions.ThemeStyle.GridColor = Color.FromArgb(187, 222, 251);
            dataTransactions.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(33, 150, 242);
            dataTransactions.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataTransactions.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataTransactions.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTransactions.ThemeStyle.HeaderStyle.Height = 22;
            dataTransactions.ThemeStyle.ReadOnly = false;
            dataTransactions.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(211, 233, 252);
            dataTransactions.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataTransactions.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataTransactions.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dataTransactions.ThemeStyle.RowsStyle.Height = 29;
            dataTransactions.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dataTransactions.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // DTStaffStartDate
            // 
            DTStaffStartDate.BackColor = Color.Azure;
            DTStaffStartDate.BorderColor = Color.SkyBlue;
            DTStaffStartDate.BorderRadius = 10;
            DTStaffStartDate.BorderThickness = 1;
            DTStaffStartDate.Checked = true;
            DTStaffStartDate.CustomizableEdges = customizableEdges15;
            DTStaffStartDate.FillColor = Color.Transparent;
            DTStaffStartDate.FocusedColor = Color.Transparent;
            DTStaffStartDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTStaffStartDate.Format = DateTimePickerFormat.Long;
            DTStaffStartDate.Location = new Point(528, 90);
            DTStaffStartDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DTStaffStartDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DTStaffStartDate.Name = "DTStaffStartDate";
            DTStaffStartDate.ShadowDecoration.CustomizableEdges = customizableEdges16;
            DTStaffStartDate.Size = new Size(201, 27);
            DTStaffStartDate.TabIndex = 53;
            DTStaffStartDate.Value = new DateTime(2024, 11, 21, 14, 30, 22, 811);
            // 
            // guna2DateTimePicker1
            // 
            guna2DateTimePicker1.BackColor = Color.Azure;
            guna2DateTimePicker1.BorderColor = Color.SkyBlue;
            guna2DateTimePicker1.BorderRadius = 10;
            guna2DateTimePicker1.BorderThickness = 1;
            guna2DateTimePicker1.Checked = true;
            guna2DateTimePicker1.CustomizableEdges = customizableEdges13;
            guna2DateTimePicker1.FillColor = Color.Transparent;
            guna2DateTimePicker1.FocusedColor = Color.Transparent;
            guna2DateTimePicker1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker1.Location = new Point(765, 90);
            guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2DateTimePicker1.Size = new Size(201, 27);
            guna2DateTimePicker1.TabIndex = 54;
            guna2DateTimePicker1.Value = new DateTime(2024, 11, 21, 14, 30, 22, 811);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(480, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 19);
            label1.TabIndex = 55;
            label1.Text = "from";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(736, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(22, 19);
            label2.TabIndex = 56;
            label2.Text = "to";
            // 
            // IDRegistrant
            // 
            IDRegistrant.HeaderText = "Registrant ID";
            IDRegistrant.MinimumWidth = 6;
            IDRegistrant.Name = "IDRegistrant";
            // 
            // IDEvent
            // 
            IDEvent.HeaderText = "Event ID";
            IDEvent.MinimumWidth = 6;
            IDEvent.Name = "IDEvent";
            // 
            // IDTransaction
            // 
            IDTransaction.HeaderText = "TransactionID";
            IDTransaction.MinimumWidth = 6;
            IDTransaction.Name = "IDTransaction";
            // 
            // IDTicket
            // 
            IDTicket.HeaderText = "TicketID";
            IDTicket.MinimumWidth = 6;
            IDTicket.Name = "IDTicket";
            // 
            // TypeTicket
            // 
            TypeTicket.HeaderText = "Ticket Type";
            TypeTicket.MinimumWidth = 6;
            TypeTicket.Name = "TypeTicket";
            // 
            // QntyTicket
            // 
            QntyTicket.HeaderText = "Quantity";
            QntyTicket.MinimumWidth = 6;
            QntyTicket.Name = "QntyTicket";
            // 
            // TotalTicketAmount
            // 
            TotalTicketAmount.HeaderText = "Amount";
            TotalTicketAmount.MinimumWidth = 6;
            TotalTicketAmount.Name = "TotalTicketAmount";
            // 
            // TransactionStatus
            // 
            TransactionStatus.HeaderText = "Status";
            TransactionStatus.MinimumWidth = 6;
            TransactionStatus.Name = "TransactionStatus";
            // 
            // btnLogIn
            // 
            btnLogIn.BorderRadius = 15;
            btnLogIn.CustomizableEdges = customizableEdges11;
            btnLogIn.DisabledState.BorderColor = Color.DarkGray;
            btnLogIn.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogIn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogIn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogIn.FillColor = Color.DodgerBlue;
            btnLogIn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.Black;
            btnLogIn.Location = new Point(778, 557);
            btnLogIn.Margin = new Padding(2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnLogIn.Size = new Size(188, 33);
            btnLogIn.TabIndex = 59;
            btnLogIn.Text = "Convert to CSV";
            // 
            // searchTransaction
            // 
            searchTransaction.BorderRadius = 10;
            searchTransaction.CustomizableEdges = customizableEdges9;
            searchTransaction.DefaultText = "search transaction";
            searchTransaction.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchTransaction.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchTransaction.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchTransaction.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchTransaction.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchTransaction.Font = new Font("Arial", 9F);
            searchTransaction.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchTransaction.Location = new Point(320, 90);
            searchTransaction.Margin = new Padding(3, 4, 3, 4);
            searchTransaction.Name = "searchTransaction";
            searchTransaction.PasswordChar = '\0';
            searchTransaction.PlaceholderText = "";
            searchTransaction.SelectedText = "";
            searchTransaction.ShadowDecoration.CustomizableEdges = customizableEdges10;
            searchTransaction.Size = new Size(155, 27);
            searchTransaction.TabIndex = 60;
            // 
            // cmbobxAllSucFail
            // 
            cmbobxAllSucFail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbobxAllSucFail.ForeColor = SystemColors.WindowFrame;
            cmbobxAllSucFail.FormattingEnabled = true;
            cmbobxAllSucFail.Items.AddRange(new object[] { "Success", "Failed" });
            cmbobxAllSucFail.Location = new Point(47, 89);
            cmbobxAllSucFail.Name = "cmbobxAllSucFail";
            cmbobxAllSucFail.Size = new Size(135, 25);
            cmbobxAllSucFail.TabIndex = 61;
            cmbobxAllSucFail.Text = "All transactions";
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(PanelTransaction);
            Name = "Transactions";
            Size = new Size(1010, 605);
            PanelTransaction.ResumeLayout(false);
            PanelTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelTransaction;
        private Label lblTittle;
        private Label lblTotalAmount;
        private Label lblOutputTotalSales;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dataTransactions;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTStaffStartDate;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private DataGridViewTextBoxColumn IDRegistrant;
        private DataGridViewTextBoxColumn IDEvent;
        private DataGridViewTextBoxColumn IDTransaction;
        private DataGridViewTextBoxColumn IDTicket;
        private DataGridViewTextBoxColumn TypeTicket;
        private DataGridViewTextBoxColumn QntyTicket;
        private DataGridViewTextBoxColumn TotalTicketAmount;
        private DataGridViewTextBoxColumn TransactionStatus;
        private Guna.UI2.WinForms.Guna2Button btnLogIn;
        private Guna.UI2.WinForms.Guna2TextBox searchTransaction;
        private ComboBox cmbobxAllSucFail;
    }
}
