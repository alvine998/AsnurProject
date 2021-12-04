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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            Boolean login = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "adminasnur" && textBox2.Text == "admin")
            {
                MessageBox.Show("Login Sukses");
                
            } else
            {
                MessageBox.Show("Login Gagal");
            }
        }
    }
}
