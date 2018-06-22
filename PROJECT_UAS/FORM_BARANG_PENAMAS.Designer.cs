namespace PROJECT_UAS
{
    partial class FORM_BARANG_PENAMAS
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
            this.txt_kemasan = new System.Windows.Forms.TextBox();
            this.btHapus = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btBaru = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Kemasan = new System.Windows.Forms.Label();
            this.txt_nama_barang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kode_barang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_kemasan
            // 
            this.txt_kemasan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kemasan.Location = new System.Drawing.Point(139, 103);
            this.txt_kemasan.Name = "txt_kemasan";
            this.txt_kemasan.Size = new System.Drawing.Size(258, 27);
            this.txt_kemasan.TabIndex = 41;
            // 
            // btHapus
            // 
            this.btHapus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHapus.Location = new System.Drawing.Point(373, 266);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(89, 44);
            this.btHapus.TabIndex = 52;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(273, 266);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(89, 44);
            this.btEdit.TabIndex = 51;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btSimpan
            // 
            this.btSimpan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimpan.Location = new System.Drawing.Point(173, 266);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(89, 44);
            this.btSimpan.TabIndex = 50;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btBaru
            // 
            this.btBaru.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaru.Location = new System.Drawing.Point(72, 266);
            this.btBaru.Name = "btBaru";
            this.btBaru.Size = new System.Drawing.Size(89, 44);
            this.btBaru.TabIndex = 49;
            this.btBaru.Text = "Baru";
            this.btBaru.UseVisualStyleBackColor = true;
            this.btBaru.Click += new System.EventHandler(this.btBaru_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(525, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 513);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cari);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(525, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 79);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian Berdasarkan Kode/ Nama Barang";
            // 
            // txt_cari
            // 
            this.txt_cari.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cari.Location = new System.Drawing.Point(11, 36);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(474, 27);
            this.txt_cari.TabIndex = 1;
            this.txt_cari.TextChanged += new System.EventHandler(this.txt_cari_TextChanged);
            // 
            // txt_stock
            // 
            this.txt_stock.Enabled = false;
            this.txt_stock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(139, 191);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(258, 27);
            this.txt_stock.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Stock";
            // 
            // txt_harga
            // 
            this.txt_harga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_harga.Location = new System.Drawing.Point(139, 146);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(258, 27);
            this.txt_harga.TabIndex = 42;
            this.txt_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_harga_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "Harga               Rp.";
            // 
            // Kemasan
            // 
            this.Kemasan.AutoSize = true;
            this.Kemasan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kemasan.Location = new System.Drawing.Point(15, 106);
            this.Kemasan.Name = "Kemasan";
            this.Kemasan.Size = new System.Drawing.Size(68, 19);
            this.Kemasan.TabIndex = 43;
            this.Kemasan.Text = "Kemasan";
            this.Kemasan.Click += new System.EventHandler(this.k_Click);
            // 
            // txt_nama_barang
            // 
            this.txt_nama_barang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama_barang.Location = new System.Drawing.Point(139, 62);
            this.txt_nama_barang.Name = "txt_nama_barang";
            this.txt_nama_barang.Size = new System.Drawing.Size(354, 27);
            this.txt_nama_barang.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nama Barang";
            // 
            // txt_kode_barang
            // 
            this.txt_kode_barang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kode_barang.Location = new System.Drawing.Point(139, 18);
            this.txt_kode_barang.Name = "txt_kode_barang";
            this.txt_kode_barang.Size = new System.Drawing.Size(258, 27);
            this.txt_kode_barang.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Kode Barang";
            // 
            // FORM_BARANG_PENAMAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1039, 631);
            this.Controls.Add(this.txt_kemasan);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.btBaru);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Kemasan);
            this.Controls.Add(this.txt_nama_barang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kode_barang);
            this.Controls.Add(this.label1);
            this.Name = "FORM_BARANG_PENAMAS";
            this.Text = "FORM_BARANG";
            this.Load += new System.EventHandler(this.FORM_BARANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kemasan;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btBaru;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Kemasan;
        private System.Windows.Forms.TextBox txt_nama_barang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kode_barang;
        private System.Windows.Forms.Label label1;
    }
}