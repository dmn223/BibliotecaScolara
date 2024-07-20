using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace b2
{
    public partial class AdaugaCarte : Form
    {
        public AdaugaCarte()
        {
            InitializeComponent();
        }
        private void AdaugaCarte_Load(object sender, EventArgs e)
        {
           numericUpDown2.Maximum = DateTime.Today.Year;
        }
        bool ok(string a, string b, string c, string d)
        {
            if (a == "" || b == "" || c == "" || d == "")
                return false;
            return true;
        }
        bool nr(int a)
        {
            using (OleDbConnection con = new OleDbConnection(Conexiune.path))
            {
                string query = @"SELECT COUNT(*) FROM Carti WHERE NumarDeInventar = @a";
                using (OleDbCommand com = new OleDbCommand(query, con))
                {
                    com.Parameters.AddWithValue(@"a", a);
                    con.Open();

                    int exist = (int)com.ExecuteScalar();
                    if (exist != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int nr_inventar = Convert.ToInt32(numericUpDown1.Value); 
            int an_aparitie = Convert.ToInt32(numericUpDown2.Value);
            string cz = textBox1.Text;
            string titlu = textBox2.Text;
            string autor = textBox3.Text;
            string editura = textBox4.Text;
            string localitate_aparitie = textBox6.Text;
            if (ok(titlu, autor, editura, localitate_aparitie) == false)
            {
                MessageBox.Show("Date gresite/incorecte", "Eroare",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nr(nr_inventar) == false)
            {
                MessageBox.Show("Numar inventar folosit deja. Alegeti alt numar", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (OleDbConnection con = new OleDbConnection(Conexiune.path))
            {
                string query = @"INSERT INTO CARTI(NumarDeInventar, Titlu, Autor, Editura, AnulAparitiei, LocalitateAparitie, CZU) VALUES(X, a, b, c, d, e, f)";
                using(OleDbCommand com = new OleDbCommand(query, con))
                {
                    con.Open();
                    com.Parameters.AddWithValue(@"X", nr_inventar);
                    com.Parameters.AddWithValue(@"a", titlu);
                    com.Parameters.AddWithValue(@"b", autor);
                    com.Parameters.AddWithValue(@"c", editura);
                    com.Parameters.AddWithValue(@"d", an_aparitie);
                    com.Parameters.AddWithValue(@"e", localitate_aparitie);
                    com.Parameters.AddWithValue(@"f", cz);

                    int rows = (int)com.ExecuteNonQuery();
                    if(rows == 0)
                    {
                        MessageBox.Show("Cartea nu a putut fi introdusa", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                    MessageBox.Show("Cartea a fost introdusa cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    /*
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox6.Text = "";
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = 0;
                    */
                }
            }
        }
        private void AdaugaCarte_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.w2.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}