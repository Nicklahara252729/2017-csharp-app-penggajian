using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPenggajian
{
    public partial class kelolajabatan : Form
    {
        public kelolajabatan()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string query = string.Format
                        ("insert into tbljabatan values('" + this.txtkodejabatan.Text + "','" + this.txttunjangan.Text + "')");
                    var kon = koneksi.koneksidata();
                    var cmd = kon.CreateCommand();
                    cmd.CommandText = query;
                    kon.Open();
                    cmd.ExecuteNonQuery();
                    kon.Close();
                    kon.Dispose();
                    cmd.Dispose();
                    txtkodejabatan.Text = "Kode Jabatan";
                    txttunjangan.Text = "Tunjangan Struktural";
                    MessageBox.Show("Data berhasil di simpan");
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("update TBLJABATAN set kodejabatan='" + this.txtkodejabatan.Text + "', tunjanganstruktural='" + this.txttunjangan.Text + "'");
                var kon = koneksi.koneksidata();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose();
                txtkodejabatan.Text = "Kode Jabatan";
                txttunjangan.Text = "Tunjangan Struktural";
                MessageBox.Show("Data berhasil di update");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("delete from tbljabatan where kodejabatan = '" + this.txtkodejabatan.Text + "'");
                var kon = koneksi.koneksidata();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose();
                txtkodejabatan.Text = "Kode Jabatan";
                txttunjangan.Text = "Tunjangan Struktural";
                MessageBox.Show("Data berhasil di hapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
