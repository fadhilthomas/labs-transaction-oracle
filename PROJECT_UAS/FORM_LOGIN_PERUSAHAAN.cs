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
    public partial class FORM_LOGIN_PERUSAHAAN : Form
    {
        public FORM_LOGIN_PERUSAHAAN()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 0;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int n = cbStatus.SelectedIndex;
                switch (n)
                {
                    case 0:
                        MessageBox.Show("Pilih status akun Anda.", "Login");
                        break;
                    case 1:
                        this.Hide();
                        FRM_LOGIN FRM_LOGIN = new FRM_LOGIN();
                        FRM_LOGIN.Closed += (s, args) => this.Close();
                        FRM_LOGIN.ShowDialog();
                        break;
                    case 2:
                        this.Hide();
                        FORM_LOGIN_PENAMAS FORM_LOGIN_PENAMAS = new FORM_LOGIN_PENAMAS();
                        FORM_LOGIN_PENAMAS.Closed += (s, args) => this.Close();
                        FORM_LOGIN_PENAMAS.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
