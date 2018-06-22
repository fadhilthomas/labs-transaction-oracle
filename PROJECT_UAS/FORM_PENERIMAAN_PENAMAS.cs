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
    public partial class FORM_PENERIMAAN_PENAMAS : Form
    {
        OracleConnection con = new OracleConnection("Data Source=XE;User Id=KARYA;Password=123_Qwerty");
        OracleCommand cmd;
        OracleDataReader rd;

        public FORM_PENERIMAAN_PENAMAS()
        {
            InitializeComponent();
            DisplayData();
            Otomatis();
            DisplayDataBar();
            Total_terbilang();
        }

        private void CleanText()
        {
            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            txtStock.Text = "0";
            txtHarga.Text = "0";
            txtJumlah.Text = "";
            txtKet.Text = "";
            txtKemasan.Text = "";
        }

        private void CleanAll()
        {
            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            txtStock.Text = "";
            txtHarga.Text = "";
            txtJumlah.Text = "";
            txtKet.Text = "";
            txtKemasan.Text = "";
        }

        private void Total_terbilang()
        {
            con.Close();
            cmd = new OracleCommand("select sub_total from tbl_penerimaan_penamas where no_penerimaan = '" + txtNoPenerimaan.Text + "'", con);
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
                txtTotal.Text = Total("sub_total", "tbl_penerimaan_penamas").Rows[0][0].ToString();
            }
            else
            {
                txtTotal.Text = "0";
            }
            con.Close();
        }

        
        private void Otomatis()
        {
            long hitung;
            string urut;
            con.Close();
            con.Open();
            cmd = new OracleCommand("select no_penerimaan from tbl_penerimaan_penamas_detail where no_penerimaan in(select max(no_penerimaan) from tbl_penerimaan_penamas_detail) order by no_penerimaan desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["no_penerimaan"].ToString().Length - 4, 4)) + 1;

                string joinstr = "0000" + hitung;



                urut = "PNR" + joinstr.Substring(joinstr.Length - 4, 4);

            }
            else
            {
                urut = "PNR0001";
            }
            rd.Close();
            txtNoPenerimaan.Text = urut;
            con.Close();
        }

        private void DisplayData()
        {
            try
            {
                con.Close();
                con.Open();
                cmd = new OracleCommand("select * from tbl_penerimaan_penamas order by no_penerimaan ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Nomor Penerimaan";
                dataGridView1.Columns[1].HeaderText = "Tanggal Penerimaan";
                dataGridView1.Columns[2].HeaderText = "Kode Barang";
                dataGridView1.Columns[3].HeaderText = "Jumlah Penerimaan";
                dataGridView1.Columns[4].HeaderText = "Sub Total";
                dataGridView1.Columns[5].HeaderText = "Keterangan";
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
                cmd = new OracleCommand("select * from tbl_barang where kode_barang like 'BRGP%' order by kode_barang ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rd);
                dGBar.DataSource = dataTable;
                dGBar.Columns[0].HeaderText = "Kode Barang";
                dGBar.Columns[1].HeaderText = "Nama Barang";
                dGBar.Columns[1].Width = 400;
                dGBar.Columns[2].HeaderText = "Kemasan";
                dGBar.Columns[3].HeaderText = "Harga";
                dGBar.Columns[4].HeaderText = "Stock";
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
                cmd = new OracleCommand("select * from tbl_barang where kode_barang like 'BRGP%' and (kode_barang LIKE '%" + txtCariBarang.Text + "%' OR nama_barang LIKE '%" + txtCariBarang.Text + "%')", con);
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

        
        private void button2_Click(object sender, EventArgs e)
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

        private void btBaru_Click(object sender, EventArgs e)
        {
            Otomatis();
            txtNoPenerimaan.Enabled = false;
            CleanAll();
            dateTimePicker1.Value = DateTime.Now;
        }

        
        private void dGBar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKodeBarang.Text = dGBar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNamaBarang.Text = dGBar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtKemasan.Text = dGBar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHarga.Text = dGBar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtStock.Text = dGBar.Rows[e.RowIndex].Cells[4].Value.ToString();
            pnBarang.Visible = false;
        }


        private void btTambah_Click(object sender, EventArgs e)
        {

            if (txtKodeBarang.Text != "" && txtNoPenerimaan.Text != "" && txtJumlah.Text != "" && txtKet.Text != "" && int.Parse(txtJumlah.Text) > 0)
            {
                con.Close();
                cmd = new OracleCommand("select no_penerimaan, kode_barang from tbl_penerimaan_penamas where no_penerimaan = '" + txtNoPenerimaan.Text + "' and kode_barang = '" + txtKodeBarang.Text + "'", con);
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
                    try
                    {
                        cmd = new OracleCommand("insert into tbl_penerimaan_penamas(no_penerimaan, tgl_penerimaan, kode_barang, jumlah_terima, sub_total, keterangan) values(:no_penerimaan, :tgl_penerimaan, :kode_barang, :jumlah_terima, :sub_total, :keterangan)", con);
                        con.Close();
                        con.Open();
                        cmd.Parameters.Add(new OracleParameter(":no_penerimaan", txtNoPenerimaan.Text));
                        cmd.Parameters.Add(new OracleParameter(":tgl_penerimaan", DateTime.Parse(dateTimePicker1.Value.Date.ToString())));
                        cmd.Parameters.Add(new OracleParameter(":kode_barang", txtKodeBarang.Text));
                        cmd.Parameters.Add(new OracleParameter(":jumlah_terima", txtJumlah.Text));
                        cmd.Parameters.Add(new OracleParameter(":sub_total", txtSubTotal.Text));
                        cmd.Parameters.Add(new OracleParameter(":keterangan", txtKet.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        
                        String stock_akhir = (int.Parse(txtJumlah.Text) + int.Parse(txtStock.Text)).ToString();
                        cmd = new OracleCommand("update tbl_barang set stock=" + stock_akhir + " where kode_barang=+'" + txtKodeBarang.Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        
                        MessageBox.Show("Data berhasil disimpan", "Berhasil");
                        Total_terbilang();
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
            txtNoPenerimaan.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKodeBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtKet.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtNamaBarang.Text = Edit("nama_barang", "tbl_barang", "kode_barang", txtKodeBarang.Text).Rows[0][0].ToString();
            txtHarga.Text = Edit("harga", "tbl_barang", "kode_barang", txtKodeBarang.Text).Rows[0][0].ToString();
            txtStock.Text = Edit("stock", "tbl_barang", "kode_barang", txtKodeBarang.Text).Rows[0][0].ToString();
            txtKemasan.Text = Edit("kemasan", "tbl_barang", "kode_barang", txtKodeBarang.Text).Rows[0][0].ToString();
            txtJumlah.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSubTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            con.Close();
            if (txtNamaBarang.Text != "")
            {
                cmd = new OracleCommand("delete tbl_penerimaan_penamas where no_penerimaan=:no_penerimaan AND kode_barang=:kode_barang", con);
                con.Open();
                cmd.Parameters.Add(new OracleParameter(":no_penerimaan", txtNoPenerimaan.Text));
                cmd.Parameters.Add(new OracleParameter(":kode_barang", txtKodeBarang.Text));
                cmd.ExecuteNonQuery();
                con.Close();

                String stock_akhir = (int.Parse(txtStock.Text) - int.Parse(txtJumlah.Text)).ToString();
                cmd = new OracleCommand("update tbl_barang set stock="+stock_akhir+" where kode_barang=+'"+txtKodeBarang.Text+"'", con);
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
            con.Close();
            if (txtNoPenerimaan.Text != "")
            {
                cmd = new OracleCommand("insert into tbl_penerimaan_penamas_detail(no_penerimaan, tgl_penerimaan, kode_barang, jumlah_terima, sub_total, keterangan) select no_penerimaan, tgl_penerimaan, kode_barang, jumlah_terima, sub_total, keterangan from tbl_penerimaan_penamas ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd = new OracleCommand("delete tbl_penerimaan_penamas where no_penerimaan=:no_penerimaan", con);
                cmd.Parameters.Add(new OracleParameter(":no_penerimaan", txtNoPenerimaan.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Transaksi tersimpan", "Berhasil");
                DisplayData();
                Total_terbilang();
                CleanAll();
                Otomatis();
            }
            else
            {
                MessageBox.Show("Transaksi gagal tersimpan", "Gagal");
            }
        }

        private void txtCariBarang_TextChanged(object sender, EventArgs e)
        {
            if (txtCariBarang.Text == "")
            {
                DisplayDataBar();
            }
            else
            {
                CariDataBar();
            }
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            if (txtJumlah.Text != "") txtSubTotal.Text = (int.Parse(txtHarga.Text) * int.Parse(txtJumlah.Text)).ToString();
            else txtSubTotal.Text = "0";
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
