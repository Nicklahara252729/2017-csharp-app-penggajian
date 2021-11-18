using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPenggajian
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            var konek = koneksi.koneksidata();
            konek.Close();
            Application.Exit();
        }

        private void btn_close_MouseHover(object sender, EventArgs e)
        {
            btn_close.ForeColor = Color.Black;
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.ForeColor = Color.White;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
                
                try
                {
                    string user="", pass="";
                    using (OracleConnection conn = new OracleConnection("User ID=dbpenggajian" + ";Password=123" + ";Data Source='XE" + "';"))
                    using (OracleCommand cmd = new OracleCommand
                        ("select * from users where NICKNAME='" + txtuser.Text + "' and KATASANDI ='" + txtpass.Text + "'", conn))
                    {
                        conn.Open();
                        using (OracleDataReader read = cmd.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                user = read["NICKNAME"].ToString();
                                pass = read["KATASANDI"].ToString();
                                if (txtuser.Text == user && txtpass.Text == pass)
                                {
                                    Home fm1 = new Home();
                                    this.Hide();
                                    fm1.ShowDialog();
                                    
                                }
                            }

                            if (txtuser.Text != user && txtpass.Text != pass)
                            {
                                txtuser.Text = "Username";
                                txtpass.Text = "Password";
                                MessageBox.Show("Username dan Password tidak sesuai", "Peringatan");
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    txtuser.Text = "Username";
                    txtpass.Text = "Password";
                    MessageBox.Show(ex.Message);
                }
            
        }
    }
}
