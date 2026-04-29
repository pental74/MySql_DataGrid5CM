using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Libreria per usare MySql
using MySql.Data.MySqlClient;


/*L'operazione è questa: in 'Esplora Soluzioni -> Riferimenti', click destro e selezionare 'Aggiungi Riferimento...'.
Si apre la form 'Gestione riferimenti' dalla quale si sceglie il riferimento da aggiungere. 
Cercare 'MySql.Data' che dovrebbe trovarsi in 'Assembly -> Estensioni'. 
Qualora ci fossero più righe, il Tooltip che appare sull'estensione, ne indica il percorso. 
È facile capire che i vari percorsi fanno riferimento alla diverse versioni del Framework installate. 
Selezionare il file voluto (compare un piccolo checkbox sulla sinistra) e cliccare su 'OK'*/


namespace MySql_DataGrid
{
    
    public partial class frmMySQLconnessione : Form
    {
        // Stringhe di connessione al DB nel server DB db4free.net e al server di Uniserver Z in locale
        public static string connStrInfinity = "server=db4free.net; user=maquilanti; database=db_multe; port=3306; password=qwertyuiop";
        public static string connStrUniZ = "server=127.0.0.1;user=root;database=multe;port=3306;password=marco";

        // stringa per la query dell'aggiornamento della List view
        public string selquery = "SELECT Targa, Marca, Modello FROM auto";
        public string serverDB;
        MySqlConnection Connessione;

        public frmMySQLconnessione()
        {
            InitializeComponent();                     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void lviVisualizzaAuto(string q)
        {
            try
            {
                // Apertura connessione
                Connessione.Open();
                    //throw new Exception("Errore nell'apertura della connessione.");

                // Query su tabella AUTO che visualizza tutti i record
                //string sql = "SELECT Targa, Marca, Modello FROM auto";

                MySqlCommand cmd = new MySqlCommand(q, Connessione);

                MySqlDataReader dr = cmd.ExecuteReader();

                // Pulizia della ListView >> metodo Clear
                listView1.Items.Clear();
                // variabile lv1 di tipo Item >> riga della lista
                ListViewItem lv1;

                while (dr.Read())
                {
                    string targa = dr.GetString("Targa");
                    string marca = dr.GetString("Marca");
                    string modello = dr.GetString("Modello");

                    lv1 = new ListViewItem(targa);
                    // colonne subitems
                    lv1.SubItems.Add(marca);
                    lv1.SubItems.Add(modello);
                    // Aggiunta di una riga(item) alla ListView
                    listView1.Items.Add(lv1);
                }
                // Chiusura connessione
               
                Connessione.Close();
                    throw new Exception("Errore nella chiusura della connessione.");
            }
            catch (Exception ex)
            {
                ChiudiConnessione(Connessione);
                MessageBox.Show("Errore: " + ex.Message);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Chiude il Form !!
            this.Close();
        }

        //"DELETE FROM `auto` WHERE `auto`.`Targa` = "
        private void button4_Click(object sender, EventArgs e)
        {
            // listView1.SelectedItems.Count > 0 Se un elemento della Listview è selezionato
            if (listView1.SelectedItems.Count > 0)
            {
                ApriConnessione(Connessione);
                // in cancTarg inserisco il primo elemanto della riga selezionata
                string cancTarga = listView1.SelectedItems[0].Text;
                string querySQL = @"DELETE FROM `auto` WHERE `Targa` = '" + cancTarga+ @"'";
                MySqlCommand cmd2 = new MySqlCommand(querySQL, Connessione);
                cmd2.ExecuteNonQuery();
                ChiudiConnessione(Connessione);

                // Visualizzazione nella Text box della query di cancellazione
                tbQuery.Text = "Cancellata Auto con targa: " + listView1.SelectedItems[0].Text;

                // Aggiorna la List view
                lviVisualizzaAuto(selquery);                                               
            }       
                    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pInserimento.Visible = true;

        }


        // Inserimento in AUTO
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            // I valori della nuova auto sono inseriti in variabili di appoggio
            string apTarga = tbTarga.Text;
            string apMarca = tbMarca.Text;
            string apModello = tbModello.Text;

            // Apertura connessione con DB
            // vecchio - GestioneMySql.ApriConnessione();
            ApriConnessione(Connessione);

            // Composizione della query di inserimento con i valori delle variabili
            // $ per inserire in una stringa le variabili
            string querySQL = $"INSERT INTO auto (Targa, Marca, Modello) VALUES ('{apTarga}','{apMarca}', '{apModello}')";
            
            // Passato il comando cmd con la query e la connessione al DB
            MySqlCommand cmd = new MySqlCommand(querySQL, Connessione);

            // ExecuteNonQuery da utilizzare per ++!! insert, update, and delete data ++!!
            cmd.ExecuteNonQuery();
            // Chiusura connessione con il DB
            ChiudiConnessione(Connessione);

            // visualizzazione delle query nel Text Box
            tbQuery.Text = querySQL;
            // Pannello inserimento oscurato
            pInserimento.Visible = false;
            // Aggiornamento dei dati nella List view   
            lviVisualizzaAuto(selquery);
        }

        // ORDER BY TARGA
        private void rdTarga_CheckedChanged(object sender, EventArgs e)
        {
            String rdTargachecked = "SELECT * FROM `auto`ORDER BY `Targa`";
            lviVisualizzaAuto(rdTargachecked);
        }

        // ORDER BY MODELLO
        private void rdModello_CheckedChanged(object sender, EventArgs e)
        {
            String rdModlellochecked = "SELECT * FROM `auto`ORDER BY `Modello`";
            lviVisualizzaAuto(rdModlellochecked);
        }

        // ORDER BY MARCA
        private void rdMarca_CheckedChanged(object sender, EventArgs e)
        {
            String rdMarcachecked = "SELECT * FROM `auto`ORDER BY `Marca`";
            lviVisualizzaAuto(rdMarcachecked);
        }

        private void lbDBserver_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToString(lbDBserver.SelectedItem) == "Uniserver Z (locale)") serverDB = connStrUniZ;
            else if (Convert.ToString(lbDBserver.SelectedItem) == "db4free.net (remoto)") serverDB = connStrInfinity;

            tbQuery.Text = serverDB;
            MySqlConnection Connessione = new MySqlConnection(serverDB);
            //ApriConnessione(Connessione);
        // Carica in List view tutti i record della tabella Auto
        lviVisualizzaAuto(selquery);

        }

        public static bool ApriConnessione(MySqlConnection conn)
        {

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ChiudiConnessione(MySqlConnection conn)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
