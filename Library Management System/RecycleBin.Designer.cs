namespace Library_Management_System
{
    partial class RecycleBin
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
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvRecycleBin = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlTopMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSelectTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel3.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecycleBin)).BeginInit();
            this.pnlTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.pnlGrid);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 65);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel3.Size = new System.Drawing.Size(668, 457);
            this.guna2Panel3.TabIndex = 11;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrid.BorderRadius = 20;
            this.pnlGrid.Controls.Add(this.dgvRecycleBin);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.pnlGrid.Location = new System.Drawing.Point(10, 10);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGrid.Size = new System.Drawing.Size(648, 437);
            this.pnlGrid.TabIndex = 0;
            // 
            // dgvRecycleBin
            // 
            this.dgvRecycleBin.AllowUserToAddRows = false;
            this.dgvRecycleBin.AllowUserToDeleteRows = false;
            this.dgvRecycleBin.AllowUserToResizeColumns = false;
            this.dgvRecycleBin.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.dgvRecycleBin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRecycleBin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecycleBin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRecycleBin.ColumnHeadersHeight = 50;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecycleBin.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRecycleBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecycleBin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dgvRecycleBin.Location = new System.Drawing.Point(10, 10);
            this.dgvRecycleBin.Name = "dgvRecycleBin";
            this.dgvRecycleBin.ReadOnly = true;
            this.dgvRecycleBin.RowHeadersVisible = false;
            this.dgvRecycleBin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRecycleBin.Size = new System.Drawing.Size(628, 417);
            this.dgvRecycleBin.TabIndex = 0;
            this.dgvRecycleBin.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen;
            this.dgvRecycleBin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.dgvRecycleBin.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRecycleBin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRecycleBin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRecycleBin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRecycleBin.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.dgvRecycleBin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dgvRecycleBin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.dgvRecycleBin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecycleBin.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRecycleBin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRecycleBin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecycleBin.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvRecycleBin.ThemeStyle.ReadOnly = true;
            this.dgvRecycleBin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            this.dgvRecycleBin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecycleBin.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRecycleBin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRecycleBin.ThemeStyle.RowsStyle.Height = 22;
            this.dgvRecycleBin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            this.dgvRecycleBin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopMenu.BorderRadius = 10;
            this.pnlTopMenu.Controls.Add(this.label2);
            this.pnlTopMenu.Controls.Add(this.cbSelectTable);
            this.pnlTopMenu.Controls.Add(this.label1);
            this.pnlTopMenu.Controls.Add(this.pbExit);
            this.pnlTopMenu.Controls.Add(this.tbSearch);
            this.pnlTopMenu.Controls.Add(this.cbSearchBy);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.pnlTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(668, 65);
            this.pnlTopMenu.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 24);
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
            this.tbSearch.Location = new System.Drawing.Point(456, 14);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "Search records";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(200, 36);
            this.tbSearch.TabIndex = 1;
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
            "Name",
            "Username",
            "ID"});
            this.cbSearchBy.Location = new System.Drawing.Point(307, 14);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(140, 36);
            this.cbSearchBy.TabIndex = 0;
            // 
            // cbSelectTable
            // 
            this.cbSelectTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSelectTable.AutoRoundedCorners = true;
            this.cbSelectTable.BackColor = System.Drawing.Color.Transparent;
            this.cbSelectTable.BorderRadius = 17;
            this.cbSelectTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSelectTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.cbSelectTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSelectTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSelectTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSelectTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSelectTable.ItemHeight = 30;
            this.cbSelectTable.Items.AddRange(new object[] {
            "Book",
            "Member",
            "Staff",
            "Genre"});
            this.cbSelectTable.Location = new System.Drawing.Point(75, 24);
            this.cbSelectTable.Name = "cbSelectTable";
            this.cbSelectTable.Size = new System.Drawing.Size(140, 36);
            this.cbSelectTable.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Table:";
            // 
            // RecycleBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.pnlTopMenu);
            this.MinimumSize = new System.Drawing.Size(684, 561);
            this.Name = "RecycleBin";
            this.Text = "RecycleBin";
            this.Load += new System.EventHandler(this.RecycleBin_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecycleBin)).EndInit();
            this.pnlTopMenu.ResumeLayout(false);
            this.pnlTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRecycleBin;
        private Guna.UI2.WinForms.Guna2Panel pnlTopMenu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox pbExit;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchBy;
        private Guna.UI2.WinForms.Guna2ComboBox cbSelectTable;
        private System.Windows.Forms.Label label2;
    }
}