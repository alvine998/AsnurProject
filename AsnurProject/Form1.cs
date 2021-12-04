using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsnurProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            logoutToolStripMenuItem.Enabled = false;
            transaksiToolStripMenuItem.Enabled = false;
            laporanToolStripMenuItem.Enabled = false;
            masterToolStripMenuItem.Enabled = false;
        }

        public void VisibleTools()
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login f1 = new Form_Login();
            f1.Show();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TentangAplikasi f2 = new Form_TentangAplikasi();
            f2.Show();
        }

        private void dataKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DataKaryawan f3 = new Form_DataKaryawan();
            f3.Show();
        }

        private void dataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DataBarang f4 = new Form_DataBarang();
            f4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
