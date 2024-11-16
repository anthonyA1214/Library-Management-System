namespace Library_Management_System
{
    partial class AddEditStaff
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.tbContactNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSideMenu = new System.Windows.Forms.Label();
            this.tbStaffID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbExit2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 472);
            this.panel3.TabIndex = 5;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlGrid.Controls.Add(this.dgvBook);
            this.pnlGrid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlGrid.Location = new System.Drawing.Point(9, 9);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(450, 454);
            this.pnlGrid.TabIndex = 0;
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AllowUserToResizeColumns = false;
            this.dgvBook.AllowUserToResizeRows = false;
            this.dgvBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBook.ColumnHeadersHeight = 50;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBook.Location = new System.Drawing.Point(9, 9);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.RowHeadersWidth = 40;
            this.dgvBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(433, 437);
            this.dgvBook.TabIndex = 0;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.pbExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 50);
            this.panel2.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(140)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(95)))), ((int)(((byte)(180)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.Location = new System.Drawing.Point(359, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 45);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(140)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(95)))), ((int)(((byte)(180)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Location = new System.Drawing.Point(258, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 45);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(140)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(95)))), ((int)(((byte)(180)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.Location = new System.Drawing.Point(157, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 45);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(140)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(95)))), ((int)(((byte)(180)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(56, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlSideMenu.Controls.Add(this.tbContactNumber);
            this.pnlSideMenu.Controls.Add(this.label2);
            this.pnlSideMenu.Controls.Add(this.tbLastName);
            this.pnlSideMenu.Controls.Add(this.cbRole);
            this.pnlSideMenu.Controls.Add(this.btnEnter);
            this.pnlSideMenu.Controls.Add(this.label8);
            this.pnlSideMenu.Controls.Add(this.tbEmail);
            this.pnlSideMenu.Controls.Add(this.label7);
            this.pnlSideMenu.Controls.Add(this.tbFirstName);
            this.pnlSideMenu.Controls.Add(this.label6);
            this.pnlSideMenu.Controls.Add(this.label5);
            this.pnlSideMenu.Controls.Add(this.tbPassword);
            this.pnlSideMenu.Controls.Add(this.label4);
            this.pnlSideMenu.Controls.Add(this.tbUsername);
            this.pnlSideMenu.Controls.Add(this.label3);
            this.pnlSideMenu.Controls.Add(this.lblSideMenu);
            this.pnlSideMenu.Controls.Add(this.tbStaffID);
            this.pnlSideMenu.Controls.Add(this.label1);
            this.pnlSideMenu.Controls.Add(this.pbExit2);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSideMenu.Location = new System.Drawing.Point(468, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(200, 522);
            this.pnlSideMenu.TabIndex = 3;
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContactNumber.Location = new System.Drawing.Point(6, 492);
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.Size = new System.Drawing.Size(182, 25);
            this.tbContactNumber.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Contact Number:";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(6, 382);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(182, 25);
            this.tbLastName.TabIndex = 23;
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Staff",
            "Admin"});
            this.cbRole.Location = new System.Drawing.Point(6, 272);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(182, 25);
            this.cbRole.TabIndex = 22;
            // 
            // btnEnter
            // 
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(29, 525);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(125, 40);
            this.btnEnter.TabIndex = 21;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(6, 437);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(182, 25);
            this.tbEmail.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(6, 327);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(182, 25);
            this.tbFirstName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Role:";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(6, 217);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(182, 25);
            this.tbPassword.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(6, 162);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(182, 25);
            this.tbUsername.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username:";
            // 
            // lblSideMenu
            // 
            this.lblSideMenu.AutoSize = true;
            this.lblSideMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideMenu.Location = new System.Drawing.Point(6, 50);
            this.lblSideMenu.Name = "lblSideMenu";
            this.lblSideMenu.Size = new System.Drawing.Size(124, 30);
            this.lblSideMenu.TabIndex = 8;
            this.lblSideMenu.Text = "ADD STAFF";
            // 
            // tbStaffID
            // 
            this.tbStaffID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStaffID.Location = new System.Drawing.Point(6, 107);
            this.tbStaffID.Name = "tbStaffID";
            this.tbStaffID.ReadOnly = true;
            this.tbStaffID.Size = new System.Drawing.Size(182, 25);
            this.tbStaffID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Staff ID:";
            // 
            // pbExit2
            // 
            this.pbExit2.Image = global::Library_Management_System.Properties.Resources.reject2;
            this.pbExit2.Location = new System.Drawing.Point(6, 3);
            this.pbExit2.Name = "pbExit2";
            this.pbExit2.Size = new System.Drawing.Size(25, 25);
            this.pbExit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit2.TabIndex = 5;
            this.pbExit2.TabStop = false;
            this.pbExit2.Click += new System.EventHandler(this.pbExit2_Click);
            // 
            // AddEditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSideMenu);
            this.Name = "AddEditStaff";
            this.Text = "AddEditStaff";
            this.Load += new System.EventHandler(this.AddEditStaff_Load);
            this.panel3.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSideMenu;
        private System.Windows.Forms.TextBox tbStaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbExit2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox tbContactNumber;
        private System.Windows.Forms.Label label2;
    }
}