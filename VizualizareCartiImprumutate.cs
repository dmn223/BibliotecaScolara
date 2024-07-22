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
using System.Net.Http.Headers;

namespace b2
{
    public partial class VizualizareCartiImprumutate : Form
    {   
        HashSet<string> s2 = new HashSet<string>();
        HashSet<string> s3 = new HashSet<string>();
        public VizualizareCartiImprumutate()
        {
            InitializeComponent();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Text = "Alege o carte";
            string nume = comboBox2.SelectedItem.ToString();
            DataView dataView = new DataView(biblioteca_BazaDataSet4.Tables["Imprumuturi"]);
            dataView.RowFilter = $"Autor = '{nume}'";
            dataGridView1.DataSource = dataView;

            HashSet<string> list = new HashSet<string>();
            using(OleDbConnection con = new OleDbConnection(Conexiune.path))
            {
                string query = @"SELECT * FROM CARTI WHERE Autor = @a";
                using(OleDbCommand com = new OleDbCommand(query, con))
                {
                    con.Open();
                    com.Parameters.AddWithValue("@a", nume);
                    using(OleDbDataReader reader = com.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            list.Add(reader["Titlu"].ToString());
                        }
                    }
                }
            }
            comboBox3.Items.Clear();
            foreach (string s in list) comboBox3.Items.Add(s);
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "Alege un autor";
            string nume = comboBox3.SelectedItem.ToString();
            DataView dataView = new DataView(biblioteca_BazaDataSet4.Tables["Imprumuturi"]);
            dataView.RowFilter = $"Titlu = '{nume}'";
            dataGridView1.DataSource = dataView;

            HashSet<string> list = new HashSet<string>();
            using (OleDbConnection con = new OleDbConnection(Conexiune.path))
            {
                string query = @"SELECT * FROM CARTI WHERE Titlu = @a";
                using (OleDbCommand com = new OleDbCommand(query, con))
                {
                    con.Open();
                    com.Parameters.AddWithValue("@a", nume);
                    using (OleDbDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(reader["Autor"].ToString());
                        }
                    }
                }
            }
        }
        private void VizualizareCarti_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.w2.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        void AdaugaCArti()
        {
            comboBox3.Items.Clear();
            foreach (string s in s3) comboBox3.Items.Add(s);
        }
        private void VizualizareCarti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioteca_BazaDataSet4.Imprumuturi' table. You can move, or remove it, as needed.
            this.imprumuturiTableAdapter.Fill(this.biblioteca_BazaDataSet4.Imprumuturi);
            using(OleDbConnection con = new OleDbConnection(Conexiune.path))
            {
                string query = "SELECT * FROM Carti";
                con.Open();
                using(OleDbCommand com = new OleDbCommand(query, con))
                {
                    using(OleDbDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            s2.Add(reader["Autor"].ToString());
                            s3.Add(reader["Titlu"].ToString());
                        }
                    }
                }
            }
            foreach (string s in s2) comboBox2.Items.Add(s);
            AdaugaCArti();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "Alege un autor";
            comboBox3.Text = "Alege o carte";
            AdaugaCArti();
            DataView dataView = new DataView(biblioteca_BazaDataSet4.Tables["Imprumuturi"]);
            dataGridView1.DataSource = dataView;
        }
    }
}
