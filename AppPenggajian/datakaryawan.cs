using DevComponents.DotNetBar.Controls;
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
    public partial class datakaryawan : Form
    {
        public datakaryawan()
        {
            InitializeComponent();
            slideform.IsOpen = true;
            slidegrid.IsOpen = false;
            tampilgrid();
            kodejabatan();
            kodegolongan();
        }

        private void datakaryawan_Load(object sender, EventArgs e)
        {
            
        }

        private void ChangeSlideSide(eSlideSide Side)
        {
            slideform.SlideSide = Side;
        }

        private void slideright_Click(object sender, EventArgs e)
        {
            slideform.IsOpen = false;
            slidegrid.IsOpen = true;
            ChangeSlideSide(eSlideSide.Left);
        }

        private void slideleft_Click(object sender, EventArgs e)
        {
            slidegrid.IsOpen = false;
            slideform.IsOpen = true;
            ChangeSlideSide(eSlideSide.Left);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home fm = new Home();
            fm.ShowDialog();
        }

        public void tampilgrid()
        {
            try
            {
                var kon = koneksi2.koneksiget();
                using (OracleCommand cmd = new OracleCommand
                    ("select * from tblkaryawan ",kon))
                {
                    kon.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);
                        griddata.DataSource = data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void kodejabatan()
        {
            try
            {
                var kon = koneksi2.koneksiget();
                using (OracleCommand cmd = new OracleCommand
                    ("select * from tbljabatan",kon))
                {
                    kon.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kodejbt.AddItem(reader["KODEJABATAN"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void kodegolongan()
        {
            try
            {
                var kon = koneksi2.koneksiget();
                using (OracleCommand cmd = new OracleCommand
                    ("select * from tblgolongan", kon))
                {
                    kon.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kodeglg.AddItem(reader["KODEGOLONGAN"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format
                    ("insert into tblkaryawan values('" + this.txtnik.Text + "','" + this.txtnama.Text + "','" + this.jenkel.selectedValue + "','" + this.status.selectedValue + "','" + this.agama.selectedValue + "','" + this.kodejbt.selectedValue + "','" + this.kodeglg.selectedValue + "')");
                var kon = koneksi.koneksidata();
                var cmd = kon.CreateCommand();
                cmd.CommandText = query;
                kon.Open();
                cmd.ExecuteNonQuery();
                kon.Close();
                kon.Dispose();
                cmd.Dispose();
                txtnik.Text = "NIK";
                txtnama.Text = "NAMA";
                jenkel.Clear();
                status.Clear();
                agama.Clear();
                kodeglg.Clear();
                kodejbt.Clear();
                MessageBox.Show("Data berhasil di tambah");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            tampilgrid();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
