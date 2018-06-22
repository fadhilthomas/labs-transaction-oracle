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
    public partial class FORM_SALES_PENAMAS : Form
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
                cmd = new OracleCommand("select * from tbl_sales order by kode_sales ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rd);
                dataGridView1.DataSource = dataTable;
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

            con.Open();
            cmd = new OracleCommand("select kode_sales from tbl_sales where kode_sales in(select max(kode_sales) from tbl_sales) order by kode_sales desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["kode_sales"].ToString().Length - 4, 4)) + 1;

                string joinstr = "0000" + hitung;



                urut = "SLS" + joinstr.Substring(joinstr.Length - 4, 4);

            }
            else
            {
                urut = "SLS0001";
            }
            rd.Close();
            txt_kode_sales.Text = urut;
            con.Close();
        }

        private void CleanText()
        {
            txt_kode_sales.Text = "";
            txt_nama_sales.Text = "";
            txt_no_telp.Text = "";
            txt_alamat.Text = "";
            txt_kode_sales.Enabled = false;
        }

        public FORM_SALES_PENAMAS()
        {
            InitializeComponent();
            DisplayData();
            CleanText();
        }

        private void FORM_SALES_Load(object sender, EventArgs e)
        {

        }

        private void btBaru_Click(object sender, EventArgs e)
        {
            CleanText();
            otomatis();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (txt_kode_sales.Text != "" && txt_nama_sales.Text != "" && txt_no_telp.Text != "" && txt_alamat.Text != "")
            {
                cmd = new OracleCommand("insert into tbl_sales(kode_sales,nama_sales,no_telp,alamat) values(:kode_sales,:nama_sales,:no_telp,:alamat)", con);
                con.Open();
                cmd.Parameters.Add(new OracleParameter(":kode_sales", txt_kode_sales.Text));
                cmd.Parameters.Add(new OracleParameter(":nama_sales", txt_nama_sales.Text));
                cmd.Parameters.Add(new OracleParameter(":no_telp", txt_no_telp.Text));
                cmd.Parameters.Add(new OracleParameter(":alamat", txt_alamat.Text));
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

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txt_kode_sales.Text != "" && txt_nama_sales.Text != "" && txt_no_telp.Text != "" && txt_alamat.Text != "")
            {
                con.Close();
                cmd = new OracleCommand("update tbl_sales set nama_sales='"+txt_nama_sales.Text+"',no_telp='"+txt_no_telp.Text+"',alamat='"+txt_alamat.Text+"' where kode_sales='"+txt_kode_sales.Text+"'", con);
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

        private void btHapus_Click(object sender, EventArgs e)
        {
            if (txt_kode_sales.Text != "")
            {
                cmd = new OracleCommand("delete tbl_sales where kode_sales=:kode_sales", con);
                con.Open();
                cmd.Parameters.Add(new OracleParameter(":kode_sales", txt_kode_sales.Text));
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_sales.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_sales.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_no_telp.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_alamat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_kode_sales.Enabled = false;
        }

        private void CariDataSal()
        {
            try
            {
                con.Close();
                con.Open();
                DataTable dt = new DataTable();
                cmd = new OracleCommand("select * from tbl_sales where kode_sales LIKE '%" + txt_cari.Text + "%' OR nama_sales LIKE '%" + txt_cari.Text + "%'", con);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Kode Sales";
                dataGridView1.Columns[1].HeaderText = "Nama Sales";
                dataGridView1.Columns[2].HeaderText = "Nomor Telepon";
                dataGridView1.Columns[3].HeaderText = "Alamat";
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
                CariDataSal();
            }
        }
    }
}
