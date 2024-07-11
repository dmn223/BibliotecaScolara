using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b2
{
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();    
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "") // cont si parola
            {
                Forms.w2 = new Meniu();
                Hide();
                Forms.w2.Show();
            }
            else
                MessageBox.Show("Cont / Parolă gresită", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Return))
            {
                button1_Click(sender, e);
            }
        }
    }
}
