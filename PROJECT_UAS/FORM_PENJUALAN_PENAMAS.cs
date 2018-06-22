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
    public partial class FORM_PENJUALAN_PENAMAS : Form
    {
        OracleConnection con = new OracleConnection("Data Source=XE;User Id=KARYA;Password=123_Qwerty");
        OracleCommand cmd;
        OracleDataReader rd;

        private void DisplayData()
        {
            try
            {
                con.Close();
                con.Open();
                cmd = new OracleCommand("select * from tbl_penjualan_penamas order by kode_penjualan ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayData1()
        {
            try
            {
                con.Close();
                con.Open();
                cmd = new OracleCommand("select * from tbl_barang where kemasan is not NULL order by kode_barang ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rd);
                dataGridView3.DataSource = dataTable;
                dataGridView3.Columns[0].HeaderText = "Kode Barang";
                dataGridView3.Columns[1].HeaderText = "Nama Barang";
                dataGridView3.Columns[1].Width = 400;
                dataGridView3.Columns[2].HeaderText = "Kemasan";
                dataGridView3.Columns[3].HeaderText = "Harga";
                dataGridView3.Columns[4].HeaderText = "Stock";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayData2()
        {
            try
            {
                con.Close();
                con.Open();
                cmd = new OracleCommand("select * from tbl_pelanggan where kode_pelanggan like 'PLGP%' order by kode_pelanggan ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rd);
                dataGridView2.DataSource = dataTable;
                dataGridView2.Columns[0].HeaderText = "Kode Pelanggan";
                dataGridView2.Columns[1].HeaderText = "Nama Pelanggan";
                dataGridView2.Columns[2].HeaderText = "Nomor Telepon";
                dataGridView2.Columns[3].HeaderText = "Alamat";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayData3()
        {
            try
            {
                con.Close();
                con.Open();
                cmd = new OracleCommand("select * from tbl_sales order by kode_sales ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rd);
                dataGridView4.DataSource = dataTable;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CleanText()
        {
            txt_kode_barang.Text = "";
            txt_nama_barang.Text = "";
            txt_satuan1.Text = "";
            txt_stock.Text = "";
            txt_harga.Text = "";
            txt_jumlah_keluar.Text = "";
            txt_keterangan.Text = "";
            txt_sub_total.Text = "";
        }

        private void CleanText1()
        {
            txt_kode_pelanggan1.Text = "";
            txt_nama_pelanggan.Text = "";
            txt_no_telp.Text = "";
            txt_alamat.Text = "";
            txt_kode_sales.Text = "";
            txt_kode_pelanggan1.Enabled = false;
        }

        private void CariDataBar()
        {
            try
            {
                con.Close();
                con.Open();
                DataTable dt = new DataTable();
                cmd = new OracleCommand("select * from tbl_barang where kode_barang like 'BRGP%' and (kode_barang LIKE '%" + txt_cari_bar.Text + "%' OR nama_barang LIKE '%" + txt_cari_bar.Text + "%')", con);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView3.DataSource = dt;
                dataGridView3.Columns[0].HeaderText = "Kode Barang";
                dataGridView3.Columns[1].HeaderText = "Nama Barang";
                dataGridView3.Columns[1].Width = 400;
                dataGridView3.Columns[2].HeaderText = "Kemasan";
                dataGridView3.Columns[3].HeaderText = "Harga";
                dataGridView3.Columns[4].HeaderText = "Stock";
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
                cmd = new OracleCommand("select * from tbl_pelanggan where kode_pelanggan like 'PLGP%' and (kode_pelanggan LIKE '%" + txt_cari_pel.Text + "%' OR nama_pelanggan LIKE '%" + txt_cari_pel.Text + "%')", con);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].HeaderText = "Kode Pelanggan";
                dataGridView2.Columns[1].HeaderText = "Nama Pelanggan";
                dataGridView2.Columns[2].HeaderText = "Nomor Telepon";
                dataGridView2.Columns[3].HeaderText = "Alamat";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CariDataSal()
        {
            try
            {
                con.Close();
                con.Open();
                DataTable dt = new DataTable();
                cmd = new OracleCommand("select * from tbl_sales where kode_sales LIKE '%" + txt_cari_sal.Text + "%' OR nama_sales LIKE '%" + txt_cari_sal.Text + "%'", con);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView4.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataTable edit(string field, string tabel, string kriteria, string syarat)
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

        private void otomatis()
        {
            long hitung;
            string urut;

            con.Open();
            cmd = new OracleCommand("select kode_penjualan from tbl_penjualan_penamas_detail where kode_penjualan in(select max(kode_penjualan) from tbl_penjualan_penamas_detail) order by kode_penjualan desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["kode_penjualan"].ToString().Length - 4, 4)) + 1;

                string joinstr = "0000" + hitung;



                urut = "SELL" + joinstr.Substring(joinstr.Length - 4, 4);

            }
            else
            {
                urut = "SELL0001";
            }
            rd.Close();
            txt_kode_penjualan.Text = urut;
            con.Close();
        }

        public FORM_PENJUALAN_PENAMAS()
        {
            InitializeComponent();
            DisplayData();
            CleanText1();
            txt_kode_penjualan.Enabled = false;
        }

        private void FORM_PENJUALAN_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_penjualan.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_kode_pelanggan1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_kode_barang.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_kode_sales.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_jumlah_keluar.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_sub_total.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_keterangan.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_discount.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_nama_pelanggan.Text = edit("nama_pelanggan", "tbl_pelanggan", "kode_pelanggan", txt_kode_pelanggan1.Text).Rows[0][0].ToString();
            txt_no_telp.Text = edit("no_telp", "tbl_pelanggan", "kode_pelanggan", txt_kode_pelanggan1.Text).Rows[0][0].ToString();
            txt_alamat.Text = edit("alamat", "tbl_pelanggan", "kode_pelanggan", txt_kode_pelanggan1.Text).Rows[0][0].ToString();
            txt_nama_barang.Text = edit("nama_barang", "tbl_barang", "kode_barang", txt_kode_barang.Text).Rows[0][0].ToString();
            txt_satuan1.Text = edit("kemasan", "tbl_barang", "kode_barang", txt_kode_barang.Text).Rows[0][0].ToString();
            txt_harga.Text = edit("harga", "tbl_barang", "kode_barang", txt_kode_barang.Text).Rows[0][0].ToString();
            txt_stock.Text = edit("stock", "tbl_barang", "kode_barang", txt_kode_barang.Text).Rows[0][0].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_kode_penjualan.Enabled = false;
            otomatis();
            CleanText1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_kode_penjualan.Text != "")
            {
                cmd = new OracleCommand("insert into tbl_penjualan_penamas_detail(kode_penjualan, tgl_penjualan, tgl_order, tgl_jtempo, kode_pelanggan, kode_barang, kode_sales, jumlah_beli, sub_total, discount, keterangan) select kode_penjualan, tgl_penjualan, tgl_order, tgl_jtempo, kode_pelanggan, kode_barang, kode_sales, jumlah_beli, sub_total, discount, keterangan from tbl_penjualan_penamas", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd = new OracleCommand("delete tbl_penjualan_penamas where kode_penjualan=:kode_penjualan", con);
                cmd.Parameters.Add(new OracleParameter(":kode_penjualan", txt_kode_penjualan.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data berhasil disimpan");
                DisplayData();
                CleanText();
            }
            else
            {
                MessageBox.Show("Gagal simpan");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_kode_pelanggan1.Text != "" && txt_kode_barang.Text != "" && txt_kode_penjualan.Text != "" && txt_jumlah_keluar.Text != "" && txt_sub_total.Text != "" && txt_keterangan.Text != "")
            {
                try
                {
                    cmd = new OracleCommand("insert into tbl_penjualan_penamas(kode_penjualan, tgl_penjualan, tgl_order, tgl_jtempo, kode_pelanggan, kode_barang, kode_sales, jumlah_beli, sub_total, discount, keterangan) values(:kode_penjualan, :tgl_penjualan, :tgl_order, :tgl_jtempo, :kode_pelanggan, :kode_barang, :kode_sales, :jumlah_beli,:sub_total, :keterangan, :discount)", con);
                    con.Open();
                    cmd.Parameters.Add(new OracleParameter(":kode_penjualan", txt_kode_penjualan.Text));
                    cmd.Parameters.Add(new OracleParameter(":tgl_penjualan", DateTime.Parse(txt_tanggal.Value.Date.ToString())));
                    cmd.Parameters.Add(new OracleParameter(":tgl_order", DateTime.Parse(txt_order.Value.Date.ToString())));
                    cmd.Parameters.Add(new OracleParameter(":tgl_jtempo", DateTime.Parse(txt_jtempo.Value.Date.ToString())));
                    cmd.Parameters.Add(new OracleParameter(":kode_pelanggan", txt_kode_pelanggan1.Text));
                    cmd.Parameters.Add(new OracleParameter(":kode_barang", txt_kode_barang.Text));
                    cmd.Parameters.Add(new OracleParameter(":kode_sales", txt_kode_sales.Text));
                    cmd.Parameters.Add(new OracleParameter(":jumlah_beli", txt_jumlah_keluar.Text));
                    cmd.Parameters.Add(new OracleParameter(":sub_total", txt_sub_total.Text));
                    cmd.Parameters.Add(new OracleParameter(":discount", txt_discount.Text));
                    cmd.Parameters.Add(new OracleParameter(":keterangan", txt_keterangan.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    String stock_akhir = (int.Parse(txt_stock.Text) - int.Parse(txt_jumlah_keluar.Text)).ToString();
                    cmd = new OracleCommand("update tbl_barang set stock=" + stock_akhir + " where kode_barang=+'" + txt_kode_barang.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data berhasil ditambah");
                    DisplayData();
                    CleanText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Gagal tambah");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel_sales.Visible != true)
            {
                panel_sales.Visible = true;
            }
            else
            {
                panel_sales.Visible = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (panel_barang.Visible != true)
            {
                panel_barang.Visible = true;
            }
            else
            {
                panel_barang.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel_pelanggan.Visible != true)
            {
                panel_pelanggan.Visible = true;
            }
            else
            {
                panel_pelanggan.Visible = false;
            }
        }

        private void panel_sales_Paint(object sender, PaintEventArgs e)
        {
            DisplayData3();
        }

        private void panel_pelanggan_Paint(object sender, PaintEventArgs e)
        {
            DisplayData2();
        }

        private void panel_barang_Paint(object sender, PaintEventArgs e)
        {
            DisplayData1();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_barang.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_barang.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_satuan1.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_harga.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_stock.Text = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
            panel_barang.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_sales.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();

            panel_sales.Visible = false;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_pelanggan1.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_pelanggan.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_no_telp.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_alamat.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            panel_pelanggan.Visible = false;
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_barang.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_barang.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_harga.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_satuan1.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_stock.Text = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
            panel_barang.Visible = false;
        }

        private void txt_jumlah_keluar_TextChanged(object sender, EventArgs e)
        {
            if (txt_jumlah_keluar.Text != "")
            {
                txt_sub_total.Text = (int.Parse(txt_harga.Text) * int.Parse(txt_jumlah_keluar.Text)).ToString();
                txt_total.Text = (int.Parse(txt_sub_total.Text) - int.Parse(txt_discount.Text)).ToString();
            }
            else txt_sub_total.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_nama_barang.Text != "")
            {
                cmd = new OracleCommand("delete tbl_penjualan_penamas where kode_penjualan=:kode_penjualan AND kode_barang=:kode_barang AND kode_pelanggan=:kode_pelanggan AND kode_sales=:kode_sales", con);
                con.Open();
                cmd.Parameters.Add(new OracleParameter(":kode_penjualan", txt_kode_penjualan.Text));
                cmd.Parameters.Add(new OracleParameter(":kode_barang", txt_kode_barang.Text));
                cmd.Parameters.Add(new OracleParameter(":kode_pelanggan", txt_kode_pelanggan1.Text));
                cmd.Parameters.Add(new OracleParameter(":kode_sales", txt_kode_sales.Text));
                cmd.ExecuteNonQuery();
                con.Close();

                String stock_akhir = (int.Parse(txt_stock.Text) + int.Parse(txt_jumlah_keluar.Text)).ToString();
                cmd = new OracleCommand("update tbl_barang set stock=" + stock_akhir + " where kode_barang=+'" + txt_kode_barang.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("berhasil hapus");
                DisplayData();
                CleanText();
            }
            else
            {
                MessageBox.Show("gagal hapus");
            }  
        }

        private void txt_jumlah_keluar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txt_cari_bar_TextChanged(object sender, EventArgs e)
        {
            if (txt_cari_bar.Text == "")
            {
                DisplayData1();
            }
            else
            {
                CariDataBar();
            }
        }

        private void txt_cari_sal_TextChanged(object sender, EventArgs e)
        {
            if (txt_cari_sal.Text == "")
            {
                DisplayData3();
            }
            else
            {
                CariDataSal();
            }
        }

        private void txt_cari_pel_TextChanged(object sender, EventArgs e)
        {
            if (txt_cari_pel.Text == "")
            {
                DisplayData2();
            }
            else
            {
                CariDataPel();
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text != "")
            {
                txt_total.Text = (int.Parse(txt_sub_total.Text) - int.Parse(txt_discount.Text)).ToString();
            }
            else txt_total.Text = "0";
        }

    }
}
