using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_UAS
{
    public partial class FRM_MENU_UTAMA : Form
    {
        public FRM_MENU_UTAMA()
        {
            InitializeComponent();
            lbJam.Text = DateTime.Now.ToLongTimeString();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void dataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BARANG FRM_BARANG = new FRM_BARANG();
            FRM_BARANG.MdiParent = this;
            FRM_BARANG.Show();
        }

        private void dataPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PELANGGAN FRM_PELANGGAN = new FRM_PELANGGAN();
            FRM_PELANGGAN.MdiParent = this;
            FRM_PELANGGAN.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin keluar?", "Keluar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    var FRM_LOGIN = new FRM_LOGIN();
                    FRM_LOGIN.ShowDialog();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        

        private void penjualanBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PENJUALAN FRM_PENJUALAN = new FRM_PENJUALAN();
            FRM_PENJUALAN.MdiParent = this;
            FRM_PENJUALAN.Show();
        }

        private void ubahPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_UBAH_PASSWORD FRM_UBAH_PASSWORD = new FRM_UBAH_PASSWORD();
            FRM_UBAH_PASSWORD.MdiParent = this;
            FRM_UBAH_PASSWORD.Show();
        }

        private void dataKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_KARYAWAN FRM_KARYAWAN = new FRM_KARYAWAN();
            FRM_KARYAWAN.MdiParent = this;
            FRM_KARYAWAN.Show();
        }

        private void penerimaanBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PENERIMAAN FRM_PENERIMAAN = new FRM_PENERIMAAN();
            FRM_PENERIMAAN.MdiParent = this;
            FRM_PENERIMAAN.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbJam.Text = DateTime.Now.ToLongTimeString();
        }

        
    }
}
