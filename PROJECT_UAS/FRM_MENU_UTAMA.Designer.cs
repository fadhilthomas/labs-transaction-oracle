namespace PROJECT_UAS
{
    partial class FRM_MENU_UTAMA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MENU_UTAMA));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualanBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penerimaanBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartuStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cetakFakturPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bantuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bantuanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbJam = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikasiToolStripMenuItem,
            this.dataMemberToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.bantuanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikasiToolStripMenuItem
            // 
            this.aplikasiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.ubahPasswordToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.aplikasiToolStripMenuItem.Name = "aplikasiToolStripMenuItem";
            this.aplikasiToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.aplikasiToolStripMenuItem.Text = "Aplikasi";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // ubahPasswordToolStripMenuItem
            // 
            this.ubahPasswordToolStripMenuItem.Name = "ubahPasswordToolStripMenuItem";
            this.ubahPasswordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.ubahPasswordToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.ubahPasswordToolStripMenuItem.Text = "Ubah Password";
            this.ubahPasswordToolStripMenuItem.Click += new System.EventHandler(this.ubahPasswordToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataMemberToolStripMenuItem
            // 
            this.dataMemberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBarangToolStripMenuItem,
            this.dataPelangganToolStripMenuItem,
            this.dataKaryawanToolStripMenuItem});
            this.dataMemberToolStripMenuItem.Name = "dataMemberToolStripMenuItem";
            this.dataMemberToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.dataMemberToolStripMenuItem.Text = "Data Master";
            // 
            // dataBarangToolStripMenuItem
            // 
            this.dataBarangToolStripMenuItem.Name = "dataBarangToolStripMenuItem";
            this.dataBarangToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.dataBarangToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.dataBarangToolStripMenuItem.Text = "Data Barang";
            this.dataBarangToolStripMenuItem.Click += new System.EventHandler(this.dataBarangToolStripMenuItem_Click);
            // 
            // dataPelangganToolStripMenuItem
            // 
            this.dataPelangganToolStripMenuItem.Name = "dataPelangganToolStripMenuItem";
            this.dataPelangganToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.dataPelangganToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.dataPelangganToolStripMenuItem.Text = "Data Pelanggan";
            this.dataPelangganToolStripMenuItem.Click += new System.EventHandler(this.dataPelangganToolStripMenuItem_Click);
            // 
            // dataKaryawanToolStripMenuItem
            // 
            this.dataKaryawanToolStripMenuItem.Name = "dataKaryawanToolStripMenuItem";
            this.dataKaryawanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.dataKaryawanToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.dataKaryawanToolStripMenuItem.Text = "Data Karyawan";
            this.dataKaryawanToolStripMenuItem.Click += new System.EventHandler(this.dataKaryawanToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penjualanBarangToolStripMenuItem,
            this.penerimaanBarangToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // penjualanBarangToolStripMenuItem
            // 
            this.penjualanBarangToolStripMenuItem.Name = "penjualanBarangToolStripMenuItem";
            this.penjualanBarangToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.penjualanBarangToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.penjualanBarangToolStripMenuItem.Text = "Penjualan Barang";
            this.penjualanBarangToolStripMenuItem.Click += new System.EventHandler(this.penjualanBarangToolStripMenuItem_Click);
            // 
            // penerimaanBarangToolStripMenuItem
            // 
            this.penerimaanBarangToolStripMenuItem.Name = "penerimaanBarangToolStripMenuItem";
            this.penerimaanBarangToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.penerimaanBarangToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.penerimaanBarangToolStripMenuItem.Text = "Penerimaan Barang";
            this.penerimaanBarangToolStripMenuItem.Click += new System.EventHandler(this.penerimaanBarangToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kartuStockToolStripMenuItem,
            this.laporanPenjualanToolStripMenuItem,
            this.cetakFakturPenjualanToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.laporanToolStripMenuItem.Text = "Laporan";
            this.laporanToolStripMenuItem.Visible = false;
            // 
            // kartuStockToolStripMenuItem
            // 
            this.kartuStockToolStripMenuItem.Name = "kartuStockToolStripMenuItem";
            this.kartuStockToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.kartuStockToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.kartuStockToolStripMenuItem.Text = "Kartu Stock";
            // 
            // laporanPenjualanToolStripMenuItem
            // 
            this.laporanPenjualanToolStripMenuItem.Name = "laporanPenjualanToolStripMenuItem";
            this.laporanPenjualanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.laporanPenjualanToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.laporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan";
            // 
            // cetakFakturPenjualanToolStripMenuItem
            // 
            this.cetakFakturPenjualanToolStripMenuItem.Name = "cetakFakturPenjualanToolStripMenuItem";
            this.cetakFakturPenjualanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.cetakFakturPenjualanToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.cetakFakturPenjualanToolStripMenuItem.Text = "Cetak Faktur Penjualan";
            // 
            // bantuanToolStripMenuItem
            // 
            this.bantuanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bantuanToolStripMenuItem1});
            this.bantuanToolStripMenuItem.Name = "bantuanToolStripMenuItem";
            this.bantuanToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.bantuanToolStripMenuItem.Text = "Bantuan";
            this.bantuanToolStripMenuItem.Visible = false;
            // 
            // bantuanToolStripMenuItem1
            // 
            this.bantuanToolStripMenuItem1.Name = "bantuanToolStripMenuItem1";
            this.bantuanToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.bantuanToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.bantuanToolStripMenuItem1.Text = "Bantuan";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbJam});
            this.statusStrip1.Location = new System.Drawing.Point(0, 599);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(660, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbJam
            // 
            this.lbJam.BackColor = System.Drawing.Color.White;
            this.lbJam.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJam.Name = "lbJam";
            this.lbJam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbJam.Size = new System.Drawing.Size(146, 19);
            this.lbJam.Text = "toolStripStatusLabel2";
            this.lbJam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_MENU_UTAMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(660, 623);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FRM_MENU_UTAMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartuStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bantuanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cetakFakturPenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bantuanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem penjualanBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubahPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKaryawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penerimaanBarangToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbJam;
        private System.Windows.Forms.Timer timer1;
    }
}