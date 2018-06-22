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
    public partial class FORM_MENU_UTAMA_PENAMAS : Form
    {
        public FORM_MENU_UTAMA_PENAMAS()
        {
            InitializeComponent();
        }

        private void dataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_BARANG_PENAMAS x = new FORM_BARANG_PENAMAS();
            x.MdiParent = this;
            x.Show();
        }

        private void dataPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_PELANGGAN_PENAMAS x = new FORM_PELANGGAN_PENAMAS();
            x.MdiParent = this;
            x.Show();
        }

        private void dataSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_SALES_PENAMAS x = new FORM_SALES_PENAMAS();
            x.MdiParent = this;
            x.Show();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_PENJUALAN_PENAMAS x = new FORM_PENJUALAN_PENAMAS();
            x.MdiParent = this;
            x.Show();
        }

        private void logOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FORM_LOGIN_PENAMAS x = new FORM_LOGIN_PENAMAS();
            x.Show();
            
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void lAPORANPENJUALANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FORM_LAPORAN_PENJUALAN_PENAMAS x = new FORM_LAPORAN_PENJUALAN_PENAMAS();
            //x.Show();
        }

        private void penerimaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_PENERIMAAN_PENAMAS x = new FORM_PENERIMAAN_PENAMAS();
            x.MdiParent = this;
            x.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin keluar?", "Keluar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    FORM_LOGIN_PENAMAS x = new FORM_LOGIN_PENAMAS();
                    x.ShowDialog();
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
    }
}
