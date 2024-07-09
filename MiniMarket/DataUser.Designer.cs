namespace MiniMarket
{
    partial class DataUser
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
            TextUser = new TextBox();
            TextNama = new TextBox();
            TextPassword = new TextBox();
            TextPegawai = new TextBox();
            TextRole = new TextBox();
            BtnTambah = new Button();
            BtnSimpan = new Button();
            BtnUbah = new Button();
            BtnBack = new Button();
            Data_Pegawai = new DataGridView();
            Kode1 = new DataGridViewTextBoxColumn();
            Pegawai = new DataGridViewTextBoxColumn();
            Jenis = new DataGridViewTextBoxColumn();
            No = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            label7 = new Label();
            Data_Role = new DataGridView();
            Kode2 = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            label8 = new Label();
            Data_User = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)Data_Pegawai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Data_Role).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Data_User).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(853, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Data User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 65);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Kode User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 133);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 167);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 4;
            label5.Text = "Nama Pegawai";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 201);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 5;
            label6.Text = "Nama Role";
            // 
            // TextUser
            // 
            TextUser.Location = new Point(135, 62);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(125, 28);
            TextUser.TabIndex = 6;
            // 
            // TextNama
            // 
            TextNama.Location = new Point(135, 96);
            TextNama.Name = "TextNama";
            TextNama.Size = new Size(125, 28);
            TextNama.TabIndex = 7;
            TextNama.KeyPress += TextNama_KeyPress;
            // 
            // TextPassword
            // 
            TextPassword.Location = new Point(135, 130);
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(125, 28);
            TextPassword.TabIndex = 8;
            TextPassword.KeyPress += TextPassword_KeyPress;
            // 
            // TextPegawai
            // 
            TextPegawai.Location = new Point(135, 164);
            TextPegawai.Name = "TextPegawai";
            TextPegawai.Size = new Size(125, 28);
            TextPegawai.TabIndex = 9;
            // 
            // TextRole
            // 
            TextRole.Location = new Point(135, 198);
            TextRole.Name = "TextRole";
            TextRole.Size = new Size(125, 28);
            TextRole.TabIndex = 10;
            // 
            // BtnTambah
            // 
            BtnTambah.Location = new Point(12, 248);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(94, 29);
            BtnTambah.TabIndex = 11;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Location = new Point(112, 248);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(94, 29);
            BtnSimpan.TabIndex = 12;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnUbah
            // 
            BtnUbah.Location = new Point(212, 248);
            BtnUbah.Name = "BtnUbah";
            BtnUbah.Size = new Size(94, 29);
            BtnUbah.TabIndex = 13;
            BtnUbah.Text = "Ubah";
            BtnUbah.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(312, 248);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 14;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            // 
            // Data_Pegawai
            // 
            Data_Pegawai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Pegawai.Columns.AddRange(new DataGridViewColumn[] { Kode1, Pegawai, Jenis, No, Alamat });
            Data_Pegawai.Location = new Point(449, 89);
            Data_Pegawai.Name = "Data_Pegawai";
            Data_Pegawai.RowHeadersWidth = 51;
            Data_Pegawai.RowTemplate.Height = 29;
            Data_Pegawai.Size = new Size(888, 361);
            Data_Pegawai.TabIndex = 15;
            Data_Pegawai.CellClick += Data_Pegawai_CellClick;
            // 
            // Kode1
            // 
            Kode1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kode1.HeaderText = "Kode Pegawai";
            Kode1.MinimumWidth = 6;
            Kode1.Name = "Kode1";
            // 
            // Pegawai
            // 
            Pegawai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pegawai.HeaderText = "Nama Pegawai";
            Pegawai.MinimumWidth = 6;
            Pegawai.Name = "Pegawai";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(449, 62);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 16;
            label7.Text = "Tabel Pegawai";
            // 
            // Data_Role
            // 
            Data_Role.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Role.Columns.AddRange(new DataGridViewColumn[] { Kode2, Role });
            Data_Role.Location = new Point(1356, 89);
            Data_Role.Name = "Data_Role";
            Data_Role.RowHeadersWidth = 51;
            Data_Role.RowTemplate.Height = 29;
            Data_Role.Size = new Size(556, 361);
            Data_Role.TabIndex = 17;
            Data_Role.CellClick += Data_Role_CellClick;
            // 
            // Kode2
            // 
            Kode2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kode2.HeaderText = "Kode Role";
            Kode2.MinimumWidth = 6;
            Kode2.Name = "Kode2";
            // 
            // Role
            // 
            Role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Role.HeaderText = "Nama Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1356, 62);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 18;
            label8.Text = "Tabel Role";
            // 
            // Data_User
            // 
            Data_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_User.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            Data_User.Location = new Point(449, 504);
            Data_User.Name = "Data_User";
            Data_User.RowHeadersWidth = 51;
            Data_User.RowTemplate.Height = 29;
            Data_User.Size = new Size(1463, 539);
            Data_User.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Kode Pegawai";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Nama Pegawai";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Jenis Kelamin";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "No Hp";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Alamat";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(449, 470);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 20;
            label9.Text = "Tabel User";
            // 
            // DataUser
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label9);
            Controls.Add(Data_User);
            Controls.Add(label8);
            Controls.Add(Data_Role);
            Controls.Add(label7);
            Controls.Add(Data_Pegawai);
            Controls.Add(BtnBack);
            Controls.Add(BtnUbah);
            Controls.Add(BtnSimpan);
            Controls.Add(BtnTambah);
            Controls.Add(TextRole);
            Controls.Add(TextPegawai);
            Controls.Add(TextPassword);
            Controls.Add(TextNama);
            Controls.Add(TextUser);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataUser";
            Text = "DataUser";
            FormClosing += DataUser_FormClosing;
            Load += DataUser_Load;
            ((System.ComponentModel.ISupportInitialize)Data_Pegawai).EndInit();
            ((System.ComponentModel.ISupportInitialize)Data_Role).EndInit();
            ((System.ComponentModel.ISupportInitialize)Data_User).EndInit();
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
        private TextBox TextUser;
        private TextBox TextNama;
        private TextBox TextPassword;
        private TextBox TextPegawai;
        private TextBox TextRole;
        private Button BtnTambah;
        private Button BtnSimpan;
        private Button BtnUbah;
        private Button BtnBack;
        private DataGridView Data_Pegawai;
        private Label label7;
        private DataGridView Data_Role;
        private DataGridViewTextBoxColumn Kode1;
        private DataGridViewTextBoxColumn Pegawai;
        private DataGridViewTextBoxColumn Jenis;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewTextBoxColumn Kode2;
        private DataGridViewTextBoxColumn Role;
        private Label label8;
        private DataGridView Data_User;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label9;
    }
}