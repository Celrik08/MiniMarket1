using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket
{
    public partial class DataUser : Form
    {
        private int selectedRowIndex = -1;
        private bool isTambahMode = true;
        public DataUser()
        {
            InitializeComponent();
            this.FormClosing += DataUser_FormClosing;
        }

        private void TextNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                TextPassword.Focus();
            }
        }

        private void TextPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerfromUser();
            }
        }

        private void Data_Pegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = Data_Pegawai.Rows[e.RowIndex];
                string id = selectedRow.Cells[0].Value.ToString();
                string nama = selectedRow.Cells[1].Value.ToString();
                TextPegawai.Text = $"{id}/{nama}"; // Menampilkan id dan nama di TextPegawai
            }
        }

        private void Data_Role_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = Data_Role.Rows[e.RowIndex];
                string id = selectedRow.Cells[0].Value.ToString();
                string nama = selectedRow.Cells[1].Value.ToString();
                TextRole.Text = $"{id}/{nama}"; // Menampilkan id dan nama di TextRole
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            PerfromUser();
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(TextNama.Text) ||
                string.IsNullOrWhiteSpace(TextPassword.Text) ||
                string.IsNullOrWhiteSpace(TextPegawai.Text) ||
                string.IsNullOrWhiteSpace(TextRole.Text))
            {
                MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void PerfromUser()
        {
            if (!IsFormValid())
            {
                return;
            }

            string nama = TextNama.Text;
            string password = TextPassword.Text;
            string idPegawaiRole = TextPegawai.Text.Split('/')[0].Trim();
            string idRole = TextRole.Text.Split('/')[0].Trim();

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_user (username, password, id_pegawai, id_role) VALUES (@username, @password, @id_pegawai, @id_role)";
                cmd.Parameters.AddWithValue("@username", nama);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@id_pegawai", idPegawaiRole);
                cmd.Parameters.AddWithValue("@id_role", idRole);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil di input!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextNama.Clear();
            TextPassword.Clear();
            TextPegawai.Clear();
            TextRole.Clear();

            BtnSimpan.Enabled = false;

            LoadDataToDataGridView();
        }

        private void DataUser_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            DisableInputControls();
            LoadDataRole();
            LoadDataPegawai();
        }

        private void LoadDataToDataGridView()
        {
            // Kosongkan DataGridView terlebih dahulu

            Data_User.Rows.Clear();

            // Tulis kueri SQL Anda untuk mengambil data dari user
            string query = "SELECT tb_user.id_user, tb_user.username, tb_user.password, tb_pegawai.nama_pegawai, tb_role.nama_role " +
                "FROM tb_user " +
                "JOIN tb_pegawai ON tb_user.id_pegawai = tb_pegawai.id_pegawai " +
                "JOIN tb_role ON tb_user.id_role = tb_role.id_role";

            // Buat SqlCommand untuk menjalankan kueri
            using (SqlCommand cmd = new SqlCommand(query, Connect.conn))
            {
                Connect.conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Menambahkan data ke DataGridView
                        string id = reader["id_user"].ToString();
                        string nama = reader["username"].ToString();
                        string password = reader["password"].ToString();
                        string pegawai = reader["nama_pegawai"].ToString();
                        string role = reader["nama_role"].ToString();
                        Data_User.Rows.Add(id, nama, password, pegawai, role);
                    }
                }
                Connect.conn.Close();
            }
        }

        private void LoadDataPegawai()
        {
            Data_Pegawai.Rows.Clear();

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "SELECT id_pegawai, nama_pegawai, jenis_kelamin, no_hp, alamat FROM tb_pegawai";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id_pegawai"].ToString();
                        string nama = reader["nama_pegawai"].ToString();
                        string jenis = reader["jenis_kelamin"].ToString();
                        string no = reader["no_hp"].ToString();
                        string alamat = reader["alamat"].ToString();
                        Data_Pegawai.Rows.Add(id, nama, jenis, no, alamat);
                    }
                }
            }
            Connect.conn.Close();
        }

        private void LoadDataRole()
        {
            Data_Role.Rows.Clear();

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "SELECT id_role, nama_role FROM tb_role";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id_role"].ToString();
                        string nama = reader["nama_role"].ToString();
                        Data_Role.Rows.Add(id, nama);
                    }
                }
            }
            Connect.conn.Close();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (isTambahMode)
            {
                EnableInputControls();
                BtnTambah.Text = "Clear";
            }
        }

        private void DataUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Reset ke mode "Tambah" saat form ditutup
            BtnTambah.Text = "Tambah";
            isTambahMode = true;
        }
    }
}
