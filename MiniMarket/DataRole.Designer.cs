namespace MiniMarket
{
    partial class DataRole
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
            TextRole = new TextBox();
            TextNama = new TextBox();
            BtnTambah = new Button();
            BtnSimpan = new Button();
            Data_Role = new DataGridView();
            BtnUbah = new Button();
            BtnBack = new Button();
            Role = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)Data_Role).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 19);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Data Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Kode Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Nama Role";
            // 
            // TextRole
            // 
            TextRole.Location = new Point(108, 70);
            TextRole.Name = "TextRole";
            TextRole.Size = new Size(169, 28);
            TextRole.TabIndex = 3;
            // 
            // TextNama
            // 
            TextNama.Location = new Point(108, 104);
            TextNama.Name = "TextNama";
            TextNama.Size = new Size(169, 28);
            TextNama.TabIndex = 4;
            TextNama.KeyPress += TextNama_KeyPress;
            // 
            // BtnTambah
            // 
            BtnTambah.Location = new Point(108, 157);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(94, 29);
            BtnTambah.TabIndex = 5;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Location = new Point(208, 157);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(94, 29);
            BtnSimpan.TabIndex = 6;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // Data_Role
            // 
            Data_Role.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Role.Columns.AddRange(new DataGridViewColumn[] { Role, Nama, Hapus });
            Data_Role.Location = new Point(12, 218);
            Data_Role.Name = "Data_Role";
            Data_Role.RowHeadersWidth = 51;
            Data_Role.RowTemplate.Height = 29;
            Data_Role.Size = new Size(725, 293);
            Data_Role.TabIndex = 7;
            Data_Role.CellClick += Data_Role_CellClick;
            Data_Role.CellContentClick += Data_Role_CellContentClick;
            // 
            // BtnUbah
            // 
            BtnUbah.Location = new Point(313, 157);
            BtnUbah.Name = "BtnUbah";
            BtnUbah.Size = new Size(94, 29);
            BtnUbah.TabIndex = 8;
            BtnUbah.Text = "Ubah";
            BtnUbah.UseVisualStyleBackColor = true;
            BtnUbah.Click += BtnUbah_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(413, 157);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 9;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // Role
            // 
            Role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Role.HeaderText = "Kode Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.HeaderText = "Nama Role";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            // 
            // Hapus
            // 
            Hapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hapus.HeaderText = "";
            Hapus.MinimumWidth = 6;
            Hapus.Name = "Hapus";
            Hapus.Resizable = DataGridViewTriState.True;
            Hapus.SortMode = DataGridViewColumnSortMode.Automatic;
            Hapus.Text = "Hapus";
            Hapus.UseColumnTextForButtonValue = true;
            // 
            // DataRole
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 523);
            Controls.Add(BtnBack);
            Controls.Add(BtnUbah);
            Controls.Add(Data_Role);
            Controls.Add(BtnSimpan);
            Controls.Add(BtnTambah);
            Controls.Add(TextNama);
            Controls.Add(TextRole);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataRole";
            Text = "DataRole";
            FormClosing += DataRole_FormClosing;
            Load += DataRole_Load;
            ((System.ComponentModel.ISupportInitialize)Data_Role).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextRole;
        private TextBox TextNama;
        private Button BtnTambah;
        private Button BtnSimpan;
        private DataGridView Data_Role;
        private Button BtnUbah;
        private Button BtnBack;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewButtonColumn Hapus;
    }
}