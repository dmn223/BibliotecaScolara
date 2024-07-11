using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b2
{
    public partial class Imprumuta : Form
    {
        public Imprumuta()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Imprumuta_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
            Forms.w2.Show();
        }
        private void Imprumuta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioteca_BazaDataSet.Carti' table. You can move, or remove it, as needed.
            this.cartiTableAdapter.Fill(this.biblioteca_BazaDataSet.Carti);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.MinDate = DateTime.Today.Date;
        }
        bool valid(string a, string b, string c, string d, string e, int f, string g)
        {
            if (a == "") return false;
            if (b == "") return false;
            if (c == "") return false;
            if (d == "") return false;
            if (e == "") return false;
            if (g == "") return false;
            if (f ==  0) return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string autor = textBox1.Text;
            string titlu = textBox2.Text;
            string CZU = textBox3.Text;
            string nume = textBox4.Text;
            string prenume = textBox5.Text;
            string clasa = textBox6.Text;
            int pret = Convert.ToInt32(numericUpDown1.Value);
            int inventar = Convert.ToInt32(numericUpDown2.Value);
            string date = Convert.ToString(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            string data_azi = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));

            if (valid(autor, titlu, CZU, nume, prenume, pret, clasa) == false)
            {
                MessageBox.Show("Date Incomplete", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string telefon = "";
            using (OleDbConnection con = new OleDbConnection(Conexiune.path))
            {
                string query = @"SELECT NumarTelefon FROM Elev WHERE Nume = @a AND Prenume = @b";
                using (OleDbCommand com = new OleDbCommand(query, con))
                {
                    com.Parameters.AddWithValue("@a", nume);
                    com.Parameters.AddWithValue("@b", prenume);
                    con.Open();
                    object chestie = com.ExecuteScalar();
                    if (chestie != null)
                    {
                        telefon = chestie.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Elevul nu este înregistrat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            using (OleDbConnection con = new OleDbConnection(Conexiune.path))
            {
                string query = @"SELECT COUNT(*) FROM Carti WHERE Luata = @a AND NumarDeInventar = @b";
                using (OleDbCommand com = new OleDbCommand(query, con))
                {
                    con.Open();
                    com.Parameters.AddWithValue("@a", false);
                    com.Parameters.AddWithValue("@b", inventar);
                    int x = (int)com.ExecuteScalar();
                    if (x == 0)
                    {
                        MessageBox.Show("Cartea nu este disponibilă", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            int ok = 0;
            using (OleDbConnection con = new OleDbConnection(Conexiune.path))
            {
                string query = @"INSERT INTO Imprumuturi(DataImprumut, Autor, Pret, NumarInventar, Clasificare, DataRestituire, Nume, Prenume, Titlu, Clasa, NumarTelefon) VALUES(@a, @b, @c, @d, @e, @f, @g, @h, @i, @j, @k)";
                using (OleDbCommand com = new OleDbCommand(query, con))
                {
                    con.Open();
                    com.Parameters.AddWithValue("@a", data_azi);
                    com.Parameters.AddWithValue("@b", autor);
                    com.Parameters.AddWithValue("@c", pret);
                    com.Parameters.AddWithValue("@d", inventar);
                    com.Parameters.AddWithValue("@e", CZU);
                    com.Parameters.AddWithValue("@f", date);
                    com.Parameters.AddWithValue("@g", nume);
                    com.Parameters.AddWithValue("@h", prenume);
                    com.Parameters.AddWithValue("@i", titlu);
                    com.Parameters.AddWithValue("@j", clasa);
                    com.Parameters.AddWithValue("@k", telefon);

                    DialogResult arata = MessageBox.Show("Confirmă rezervarea cărții", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (arata == DialogResult.Yes)
                    {
                        ok = (int)com.ExecuteNonQuery();
                        MessageBox.Show("Cartea a fost introdusă cu succes", "Rezervare", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        return;
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
                        com.Parameters.AddWithValue("@a", true);
                        com.Parameters.AddWithValue("@b", inventar);
                        com.ExecuteNonQuery();

                        
                    }
                }
                this.cartiTableAdapter.Fill(this.biblioteca_BazaDataSet.Carti);
                DataView dataView = new DataView(biblioteca_BazaDataSet.Tables[0]);
                dataGridView1.DataSource = dataView;
            }
        }
        bool aici = false;
        private void button2_Click(object sender, EventArgs e) // titlu
        {
            button1.Visible = true;
            dataGridView1.Visible = true;
            string titlu = textBox2.Text;
            DataView dataView = new DataView(biblioteca_BazaDataSet.Tables["Carti"]);
            dataView.RowFilter = $"Titlu = '{titlu}' AND Luata = '{aici}'";
            dataGridView1.DataSource = dataView;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            dataGridView1.Visible = true;
            string autor = textBox1.Text;
            DataView dataView = new DataView(biblioteca_BazaDataSet.Tables["Carti"]);
            dataView.RowFilter = $"Autor = '{autor}'AND Luata = '{aici}'";
            dataGridView1.DataSource = dataView;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            dataGridView1.Visible = true;

            string czu = textBox3.Text;
            DataView dataView = new DataView(biblioteca_BazaDataSet.Tables["Carti"]);
            dataView.RowFilter = $"CZU = '{czu}'AND Luata = '{aici}'";
            dataGridView1.DataSource = dataView;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                button1.Visible = true;
                textBox1.Text = row.Cells[2].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[6].Value.ToString();
                numericUpDown2.Value = Convert.ToInt32(row.Cells[0].Value);
                numericUpDown1.Value = 20;
                dateTimePicker1.Value = DateTime.Today.AddDays(14);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            DataView dataView = new DataView(biblioteca_BazaDataSet.Tables["Carti"]);
            dataGridView1.DataSource = dataView;
        }
    }
}