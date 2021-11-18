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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            slide_kelola.IsOpen = false;
            slide_gaji.IsOpen = false;
            slide_golongan.IsOpen = false;
            slide_hitung.IsOpen = false;
            slide_karyawan.IsOpen = false;
        }

       private void ChangeSlideSide(eSlideSide side)
        {
            slide_kelola.SlideSide = side;
        }

       private void pct_kelola_jabatan_MouseEnter(object sender, EventArgs e)
       {
           slide_kelola.IsOpen = true;
           ChangeSlideSide(eSlideSide.Left);
       }

       private void pct_kelola_jabatan_MouseLeave(object sender, EventArgs e)
       {
           slide_kelola.IsOpen = false;
       }

       private void btn_close_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }

       private void pnl_menu_Paint(object sender, PaintEventArgs e)
       {

       }

       private void pct_kelola_jabatan_MouseHover(object sender, EventArgs e)
       {
         
       }

       private void pct_perhitungan_gaji_MouseEnter(object sender, EventArgs e)
       {
           slide_hitung.IsOpen = true;
           ChangeSlideSide(eSlideSide.Left);
       }

       private void pct_perhitungan_gaji_MouseLeave(object sender, EventArgs e)
       {
           slide_hitung.IsOpen = false;
       }

       private void pct_golongan_MouseEnter(object sender, EventArgs e)
       {
           slide_golongan.IsOpen = true;
           ChangeSlideSide(eSlideSide.Left);
       }

       private void pct_golongan_MouseLeave(object sender, EventArgs e)
       {
           slide_golongan.IsOpen = false;
       }

       private void pct_karyawan_MouseEnter(object sender, EventArgs e)
       {
           slide_karyawan.IsOpen = true;
           ChangeSlideSide(eSlideSide.Left);
       }

       private void pct_karyawan_MouseLeave(object sender, EventArgs e)
       {
           slide_karyawan.IsOpen = false;
       }

       private void pct_gaji_MouseEnter(object sender, EventArgs e)
       {
           slide_gaji.IsOpen = true;
           ChangeSlideSide(eSlideSide.Left);
       }

       private void pct_gaji_MouseLeave(object sender, EventArgs e)
       {
           slide_gaji.IsOpen = false;
       }

       private void pnl_section_one_Paint(object sender, PaintEventArgs e)
       {

       }

       private void pnl_header_Paint(object sender, PaintEventArgs e)
       {

       }
    }
}
