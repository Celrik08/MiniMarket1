using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket
{
    public partial class DataRole : Form
    {
        private int roleId;
        private int selectedRowIndex = -1;
        private bool isTambahMode = true;
        public DataRole(int roleId)
        {
            InitializeComponent();
            this.FormClosing += DataRole_FormClosing;
            this.roleId = roleId;
        }

        private void TextNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerfromRole();
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            PerfromRole();
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(TextNama.Text))
            {
                MessageBox.Show("Kolom nama role harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void PerfromRole()
        {
            if (!IsFormValid())
            {
                return;
            }

            string nama = TextNama.Text;

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_role (nama_role) VALUES (@nama_role)";
                cmd.Parameters.AddWithValue("@nama_role", nama);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil di input!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextNama.Clear();

            BtnSimpan.Enabled = false;

            LoadDataToDataGridView();
        }

        private void DataRole_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            DisableInputControls();
        }

        private void LoadDataToDataGridView()
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

        private void DataRole_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Reset ke mode "Tambah" saat form ditutup
            BtnTambah.Text = "Tambah";
            isTambahMode = true;
        }

        private void Data_Role_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                // Periksa apakah sel yang diklik tidak null sebelum mengambil nilai
                if (Data_Role.Rows[selectedRowIndex].Cells[0].Value != null)
                {
                    TextRole.Text = Data_Role.Rows[selectedRowIndex].Cells[0].Value.ToString();
                }
                else
                {
                    TextRole.Text = string.Empty;
                }

                if (Data_Role.Rows[selectedRowIndex].Cells[1].Value != null)
                {
                    TextNama.Text = Data_Role.Rows[selectedRowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    TextNama.Text = string.Empty;
                }

                BtnSimpan.Enabled = false;
                BtnUbah.Enabled = true;

                // Mengatifkan kolom "Hapus"
                EnableDeleteColumn(true);
            }
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                MessageBox.Show("Pilih baris yang ingin diubah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = TextRole.Text;
            string nama = TextNama.Text;

            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Kolom nama role harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Connect.conn.Open();
            using (SqlCommand cmd = Connect.conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE tb_role SET nama_role = @nama_role WHERE id_role = @id_role";
                cmd.Parameters.AddWithValue("@id_role", id);
                cmd.Parameters.AddWithValue("@nama_role", nama);
                cmd.ExecuteNonQuery();
            }
            Connect.conn.Close();

            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextRole.Clear();
            TextNama.Clear();

            // Enable tombol Simpan dan Disable tombol Ubah, Hapus
            selectedRowIndex = -1;
            BtnSimpan.Enabled = true;
            BtnUbah.Enabled = false;
            EnableDeleteColumn(false);

            LoadDataToDataGridView();
        }

        private void Data_Role_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Data_Role.Columns["Hapus"].Index && e.RowIndex >= 0)
            {
                // Pastikan kolom yang diklik adalah kolom Hapus Data dan bukan header
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    // Periksa apakah nilai di kolom "id_role" tidak null sebelum mengakses propertinya
                    string id = Data_Role.Rows[e.RowIndex].Cells["Role"]?.Value?.ToString();

                    if (id != null)
                    {
                        Connect.conn.Open();
                        using (SqlCommand cmd = Connect.conn.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM tb_role WHERE id_role = @id_role";
                            cmd.Parameters.AddWithValue("@id_role", id);
                            cmd.ExecuteNonQuery();
                        }
                        Connect.conn.Close();

                        MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TextRole.Clear();
                        TextNama.Clear();

                        selectedRowIndex = -1;

                        LoadDataToDataGridView();
                    }
                    else
                    {
                        // Pengguna memilih No, tidak melakukan apa-apa
                    }
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MenuUtama MU = new MenuUtama(roleId);
            MU.Show();
            Hide();
        }

        private void EnableDeleteColumn(bool enable)
        {
            // Mendapatkan indeks kolom "Hapus"
            int deleteColumnIndex = Data_Role.Columns["Hapus"].Index;

            // Mengatur properti ReadOnly untuk setiap sel di kolom "Hapus"
            foreach (DataGridViewRow row in Data_Role.Rows)
            {
                if (row.Cells[deleteColumnIndex].Value != null)
                {
                    // Mengatur properti ReadOnly sesuai kebutuhan
                    row.Cells[deleteColumnIndex].ReadOnly = !enable;
                }
            }
        }

        private void EnableInputControls()
        {
            TextRole.Clear();
            TextNama.Clear();

            TextNama.Enabled = true;
            Data_Role.Enabled = true;

            BtnSimpan.Enabled = true;
            BtnUbah.Enabled = true;
            EnableDeleteColumn(true);
        }

        private void DisableInputControls()
        {
            TextRole.Enabled = false;
            TextNama.Enabled = false;
            Data_Role.Enabled = false;

            BtnSimpan.Enabled = false;
            BtnUbah.Enabled = false;
            EnableDeleteColumn(false);
        }
    }
}
