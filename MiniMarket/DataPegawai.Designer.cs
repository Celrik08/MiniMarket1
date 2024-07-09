namespace MiniMarket
{
    partial class DataPegawai
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TextPegawai = new TextBox();
            TextNama = new TextBox();
            TextNo = new TextBox();
            TextAlamat = new TextBox();
            BtnTambah = new Button();
            Data_Pegawai = new DataGridView();
            Pegawai = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Jenis = new DataGridViewTextBoxColumn();
            No = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewButtonColumn();
            BtnSimpan = new Button();
            RadioLaki = new RadioButton();
            RadioPerempuan = new RadioButton();
            BtnBack = new Button();
            BtnUbah = new Button();
            ((System.ComponentModel.ISupportInitialize)Data_Pegawai).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(561, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 0;
            label1.Text = "Data Pegawai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 1;
            label2.Text = "Kode Pegawai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Nama Pegawai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 133);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 3;
            label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 167);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "No Hp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 201);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 5;
            label6.Text = "Alamat";
            // 
            // TextPegawai
            // 
            TextPegawai.Location = new Point(141, 62);
            TextPegawai.Name = "TextPegawai";
            TextPegawai.Size = new Size(125, 28);
            TextPegawai.TabIndex = 6;
            // 
            // TextNama
            // 
            TextNama.Location = new Point(141, 96);
            TextNama.Name = "TextNama";
            TextNama.Size = new Size(125, 28);
            TextNama.TabIndex = 7;
            TextNama.KeyPress += TextNama_KeyPress;
            // 
            // TextNo
            // 
            TextNo.Location = new Point(141, 164);
            TextNo.Name = "TextNo";
            TextNo.Size = new Size(125, 28);
            TextNo.TabIndex = 9;
            TextNo.KeyPress += TextNo_KeyPress;
            // 
            // TextAlamat
            // 
            TextAlamat.Location = new Point(141, 198);
            TextAlamat.Name = "TextAlamat";
            TextAlamat.Size = new Size(125, 28);
            TextAlamat.TabIndex = 10;
            TextAlamat.KeyPress += TextAlamat_KeyPress;
            // 
            // BtnTambah
            // 
            BtnTambah.Location = new Point(141, 249);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(94, 29);
            BtnTambah.TabIndex = 11;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // Data_Pegawai
            // 
            Data_Pegawai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Pegawai.Columns.AddRange(new DataGridViewColumn[] { Pegawai, Nama, Jenis, No, Alamat, Hapus });
            Data_Pegawai.Location = new Point(18, 305);
            Data_Pegawai.Name = "Data_Pegawai";
            Data_Pegawai.RowHeadersWidth = 51;
            Data_Pegawai.RowTemplate.Height = 29;
            Data_Pegawai.Size = new Size(1245, 463);
            Data_Pegawai.TabIndex = 12;
            Data_Pegawai.CellClick += Data_Pegawai_CellClick;
            Data_Pegawai.CellContentClick += Data_Pegawai_CellContentClick;
            // 
            // Pegawai
            // 
            Pegawai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pegawai.HeaderText = "Kode Pegawai";
            Pegawai.MinimumWidth = 6;
            Pegawai.Name = "Pegawai";
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.HeaderText = "Nama Pegawai";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            // 
            // Jenis
            // 
            Jenis.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Jenis.HeaderText = "Jenis Kelamin";
            Jenis.MinimumWidth = 6;
            Jenis.Name = "Jenis";
            // 
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            No.HeaderText = "No Hp";
            No.MinimumWidth = 6;
            No.Name = "No";
            // 
            // Alamat
            // 
            Alamat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Alamat.HeaderText = "Alamat";
            Alamat.MinimumWidth = 6;
            Alamat.Name = "Alamat";
            // 
            // Hapus
            // 
            Hapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hapus.HeaderText = "";
            Hapus.MinimumWidth = 6;
            Hapus.Name = "Hapus";
            Hapus.Text = "Hapus";
            Hapus.UseColumnTextForButtonValue = true;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Location = new Point(251, 249);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(94, 29);
            BtnSimpan.TabIndex = 13;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // RadioLaki
            // 
            RadioLaki.AutoSize = true;
            RadioLaki.Location = new Point(142, 131);
            RadioLaki.Name = "RadioLaki";
            RadioLaki.Size = new Size(93, 24);
            RadioLaki.TabIndex = 14;
            RadioLaki.TabStop = true;
            RadioLaki.Text = "Laki-laki";
            RadioLaki.UseVisualStyleBackColor = true;
            RadioLaki.KeyPress += RadioLaki_KeyPress;
            // 
            // RadioPerempuan
            // 
            RadioPerempuan.AutoSize = true;
            RadioPerempuan.Location = new Point(241, 131);
            RadioPerempuan.Name = "RadioPerempuan";
            RadioPerempuan.Size = new Size(112, 24);
            RadioPerempuan.TabIndex = 15;
            RadioPerempuan.TabStop = true;
            RadioPerempuan.Text = "Perempuan";
            RadioPerempuan.UseVisualStyleBackColor = true;
            RadioPerempuan.KeyPress += RadioPerempuan_KeyPress;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(451, 249);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 16;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnUbah
            // 
            BtnUbah.Location = new Point(351, 249);
            BtnUbah.Name = "BtnUbah";
            BtnUbah.Size = new Size(94, 29);
            BtnUbah.TabIndex = 17;
            BtnUbah.Text = "Ubah";
            BtnUbah.UseVisualStyleBackColor = true;
            BtnUbah.Click += BtnUbah_Click;
            // 
            // DataPegawai
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 780);
            Controls.Add(BtnUbah);
            Controls.Add(BtnBack);
            Controls.Add(RadioPerempuan);
            Controls.Add(RadioLaki);
            Controls.Add(BtnSimpan);
            Controls.Add(Data_Pegawai);
            Controls.Add(BtnTambah);
            Controls.Add(TextAlamat);
            Controls.Add(TextNo);
            Controls.Add(TextNama);
            Controls.Add(TextPegawai);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataPegawai";
            Text = "DataPegawai";
            FormClosing += DataPegawai_FormClosing;
            Load += DataPegawai_Load;
            ((System.ComponentModel.ISupportInitialize)Data_Pegawai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TextPegawai;
        private TextBox TextNama;
        private TextBox TextNo;
        private TextBox TextAlamat;
        private Button BtnTambah;
        private DataGridView Data_Pegawai;
        private Button BtnSimpan;
        private RadioButton RadioLaki;
        private RadioButton RadioPerempuan;
        private Button BtnBack;
        private Button BtnUbah;
        private DataGridViewTextBoxColumn Pegawai;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Jenis;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewButtonColumn Hapus;
    }
}