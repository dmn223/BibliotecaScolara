using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace b2
{
    public partial class AdaugaElev : Form
    {
        public AdaugaElev()
        {
            InitializeComponent();
        }
        bool valid(string a, string b, string c, string d, string e)
        {
            if (a == "" || b == "" || c == "" || d == "" || e == "")
                return false;
            return true;
        }
        bool verif_cnp(string cnp)
        {  
            using (OleDbConnection con = new OleDbConnection(Conexiune.path))
            {
                string query = @"SELECT COUNT(*) FROM Elev WHERE CNP = @a";
                using (OleDbCommand com = new OleDbCommand(query, con))
                {
                    com.Parameters.AddWithValue(@"a", cnp);
                    con.Open();

                    int exist = (int)com.ExecuteScalar();
                    if (exist != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cnp = textBox1.Text;
            string nume = textBox2.Text;
            string prenume = textBox3.Text;
            string clasa = textBox4.Text;
            string telefon = textBox5.Text;
            if (valid(cnp, nume, prenume, clasa, telefon) == false)
            {
                MessageBox.Show("Date Incomplete", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (verif_cnp(cnp) == true)
            {
                MessageBox.Show("CNP folosit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                return;
            }
            using(OleDbConnection con = new OleDbConnection(Conexiune.path))
            {
                string query = @"INSERT INTO ELEV(CNP, Nume, Prenume, Clasa, NumarTelefon) VALUES(a, b, c, d, e)";
                using (OleDbCommand com = new OleDbCommand(query, con))
                {
                    con.Open();
                    com.Parameters.AddWithValue(@"a", cnp);
                    com.Parameters.AddWithValue(@"b", nume);
                    com.Parameters.AddWithValue(@"c", prenume);
                    com.Parameters.AddWithValue(@"d", clasa);
                    com.Parameters.AddWithValue(@"e", telefon);

                    bool ok = Convert.ToBoolean(com.ExecuteNonQuery());
                    if(ok == false)
                    {
                        MessageBox.Show("Elevul nu a fost introdus", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Elevul a fost introdus cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
                
        }
        private void AdaugaElev_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.w2.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
