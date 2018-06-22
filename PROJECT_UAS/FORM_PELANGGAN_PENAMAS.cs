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
    public partial class FORM_PELANGGAN_PENAMAS : Form
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
                cmd = new OracleCommand("select * from tbl_pelanggan where kode_pelanggan like 'PLGP%' order by kode_pelanggan ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rd);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Kode Pelanggan";
                dataGridView1.Columns[1].HeaderText = "Nama Pelanggan";
                dataGridView1.Columns[2].HeaderText = "Nomor Telepon";
                dataGridView1.Columns[3].HeaderText = "Alamat";
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
            cmd = new OracleCommand("select kode_pelanggan from tbl_pelanggan where kode_pelanggan in(select max(kode_pelanggan) from tbl_pelanggan where kode_pelanggan like 'PLGP%') order by kode_pelanggan desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["kode_pelanggan"].ToString().Length - 4, 4)) + 1;

                string joinstr = "0000" + hitung;



                urut = "PLGP" + joinstr.Substring(joinstr.Length - 4, 4);

            }
            else
            {
                urut = "PLGP0001";
            }
            rd.Close();
            txt_kode_pelanggan.Text = urut;
            con.Close();
        }

        private void CleanText()
        {
            txt_kode_pelanggan.Text = "";
            txt_nama_pelanggan.Text = "";
            txt_no_telp.Text = "";
            txt_alamat.Text = "";
            txt_kode_pelanggan.Enabled = false;
        }

        public FORM_PELANGGAN_PENAMAS()
        {
            InitializeComponent();
            DisplayData();
            CleanText();
        }

        private void FORM_PELANGGAN_Load(object sender, EventArgs e)
        {

        }

        private void btBaru_Click(object sender, EventArgs e)
        {
            CleanText();
            otomatis();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (txt_kode_pelanggan.Text != "" && txt_nama_pelanggan.Text != "" && txt_no_telp.Text != "" && txt_alamat.Text != "")
            {
                con.Close();
                cmd = new OracleCommand("insert into tbl_pelanggan(kode_pelanggan,nama_pelanggan,no_telp,alamat) values(:kode,:nama,:telepon,:alamat)", con);
                con.Open();
                cmd.Parameters.Add(new OracleParameter(":kode", txt_kode_pelanggan.Text));
                cmd.Parameters.Add(new OracleParameter(":nama", txt_nama_pelanggan.Text));
                cmd.Parameters.Add(new OracleParameter(":telepon", txt_no_telp.Text));
                cmd.Parameters.Add(new OracleParameter(":alamat", txt_alamat.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data berhasil disimpan", "Berhasil");
                DisplayData();
                CleanText();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txt_kode_pelanggan.Text != "" && txt_nama_pelanggan.Text != "" && txt_no_telp.Text != "" && txt_alamat.Text != "")
            {
                cmd = new OracleCommand("update tbl_pelanggan set nama_pelanggan='" + txt_nama_pelanggan.Text + "',no_telp='" + txt_no_telp.Text + "',alamat='" + txt_alamat.Text + "' where kode_pelanggan='" + txt_kode_pelanggan.Text + "'", con);
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
            if (txt_kode_pelanggan.Text != "")
            {
                con.Close();
                cmd = new OracleCommand("delete tbl_pelanggan where kode_pelanggan=:kode", con);
                con.Open();
                cmd.Parameters.Add(new OracleParameter(":kode", txt_kode_pelanggan.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil hapus", "Berhasil");
                DisplayData();
                CleanText();
            }
            else
            {
                MessageBox.Show("Gagal hapus", "Berhasil");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_pelanggan.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_pelanggan.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_no_telp.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_alamat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_kode_pelanggan.Enabled = false;
        }

        private void CariDataPel()
        {
            try
            {
                con.Close();
                con.Open();
                DataTable dt = new DataTable();
                cmd = new OracleCommand("select * from tbl_pelanggan where kode_pelanggan like 'PLGP%' and (kode_pelanggan LIKE '%" + txt_cari.Text + "%' OR nama_pelanggan LIKE '%" + txt_cari.Text + "%')", con);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Kode Pelanggan";
                dataGridView1.Columns[1].HeaderText = "Nama Pelanggan";
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
                CariDataPel();
            }
        }
    }
}
