using DevComponents.DotNetBar.Controls;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            sld_perhitungan_gaji.IsOpen = false;
            sld_kelola_jabatan.IsOpen = false;
            sld_kelola_golongan.IsOpen = false;
            sld_data_karyawan.IsOpen = false;
            sld_data_gaji.IsOpen = false;
            sld_section_one.IsOpen = true;
            sld_section_two.IsOpen = false;
        }

      
        private void pct_close_Click(object sender, EventArgs e)
        {
            DialogResult pesan =
            MessageBox.Show("Aplikasi akan di tutup", "Peringatan", MessageBoxButtons.YesNo);
            if (pesan == DialogResult.Yes)
            {
                this.Hide();
                login login = new login();
                login.ShowDialog();
            }
            //Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void ChangeSlideSide(eSlideSide side)
        {
            sld_perhitungan_gaji.SlideSide = side;
        }

        private void pct_menu_perhitungan_gaji_MouseEnter(object sender, EventArgs e)
        {
            sld_perhitungan_gaji.IsOpen = true;
        }

        private void pct_menu_perhitungan_gaji_MouseLeave(object sender, EventArgs e)
        {
            sld_perhitungan_gaji.IsOpen = false;
        }

        private void pct_menu_jabatan_MouseEnter(object sender, EventArgs e)
        {
            sld_kelola_jabatan.IsOpen = true;
        }

        private void pct_menu_jabatan_MouseLeave(object sender, EventArgs e)
        {
            sld_kelola_jabatan.IsOpen = false;
        }

        private void pct_kelola_golongan_MouseEnter(object sender, EventArgs e)
        {
            sld_kelola_golongan.IsOpen = true;
        }

        private void pct_kelola_golongan_MouseLeave(object sender, EventArgs e)
        {
            sld_kelola_golongan.IsOpen = false;
        }

        private void pct_data_karyawan_MouseEnter(object sender, EventArgs e)
        {
            sld_data_karyawan.IsOpen = true;
        }

        private void pct_data_karyawan_MouseLeave(object sender, EventArgs e)
        {
            sld_data_karyawan.IsOpen = false;
        }

        private void pct_data_gaji_MouseEnter(object sender, EventArgs e)
        {
            sld_data_gaji.IsOpen = true;
        }

        private void pct_data_gaji_MouseLeave(object sender, EventArgs e)
        {
            sld_data_gaji.IsOpen = false;
        }

        private void pct_slide_section_left_Click(object sender, EventArgs e)
        {
            sld_section_one.IsOpen = false;
            sld_section_two.IsOpen = true;
        }

        private void pct_slide_section_right_Click(object sender, EventArgs e)
        {
            sld_section_one.IsOpen = true;
            sld_section_two.IsOpen = false;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btn_kelola_jabatan_Click(object sender, EventArgs e)
        {
            this.Hide();
            kelolajabatan jbt = new kelolajabatan();
            jbt.ShowDialog();
        }

        private void btn_perhitungan_gaji_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_data_karyawan_Click(object sender, EventArgs e)
        {
            this.Hide();
            datakaryawan kar = new datakaryawan();
            kar.ShowDialog();
        }

        private void btn_kelola_golongan_Click(object sender, EventArgs e)
        {
            this.Hide();
            golongan gol = new golongan();
            gol.ShowDialog();
            
        }

     
    }
}
