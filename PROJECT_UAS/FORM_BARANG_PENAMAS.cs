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
    public partial class FORM_BARANG_PENAMAS : Form
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
                cmd = new OracleCommand("select * from tbl_barang where kemasan is not NULL order by kode_barang ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rd);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Kode Barang";
                dataGridView1.Columns[1].HeaderText = "Nama Barang";
                dataGridView1.Columns[2].HeaderText = "Kemasan";
                dataGridView1.Columns[3].HeaderText = "Harga";
                dataGridView1.Columns[4].HeaderText = "Stock";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void otomatis()
        {
            long hitung;
            string urut;
            con.Close();
            con.Open();
            cmd = new OracleCommand("select kode_barang from tbl_barang where kode_barang in(select max(kode_barang) from tbl_barang where kode_barang like 'BRGP%') order by kode_barang desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["kode_barang"].ToString().Length - 4, 4)) + 1;

                string joinstr = "0000" + hitung;



                urut = "BRGP" + joinstr.Substring(joinstr.Length - 4, 4);

            }
            else
            {
                urut = "BRGP0001";
            }
            rd.Close();
            txt_kode_barang.Text = urut;
            con.Close();
        }

        private void CleanText()
        {
            txt_kode_barang.Text = "";
            txt_nama_barang.Text = "";
            txt_kemasan.Text = "";
            txt_harga.Text = "";
            txt_stock.Text = "0";
            txt_kode_barang.Enabled = true;
        }

        public FORM_BARANG_PENAMAS()
        {
            InitializeComponent();
            DisplayData();
            CleanText();
        }

        private void FORM_BARANG_Load(object sender, EventArgs e)
        {

        }

        private void k_Click(object sender, EventArgs e)
        {
        
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (txt_kode_barang.Text != "" && txt_nama_barang.Text != "" && txt_kemasan.Text != "" && txt_harga.Text != "" && txt_stock.Text != "")
            {
                cmd = new OracleCommand("insert into tbl_barang(kode_barang,nama_barang,kemasan,harga,stock) values(:kode_barang,:nama_barang,:kemasan,:harga,:stock)", con);
                con.Open();
                cmd.Parameters.Add(new OracleParameter(":kode_barang", txt_kode_barang.Text));
                cmd.Parameters.Add(new OracleParameter(":nama_barang", txt_nama_barang.Text));
                cmd.Parameters.Add(new OracleParameter(":kemasan", txt_kemasan.Text));
                cmd.Parameters.Add(new OracleParameter(":harga", txt_harga.Text));
                cmd.Parameters.Add(new OracleParameter(":stock", txt_stock.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data berhasil disimpan");
                DisplayData();
                CleanText();
            }
            else
            {
                MessageBox.Show("gagal simpan");
            }  
        }

        private void btBaru_Click(object sender, EventArgs e)
        {
            CleanText();
            otomatis();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            if (txt_kode_barang.Text != "")
            {
                cmd = new OracleCommand("delete tbl_barang where kode_barang=:kode_barang", con);
                con.Open();
                cmd.Parameters.Add(new OracleParameter(":kode_barang", txt_kode_barang.Text));
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

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txt_kode_barang.Text != "" && txt_nama_barang.Text != "" && txt_kemasan.Text != "" && txt_harga.Text != "" && txt_stock.Text != "")
            {
                con.Close();
                cmd = new OracleCommand("update tbl_barang set nama_barang='"+txt_nama_barang.Text+"',kemasan='"+txt_kemasan.Text+"',harga='"+txt_harga.Text+"',stock='"+txt_stock.Text+"' where kode_barang='"+txt_kode_barang.Text+"'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edit Berhasil");
                con.Close();
                DisplayData();
                CleanText();
            }
            else
            {
                MessageBox.Show("gagal edit");

            }  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_barang.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_barang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_kemasan.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_harga.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_stock.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_kode_barang.Enabled = false;
        }

        private void txt_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void CariDataBar()
        {
            try
            {
                con.Close();
                con.Open();
                DataTable dt = new DataTable();
                cmd = new OracleCommand("select * from tbl_barang where kode_barang like 'BRGP%' and (kode_barang LIKE '%" + txt_cari.Text + "%' OR nama_barang LIKE '%" + txt_cari.Text + "%')", con);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Kode Barang";
                dataGridView1.Columns[1].HeaderText = "Nama Barang";
                dataGridView1.Columns[1].Width = 400;
                dataGridView1.Columns[2].HeaderText = "Kemasan";
                dataGridView1.Columns[3].HeaderText = "Harga";
                dataGridView1.Columns[4].HeaderText = "Stock";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            if (txt_cari.Text == "")
            {
                DisplayData();
            }
            else
            {
                CariDataBar();
            }
        }
    }
}
