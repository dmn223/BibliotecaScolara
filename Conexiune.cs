using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2
{
    internal class Conexiune
    {
        static public string path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Biblioteca_Baza.accdb";
    }
    internal class Forms
    {
        static public Autentificare w1 = null;
        static public Meniu w2 = null;
        static public AdaugaElev w3 = null;
        static public AdaugaCarte w4 = null;
        static public VizualizareCartiImprumutate w5 = null;
        static public Imprumuta w6 = null;
        static public Sterge w7 = null;
        static public Restituie w8 = null;
    }
}
