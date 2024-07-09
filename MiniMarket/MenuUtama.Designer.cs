namespace MiniMarket
{
    partial class MenuUtama
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
            menuStrip1 = new MenuStrip();
            DataMaster = new ToolStripMenuItem();
            DataPegawai = new ToolStripMenuItem();
            DataBarang = new ToolStripMenuItem();
            DataKategori = new ToolStripMenuItem();
            DataUser = new ToolStripMenuItem();
            DataRole = new ToolStripMenuItem();
            DataSuplaier = new ToolStripMenuItem();
            DataMember = new ToolStripMenuItem();
            DataSatuan = new ToolStripMenuItem();
            Transaksi = new ToolStripMenuItem();
            DataTransaksi = new ToolStripMenuItem();
            DetailTransaksi = new ToolStripMenuItem();
            DataBarangMasuk = new ToolStripMenuItem();
            DetailBarangMasuk = new ToolStripMenuItem();
            Back = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            User = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { DataMaster, Transaksi, Back });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(509, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // DataMaster
            // 
            DataMaster.DropDownItems.AddRange(new ToolStripItem[] { DataPegawai, DataBarang, DataKategori, DataUser, DataRole, DataSuplaier, DataMember, DataSatuan });
            DataMaster.Name = "DataMaster";
            DataMaster.Size = new Size(104, 24);
            DataMaster.Text = "Data Master";
            // 
            // DataPegawai
            // 
            DataPegawai.Name = "DataPegawai";
            DataPegawai.Size = new Size(224, 26);
            DataPegawai.Text = "Data Pegawai";
            DataPegawai.Click += DataPegawai_Click;
            // 
            // DataBarang
            // 
            DataBarang.Name = "DataBarang";
            DataBarang.Size = new Size(224, 26);
            DataBarang.Text = "Data Barang";
            // 
            // DataKategori
            // 
            DataKategori.Name = "DataKategori";
            DataKategori.Size = new Size(224, 26);
            DataKategori.Text = "Data Kategori";
            // 
            // DataUser
            // 
            DataUser.Name = "DataUser";
            DataUser.Size = new Size(224, 26);
            DataUser.Text = "Data User";
            DataUser.Click += DataUser_Click;
            // 
            // DataRole
            // 
            DataRole.Name = "DataRole";
            DataRole.Size = new Size(224, 26);
            DataRole.Text = "Data Role";
            DataRole.Click += DataRole_Click;
            // 
            // DataSuplaier
            // 
            DataSuplaier.Name = "DataSuplaier";
            DataSuplaier.Size = new Size(224, 26);
            DataSuplaier.Text = "Data Suplaier";
            // 
            // DataMember
            // 
            DataMember.Name = "DataMember";
            DataMember.Size = new Size(224, 26);
            DataMember.Text = "Data Member";
            // 
            // DataSatuan
            // 
            DataSatuan.Name = "DataSatuan";
            DataSatuan.Size = new Size(224, 26);
            DataSatuan.Text = "Data Satuan";
            // 
            // Transaksi
            // 
            Transaksi.DropDownItems.AddRange(new ToolStripItem[] { DataTransaksi, DetailTransaksi, DataBarangMasuk, DetailBarangMasuk });
            Transaksi.Name = "Transaksi";
            Transaksi.Size = new Size(82, 24);
            Transaksi.Text = "Transaksi";
            // 
            // DataTransaksi
            // 
            DataTransaksi.Name = "DataTransaksi";
            DataTransaksi.Size = new Size(229, 26);
            DataTransaksi.Text = "Data Transaksi";
            // 
            // DetailTransaksi
            // 
            DetailTransaksi.Name = "DetailTransaksi";
            DetailTransaksi.Size = new Size(229, 26);
            DetailTransaksi.Text = "Detail Transaksi";
            // 
            // DataBarangMasuk
            // 
            DataBarangMasuk.Name = "DataBarangMasuk";
            DataBarangMasuk.Size = new Size(229, 26);
            DataBarangMasuk.Text = "Data Barang Masuk";
            // 
            // DetailBarangMasuk
            // 
            DetailBarangMasuk.Name = "DetailBarangMasuk";
            DetailBarangMasuk.Size = new Size(229, 26);
            DetailBarangMasuk.Text = "Detail Barang Masuk";
            // 
            // Back
            // 
            Back.Name = "Back";
            Back.Size = new Size(54, 24);
            Back.Text = "Back";
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 151);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 1;
            label1.Text = "Anda Masuk Sebagai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(186, 38);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 2;
            label2.Text = "MenuUtama";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(221, 191);
            User.Name = "User";
            User.Size = new Size(43, 20);
            User.TabIndex = 3;
            User.Text = "User";
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 331);
            Controls.Add(User);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuUtama";
            Text = "MenuUtama";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem DataMaster;
        private ToolStripMenuItem DataPegawai;
        private ToolStripMenuItem DataUser;
        private ToolStripMenuItem DataRole;
        private ToolStripMenuItem Transaksi;
        private ToolStripMenuItem Back;
        private ToolStripMenuItem DataBarang;
        private ToolStripMenuItem DataKategori;
        private ToolStripMenuItem DataMember;
        private ToolStripMenuItem DataSuplaier;
        private ToolStripMenuItem dataMemberToolStripMenuItem1;
        private ToolStripMenuItem DataSatuan;
        private ToolStripMenuItem DataTransaksi;
        private ToolStripMenuItem DetailTransaksi;
        private ToolStripMenuItem DataBarangMasuk;
        private ToolStripMenuItem DetailBarangMasuk;
        private Label label1;
        private Label label2;
        private Label User;
    }
}