using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Libreria per usare MySql
using System.Data;
using MySql.Data.MySqlClient;


/*L'operazione è questa: in 'Esplora Soluzioni -> Riferimenti', click destro e selezionare 'Aggiungi Riferimento...'.
Si apre la form 'Gestione riferimenti' dalla quale si sceglie il riferimento da aggiungere. 
Cercare 'MySql.Data' che dovrebbe trovarsi in 'Assembly -> Estensioni'. 
Qualora ci fossero più righe, il Tooltip che appare sull'estensione, ne indica il percorso. 
È facile capire che i vari percorsi fanno riferimento alla diverse versioni del Framework installate. 
Selezionare il file voluto (compare un piccolo checkbox sulla sinistra) e cliccare su 'OK'*/


namespace MySql_DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Apertura connessione
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                // Query da eseguire
                string sql = "SELECT Targa, Marca, Modello FROM auto";

                MySqlCommand cmd = new MySqlCommand(sql, GestioneMySql.Connessione);
                
                MySqlDataReader dr = cmd.ExecuteReader();
                


                        /*while (dr.Read())
                        {
                            string targa = dr.GetString("Targa");
                            string cognome = dr.GetString("Marca");
                            string nome = dr.GetString("Modello");
                            
                        }
                        */
                DataTable dt = new DataTable();
                dt.Load(dr);

                // Chiusura connessione
                if (!GestioneMySql.ChiudiConnessione())
                    throw new Exception("Errore nella chiusura della connessione.");
            }
            catch (Exception ex)
            {
                GestioneMySql.ChiudiConnessione();
                MessageBox.Show("Errore: " + ex.Message);
            }
        }
    }
}
