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
    public partial class FRM_BARANG : Form
    {
        OracleConnection con = new OracleConnection("Data Source=XE;User Id=KARYA;Password=123_Qwerty");
        OracleCommand cmd;
        OracleDataReader rd;

        public FRM_BARANG()
        {
            InitializeComponent();
            DisplayData();
            CleanText();
            Otomatis();
            lbJam.Text = DateTime.Now.ToLongTimeString();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void Otomatis()
        {
            long hitung;
            string urut;
            con.Close();
            con.Open();
            cmd = new OracleCommand("select kode_barang from tbl_barang where kode_barang in(select max(kode_barang) from tbl_barang where kode_barang like 'BRGA%') order by kode_barang desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["kode_barang"].ToString().Length - 4, 4)) + 1;

                string joinstr = "0000" + hitung;



                urut = "BRGA" + joinstr.Substring(joinstr.Length - 4, 4);

            }
            else
            {
                urut = "BRGA0001";
            }
            rd.Close();
            txtKodeBarang.Text = urut;
            con.Close();
        }
        

        public void DisplayData()
        {
            try
            {
                con.Close();
                con.Open();
                cmd = new OracleCommand("select kode_barang, nama_barang, harga, stock from tbl_barang where kemasan is NULL order by kode_barang ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rd);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Kode Barang";
                dataGridView1.Columns[1].HeaderText = "Nama Barang";
                dataGridView1.Columns[1].Width = 400;
                dataGridView1.Columns[2].HeaderText = "Harga";
                dataGridView1.Columns[3].HeaderText = "Stock";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void CariData()
        {
            try
            {
                con.Close();
                con.Open();
                DataTable dt = new DataTable();
                cmd = new OracleCommand("select kode_barang, nama_barang, harga, stock from tbl_barang where kode_barang like 'BRGA%' and (kode_barang LIKE '%" + txtCari.Text + "%' OR nama_barang LIKE '%" + txtCari.Text + "%')", con);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Kode Barang";
                dataGridView1.Columns[1].HeaderText = "Nama Barang";
                dataGridView1.Columns[2].HeaderText = "Harga";
                dataGridView1.Columns[3].HeaderText = "Stock";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void CleanText()
        {
            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            txtHarga.Text = "0";
            txtStock.Text = "0";
            txtKodeBarang.Enabled = false;
            txtStock.Enabled = false;
        }

        private void FRM_BARANG_Load(object sender, EventArgs e)
        {
            
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text != "" && txtNamaBarang.Text != "" && txtHarga.Text != "" && txtStock.Text != "")
            {
                try
                {
                    con.Close();
                    cmd = new OracleCommand("insert into tbl_barang (kode_barang,nama_barang,harga,stock) values (:kode_barang,:nama_barang,:harga,:stock)", con);
                    con.Open();
                    cmd.Parameters.Add(new OracleParameter(":kode_barang", txtKodeBarang.Text));
                    cmd.Parameters.Add(new OracleParameter(":nama_barang", txtNamaBarang.Text));
                    cmd.Parameters.Add(new OracleParameter(":harga", txtHarga.Text));
                    cmd.Parameters.Add(new OracleParameter(":stock", txtStock.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data berhasil disimpan", "Berhasil");
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
                MessageBox.Show("Gagal simpan", "Gagal");
            }  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKodeBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNamaBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHarga.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStock.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtKodeBarang.Enabled = false;
        }

        private void btKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text != "" && txtNamaBarang.Text != "" && txtHarga.Text != "" && txtStock.Text != "")
            {
                try
                {
                    con.Close();
                    cmd = new OracleCommand("update tbl_barang set nama_barang='"+txtNamaBarang.Text+"', harga='"+txtHarga.Text+"', stock='"+txtStock.Text+"' where kode_barang='"+txtKodeBarang.Text+"'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ubah berhasil", "Berhasil");
                    con.Close();
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
                MessageBox.Show("Gagal ubah", "Gagal");
            }  
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text != "")
            {
                con.Close();
                cmd = new OracleCommand("delete tbl_barang where kode_barang=:kode_barang", con);
                con.Open();
                cmd.Parameters.Add(new OracleParameter(":kode_barang", txtKodeBarang.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil hapus", "Berhasil");
                DisplayData();
                CleanText();
            }
            else
            {
                MessageBox.Show("Gagal hapus", "Gagal");
            }  
        }

        private void btBaru_Click(object sender, EventArgs e)
        {
            CleanText();
            Otomatis();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (txtCari.Text == "")
            {
                DisplayData();
            }
            else
            {
                CariData();
            }
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbJam.Text = DateTime.Now.ToLongTimeString();
        }  
    }
}
