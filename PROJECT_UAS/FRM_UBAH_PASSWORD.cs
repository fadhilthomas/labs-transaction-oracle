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
    public partial class FRM_UBAH_PASSWORD : Form
    {
        OracleConnection con = new OracleConnection("Data Source=XE;User Id=KARYA;Password=123_Qwerty");
        OracleConnection con2 = new OracleConnection("Data Source=XE;User Id=KARYA;Password=123_Qwerty");
        OracleCommand cmd, cmd2;
        
        public FRM_UBAH_PASSWORD()
        {
            InitializeComponent();
        }

        private void btUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text != string.Empty)
                {
                    if (txtPass.Text != string.Empty)
                    {
                        if (txtPassBaru.Text != string.Empty)
                            {
                                if (txtPassBaru2.Text == txtPassBaru.Text)
                                {

                                    String query = "select * from tbl_hak_akses where username = '" + txtUser.Text + "' and password = '" + txtPass.Text + "'";
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
                                        cmd2 = new OracleCommand("update tbl_hak_akses set password='"+txtPassBaru.Text+"' where username='"+txtUser.Text+"'", con2);
                                        con2.Open();
                                        cmd2.ExecuteNonQuery();
                                        MessageBox.Show("Ubah Password Berhasil");
                                        txtUser.Text = "";
                                        txtPass.Text = "";
                                        txtPassBaru.Text = "";
                                        txtPassBaru2.Text = "";
                                        con2.Close();
                                    }
                                    else if (count > 1)
                                    {
                                        MessageBox.Show("Username dan Password tidak boleh sama.", "Login");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Username, Password lama salah.", "Login");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Password baru tidak cocok.", "Login");
                                }
                        }
                        else
                        {
                            MessageBox.Show("Password baru tidak boleh kosong.", "Login");
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
    }
}
