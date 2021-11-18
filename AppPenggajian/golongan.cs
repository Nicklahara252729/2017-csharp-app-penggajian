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
    public partial class golongan : Form
    {
        public golongan()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.ShowDialog();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("insert into tblgolongan values('" + this.txtkodegolongan.Text + "','" + this.txtgajipokok.Text + "','" + this.txttunjanganaka.Text + "','" + this.txttunjangantrans.Text + "')");
                var kon = koneksi.koneksidata();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose();
                txtgajipokok.Text = "Gaji Pokok";
                txtkodegolongan.Text = "Kode Golongan ( Rp )";
                txttunjanganaka.Text = "Tunjangan Akademik ( Rp )";
                txttunjangantrans.Text = "Tunjangan Transporasi ( Rp )";
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
                string query = string.Format("update tblgolongan set gajipokok='" + this.txtgajipokok.Text + "',tunjanganakademik='" + this.txttunjanganaka.Text + "',tunjangantransport='" + this.txttunjangantrans.Text + "' where kodegolongan='" + this.txtkodegolongan.Text + "'");
                var kon = koneksi.koneksidata();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose();
                txtgajipokok.Text = "Gaji Pokok ( Rp )";
                txtkodegolongan.Text = "Kode Golongan ";
                txttunjanganaka.Text = "Tunjangan Akademik ( Rp )";
                txttunjangantrans.Text = "Tunjangan Transportasi ( Rp )";
                MessageBox.Show("Data berhasil di ubah");
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
                string query = string.Format("delete from tblgolongan where kodegolongan='" + this.txtkodegolongan.Text + "'");
                var kon = koneksi.koneksidata();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose();
                txtgajipokok.Text = "Gaji Pokok ( Rp )";
                txtkodegolongan.Text = "Kode Golongan";
                txttunjanganaka.Text = "Tunjangan Akadmik ( Rp )";
                txttunjangantrans.Text = "Tunjanan Transport ( Rp )";
                MessageBox.Show("Data berhasil di hapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
