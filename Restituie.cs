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

namespace b2
{
    public partial class Restituie : Form
    {
        public Restituie()
        {
            InitializeComponent();
        }
        private void Restituie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioteca_BazaDataSet1.Imprumuturi' table. You can move, or remove it, as needed.
            this.imprumuturiTableAdapter.Fill(this.biblioteca_BazaDataSet1.Imprumuturi);
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            string nume = textBox1.Text;
            string prenume = textBox2.Text;

            DataView dataView = new DataView(biblioteca_BazaDataSet1.Tables[0]);
            dataView.RowFilter = $"Nume = '{nume}' AND Prenume = '{prenume}'";
            dataGridView1.DataSource = dataView;
            
        }

        private void Restituie_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView1.DataSource = null;
            Forms.w2 = new Meniu();
            Forms.w2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ok = 0;
            string inventar = textBox3.Text;
            string nume = textBox1.Text;
            string prenume = textBox2.Text;
            using(OleDbConnection con = new OleDbConnection(Conexiune.path))
            {
                con.Open();
                string query = @"DELETE FROM Imprumuturi WHERE NumarInventar = @a AND Nume = @b AND Prenume = @c";
                using(OleDbCommand com = new OleDbCommand(query, con))
                {
                    com.Parameters.AddWithValue("@a", inventar);
                    com.Parameters.AddWithValue("@b", nume);
                    com.Parameters.AddWithValue("@c", prenume);
                    ok = (int)com.ExecuteNonQuery();
                    if(ok != 0)
                    {
                        MessageBox.Show("Cartea a fost restituita cu succes", "", MessageBoxButtons.OK, MessageBoxIcon.Information);      
                    }
                    else
                    {
                        MessageBox.Show("Nu a fost gasita cartea pe numele introdus", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (ok > 0)
            {
                using (OleDbConnection con = new OleDbConnection(Conexiune.path))
                {
                    string query = @"UPDATE Carti SET Luata = @a WHERE NumarDeInventar = @b";
                    using (OleDbCommand com = new OleDbCommand(query, con))
                    {
                        con.Open();
                        com.Parameters.AddWithValue("@a", false);
                        com.Parameters.AddWithValue("@b", inventar);
                        com.ExecuteNonQuery();
                        textBox3.Text = "";
                    }
                }
            }
            this.imprumuturiTableAdapter.Fill(this.biblioteca_BazaDataSet1.Imprumuturi);
            DataView dataView = new DataView(biblioteca_BazaDataSet1.Tables[0]);
            dataGridView1.DataSource = dataView;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
