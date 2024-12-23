namespace Library_Management_System
{
    partial class ManageGenres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddGenre = new Guna.UI2.WinForms.Guna2Button();
            this.pbExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlAddGenre = new Guna.UI2.WinForms.Guna2Panel();
            this.pbExit2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSaveGenre = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGenreName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvGenre = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.pnlAddGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit2)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopMenu.BorderRadius = 10;
            this.pnlTopMenu.Controls.Add(this.btnAddGenre);
            this.pnlTopMenu.Controls.Add(this.pbExit);
            this.pnlTopMenu.Controls.Add(this.tbSearch);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.pnlTopMenu.Location = new System.Drawing.Point(10, 10);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTopMenu.Size = new System.Drawing.Size(648, 50);
            this.pnlTopMenu.TabIndex = 3;
            this.pnlTopMenu.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddGenre.AutoRoundedCorners = true;
            this.btnAddGenre.BorderRadius = 19;
            this.btnAddGenre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddGenre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddGenre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(185)))), ((int)(((byte)(163)))));
            this.btnAddGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddGenre.ForeColor = System.Drawing.Color.White;
            this.btnAddGenre.Location = new System.Drawing.Point(146, 5);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(150, 40);
            this.btnAddGenre.TabIndex = 2;
            this.btnAddGenre.Text = "Add Genre";
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
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
            this.tbSearch.Location = new System.Drawing.Point(302, 7);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "Search genres";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(200, 36);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // pnlAddGenre
            // 
            this.pnlAddGenre.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddGenre.BorderRadius = 10;
            this.pnlAddGenre.Controls.Add(this.pbExit2);
            this.pnlAddGenre.Controls.Add(this.btnSaveGenre);
            this.pnlAddGenre.Controls.Add(this.label2);
            this.pnlAddGenre.Controls.Add(this.tbGenreName);
            this.pnlAddGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddGenre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.pnlAddGenre.Location = new System.Drawing.Point(10, 65);
            this.pnlAddGenre.Name = "pnlAddGenre";
            this.pnlAddGenre.Size = new System.Drawing.Size(648, 65);
            this.pnlAddGenre.TabIndex = 32;
            // 
            // pbExit2
            // 
            this.pbExit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit2.Image = global::Library_Management_System.Properties.Resources.reject2;
            this.pbExit2.ImageRotate = 0F;
            this.pbExit2.Location = new System.Drawing.Point(614, 7);
            this.pbExit2.Name = "pbExit2";
            this.pbExit2.Size = new System.Drawing.Size(25, 25);
            this.pbExit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit2.TabIndex = 3;
            this.pbExit2.TabStop = false;
            this.pbExit2.Click += new System.EventHandler(this.pbExit2_Click);
            // 
            // btnSaveGenre
            // 
            this.btnSaveGenre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveGenre.AutoRoundedCorners = true;
            this.btnSaveGenre.BorderRadius = 19;
            this.btnSaveGenre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveGenre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveGenre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(185)))), ((int)(((byte)(163)))));
            this.btnSaveGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveGenre.ForeColor = System.Drawing.Color.White;
            this.btnSaveGenre.Location = new System.Drawing.Point(146, 19);
            this.btnSaveGenre.Name = "btnSaveGenre";
            this.btnSaveGenre.Size = new System.Drawing.Size(150, 40);
            this.btnSaveGenre.TabIndex = 3;
            this.btnSaveGenre.Text = "Save Genre";
            this.btnSaveGenre.Click += new System.EventHandler(this.btnSaveGenre_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(307, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre Name:";
            // 
            // tbGenreName
            // 
            this.tbGenreName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbGenreName.AutoRoundedCorners = true;
            this.tbGenreName.BorderRadius = 17;
            this.tbGenreName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGenreName.DefaultText = "";
            this.tbGenreName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbGenreName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbGenreName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbGenreName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbGenreName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.tbGenreName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGenreName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbGenreName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGenreName.Location = new System.Drawing.Point(302, 26);
            this.tbGenreName.Name = "tbGenreName";
            this.tbGenreName.PasswordChar = '\0';
            this.tbGenreName.PlaceholderText = "";
            this.tbGenreName.SelectedText = "";
            this.tbGenreName.Size = new System.Drawing.Size(200, 36);
            this.tbGenreName.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(10, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(648, 5);
            this.guna2Panel1.TabIndex = 31;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.pnlGrid);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(10, 130);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel3.Size = new System.Drawing.Size(648, 382);
            this.guna2Panel3.TabIndex = 33;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrid.BorderRadius = 20;
            this.pnlGrid.Controls.Add(this.dgvGenre);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.pnlGrid.Location = new System.Drawing.Point(10, 10);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGrid.Size = new System.Drawing.Size(628, 362);
            this.pnlGrid.TabIndex = 0;
            // 
            // dgvGenre
            // 
            this.dgvGenre.AllowUserToAddRows = false;
            this.dgvGenre.AllowUserToDeleteRows = false;
            this.dgvGenre.AllowUserToResizeColumns = false;
            this.dgvGenre.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.dgvGenre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGenre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGenre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGenre.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGenre.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGenre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dgvGenre.Location = new System.Drawing.Point(10, 10);
            this.dgvGenre.Name = "dgvGenre";
            this.dgvGenre.ReadOnly = true;
            this.dgvGenre.RowHeadersVisible = false;
            this.dgvGenre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGenre.Size = new System.Drawing.Size(608, 342);
            this.dgvGenre.TabIndex = 0;
            this.dgvGenre.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen;
            this.dgvGenre.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.dgvGenre.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGenre.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGenre.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGenre.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGenre.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.dgvGenre.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dgvGenre.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.dgvGenre.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGenre.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGenre.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGenre.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGenre.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvGenre.ThemeStyle.ReadOnly = true;
            this.dgvGenre.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            this.dgvGenre.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGenre.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGenre.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGenre.ThemeStyle.RowsStyle.Height = 22;
            this.dgvGenre.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            this.dgvGenre.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGenre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenre_CellContentClick);
            this.dgvGenre.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dgvGenre_CellToolTipTextNeeded);
            // 
            // ManageGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.pnlAddGenre);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlTopMenu);
            this.MinimumSize = new System.Drawing.Size(684, 561);
            this.Name = "ManageGenres";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ManageGenres";
            this.Load += new System.EventHandler(this.ManageGenres_Load);
            this.pnlTopMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.pnlAddGenre.ResumeLayout(false);
            this.pnlAddGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit2)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlTopMenu;
        private Guna.UI2.WinForms.Guna2Button btnAddGenre;
        private Guna.UI2.WinForms.Guna2PictureBox pbExit;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2Panel pnlAddGenre;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbGenreName;
        private Guna.UI2.WinForms.Guna2Button btnSaveGenre;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGenre;
        private Guna.UI2.WinForms.Guna2PictureBox pbExit2;
    }
}