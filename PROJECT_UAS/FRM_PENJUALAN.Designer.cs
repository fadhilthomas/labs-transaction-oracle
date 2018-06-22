namespace PROJECT_UAS
{
    partial class FRM_PENJUALAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PENJUALAN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoOrder = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btPilihPelanggan = new System.Windows.Forms.Button();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btPilihBarang = new System.Windows.Forms.Button();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btHapus = new System.Windows.Forms.Button();
            this.btTambah = new System.Windows.Forms.Button();
            this.txtKet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtJumlahBeli = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnPelanggan = new System.Windows.Forms.Panel();
            this.dGPel = new System.Windows.Forms.DataGridView();
            this.txtCariPel = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pnBarang = new System.Windows.Forms.Panel();
            this.dGBar = new System.Windows.Forms.DataGridView();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTerbilang = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btBaru = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnPelanggan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGPel)).BeginInit();
            this.pnBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGBar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Penjualan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal";
            // 
            // txtNoOrder
            // 
            this.txtNoOrder.Enabled = false;
            this.txtNoOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOrder.Location = new System.Drawing.Point(117, 17);
            this.txtNoOrder.Name = "txtNoOrder";
            this.txtNoOrder.Size = new System.Drawing.Size(178, 27);
            this.txtNoOrder.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAlamat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTelepon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btPilihPelanggan);
            this.groupBox1.Controls.Add(this.txtKode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 227);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilih Data Pelanggan";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Enabled = false;
            this.txtAlamat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(125, 137);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(235, 75);
            this.txtAlamat.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alamat";
            // 
            // txtTelepon
            // 
            this.txtTelepon.Enabled = false;
            this.txtTelepon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelepon.Location = new System.Drawing.Point(125, 103);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(235, 27);
            this.txtTelepon.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "No Telepon";
            // 
            // txtNama
            // 
            this.txtNama.Enabled = false;
            this.txtNama.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(125, 69);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(235, 27);
            this.txtNama.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nama Pelanggan";
            // 
            // btPilihPelanggan
            // 
            this.btPilihPelanggan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPilihPelanggan.ForeColor = System.Drawing.Color.Black;
            this.btPilihPelanggan.Location = new System.Drawing.Point(291, 27);
            this.btPilihPelanggan.Name = "btPilihPelanggan";
            this.btPilihPelanggan.Size = new System.Drawing.Size(69, 27);
            this.btPilihPelanggan.TabIndex = 5;
            this.btPilihPelanggan.Text = "Pilih";
            this.btPilihPelanggan.UseVisualStyleBackColor = true;
            this.btPilihPelanggan.Click += new System.EventHandler(this.btPilihPelanggan_Click);
            // 
            // txtKode
            // 
            this.txtKode.Enabled = false;
            this.txtKode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKode.Location = new System.Drawing.Point(125, 27);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(158, 27);
            this.txtKode.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kode Pelanggan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHarga);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtStock);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNamaBarang);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btPilihBarang);
            this.groupBox2.Controls.Add(this.txtKodeBarang);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(391, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 165);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilih Data Barang";
            // 
            // txtHarga
            // 
            this.txtHarga.Enabled = false;
            this.txtHarga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(112, 125);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(249, 27);
            this.txtHarga.TabIndex = 13;
            this.txtHarga.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "Harga        Rp.";
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(112, 92);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(105, 27);
            this.txtStock.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stock";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Enabled = false;
            this.txtNamaBarang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaBarang.Location = new System.Drawing.Point(112, 59);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(249, 27);
            this.txtNamaBarang.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nama Barang";
            // 
            // btPilihBarang
            // 
            this.btPilihBarang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPilihBarang.ForeColor = System.Drawing.Color.Black;
            this.btPilihBarang.Location = new System.Drawing.Point(292, 25);
            this.btPilihBarang.Name = "btPilihBarang";
            this.btPilihBarang.Size = new System.Drawing.Size(69, 27);
            this.btPilihBarang.TabIndex = 5;
            this.btPilihBarang.Text = "Pilih";
            this.btPilihBarang.UseVisualStyleBackColor = true;
            this.btPilihBarang.Click += new System.EventHandler(this.btPilihBarang_Click);
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Enabled = false;
            this.txtKodeBarang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeBarang.Location = new System.Drawing.Point(112, 25);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(174, 27);
            this.txtKodeBarang.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Kode Barang";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btHapus);
            this.groupBox3.Controls.Add(this.btTambah);
            this.groupBox3.Controls.Add(this.txtKet);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtSubTotal);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtJumlahBeli);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(391, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 139);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Penjualan";
            // 
            // btHapus
            // 
            this.btHapus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHapus.ForeColor = System.Drawing.Color.Black;
            this.btHapus.Location = new System.Drawing.Point(285, 90);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(76, 36);
            this.btHapus.TabIndex = 13;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btTambah
            // 
            this.btTambah.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTambah.ForeColor = System.Drawing.Color.Black;
            this.btTambah.Location = new System.Drawing.Point(203, 90);
            this.btTambah.Name = "btTambah";
            this.btTambah.Size = new System.Drawing.Size(76, 36);
            this.btTambah.TabIndex = 12;
            this.btTambah.Text = "Tambah";
            this.btTambah.UseVisualStyleBackColor = true;
            this.btTambah.Click += new System.EventHandler(this.btTambah_Click);
            // 
            // txtKet
            // 
            this.txtKet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKet.Location = new System.Drawing.Point(229, 57);
            this.txtKet.Name = "txtKet";
            this.txtKet.Size = new System.Drawing.Size(133, 27);
            this.txtKet.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(134, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "Keterangan";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(228, 25);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(133, 27);
            this.txtSubTotal.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(133, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Sub Total  Rp.";
            // 
            // txtJumlahBeli
            // 
            this.txtJumlahBeli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahBeli.Location = new System.Drawing.Point(10, 54);
            this.txtJumlahBeli.Name = "txtJumlahBeli";
            this.txtJumlahBeli.Size = new System.Drawing.Size(118, 27);
            this.txtJumlahBeli.TabIndex = 4;
            this.txtJumlahBeli.TextChanged += new System.EventHandler(this.txtJumlahBeli_TextChanged);
            this.txtJumlahBeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahBeli_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 19);
            this.label16.TabIndex = 3;
            this.label16.Text = "Jumlah Penjualan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(750, 145);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pnPelanggan
            // 
            this.pnPelanggan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPelanggan.Controls.Add(this.dGPel);
            this.pnPelanggan.Controls.Add(this.txtCariPel);
            this.pnPelanggan.Controls.Add(this.label18);
            this.pnPelanggan.ForeColor = System.Drawing.Color.Black;
            this.pnPelanggan.Location = new System.Drawing.Point(10, 152);
            this.pnPelanggan.Name = "pnPelanggan";
            this.pnPelanggan.Size = new System.Drawing.Size(370, 310);
            this.pnPelanggan.TabIndex = 29;
            this.pnPelanggan.Visible = false;
            // 
            // dGPel
            // 
            this.dGPel.AllowUserToAddRows = false;
            this.dGPel.AllowUserToDeleteRows = false;
            this.dGPel.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGPel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGPel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGPel.Location = new System.Drawing.Point(9, 60);
            this.dGPel.Name = "dGPel";
            this.dGPel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGPel.Size = new System.Drawing.Size(348, 240);
            this.dGPel.TabIndex = 8;
            this.dGPel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGPel_CellDoubleClick);
            // 
            // txtCariPel
            // 
            this.txtCariPel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariPel.Location = new System.Drawing.Point(9, 29);
            this.txtCariPel.Name = "txtCariPel";
            this.txtCariPel.Size = new System.Drawing.Size(348, 26);
            this.txtCariPel.TabIndex = 7;
            this.txtCariPel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(6, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 19);
            this.label18.TabIndex = 6;
            this.label18.Text = "Cari Pelanggan Penjualan";
            // 
            // pnBarang
            // 
            this.pnBarang.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBarang.Controls.Add(this.dGBar);
            this.pnBarang.Controls.Add(this.txtCari);
            this.pnBarang.Controls.Add(this.label17);
            this.pnBarang.ForeColor = System.Drawing.Color.Black;
            this.pnBarang.Location = new System.Drawing.Point(394, 66);
            this.pnBarang.Name = "pnBarang";
            this.pnBarang.Size = new System.Drawing.Size(363, 290);
            this.pnBarang.TabIndex = 31;
            this.pnBarang.Visible = false;
            // 
            // dGBar
            // 
            this.dGBar.AllowUserToAddRows = false;
            this.dGBar.AllowUserToDeleteRows = false;
            this.dGBar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGBar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGBar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGBar.Location = new System.Drawing.Point(10, 59);
            this.dGBar.Name = "dGBar";
            this.dGBar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGBar.Size = new System.Drawing.Size(345, 218);
            this.dGBar.TabIndex = 5;
            this.dGBar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGBar_CellDoubleClick);
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.Location = new System.Drawing.Point(10, 28);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(345, 26);
            this.txtCari.TabIndex = 4;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(8, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 19);
            this.label17.TabIndex = 3;
            this.label17.Text = "Cari Barang Penjualan";
            // 
            // lblTerbilang
            // 
            this.lblTerbilang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTerbilang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTerbilang.Enabled = false;
            this.lblTerbilang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerbilang.Location = new System.Drawing.Point(242, 547);
            this.lblTerbilang.Multiline = true;
            this.lblTerbilang.Name = "lblTerbilang";
            this.lblTerbilang.ReadOnly = true;
            this.lblTerbilang.Size = new System.Drawing.Size(522, 60);
            this.lblTerbilang.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(202, 513);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 23);
            this.label15.TabIndex = 57;
            this.label15.Text = "Rp.";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(242, 510);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(296, 31);
            this.txtTotal.TabIndex = 56;
            this.txtTotal.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(202, 476);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 23);
            this.label14.TabIndex = 55;
            this.label14.Text = "Total Penjualan";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btBaru);
            this.groupBox4.Controls.Add(this.btSimpan);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(12, 476);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 131);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proses";
            // 
            // btBaru
            // 
            this.btBaru.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaru.ForeColor = System.Drawing.Color.Black;
            this.btBaru.Location = new System.Drawing.Point(10, 43);
            this.btBaru.Name = "btBaru";
            this.btBaru.Size = new System.Drawing.Size(76, 57);
            this.btBaru.TabIndex = 6;
            this.btBaru.Text = "Baru";
            this.btBaru.UseVisualStyleBackColor = true;
            this.btBaru.Click += new System.EventHandler(this.btBaru_Click);
            // 
            // btSimpan
            // 
            this.btSimpan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimpan.ForeColor = System.Drawing.Color.Black;
            this.btSimpan.Location = new System.Drawing.Point(92, 43);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(76, 57);
            this.btSimpan.TabIndex = 5;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // FRM_PENJUALAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(774, 616);
            this.Controls.Add(this.lblTerbilang);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnBarang);
            this.Controls.Add(this.pnPelanggan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNoOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_PENJUALAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Penjualan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnPelanggan.ResumeLayout(false);
            this.pnPelanggan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGPel)).EndInit();
            this.pnBarang.ResumeLayout(false);
            this.pnBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGBar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btPilihPelanggan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btPilihBarang;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtKet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtJumlahBeli;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btTambah;
        public System.Windows.Forms.TextBox txtAlamat;
        public System.Windows.Forms.TextBox txtTelepon;
        public System.Windows.Forms.TextBox txtNama;
        public System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Panel pnPelanggan;
        private System.Windows.Forms.DataGridView dGPel;
        private System.Windows.Forms.TextBox txtCariPel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnBarang;
        private System.Windows.Forms.DataGridView dGBar;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox lblTerbilang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btBaru;
        private System.Windows.Forms.Button btSimpan;
    }
}