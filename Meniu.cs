using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b2
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.w1 = new Autentificare();
            Forms.w1.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Forms.w3 = new AdaugaElev();
            Hide();
            Forms.w3.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Forms.w4 = new AdaugaCarte();
            Hide();
            Forms.w4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Forms.w5 = new VizualizareCartiImprumutate();
            Hide();
            Forms.w5.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Forms.w6 = new Imprumuta();
            Hide();
            Forms.w6.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Forms.w7 = new Sterge();
            Hide();
            Forms.w7.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Forms.w8 = new Restituie();
            Hide();
            Forms.w8.Show();
        }
    }
}
