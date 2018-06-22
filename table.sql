CREATE TABLE tbl_penjualan_alie_detail(
	no_penjualan varchar(15) NULL,
	tgl_penjualan date NULL,
	kode_pelanggan varchar(15) NULL,
	kode_barang varchar(15) NULL,
	jumlah_beli int NULL,
	sub_total float NULL,
	keterangan varchar(50) NULL
);

CREATE TABLE tbl_penjualan_alie(
	no_penjualan varchar(15) NOT NULL,
	tgl_penjualan date NULL,
	kode_pelanggan varchar(15) NOT NULL,
	kode_barang varchar(15) NOT NULL,
	jumlah_beli int NULL,
	sub_total float NULL,
	keterangan varchar(50) NULL,
 CONSTRAINT PK_tbl_penjualan_alie PRIMARY KEY  
(
	no_penjualan,
	kode_pelanggan,
	kode_barang 
));

CREATE TABLE tbl_penerimaan_detail(
	no_penerimaan varchar(15) NULL,
	tgl_penerimaan date NULL,
	kode_barang varchar(15) NULL,
	jumlah_terima int NULL,
	sub_total float NULL,
	keterangan varchar(50) NULL
);

CREATE TABLE tbl_penerimaan(
	no_penerimaan varchar(15) NOT NULL,
	tgl_penerimaan date NULL,
	kode_barang varchar(15) NOT NULL,
	jumlah_terima int NULL,
	sub_total float NULL,
	keterangan nchar(10) NULL,
 CONSTRAINT PK_tbl_penerimaan PRIMARY KEY  
(
	no_penerimaan,
	kode_barang 
));

CREATE TABLE tbl_penerimaan_penamas_detail(
	no_penerimaan varchar(15) NULL,
	tgl_penerimaan date NULL,
	kode_barang varchar(15) NULL,
	jumlah_terima int NULL,
	sub_total float NULL,
	keterangan varchar(50) NULL
);

CREATE TABLE tbl_penerimaan_penamas(
	no_penerimaan varchar(15) NOT NULL,
	tgl_penerimaan date NULL,
	kode_barang varchar(15) NOT NULL,
	jumlah_terima int NULL,
	sub_total float NULL,
	keterangan nchar(10) NULL,
 CONSTRAINT PK_tbl_penerimaan_penamas PRIMARY KEY  
(
	no_penerimaan,
	kode_barang 
));

CREATE TABLE tbl_pelanggan(
	kode_pelanggan varchar(15) NOT NULL,
	nama_pelanggan varchar(50) NULL,
	no_telp varchar(50) NULL,
	alamat varchar(100) NULL,
 CONSTRAINT PK_tbl_pelanggan PRIMARY KEY  
(
	kode_pelanggan 
));

CREATE TABLE tbl_karyawan(
	kode_karyawan varchar(15) NULL,
	nama_karyawan varchar(50) NULL,
	no_telp varchar(15) NULL,
	alamat_karyawan varchar(100) NULL,
	status varchar(50) NULL,
CONSTRAINT PK_tbl_karyawan PRIMARY KEY  
(
	kode_karyawan 
));


CREATE TABLE tbl_hak_akses(
	username varchar(50) NULL,
	password varchar(50) NULL,
	status varchar(50) NULL,
	perusahaan varchar(50) NULL
);

CREATE TABLE tbl_barang(
	kode_barang varchar(15) NOT NULL,
	nama_barang varchar(100) NULL,
	kemasan varchar(50) NULL,
	harga int NULL,
	stock int NULL,
 CONSTRAINT PK_tbl_barang PRIMARY KEY  
(
	kode_barang 
));

CREATE TABLE tbl_sales(
	kode_sales varchar(15) NOT NULL,
	nama_sales varchar(50) NULL,
	no_telp varchar(50) NULL,
	alamat varchar(100) NULL,
 CONSTRAINT PK_tbl_sales PRIMARY KEY  
(
	kode_sales 
));

CREATE TABLE tbl_penjualan_penamas_detail(
	kode_penjualan varchar(15) NULL,
	tgl_penjualan date NULL,
	kode_pelanggan varchar(15) NULL,
	kode_barang varchar(15) NULL,
	kode_sales varchar(15) NULL,
	tgl_order date NULL,
	tgl_jtempo date NULL,
	sub_total int NULL,
	discount int NULL,
	keterangan varchar(50) NULL,
	jumlah_beli int NULL
);

CREATE TABLE tbl_penjualan_penamas(
	kode_penjualan varchar(15) NOT NULL,
	tgl_penjualan date NULL,
	kode_pelanggan varchar(15) NOT NULL,
	kode_barang varchar(15) NOT NULL,
	kode_sales varchar(15) NOT NULL,
	tgl_order date NULL,
	tgl_jtempo date NULL,
	sub_total int NULL,
	discount int NULL,
	keterangan varchar(50) NULL,
	jumlah_beli int NULL,
 CONSTRAINT PK_tbl_penjualan_penamas PRIMARY KEY  
(
	kode_penjualan,
	kode_pelanggan,
	kode_barang,
	kode_sales 
));