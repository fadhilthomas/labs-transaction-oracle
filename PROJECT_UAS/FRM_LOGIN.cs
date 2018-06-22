using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace PROJECT_UAS
{
    public partial class FRM_LOGIN : Form
    {
        OracleConnection con = new OracleConnection("Data Source=XE;User Id=KARYA;Password=123_Qwerty");
        OracleCommand cmd;
        
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text != string.Empty)
                {
                    if (txtPass.Text != string.Empty)
                    {
                        if (cbStatus.SelectedIndex != 0)
                        {
                            con.Close();
                            String query = "select * from tbl_hak_akses where username = '" + txtUser.Text + "' and password = '" + txtPass.Text + "' and status = '" + cbStatus.SelectedItem.ToString() + "' and perusahaan='ALIE JAYA'";
                            cmd = new OracleCommand(query, con);
                            OracleDataReader dbr;
                            con.Open();
                            dbr = cmd.ExecuteReader();
                            int count = 0;
                            while (dbr.Read())
                            {
                                count += 1;
                            }
                            if (count == 1)
                            {
                                MessageBox.Show("Welcome, " + txtUser.Text,"Login Berhasil.");
                                this.Hide();
                                var FRM_MENU_UTAMA = new FRM_MENU_UTAMA();
                                FRM_MENU_UTAMA.Closed += (s, args) => this.Close();
                                FRM_MENU_UTAMA.ShowDialog();
                            }
                            else if (count > 1)
                            {
                                MessageBox.Show("Username dan Password tidak boleh sama.", "Login");
                            }
                            else
                            {
                                MessageBox.Show("Username, Password, atau Status salah.", "Login");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Pilih status akun Anda.", "Login");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password tidak boleh kosong.", "Login");
                    }
                }
                else
                {
                    MessageBox.Show("Username tidak boleh kosong.", "Login");
                }
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = 0;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FORM_LOGIN_PERUSAHAAN FORM_LOGIN_PERUSAHAAN = new FORM_LOGIN_PERUSAHAAN();
            FORM_LOGIN_PERUSAHAAN.Closed += (s, args) => this.Close();
            FORM_LOGIN_PERUSAHAAN.ShowDialog();
        }
    }
}
