using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace PROJECT_UAS
{
    public partial class FRM_PENJUALAN : Form
    {
        OracleConnection con = new OracleConnection("Data Source=XE;User Id=KARYA;Password=123_Qwerty");
        OracleCommand cmd;
        OracleDataReader rd;

        public FRM_PENJUALAN()
        {
            InitializeComponent();
            DisplayData();
            Otomatis();
            DisplayDataBar();
            DisplayDataPel();
            Total_terbilang();
        }

        private void CleanText()
        {
            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            txtStock.Text = "";
            txtHarga.Text = "0";
            txtSubTotal.Text = "0";
            txtKet.Text = "";
            txtJumlahBeli.Text = "0";
        }

        private void CleanAll()
        {
            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            txtStock.Text = "";
            txtHarga.Text = "0";
            txtKode.Text = "";
            txtAlamat.Text = "";
            txtTelepon.Text = "";
            txtNama.Text = "";
            txtSubTotal.Text = "0";
            txtKet.Text = "";
            txtJumlahBeli.Text = "0";
        }

        private void Total_terbilang()
        {
                con.Close();
                cmd = new OracleCommand("select sub_total from tbl_penjualan_alie where no_penjualan = '" + txtNoOrder.Text + "'", con);
                OracleDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();
                int count = 0;
                while (dbr.Read())
                {
                    count += 1;
                }
                if (count != 0)
                {
                    txtTotal.Text = Total("sub_total", "tbl_penjualan_alie").Rows[0][0].ToString();
                    lblTerbilang.Text = Terbilang(int.Parse(txtTotal.Text)) + "rupiah";
                    lblTerbilang.Text = lblTerbilang.Text.Replace("  "," ");
                }
                else
                {
                    txtTotal.Text = "0";
                    lblTerbilang.Text = "nol rupiah";
                }
                con.Close();
        }

        private void Otomatis()
        {
            long hitung;
            string urut;

            con.Close();
            con.Open();
            cmd = new OracleCommand("select no_penjualan from tbl_penjualan_alie_detail where no_penjualan in(select max(no_penjualan) from tbl_penjualan_alie_detail) order by no_penjualan desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["no_penjualan"].ToString().Length - 4, 4)) + 1;

                string joinstr = "0000" + hitung;



                urut = "PJL" + joinstr.Substring(joinstr.Length - 4, 4);

            }
            else
            {
                urut = "PJL0001";
            }
            rd.Close();
            txtNoOrder.Text = urut;
            con.Close();
        }

        public static string Terbilang(int x)
        {
            string[] bilangan = { "", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas" };
            string temp = "";

            if (x < 12)
            {
                temp = " " + bilangan[x];
            }
            else if (x < 20)
            {
                temp = Terbilang(x - 10).ToString() + " belas";
            }
            else if (x < 100)
            {
                temp = Terbilang(x / 10) + " puluh" + Terbilang(x % 10);
            }
            else if (x < 200)
            {
                temp = " seratus" + Terbilang(x - 100);
            }
            else if (x < 1000)
            {
                temp = Terbilang(x / 100) + " ratus" + Terbilang(x % 100);
            }
            else if (x < 2000)
            {
                temp = " seribu" + Terbilang(x - 1000);
            }
            else if (x < 1000000)
            {
                temp = Terbilang(x / 1000) + " ribu" + Terbilang(x % 1000);
            }
            else if (x < 1000000000)
            {
                temp = Terbilang(x / 1000000) + " juta" + Terbilang(x % 1000000);
            }

            return temp;
        }


        private void DisplayData()
        {
            try
            {
                con.Close();
                con.Open();
                cmd = new OracleCommand("select * from tbl_penjualan_alie order by no_penjualan ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Nomor Penjualan";
                dataGridView1.Columns[1].HeaderText = "Tanggal Penjualan";
                dataGridView1.Columns[2].HeaderText = "Kode Pelanggan";
                dataGridView1.Columns[3].HeaderText = "Kode Barang";
                dataGridView1.Columns[4].HeaderText = "Jumlah Beli";
                dataGridView1.Columns[5].HeaderText = "Sub Total";
                dataGridView1.Columns[6].HeaderText = "Keterangan";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayDataPel()
        {
            try
            {
                con.Close();
                con.Open();
                cmd = new OracleCommand("select * from tbl_pelanggan where kode_pelanggan like 'PLGA%' order by kode_pelanggan ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rd);
                dGPel.DataSource = dataTable;
                dGPel.Columns[0].HeaderText = "Kode Pelanggan";
                dGPel.Columns[1].HeaderText = "Nama Pelanggan";
                dGPel.Columns[2].HeaderText = "Nomor Telepon";
                dGPel.Columns[3].HeaderText = "Alamat";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayDataBar()
        {
            try
            {
                con.Close();
                con.Open();
                cmd = new OracleCommand("select kode_barang, nama_barang, harga, stock from tbl_barang where kemasan is NULL order by kode_barang ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rd);
                dGBar.DataSource = dataTable;
                dGBar.Columns[0].HeaderText = "Kode Barang";
                dGBar.Columns[1].HeaderText = "Nama Barang";
                dGBar.Columns[1].Width = 400;
                dGBar.Columns[2].HeaderText = "Harga";
                dGBar.Columns[3].HeaderText = "Stock";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CariDataBar()
        {
            try
            {
                con.Close();
                con.Open();
                DataTable dt = new DataTable();
                cmd = new OracleCommand("select kode_barang, nama_barang, harga, stock from tbl_barang where kode_barang like 'BRGA%' and (kode_barang LIKE '%" + txtCari.Text + "%' OR nama_barang LIKE '%" + txtCari.Text + "%')", con);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                dGBar.DataSource = dt;
                dGBar.Columns[0].HeaderText = "Kode Barang";
                dGBar.Columns[1].HeaderText = "Nama Barang";
                dGBar.Columns[1].Width = 400;
                dGBar.Columns[2].HeaderText = "Harga";
                dGBar.Columns[3].HeaderText = "Stock";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CariDataPel()
        {
            try
            {
                con.Close();
                con.Open();
                DataTable dt = new DataTable();
                cmd = new OracleCommand("select * from tbl_pelanggan where kode_pelanggan like 'PLGA%' and (kode_pelanggan LIKE '%" + txtCariPel.Text + "%' OR nama_pelanggan LIKE '%" + txtCariPel.Text + "%')", con);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                dGPel.DataSource = dt;
                dGPel.Columns[0].HeaderText = "Kode Pelanggan";
                dGPel.Columns[1].HeaderText = "Nama Pelanggan";
                dGPel.Columns[2].HeaderText = "Nomor Telepon";
                dGPel.Columns[3].HeaderText = "Alamat";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataTable Edit(string field, string tabel, string kriteria, string syarat)
        {
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            cmd = new OracleCommand("select " + field + " from " + tabel + " where " + kriteria + " = '" + syarat + "'", con);
            rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }

        private DataTable Total(string field, string tabel)
        {
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            cmd = new OracleCommand("select sum(" + field + ") from " + tabel, con);
            rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }

        private void btPilihPelanggan_Click(object sender, EventArgs e)
        {
            if (pnPelanggan.Visible == false)
            {
                pnPelanggan.Visible = true;
                pnPelanggan.BringToFront();
                DisplayDataPel();
            }
            else
            {
                pnPelanggan.Visible = false;
            }
        }

        private void btPilihBarang_Click(object sender, EventArgs e)
        {
            if (pnBarang.Visible == false)
            {
                pnBarang.Visible = true;
                DisplayDataBar();
                pnBarang.BringToFront();
            }
            else
            {
                pnBarang.Visible = false;
            }
        }

        private void dGBar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKodeBarang.Text = dGBar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNamaBarang.Text = dGBar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHarga.Text = dGBar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStock.Text = dGBar.Rows[e.RowIndex].Cells[3].Value.ToString();
            pnBarang.Visible = false;
        }

        private void btTambah_Click(object sender, EventArgs e)
        {
            if (txtKode.Text != "" && txtKodeBarang.Text != "" && txtNoOrder.Text != "" && txtJumlahBeli.Text != "" && txtKet.Text != "" && txtSubTotal.Text != "" && int.Parse(txtJumlahBeli.Text)>0)
            {
                con.Close();
                cmd = new OracleCommand("select no_penjualan, kode_pelanggan, kode_barang from tbl_penjualan_alie where no_penjualan = '" + txtNoOrder.Text + "' and kode_pelanggan = '" + txtKode.Text + "' and kode_barang = '" + txtKodeBarang.Text + "'", con);
                OracleDataReader dbr;
                con.Open();
                dbr = cmd.ExecuteReader();
                int count = 0;
                while (dbr.Read())
                {
                    count += 1;
                }
                if (count == 0)
                {
                    if (int.Parse(txtJumlahBeli.Text) < int.Parse(txtStock.Text))
                    {
                        con.Close();
                        cmd = new OracleCommand("insert into tbl_penjualan_alie(no_penjualan, tgl_penjualan, kode_pelanggan, kode_barang, jumlah_beli, sub_total, keterangan) values(:no_penjualan, :tgl_penjualan, :kode_pelanggan, :kode_barang, :jumlah_beli, :sub_total, :keterangan)", con);
                        con.Open();
                        cmd.Parameters.Add(new OracleParameter(":no_penjualan", txtNoOrder.Text));
                        cmd.Parameters.Add(new OracleParameter(":tgl_penjualan", DateTime.Parse(dateTimePicker1.Value.Date.ToString())));
                        cmd.Parameters.Add(new OracleParameter(":kode_pelanggan", txtKode.Text));
                        cmd.Parameters.Add(new OracleParameter(":kode_barang", txtKodeBarang.Text));
                        cmd.Parameters.Add(new OracleParameter(":jumlah_beli", txtJumlahBeli.Text));
                        cmd.Parameters.Add(new OracleParameter(":sub_total", txtSubTotal.Text));
                        cmd.Parameters.Add(new OracleParameter(":keterangan", txtKet.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();

                        String stock_akhir = (int.Parse(txtStock.Text) - int.Parse(txtJumlahBeli.Text)).ToString();
                        cmd = new OracleCommand("update tbl_barang set stock=" + stock_akhir + " where kode_barang=+'" + txtKodeBarang.Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        Total_terbilang();
                        MessageBox.Show("Data berhasil disimpan", "Berhasil");
                        DisplayData();
                        CleanText();
                    }
                    else
                    {
                        MessageBox.Show("Stock harus lebih besar dari jumlah beli", "Gagal");
                    }
                }
                else
                {
                    MessageBox.Show("Transaksi sudah ada", "Gagal");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Gagal simpan", "Gagal");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNoOrder.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //dateTimePicker1.Value = new DateTime(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Substring(6, 4)), int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Substring(3, 2)), int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Substring(0, 2)));
            txtKode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtKodeBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNama.Text = Edit("nama_pelanggan", "tbl_pelanggan", "kode_pelanggan", txtKode.Text).Rows[0][0].ToString();
            txtTelepon.Text = Edit("no_telp", "tbl_pelanggan", "kode_pelanggan", txtKode.Text).Rows[0][0].ToString();
            txtAlamat.Text = Edit("alamat", "tbl_pelanggan", "kode_pelanggan", txtKode.Text).Rows[0][0].ToString();
            txtNamaBarang.Text = Edit("nama_barang", "tbl_barang", "kode_barang", txtKodeBarang.Text).Rows[0][0].ToString();
            txtHarga.Text = Edit("harga", "tbl_barang", "kode_barang", txtKodeBarang.Text).Rows[0][0].ToString();
            txtStock.Text = Edit("stock", "tbl_barang", "kode_barang", txtKodeBarang.Text).Rows[0][0].ToString();
            txtJumlahBeli.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSubTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtKet.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            if (txtNamaBarang.Text != "")
            {
                con.Close();
                cmd = new OracleCommand("delete tbl_penjualan_alie where no_penjualan=:no_penjualan AND kode_pelanggan=:kode_pelanggan AND kode_barang=:kode_barang", con);
                con.Open();
                cmd.Parameters.Add(new OracleParameter(":no_penjualan", txtNoOrder.Text));
                cmd.Parameters.Add(new OracleParameter(":kode_pelanggan", txtKode.Text));
                cmd.Parameters.Add(new OracleParameter(":kode_barang", txtKodeBarang.Text));
                cmd.ExecuteNonQuery();
                con.Close();

                String stock_akhir = (int.Parse(txtJumlahBeli.Text) + int.Parse(txtStock.Text)).ToString();
                cmd = new OracleCommand("update tbl_barang set stock=" + stock_akhir + " where kode_barang=+'" + txtKodeBarang.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Berhasil hapus", "Berhasil");
                DisplayData();
                CleanText();
                Total_terbilang();
            }
            else
            {
                MessageBox.Show("Gagal hapus", "Gagal");
            }
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (txtNoOrder.Text != "")
            {
                con.Close();
                cmd = new OracleCommand("insert into tbl_penjualan_alie_detail(no_penjualan, tgl_penjualan, kode_pelanggan, kode_barang, jumlah_beli, sub_total, keterangan) select no_penjualan, tgl_penjualan, kode_pelanggan, kode_barang, jumlah_beli, sub_total, keterangan from tbl_penjualan_alie ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd = new OracleCommand("delete tbl_penjualan_alie where no_penjualan=:no_penjualan", con);
                cmd.Parameters.Add(new OracleParameter(":no_penjualan", txtNoOrder.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Transaksi tersimpan", "Berhasil");
                txtTotal.Text = Total("sub_total", "tbl_penjualan_alie").Rows[0][0].ToString();
                DisplayData();
                CleanAll();
                Otomatis();
                Total_terbilang();
            }
            else
            {
                MessageBox.Show("Transaksi gagal tersimpan","Gagal");
            }
        }

        private void btBaru_Click(object sender, EventArgs e)
        {
            Otomatis();
            CleanAll();
        }

        private void txtJumlahBeli_TextChanged(object sender, EventArgs e)
        {
            if (txtJumlahBeli.Text != "") txtSubTotal.Text = (int.Parse(txtHarga.Text) * int.Parse(txtJumlahBeli.Text)).ToString();
            else txtSubTotal.Text = "0";
        }

        private void txtJumlahBeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void dGPel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKode.Text = dGPel.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNama.Text = dGPel.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelepon.Text = dGPel.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAlamat.Text = dGPel.Rows[e.RowIndex].Cells[3].Value.ToString();
            pnPelanggan.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtCariPel.Text == "")
            {
                DisplayDataPel();
            }
            else
            {
                CariDataPel();
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (txtCari.Text == "")
            {
                DisplayDataBar();
            }
            else
            {
                CariDataBar();
            }
        }

        
    }
}
