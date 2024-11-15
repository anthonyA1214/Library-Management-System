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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pnlLowStocksContainer = new System.Windows.Forms.Panel();
            this.pnlLowStocks = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbHideShow = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvLowStocks = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbSearchTitle = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSearchAuthor = new System.Windows.Forms.ComboBox();
            this.cbSearchGenre = new System.Windows.Forms.ComboBox();
            this.tbSearchISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.pnlLowStocksContainer.SuspendLayout();
            this.pnlLowStocks.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideShow)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStocks)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 36);
            this.panel2.TabIndex = 1;
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
            // pnlLowStocksContainer
            // 
            this.pnlLowStocksContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.pnlLowStocksContainer.Controls.Add(this.pnlLowStocks);
            this.pnlLowStocksContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLowStocksContainer.Location = new System.Drawing.Point(0, 36);
            this.pnlLowStocksContainer.Name = "pnlLowStocksContainer";
            this.pnlLowStocksContainer.Size = new System.Drawing.Size(668, 220);
            this.pnlLowStocksContainer.TabIndex = 3;
            // 
            // pnlLowStocks
            // 
            this.pnlLowStocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLowStocks.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLowStocks.Controls.Add(this.dgvLowStocks);
            this.pnlLowStocks.Controls.Add(this.panel4);
            this.pnlLowStocks.Location = new System.Drawing.Point(8, 10);
            this.pnlLowStocks.Name = "pnlLowStocks";
            this.pnlLowStocks.Size = new System.Drawing.Size(653, 200);
            this.pnlLowStocks.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.pbHideShow);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(653, 40);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Low Stock Books";
            // 
            // pbHideShow
            // 
            this.pbHideShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHideShow.Image = global::Library_Management_System.Properties.Resources.up_arrow;
            this.pbHideShow.Location = new System.Drawing.Point(623, 5);
            this.pbHideShow.Name = "pbHideShow";
            this.pbHideShow.Size = new System.Drawing.Size(25, 25);
            this.pbHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHideShow.TabIndex = 1;
            this.pbHideShow.TabStop = false;
            this.pbHideShow.Click += new System.EventHandler(this.pbHideShow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 266);
            this.panel1.TabIndex = 4;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.AutoScroll = true;
            this.pnlGrid.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlGrid.Controls.Add(this.dgvBook);
            this.pnlGrid.Controls.Add(this.panel3);
            this.pnlGrid.Location = new System.Drawing.Point(8, 11);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(653, 245);
            this.pnlGrid.TabIndex = 0;
            // 
            // dgvLowStocks
            // 
            this.dgvLowStocks.AllowUserToAddRows = false;
            this.dgvLowStocks.AllowUserToDeleteRows = false;
            this.dgvLowStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLowStocks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLowStocks.ColumnHeadersHeight = 50;
            this.dgvLowStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLowStocks.Location = new System.Drawing.Point(6, 44);
            this.dgvLowStocks.Name = "dgvLowStocks";
            this.dgvLowStocks.ReadOnly = true;
            this.dgvLowStocks.RowHeadersVisible = false;
            this.dgvLowStocks.RowHeadersWidth = 40;
            this.dgvLowStocks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLowStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStocks.Size = new System.Drawing.Size(640, 151);
            this.dgvLowStocks.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbSearchGenre);
            this.panel3.Controls.Add(this.tbSearchISBN);
            this.panel3.Controls.Add(this.cbSearchAuthor);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Controls.Add(this.tbSearchTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 80);
            this.panel3.TabIndex = 0;
            // 
            // tbSearchTitle
            // 
            this.tbSearchTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearchTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchTitle.Location = new System.Drawing.Point(13, 35);
            this.tbSearchTitle.Name = "tbSearchTitle";
            this.tbSearchTitle.Size = new System.Drawing.Size(120, 25);
            this.tbSearchTitle.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(546, 20);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 40);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // cbSearchAuthor
            // 
            this.cbSearchAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSearchAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbSearchAuthor.FormattingEnabled = true;
            this.cbSearchAuthor.Location = new System.Drawing.Point(149, 35);
            this.cbSearchAuthor.Name = "cbSearchAuthor";
            this.cbSearchAuthor.Size = new System.Drawing.Size(120, 25);
            this.cbSearchAuthor.TabIndex = 3;
            // 
            // cbSearchGenre
            // 
            this.cbSearchGenre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSearchGenre.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbSearchGenre.FormattingEnabled = true;
            this.cbSearchGenre.Location = new System.Drawing.Point(420, 35);
            this.cbSearchGenre.Name = "cbSearchGenre";
            this.cbSearchGenre.Size = new System.Drawing.Size(120, 25);
            this.cbSearchGenre.TabIndex = 4;
            // 
            // tbSearchISBN
            // 
            this.tbSearchISBN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearchISBN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchISBN.Location = new System.Drawing.Point(285, 35);
            this.tbSearchISBN.Name = "tbSearchISBN";
            this.tbSearchISBN.Size = new System.Drawing.Size(120, 25);
            this.tbSearchISBN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "ISBN:";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBook.ColumnHeadersHeight = 50;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBook.Location = new System.Drawing.Point(6, 86);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.RowHeadersWidth = 40;
            this.dgvBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(640, 152);
            this.dgvBook.TabIndex = 2;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLowStocksContainer);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(684, 561);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.pnlLowStocksContainer.ResumeLayout(false);
            this.pnlLowStocks.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideShow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStocks)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel pnlLowStocksContainer;
        private System.Windows.Forms.Panel pnlLowStocks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbHideShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvLowStocks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox tbSearchTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSearchAuthor;
        private System.Windows.Forms.TextBox tbSearchISBN;
        private System.Windows.Forms.ComboBox cbSearchGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBook;
    }
}