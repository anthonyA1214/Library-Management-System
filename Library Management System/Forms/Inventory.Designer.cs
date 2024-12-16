namespace Library_Management_System
{
    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAvailabilityStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGenre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSideMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.numQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnEnter = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbExit2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSideMenu = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvBook = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit2)).BeginInit();
            this.guna2Panel5.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopMenu.BorderRadius = 20;
            this.pnlTopMenu.Controls.Add(this.label1);
            this.pnlTopMenu.Controls.Add(this.pbExit);
            this.pnlTopMenu.Controls.Add(this.tbSearch);
            this.pnlTopMenu.Controls.Add(this.cbSearchBy);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.pnlTopMenu.Location = new System.Drawing.Point(10, 10);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(648, 50);
            this.pnlTopMenu.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by:";
            // 
            // pbExit
            // 
            this.pbExit.Image = global::Library_Management_System.Properties.Resources.reject2;
            this.pbExit.ImageRotate = 0F;
            this.pbExit.Location = new System.Drawing.Point(7, 7);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(25, 25);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 1;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.AutoRoundedCorners = true;
            this.tbSearch.BorderRadius = 17;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.IconLeft = global::Library_Management_System.Properties.Resources.search;
            this.tbSearch.Location = new System.Drawing.Point(338, 7);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "Search books";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(200, 36);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSearchBy.AutoRoundedCorners = true;
            this.cbSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.cbSearchBy.BorderRadius = 17;
            this.cbSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.cbSearchBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSearchBy.ItemHeight = 30;
            this.cbSearchBy.Items.AddRange(new object[] {
            "Title",
            "Author",
            "ISBN",
            "Publication Year",
            "ID"});
            this.cbSearchBy.Location = new System.Drawing.Point(189, 7);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(140, 36);
            this.cbSearchBy.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(10, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(648, 5);
            this.guna2Panel1.TabIndex = 12;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.cbAvailabilityStatus);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.cbGenre);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.guna2Panel2.Location = new System.Drawing.Point(10, 65);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(648, 65);
            this.guna2Panel2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Availability Status:";
            // 
            // cbAvailabilityStatus
            // 
            this.cbAvailabilityStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAvailabilityStatus.AutoRoundedCorners = true;
            this.cbAvailabilityStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbAvailabilityStatus.BorderRadius = 17;
            this.cbAvailabilityStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAvailabilityStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAvailabilityStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.cbAvailabilityStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAvailabilityStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAvailabilityStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAvailabilityStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbAvailabilityStatus.ItemHeight = 30;
            this.cbAvailabilityStatus.Items.AddRange(new object[] {
            "All",
            "Available",
            "Unavailable"});
            this.cbAvailabilityStatus.Location = new System.Drawing.Point(329, 23);
            this.cbAvailabilityStatus.Name = "cbAvailabilityStatus";
            this.cbAvailabilityStatus.Size = new System.Drawing.Size(140, 36);
            this.cbAvailabilityStatus.TabIndex = 4;
            this.cbAvailabilityStatus.SelectedIndexChanged += new System.EventHandler(this.cbAvailabilityStatus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genre:";
            // 
            // cbGenre
            // 
            this.cbGenre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbGenre.AutoRoundedCorners = true;
            this.cbGenre.BackColor = System.Drawing.Color.Transparent;
            this.cbGenre.BorderRadius = 17;
            this.cbGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.cbGenre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGenre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGenre.ItemHeight = 30;
            this.cbGenre.Items.AddRange(new object[] {
            "All",
            "Title",
            "Author",
            "ISBN",
            "Genre",
            "Publication Year"});
            this.cbGenre.Location = new System.Drawing.Point(183, 21);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(140, 36);
            this.cbGenre.TabIndex = 1;
            this.cbGenre.SelectedIndexChanged += new System.EventHandler(this.cbGenre_SelectedIndexChanged);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 20;
            this.guna2Panel4.Controls.Add(this.btnRefresh);
            this.guna2Panel4.Controls.Add(this.btnExport);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.guna2Panel4.Location = new System.Drawing.Point(10, 462);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(648, 50);
            this.guna2Panel4.TabIndex = 15;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.AutoRoundedCorners = true;
            this.btnRefresh.BorderRadius = 19;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(185)))), ((int)(((byte)(163)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(327, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh Inventory";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExport.AutoRoundedCorners = true;
            this.btnExport.BorderRadius = 19;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(185)))), ((int)(((byte)(163)))));
            this.btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(171, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 40);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export Inventory";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlSideMenu.BorderRadius = 20;
            this.pnlSideMenu.Controls.Add(this.numQuantity);
            this.pnlSideMenu.Controls.Add(this.btnEnter);
            this.pnlSideMenu.Controls.Add(this.label7);
            this.pnlSideMenu.Controls.Add(this.label8);
            this.pnlSideMenu.Controls.Add(this.tbAuthor);
            this.pnlSideMenu.Controls.Add(this.label9);
            this.pnlSideMenu.Controls.Add(this.tbTitle);
            this.pnlSideMenu.Controls.Add(this.pbExit2);
            this.pnlSideMenu.Controls.Add(this.lblSideMenu);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.pnlSideMenu.Location = new System.Drawing.Point(10, 130);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(225, 332);
            this.pnlSideMenu.TabIndex = 17;
            // 
            // numQuantity
            // 
            this.numQuantity.AutoRoundedCorners = true;
            this.numQuantity.BackColor = System.Drawing.Color.Transparent;
            this.numQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.numQuantity.BorderRadius = 17;
            this.numQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantity.Location = new System.Drawing.Point(12, 221);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(200, 36);
            this.numQuantity.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.AutoRoundedCorners = true;
            this.btnEnter.BorderRadius = 19;
            this.btnEnter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(185)))), ((int)(((byte)(163)))));
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(37, 263);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(150, 40);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(17, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(17, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Author:";
            // 
            // tbAuthor
            // 
            this.tbAuthor.AutoRoundedCorners = true;
            this.tbAuthor.BorderRadius = 17;
            this.tbAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAuthor.DefaultText = "";
            this.tbAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAuthor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.tbAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAuthor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAuthor.Location = new System.Drawing.Point(12, 162);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.PasswordChar = '\0';
            this.tbAuthor.PlaceholderText = "";
            this.tbAuthor.SelectedText = "";
            this.tbAuthor.Size = new System.Drawing.Size(200, 36);
            this.tbAuthor.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label9.Location = new System.Drawing.Point(17, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Title:";
            // 
            // tbTitle
            // 
            this.tbTitle.AutoRoundedCorners = true;
            this.tbTitle.BorderRadius = 17;
            this.tbTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTitle.DefaultText = "";
            this.tbTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.tbTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTitle.Location = new System.Drawing.Point(12, 100);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.PasswordChar = '\0';
            this.tbTitle.PlaceholderText = "";
            this.tbTitle.SelectedText = "";
            this.tbTitle.Size = new System.Drawing.Size(200, 36);
            this.tbTitle.TabIndex = 1;
            // 
            // pbExit2
            // 
            this.pbExit2.Image = global::Library_Management_System.Properties.Resources.reject2;
            this.pbExit2.ImageRotate = 0F;
            this.pbExit2.Location = new System.Drawing.Point(181, 6);
            this.pbExit2.Name = "pbExit2";
            this.pbExit2.Size = new System.Drawing.Size(25, 25);
            this.pbExit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit2.TabIndex = 3;
            this.pbExit2.TabStop = false;
            this.pbExit2.Click += new System.EventHandler(this.pbExit2_Click);
            // 
            // lblSideMenu
            // 
            this.lblSideMenu.AutoSize = true;
            this.lblSideMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSideMenu.Location = new System.Drawing.Point(15, 35);
            this.lblSideMenu.Name = "lblSideMenu";
            this.lblSideMenu.Size = new System.Drawing.Size(114, 30);
            this.lblSideMenu.TabIndex = 2;
            this.lblSideMenu.Text = "Add Stock";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.pnlGrid);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel5.Location = new System.Drawing.Point(235, 130);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel5.Size = new System.Drawing.Size(423, 332);
            this.guna2Panel5.TabIndex = 18;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrid.BorderRadius = 20;
            this.pnlGrid.Controls.Add(this.dgvBook);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.pnlGrid.Location = new System.Drawing.Point(10, 10);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGrid.Size = new System.Drawing.Size(403, 312);
            this.pnlGrid.TabIndex = 0;
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AllowUserToResizeColumns = false;
            this.dgvBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.dgvBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBook.ColumnHeadersHeight = 50;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dgvBook.Location = new System.Drawing.Point(10, 10);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBook.Size = new System.Drawing.Size(383, 292);
            this.dgvBook.TabIndex = 0;
            this.dgvBook.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen;
            this.dgvBook.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.dgvBook.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBook.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBook.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBook.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBook.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.dgvBook.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dgvBook.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.dgvBook.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBook.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBook.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBook.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBook.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvBook.ThemeStyle.ReadOnly = true;
            this.dgvBook.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            this.dgvBook.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBook.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBook.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBook.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBook.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            this.dgvBook.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            this.dgvBook.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBook_CellFormatting);
            this.dgvBook.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dgvBook_CellToolTipTextNeeded);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlTopMenu);
            this.MinimumSize = new System.Drawing.Size(684, 561);
            this.Name = "Inventory";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.pnlTopMenu.ResumeLayout(false);
            this.pnlTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit2)).EndInit();
            this.guna2Panel5.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlTopMenu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox pbExit;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchBy;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbAvailabilityStatus;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbGenre;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2Panel pnlSideMenu;
        private Guna.UI2.WinForms.Guna2NumericUpDown numQuantity;
        private Guna.UI2.WinForms.Guna2Button btnEnter;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox tbAuthor;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox tbTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pbExit2;
        private System.Windows.Forms.Label lblSideMenu;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBook;
    }
}