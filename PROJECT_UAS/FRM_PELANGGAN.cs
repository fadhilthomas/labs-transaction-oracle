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
    public partial class FRM_PELANGGAN : Form
    {
        OracleConnection con = new OracleConnection("Data Source=XE;User Id=KARYA;Password=123_Qwerty");
        OracleCommand cmd;
        OracleDataReader rd;

        public FRM_PELANGGAN()
        {
            InitializeComponent();
            DisplayData();
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
            cmd = new OracleCommand("select kode_pelanggan from tbl_pelanggan where kode_pelanggan in(select max(kode_pelanggan) from tbl_pelanggan where kode_pelanggan like 'PLGA%') order by kode_pelanggan desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["kode_pelanggan"].ToString().Length - 4, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "PLGA" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {
                urut = "PLGA0001";
            }
            rd.Close();
            txtKode.Text = urut;
            con.Close();
        }

        private void DisplayData()
        {
            try
            {
                con.Close();
                con.Open();
                cmd = new OracleCommand("select * from tbl_pelanggan where kode_pelanggan like 'PLGA%' order by kode_pelanggan ASC", con);
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

        private void CariData()
        {
            try
            {
                con.Close();
                con.Open();
                DataTable dt = new DataTable();
                cmd = new OracleCommand("select * from tbl_pelanggan where kode_pelanggan like 'PLGA%' and (kode_pelanggan LIKE '%" + txtCari.Text + "%' OR nama_pelanggan LIKE '%" + txtCari.Text + "%')", con);
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

        private void CleanText()
        {
            txtKode.Text = "";
            txtNama.Text = "";
            txtTelepon.Text = "";
            txtAlamat.Text = "";
            txtKode.Enabled = false;
        }

        private void btBaru_Click(object sender, EventArgs e)
        {
            CleanText();
            Otomatis();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (txtKode.Text != "" && txtNama.Text != "" && txtTelepon.Text != "" && txtAlamat.Text != "")
            {
                con.Close();
                cmd = new OracleCommand("insert into tbl_pelanggan(kode_pelanggan,nama_pelanggan,no_telp,alamat) values(:kode,:nama,:telepon,:alamat)", con);
                con.Open();
                cmd.Parameters.Add(new OracleParameter(":kode", txtKode.Text));
                cmd.Parameters.Add(new OracleParameter(":nama", txtNama.Text));
                cmd.Parameters.Add(new OracleParameter(":telepon", txtTelepon.Text));
                cmd.Parameters.Add(new OracleParameter(":alamat", txtAlamat.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data berhasil disimpan", "Berhasil");
                DisplayData();
                CleanText();
            }
            else
            {
                MessageBox.Show("Gagal simpan", "Berhasil");
            }  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelepon.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAlamat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtKode.Enabled = false;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtKode.Text != "" && txtNama.Text != "" && txtTelepon.Text != "" && txtAlamat.Text != "")
            {
                con.Close();
                cmd = new OracleCommand("update tbl_pelanggan set nama_pelanggan='"+txtNama.Text+"',no_telp='"+txtTelepon.Text+"',alamat='"+txtAlamat.Text+"' where kode_pelanggan='"+txtKode.Text+"'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ubah berhasil", "Berhasil");
                con.Close();
                DisplayData();
                CleanText();
            }
            else
            {
                MessageBox.Show("Gagal ubah", "Gagal");
            }  
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            if (txtKode.Text != "")
            {
                con.Close();
                cmd = new OracleCommand("delete tbl_pelanggan where kode_pelanggan=:kode", con);
                con.Open();
                cmd.Parameters.Add(new OracleParameter(":kode", txtKode.Text));
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

        private void btKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbJam.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
