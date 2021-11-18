namespace AppPenggajian
{
    partial class kelolajabatan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.btndelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txttunjangan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtkodejabatan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnupdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.txttunjangan);
            this.panel2.Controls.Add(this.txtkodejabatan);
            this.panel2.Location = new System.Drawing.Point(305, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 321);
            this.panel2.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Wolf in the City Light", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label21.Location = new System.Drawing.Point(54, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(246, 49);
            this.label21.TabIndex = 4;
            this.label21.Text = "Kelola Jabatan";
            // 
            // btndelete
            // 
            this.btndelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(86)))), ((int)(((byte)(84)))));
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(86)))), ((int)(((byte)(84)))));
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndelete.BorderRadius = 0;
            this.btndelete.ButtonText = "DELETE";
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.DisabledColor = System.Drawing.Color.Gray;
            this.btndelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btndelete.Iconimage = null;
            this.btndelete.Iconimage_right = null;
            this.btndelete.Iconimage_right_Selected = null;
            this.btndelete.Iconimage_Selected = null;
            this.btndelete.IconMarginLeft = 0;
            this.btndelete.IconMarginRight = 0;
            this.btndelete.IconRightVisible = true;
            this.btndelete.IconRightZoom = 0D;
            this.btndelete.IconVisible = true;
            this.btndelete.IconZoom = 90D;
            this.btndelete.IsTab = false;
            this.btndelete.Location = new System.Drawing.Point(20, 245);
            this.btndelete.Name = "btndelete";
            this.btndelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(86)))), ((int)(((byte)(84)))));
            this.btndelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(86)))), ((int)(((byte)(84)))));
            this.btndelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btndelete.selected = false;
            this.btndelete.Size = new System.Drawing.Size(93, 48);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "DELETE";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.Textcolor = System.Drawing.Color.White;
            this.btndelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txttunjangan
            // 
            this.txttunjangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttunjangan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txttunjangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttunjangan.HintForeColor = System.Drawing.Color.Empty;
            this.txttunjangan.HintText = "";
            this.txttunjangan.isPassword = false;
            this.txttunjangan.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txttunjangan.LineIdleColor = System.Drawing.Color.Gray;
            this.txttunjangan.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txttunjangan.LineThickness = 3;
            this.txttunjangan.Location = new System.Drawing.Point(20, 186);
            this.txttunjangan.Margin = new System.Windows.Forms.Padding(4);
            this.txttunjangan.Name = "txttunjangan";
            this.txttunjangan.Size = new System.Drawing.Size(302, 33);
            this.txttunjangan.TabIndex = 1;
            this.txttunjangan.Text = "Tunjangan Struktural";
            this.txttunjangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtkodejabatan
            // 
            this.txtkodejabatan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtkodejabatan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtkodejabatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtkodejabatan.HintForeColor = System.Drawing.Color.Empty;
            this.txtkodejabatan.HintText = "";
            this.txtkodejabatan.isPassword = false;
            this.txtkodejabatan.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtkodejabatan.LineIdleColor = System.Drawing.Color.Gray;
            this.txtkodejabatan.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtkodejabatan.LineThickness = 3;
            this.txtkodejabatan.Location = new System.Drawing.Point(20, 127);
            this.txtkodejabatan.Margin = new System.Windows.Forms.Padding(4);
            this.txtkodejabatan.Name = "txtkodejabatan";
            this.txtkodejabatan.Size = new System.Drawing.Size(302, 33);
            this.txtkodejabatan.TabIndex = 0;
            this.txtkodejabatan.Text = "Kode Jabatan";
            this.txtkodejabatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnupdate
            // 
            this.btnupdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(15)))));
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(15)))));
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdate.BorderRadius = 0;
            this.btnupdate.ButtonText = "UPDATE";
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnupdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnupdate.Iconimage = null;
            this.btnupdate.Iconimage_right = null;
            this.btnupdate.Iconimage_right_Selected = null;
            this.btnupdate.Iconimage_Selected = null;
            this.btnupdate.IconMarginLeft = 0;
            this.btnupdate.IconMarginRight = 0;
            this.btnupdate.IconRightVisible = true;
            this.btnupdate.IconRightZoom = 0D;
            this.btnupdate.IconVisible = true;
            this.btnupdate.IconZoom = 90D;
            this.btnupdate.IsTab = false;
            this.btnupdate.Location = new System.Drawing.Point(128, 245);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(15)))));
            this.btnupdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(15)))));
            this.btnupdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnupdate.selected = false;
            this.btnupdate.Size = new System.Drawing.Size(89, 48);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupdate.Textcolor = System.Drawing.Color.White;
            this.btnupdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnsave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.BorderRadius = 0;
            this.btnsave.ButtonText = "SAVE";
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.DisabledColor = System.Drawing.Color.Gray;
            this.btnsave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsave.Iconimage = null;
            this.btnsave.Iconimage_right = null;
            this.btnsave.Iconimage_right_Selected = null;
            this.btnsave.Iconimage_Selected = null;
            this.btnsave.IconMarginLeft = 0;
            this.btnsave.IconMarginRight = 0;
            this.btnsave.IconRightVisible = true;
            this.btnsave.IconRightZoom = 0D;
            this.btnsave.IconVisible = true;
            this.btnsave.IconZoom = 90D;
            this.btnsave.IsTab = false;
            this.btnsave.Location = new System.Drawing.Point(230, 245);
            this.btnsave.Name = "btnsave";
            this.btnsave.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnsave.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnsave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsave.selected = false;
            this.btnsave.Size = new System.Drawing.Size(94, 48);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "SAVE";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.Textcolor = System.Drawing.Color.White;
            this.btnsave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Location = new System.Drawing.Point(859, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 42);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // kelolajabatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(946, 702);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kelolajabatan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kelolajabatan";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuFlatButton btndelete;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txttunjangan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtkodejabatan;
        private Bunifu.Framework.UI.BunifuFlatButton btnsave;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdate;
        private System.Windows.Forms.Button btn_close;
    }
}