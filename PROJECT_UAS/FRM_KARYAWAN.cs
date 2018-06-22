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
    public partial class FRM_KARYAWAN : Form
    {
        OracleConnection con = new OracleConnection("Data Source=XE;User Id=KARYA;Password=123_Qwerty");
        OracleCommand cmd;
        OracleDataReader rd;


        public FRM_KARYAWAN()
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
            cmd = new OracleCommand("select kode_karyawan from tbl_karyawan where kode_karyawan in(select max(kode_karyawan) from tbl_karyawan) order by kode_karyawan desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["kode_karyawan"].ToString().Length - 4, 4)) + 1;

                string joinstr = "0000" + hitung;
                urut = "KRY" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {
                urut = "KRY0001";
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
                cmd = new OracleCommand("select * from tbl_karyawan order by kode_karyawan ASC", con);
                rd = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(rd);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Kode Karyawan";
                dataGridView1.Columns[1].HeaderText = "Nama Karyawan";
                dataGridView1.Columns[2].HeaderText = "Nomor Telepon";
                dataGridView1.Columns[3].HeaderText = "Alamat";
                dataGridView1.Columns[4].HeaderText = "Status Karyawan";
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
                cmd = new OracleCommand("select * from tbl_karyawan where kode_karyawan LIKE '%" + txtCari.Text + "%' OR nama_karyawan LIKE '%" + txtCari.Text + "%'", con);
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Kode Karyawan";
                dataGridView1.Columns[1].HeaderText = "Nama Karyawan";
                dataGridView1.Columns[2].HeaderText = "Nomor Telepon";
                dataGridView1.Columns[3].HeaderText = "Alamat";
                dataGridView1.Columns[4].HeaderText = "Status Karyawan";
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
            if (txtKode.Text != "" && txtNama.Text != "" && txtTelepon.Text != "" && txtAlamat.Text != "" && cbStatus.SelectedIndex!=0)
            {
                try
                {
                    con.Close();
                    cmd = new OracleCommand("insert into tbl_karyawan(kode_karyawan,nama_karyawan,no_telp,alamat_karyawan, status) values(:kode,:nama,:telepon,:alamat, :status)", con);
                    con.Open();
                    cmd.Parameters.Add(new OracleParameter(":kode", txtKode.Text));
                    cmd.Parameters.Add(new OracleParameter(":nama", txtNama.Text));
                    cmd.Parameters.Add(new OracleParameter(":telepon", txtTelepon.Text));
                    cmd.Parameters.Add(new OracleParameter(":alamat", txtAlamat.Text));
                    cmd.Parameters.Add(new OracleParameter(":status", cbStatus.SelectedItem.ToString()));
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
            txtKode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelepon.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAlamat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtKode.Enabled = false;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtKode.Text != "" && txtNama.Text != "" && txtTelepon.Text != "" && txtAlamat.Text != "" && cbStatus.SelectedIndex != 0)
            {
                con.Close();
                cmd = new OracleCommand("update tbl_karyawan set nama_karyawan='"+txtNama.Text+"',no_telp='"+txtTelepon.Text+"',alamat_karyawan='"+txtAlamat.Text+"', status='"+cbStatus.SelectedItem.ToString()+"' where kode_karyawan='"+txtKode.Text+"'", con);
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
                cmd = new OracleCommand("delete tbl_karyawan where kode_karyawan=:kode", con);
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
                MessageBox.Show("Gagal hapus", "Gagal");
            }  
        }

        private void btKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            CariData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbJam.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
