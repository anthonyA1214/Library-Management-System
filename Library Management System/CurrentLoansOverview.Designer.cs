namespace Library_Management_System
{
    partial class CurrentLoansOverview
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvCurrentLoans = new System.Windows.Forms.DataGridView();
            this.pnlCustomRange = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDateRange = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBookTitleID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMemberNameID = new System.Windows.Forms.TextBox();
            this.cbLoanStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentLoans)).BeginInit();
            this.pnlCustomRange.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 36);
            this.panel1.TabIndex = 24;
            // 
            // pbExit
            // 
            this.pbExit.Image = global::Library_Management_System.Properties.Resources.reject;
            this.pbExit.Location = new System.Drawing.Point(12, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(25, 25);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 0;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 486);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pnlCustomRange);
            this.panel3.Controls.Add(this.pnlSearch);
            this.panel3.Location = new System.Drawing.Point(12, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 467);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.dgvCurrentLoans);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(644, 337);
            this.panel4.TabIndex = 5;
            // 
            // dgvCurrentLoans
            // 
            this.dgvCurrentLoans.AllowUserToAddRows = false;
            this.dgvCurrentLoans.AllowUserToDeleteRows = false;
            this.dgvCurrentLoans.AllowUserToResizeColumns = false;
            this.dgvCurrentLoans.AllowUserToResizeRows = false;
            this.dgvCurrentLoans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCurrentLoans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCurrentLoans.ColumnHeadersHeight = 50;
            this.dgvCurrentLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCurrentLoans.Location = new System.Drawing.Point(6, 6);
            this.dgvCurrentLoans.Name = "dgvCurrentLoans";
            this.dgvCurrentLoans.ReadOnly = true;
            this.dgvCurrentLoans.RowHeadersVisible = false;
            this.dgvCurrentLoans.RowHeadersWidth = 40;
            this.dgvCurrentLoans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCurrentLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentLoans.Size = new System.Drawing.Size(632, 325);
            this.dgvCurrentLoans.TabIndex = 2;
            // 
            // pnlCustomRange
            // 
            this.pnlCustomRange.Controls.Add(this.label6);
            this.pnlCustomRange.Controls.Add(this.dtpEndDate);
            this.pnlCustomRange.Controls.Add(this.label3);
            this.pnlCustomRange.Controls.Add(this.dtpStartDate);
            this.pnlCustomRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomRange.Location = new System.Drawing.Point(0, 80);
            this.pnlCustomRange.Name = "pnlCustomRange";
            this.pnlCustomRange.Size = new System.Drawing.Size(644, 50);
            this.pnlCustomRange.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(400, 13);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(120, 25);
            this.dtpEndDate.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(199, 13);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(120, 25);
            this.dtpStartDate.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSearch.Controls.Add(this.cbLoanStatus);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Controls.Add(this.cbDateRange);
            this.pnlSearch.Controls.Add(this.btnClear);
            this.pnlSearch.Controls.Add(this.label5);
            this.pnlSearch.Controls.Add(this.btnFilter);
            this.pnlSearch.Controls.Add(this.label4);
            this.pnlSearch.Controls.Add(this.tbBookTitleID);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.tbMemberNameID);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(644, 80);
            this.pnlSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date Range Filter";
            // 
            // cbDateRange
            // 
            this.cbDateRange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDateRange.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbDateRange.FormattingEnabled = true;
            this.cbDateRange.Items.AddRange(new object[] {
            "All",
            "Last 7 Days",
            "This Month",
            "This Year",
            "Custom Range"});
            this.cbDateRange.Location = new System.Drawing.Point(409, 37);
            this.cbDateRange.Name = "cbDateRange";
            this.cbDateRange.Size = new System.Drawing.Size(120, 25);
            this.cbDateRange.TabIndex = 10;
            this.cbDateRange.TextChanged += new System.EventHandler(this.cbDateRange_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(541, 44);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Book Title or ID:";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(541, 8);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loan Status:";
            // 
            // tbBookTitleID
            // 
            this.tbBookTitleID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbBookTitleID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookTitleID.Location = new System.Drawing.Point(141, 37);
            this.tbBookTitleID.Name = "tbBookTitleID";
            this.tbBookTitleID.Size = new System.Drawing.Size(120, 25);
            this.tbBookTitleID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Member Name or ID:";
            // 
            // tbMemberNameID
            // 
            this.tbMemberNameID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMemberNameID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberNameID.Location = new System.Drawing.Point(7, 37);
            this.tbMemberNameID.Name = "tbMemberNameID";
            this.tbMemberNameID.Size = new System.Drawing.Size(120, 25);
            this.tbMemberNameID.TabIndex = 0;
            // 
            // cbLoanStatus
            // 
            this.cbLoanStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLoanStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbLoanStatus.FormattingEnabled = true;
            this.cbLoanStatus.Items.AddRange(new object[] {
            "All",
            "Issued",
            "Returned"});
            this.cbLoanStatus.Location = new System.Drawing.Point(275, 37);
            this.cbLoanStatus.Name = "cbLoanStatus";
            this.cbLoanStatus.Size = new System.Drawing.Size(120, 25);
            this.cbLoanStatus.TabIndex = 12;
            // 
            // CurrentLoansOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(684, 561);
            this.Name = "CurrentLoansOverview";
            this.Text = "CurrentLoansOverview";
            this.Load += new System.EventHandler(this.CurrentLoansOverview_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentLoans)).EndInit();
            this.pnlCustomRange.ResumeLayout(false);
            this.pnlCustomRange.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBookTitleID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox tbMemberNameID;
        private System.Windows.Forms.Panel pnlCustomRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDateRange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvCurrentLoans;
        private System.Windows.Forms.ComboBox cbLoanStatus;
    }
}