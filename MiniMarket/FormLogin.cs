﻿using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void TextUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TextPassword.Focus();
                e.Handled = true;
            }
        }

        private void TextPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerfromLogin();
            }
        }

        private void BtnKlik_Click(object sender, EventArgs e)
        {
            PerfromLogin();
        }

        private void PerfromLogin()
        {
            string username = TextUser.Text;
            string password = TextPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Usename dan password tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT * FROM tb_user WHERE username = @username AND password = @password";

            using (SqlCommand cmd = new SqlCommand(query, Connect.conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                Connect.conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int roleId;
                        if (int.TryParse(reader["id_role"].ToString(), out roleId))
                        {
                            // Pastikan roleId hanya 1, 2, 3, atau 4
                            if (roleId >= 1 && roleId <= 4)
                            {
                                string id = reader["id_role"].ToString();

                                MenuUtama menuUtama = new MenuUtama(roleId);
                                menuUtama.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Role ID tidak valid", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Role ID tidak valid", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextUser.Text = "";
                        TextPassword.Text = "";
                    }
                }

                Connect.conn.Close();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            TextPassword.PasswordChar = '*';
        }

        private void CheckPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPassword.Checked)
            {
                TextPassword.PasswordChar = '\0'; // Menampilkan teks biasa (tanpa karakter tersembunyi)
            }
            else
            {
                TextPassword.PasswordChar = '*'; // Menggunakan karakter tersembunyi (bintang)
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
