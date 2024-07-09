using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket
{
    public partial class MenuUtama : Form
    {
        private int roleId; // Tambahkan variabel roleId
        public MenuUtama(int roleId)
        {
            InitializeComponent();
            this.roleId = roleId;

            // Ganti pengecekan level dengan pengecekan roleId
            if (roleId == 1)
            {
                DataMaster.Visible = true;
                Transaksi.Visible = true;
            }
            else if (roleId == 2)
            {
                DataMaster.Visible = false;
                DataTransaksi.Visible = true;
                DetailTransaksi.Visible = false;
                DataBarangMasuk.Visible = true;
                DetailBarangMasuk.Visible = false;
            }
            else if (roleId == 3)
            {
                DataMaster.Visible = false;
                DataTransaksi.Visible = true;
            }

            User.Text = GetRoleName(roleId);
        }

        private string GetRoleName(int roleId)
        {
            switch (roleId)
            {
                case 1:
                    return "Admin";
                case 2:
                    return "Manager";
                case 3:
                    return "Kasir";
                default:
                    return "Unknown";
            }
        }

        private void DataPegawai_Click(object sender, EventArgs e)
        {
            DataPegawai DP = new DataPegawai(roleId);
            DP.Show();
            Hide();
        }

        private void DataRole_Click(object sender, EventArgs e)
        {
            DataRole DR = new DataRole(roleId);
            DR.Show();
            Hide();
        }

        private void DataUser_Click(object sender, EventArgs e)
        {
            DataUser DU = new DataUser();
            DU.Show();
            Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormLogin FL = new FormLogin();
            FL.Show();
            Hide();
        }
    }
}
