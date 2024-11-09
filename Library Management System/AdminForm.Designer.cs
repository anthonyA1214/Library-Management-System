namespace Library_Management_System
{
    partial class AdminForm
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
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlReportsSubMenu = new System.Windows.Forms.Panel();
            this.btnOverdueItemsReports = new System.Windows.Forms.Button();
            this.btnMemberActivityReports = new System.Windows.Forms.Button();
            this.btnCirculationReports = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlBorrowReturnSubMenu = new System.Windows.Forms.Panel();
            this.btnCurrentLoansOverview = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnBorrowReturn = new System.Windows.Forms.Button();
            this.pnlManageMembersSubMenu = new System.Windows.Forms.Panel();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.btnAddEditMember = new System.Windows.Forms.Button();
            this.btnManageMembers = new System.Windows.Forms.Button();
            this.pnlManageStaffsSubMenu = new System.Windows.Forms.Panel();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.btnAddEditStaff = new System.Windows.Forms.Button();
            this.btnManageStaffs = new System.Windows.Forms.Button();
            this.pnlManageBooksSubMenu = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnAddEditBook = new System.Windows.Forms.Button();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            this.pnlReportsSubMenu.SuspendLayout();
            this.pnlBorrowReturnSubMenu.SuspendLayout();
            this.pnlManageMembersSubMenu.SuspendLayout();
            this.pnlManageStaffsSubMenu.SuspendLayout();
            this.pnlManageBooksSubMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(120)))));
            this.pnlSideMenu.Controls.Add(this.btnLogout);
            this.pnlSideMenu.Controls.Add(this.pnlReportsSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnReports);
            this.pnlSideMenu.Controls.Add(this.pnlBorrowReturnSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnBorrowReturn);
            this.pnlSideMenu.Controls.Add(this.pnlManageMembersSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnManageMembers);
            this.pnlSideMenu.Controls.Add(this.pnlManageStaffsSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnManageStaffs);
            this.pnlSideMenu.Controls.Add(this.pnlManageBooksSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnManageBooks);
            this.pnlSideMenu.Controls.Add(this.btnDashboard);
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(250, 561);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Image = global::Library_Management_System.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 965);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(233, 45);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "       Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlReportsSubMenu
            // 
            this.pnlReportsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.pnlReportsSubMenu.Controls.Add(this.btnOverdueItemsReports);
            this.pnlReportsSubMenu.Controls.Add(this.btnMemberActivityReports);
            this.pnlReportsSubMenu.Controls.Add(this.btnCirculationReports);
            this.pnlReportsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportsSubMenu.Location = new System.Drawing.Point(0, 840);
            this.pnlReportsSubMenu.Name = "pnlReportsSubMenu";
            this.pnlReportsSubMenu.Size = new System.Drawing.Size(233, 125);
            this.pnlReportsSubMenu.TabIndex = 11;
            // 
            // btnOverdueItemsReports
            // 
            this.btnOverdueItemsReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOverdueItemsReports.FlatAppearance.BorderSize = 0;
            this.btnOverdueItemsReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverdueItemsReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverdueItemsReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOverdueItemsReports.Location = new System.Drawing.Point(0, 80);
            this.btnOverdueItemsReports.Name = "btnOverdueItemsReports";
            this.btnOverdueItemsReports.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOverdueItemsReports.Size = new System.Drawing.Size(233, 40);
            this.btnOverdueItemsReports.TabIndex = 5;
            this.btnOverdueItemsReports.Text = "       Overdue Items Report";
            this.btnOverdueItemsReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverdueItemsReports.UseVisualStyleBackColor = true;
            this.btnOverdueItemsReports.Click += new System.EventHandler(this.btnOverdueItemsReports_Click);
            // 
            // btnMemberActivityReports
            // 
            this.btnMemberActivityReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberActivityReports.FlatAppearance.BorderSize = 0;
            this.btnMemberActivityReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberActivityReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberActivityReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMemberActivityReports.Location = new System.Drawing.Point(0, 40);
            this.btnMemberActivityReports.Name = "btnMemberActivityReports";
            this.btnMemberActivityReports.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMemberActivityReports.Size = new System.Drawing.Size(233, 40);
            this.btnMemberActivityReports.TabIndex = 4;
            this.btnMemberActivityReports.Text = "       Member Activity Report";
            this.btnMemberActivityReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberActivityReports.UseVisualStyleBackColor = true;
            this.btnMemberActivityReports.Click += new System.EventHandler(this.btnMemberActivityReports_Click);
            // 
            // btnCirculationReports
            // 
            this.btnCirculationReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCirculationReports.FlatAppearance.BorderSize = 0;
            this.btnCirculationReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCirculationReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCirculationReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCirculationReports.Location = new System.Drawing.Point(0, 0);
            this.btnCirculationReports.Name = "btnCirculationReports";
            this.btnCirculationReports.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCirculationReports.Size = new System.Drawing.Size(233, 40);
            this.btnCirculationReports.TabIndex = 3;
            this.btnCirculationReports.Text = "       Circulation Report";
            this.btnCirculationReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCirculationReports.UseVisualStyleBackColor = true;
            this.btnCirculationReports.Click += new System.EventHandler(this.btnCirculationReports_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReports.Image = global::Library_Management_System.Properties.Resources.report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 795);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(233, 45);
            this.btnReports.TabIndex = 10;
            this.btnReports.Text = "       Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReports.Image = global::Library_Management_System.Properties.Resources.report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 795);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(233, 45);
            this.btnReports.TabIndex = 10;
            this.btnReports.Text = "       Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlBorrowReturnSubMenu
            // 
            this.pnlBorrowReturnSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.pnlBorrowReturnSubMenu.Controls.Add(this.btnCurrentLoansOverview);
            this.pnlBorrowReturnSubMenu.Controls.Add(this.btnReturnBook);
            this.pnlBorrowReturnSubMenu.Controls.Add(this.btnIssueBook);
            this.pnlBorrowReturnSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorrowReturnSubMenu.Location = new System.Drawing.Point(0, 670);
            this.pnlBorrowReturnSubMenu.Name = "pnlBorrowReturnSubMenu";
            this.pnlBorrowReturnSubMenu.Size = new System.Drawing.Size(233, 125);
            this.pnlBorrowReturnSubMenu.TabIndex = 9;
            // 
            // btnCurrentLoansOverview
            // 
            this.btnCurrentLoansOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentLoansOverview.FlatAppearance.BorderSize = 0;
            this.btnCurrentLoansOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentLoansOverview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentLoansOverview.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCurrentLoansOverview.Location = new System.Drawing.Point(0, 80);
            this.btnCurrentLoansOverview.Name = "btnCurrentLoansOverview";
            this.btnCurrentLoansOverview.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCurrentLoansOverview.Size = new System.Drawing.Size(233, 40);
            this.btnCurrentLoansOverview.TabIndex = 5;
            this.btnCurrentLoansOverview.Text = "       Current Loans Overview";
            this.btnCurrentLoansOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrentLoansOverview.UseVisualStyleBackColor = true;
            this.btnCurrentLoansOverview.Click += new System.EventHandler(this.btnCurrentLoansOverview_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReturnBook.Location = new System.Drawing.Point(0, 40);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReturnBook.Size = new System.Drawing.Size(233, 40);
            this.btnReturnBook.TabIndex = 4;
            this.btnReturnBook.Text = "       Return Book";
            this.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIssueBook.FlatAppearance.BorderSize = 0;
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIssueBook.Location = new System.Drawing.Point(0, 0);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnIssueBook.Size = new System.Drawing.Size(233, 40);
            this.btnIssueBook.TabIndex = 3;
            this.btnIssueBook.Text = "       Issue Book";
            this.btnIssueBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // btnBorrowReturn
            // 
            this.btnBorrowReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrowReturn.FlatAppearance.BorderSize = 0;
            this.btnBorrowReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowReturn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowReturn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBorrowReturn.Image = global::Library_Management_System.Properties.Resources.borrow;
            this.btnBorrowReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowReturn.Location = new System.Drawing.Point(0, 625);
            this.btnBorrowReturn.Name = "btnBorrowReturn";
            this.btnBorrowReturn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBorrowReturn.Size = new System.Drawing.Size(233, 45);
            this.btnBorrowReturn.TabIndex = 8;
            this.btnBorrowReturn.Text = "       Borrow/Return";
            this.btnBorrowReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowReturn.UseVisualStyleBackColor = true;
            this.btnBorrowReturn.Click += new System.EventHandler(this.btnBorrowReturn_Click);
            // 
            // btnBorrowReturn
            // 
            this.btnBorrowReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrowReturn.FlatAppearance.BorderSize = 0;
            this.btnBorrowReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowReturn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowReturn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBorrowReturn.Image = global::Library_Management_System.Properties.Resources.borrow;
            this.btnBorrowReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowReturn.Location = new System.Drawing.Point(0, 625);
            this.btnBorrowReturn.Name = "btnBorrowReturn";
            this.btnBorrowReturn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBorrowReturn.Size = new System.Drawing.Size(233, 45);
            this.btnBorrowReturn.TabIndex = 8;
            this.btnBorrowReturn.Text = "       Borrow/Return";
            this.btnBorrowReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowReturn.UseVisualStyleBackColor = true;
            this.btnBorrowReturn.Click += new System.EventHandler(this.btnBorrowReturn_Click);
            // 
            // pnlManageMembersSubMenu
            // 
            this.pnlManageMembersSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.pnlManageMembersSubMenu.Controls.Add(this.btnSearchMember);
            this.pnlManageMembersSubMenu.Controls.Add(this.btnAddEditMember);
            this.pnlManageMembersSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageMembersSubMenu.Location = new System.Drawing.Point(0, 540);
            this.pnlManageMembersSubMenu.Name = "pnlManageMembersSubMenu";
            this.pnlManageMembersSubMenu.Size = new System.Drawing.Size(233, 85);
            this.pnlManageMembersSubMenu.TabIndex = 7;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchMember.FlatAppearance.BorderSize = 0;
            this.btnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMember.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchMember.Location = new System.Drawing.Point(0, 40);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchMember.Size = new System.Drawing.Size(233, 40);
            this.btnSearchMember.TabIndex = 4;
            this.btnSearchMember.Text = "       Search Member";
            this.btnSearchMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // btnAddEditMember
            // 
            this.btnAddEditMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEditMember.FlatAppearance.BorderSize = 0;
            this.btnAddEditMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEditMember.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditMember.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddEditMember.Location = new System.Drawing.Point(0, 0);
            this.btnAddEditMember.Name = "btnAddEditMember";
            this.btnAddEditMember.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddEditMember.Size = new System.Drawing.Size(233, 40);
            this.btnAddEditMember.TabIndex = 3;
            this.btnAddEditMember.Text = "       Add/Edit Member";
            this.btnAddEditMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEditMember.UseVisualStyleBackColor = true;
            this.btnAddEditMember.Click += new System.EventHandler(this.btnAddEditMember_Click);
            // 
            // btnManageMembers
            // 
            this.btnManageMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageMembers.FlatAppearance.BorderSize = 0;
            this.btnManageMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMembers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMembers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManageMembers.Image = global::Library_Management_System.Properties.Resources.profile;
            this.btnManageMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMembers.Location = new System.Drawing.Point(0, 495);
            this.btnManageMembers.Name = "btnManageMembers";
            this.btnManageMembers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageMembers.Size = new System.Drawing.Size(233, 45);
            this.btnManageMembers.TabIndex = 6;
            this.btnManageMembers.Text = "       Manage Members";
            this.btnManageMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMembers.UseVisualStyleBackColor = true;
            this.btnManageMembers.Click += new System.EventHandler(this.btnManageMembers_Click);
            // 
            // btnManageMembers
            // 
            this.btnManageMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageMembers.FlatAppearance.BorderSize = 0;
            this.btnManageMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMembers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMembers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManageMembers.Image = global::Library_Management_System.Properties.Resources.profile;
            this.btnManageMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMembers.Location = new System.Drawing.Point(0, 495);
            this.btnManageMembers.Name = "btnManageMembers";
            this.btnManageMembers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageMembers.Size = new System.Drawing.Size(233, 45);
            this.btnManageMembers.TabIndex = 6;
            this.btnManageMembers.Text = "       Manage Members";
            this.btnManageMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMembers.UseVisualStyleBackColor = true;
            this.btnManageMembers.Click += new System.EventHandler(this.btnManageMembers_Click);
            // 
            // pnlManageStaffsSubMenu
            // 
            this.pnlManageStaffsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.pnlManageStaffsSubMenu.Controls.Add(this.btnSearchStaff);
            this.pnlManageStaffsSubMenu.Controls.Add(this.btnAddEditStaff);
            this.pnlManageStaffsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageStaffsSubMenu.Location = new System.Drawing.Point(0, 410);
            this.pnlManageStaffsSubMenu.Name = "pnlManageStaffsSubMenu";
            this.pnlManageStaffsSubMenu.Size = new System.Drawing.Size(233, 85);
            this.pnlManageStaffsSubMenu.TabIndex = 5;
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchStaff.FlatAppearance.BorderSize = 0;
            this.btnSearchStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStaff.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchStaff.Location = new System.Drawing.Point(0, 40);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchStaff.Size = new System.Drawing.Size(233, 40);
            this.btnSearchStaff.TabIndex = 4;
            this.btnSearchStaff.Text = "       Search Staff";
            this.btnSearchStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // btnAddEditStaff
            // 
            this.btnAddEditStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEditStaff.FlatAppearance.BorderSize = 0;
            this.btnAddEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEditStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditStaff.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddEditStaff.Location = new System.Drawing.Point(0, 0);
            this.btnAddEditStaff.Name = "btnAddEditStaff";
            this.btnAddEditStaff.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddEditStaff.Size = new System.Drawing.Size(233, 40);
            this.btnAddEditStaff.TabIndex = 3;
            this.btnAddEditStaff.Text = "       Add/Edit Staff";
            this.btnAddEditStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEditStaff.UseVisualStyleBackColor = true;
            this.btnAddEditStaff.Click += new System.EventHandler(this.btnAddEditStaff_Click);
            // 
            // btnManageStaffs
            // 
            this.btnManageStaffs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageStaffs.FlatAppearance.BorderSize = 0;
            this.btnManageStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStaffs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStaffs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManageStaffs.Image = global::Library_Management_System.Properties.Resources.team;
            this.btnManageStaffs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStaffs.Location = new System.Drawing.Point(0, 365);
            this.btnManageStaffs.Name = "btnManageStaffs";
            this.btnManageStaffs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageStaffs.Size = new System.Drawing.Size(233, 45);
            this.btnManageStaffs.TabIndex = 4;
            this.btnManageStaffs.Text = "       Manage Staffs";
            this.btnManageStaffs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStaffs.UseVisualStyleBackColor = true;
            this.btnManageStaffs.Click += new System.EventHandler(this.btnManageStaffs_Click);
            // 
            // btnManageStaffs
            // 
            this.btnManageStaffs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageStaffs.FlatAppearance.BorderSize = 0;
            this.btnManageStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStaffs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStaffs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManageStaffs.Image = global::Library_Management_System.Properties.Resources.team;
            this.btnManageStaffs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStaffs.Location = new System.Drawing.Point(0, 365);
            this.btnManageStaffs.Name = "btnManageStaffs";
            this.btnManageStaffs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageStaffs.Size = new System.Drawing.Size(233, 45);
            this.btnManageStaffs.TabIndex = 4;
            this.btnManageStaffs.Text = "       Manage Staffs";
            this.btnManageStaffs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStaffs.UseVisualStyleBackColor = true;
            this.btnManageStaffs.Click += new System.EventHandler(this.btnManageStaffs_Click);
            // 
            // pnlManageBooksSubMenu
            // 
            this.pnlManageBooksSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.pnlManageBooksSubMenu.Controls.Add(this.btnInventory);
            this.pnlManageBooksSubMenu.Controls.Add(this.btnSearchBook);
            this.pnlManageBooksSubMenu.Controls.Add(this.btnAddEditBook);
            this.pnlManageBooksSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageBooksSubMenu.Location = new System.Drawing.Point(0, 240);
            this.pnlManageBooksSubMenu.Name = "pnlManageBooksSubMenu";
            this.pnlManageBooksSubMenu.Size = new System.Drawing.Size(233, 125);
            this.pnlManageBooksSubMenu.TabIndex = 3;
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInventory.Location = new System.Drawing.Point(0, 80);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(233, 40);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "       Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchBook.FlatAppearance.BorderSize = 0;
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchBook.Location = new System.Drawing.Point(0, 40);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchBook.Size = new System.Drawing.Size(233, 40);
            this.btnSearchBook.TabIndex = 4;
            this.btnSearchBook.Text = "       Search Book";
            this.btnSearchBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnAddEditBook
            // 
            this.btnAddEditBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEditBook.FlatAppearance.BorderSize = 0;
            this.btnAddEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEditBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddEditBook.Location = new System.Drawing.Point(0, 0);
            this.btnAddEditBook.Name = "btnAddEditBook";
            this.btnAddEditBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddEditBook.Size = new System.Drawing.Size(233, 40);
            this.btnAddEditBook.TabIndex = 3;
            this.btnAddEditBook.Text = "       Add/Edit Book";
            this.btnAddEditBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEditBook.UseVisualStyleBackColor = true;
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageBooks.FlatAppearance.BorderSize = 0;
            this.btnManageBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBooks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBooks.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManageBooks.Image = global::Library_Management_System.Properties.Resources.book;
            this.btnManageBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBooks.Location = new System.Drawing.Point(0, 195);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageBooks.Size = new System.Drawing.Size(233, 45);
            this.btnManageBooks.TabIndex = 2;
            this.btnManageBooks.Text = "       Manage Books";
            this.btnManageBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.Image = global::Library_Management_System.Properties.Resources.layout;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 150);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(233, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "       Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(233, 150);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(233, 150);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Library_Management_System.Properties.Resources.digital_library;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(120)))));
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(250, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(684, 561);
            this.pnlContainer.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlSideMenu);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlReportsSubMenu.ResumeLayout(false);
            this.pnlBorrowReturnSubMenu.ResumeLayout(false);
            this.pnlManageMembersSubMenu.ResumeLayout(false);
            this.pnlManageStaffsSubMenu.ResumeLayout(false);
            this.pnlManageBooksSubMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlManageBooksSubMenu;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnAddEditBook;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Panel pnlBorrowReturnSubMenu;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnBorrowReturn;
        private System.Windows.Forms.Panel pnlManageMembersSubMenu;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnAddEditMember;
        private System.Windows.Forms.Button btnManageMembers;
        private System.Windows.Forms.Panel pnlManageStaffsSubMenu;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.Button btnAddEditStaff;
        private System.Windows.Forms.Button btnManageStaffs;
        private System.Windows.Forms.Panel pnlReportsSubMenu;
        private System.Windows.Forms.Button btnOverdueItemsReports;
        private System.Windows.Forms.Button btnMemberActivityReports;
        private System.Windows.Forms.Button btnCirculationReports;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnCurrentLoansOverview;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlContainer;
    }
}