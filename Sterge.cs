using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace b2
{
    public partial class Sterge : Form
    {
        public Sterge()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Sterge_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.w2.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cnp = textBox1.Text;
            using (OleDbConnection con = new OleDbConnection(Conexiune.path))
            {
                string query = @"DELETE FROM Elev WHERE CNP = @a";
                con.Open();

                using (OleDbCommand com = new OleDbCommand(query, con))
                {
                    com.Parameters.AddWithValue(@"a", cnp);
                    int sters = (int)com.ExecuteNonQuery();
                    if (sters != 0)
                    {
                        MessageBox.Show("Elev sters cu succes", "Stergere", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textBox1.Text = "";
                        return;
                    }
                    MessageBox.Show("CNP incorect", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                button1_Click(sender, e);
            }
        }
    }
}
