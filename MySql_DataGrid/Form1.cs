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
        // Configurazioni originali: verificare che il tunnel remoto sia ancora attivo.
        public static string connGithub = "server=2.tcp.eu.ngrok.io; user=root; database=concessionario; port=11668; password=root";
        public static string connStrUniZ = "server=127.0.0.1;user=root;database=concessionario;port=3306;password=root";

        public string selquery = "SELECT targa, marca, modello FROM auto";
        public string serverDB = "";

        private string colonnaOrdinamento = "";

        public frmMySQLconnessione()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Enabled = false;
            pInserimento.Visible = false;
        }

        private bool ServerDisponibile()
        {
            if (!string.IsNullOrWhiteSpace(serverDB))
                return true;

            MessageBox.Show("Selezionare prima un server MySQL.",
                "Server non selezionato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        // Ciascuna operazione usa una propria connessione, chiusa automaticamente.
        private void lviVisualizzaAuto(string q)
        {
            if (!ServerDisponibile())
                return;

            try
            {
                // Prepara i dati prima di sostituire quelli visualizzati.
                System.Collections.Generic.List<ListViewItem> righe =
                    new System.Collections.Generic.List<ListViewItem>();

                using (MySqlConnection conn = new MySqlConnection(serverDB))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(q, conn))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string targa = Convert.ToString(dr["targa"]);
                            string marca = Convert.ToString(dr["marca"]);
                            string modello = Convert.ToString(dr["modello"]);

                            ListViewItem item = new ListViewItem(targa);
                            item.SubItems.Add(marca);
                            item.SubItems.Add(modello);
                            righe.Add(item);
                        }
                    }
                }

                listView1.BeginUpdate();
                try
                {
                    listView1.Items.Clear();
                    listView1.Items.AddRange(righe.ToArray());
                }
                finally
                {
                    listView1.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossibile caricare le auto:\n" + ex.Message,
                    "Errore MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AggiornaLista()
        {
            string query = selquery;
            if (!string.IsNullOrEmpty(colonnaOrdinamento))
                query += " ORDER BY `" + colonnaOrdinamento + "`";

            lviVisualizzaAuto(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cancella l'auto selezionata.
        private void button4_Click(object sender, EventArgs e)
        {
            if (!ServerDisponibile())
                return;

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selezionare un'auto da cancellare.");
                return;
            }

            string cancTarga = listView1.SelectedItems[0].Text;
            if (MessageBox.Show("Cancellare l'auto con targa " + cancTarga + "?",
                "Conferma cancellazione", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            const string querySQL = "DELETE FROM `auto` WHERE `targa` = @targa";

            try
            {
                int righeEliminate;
                using (MySqlConnection conn = new MySqlConnection(serverDB))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(querySQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@targa", cancTarga);
                        righeEliminate = cmd.ExecuteNonQuery();
                    }
                }

                tbQuery.Text = righeEliminate > 0
                    ? "Cancellata auto con targa: " + cancTarga
                    : "Nessuna auto trovata con targa: " + cancTarga;
                AggiornaLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la cancellazione:\n" + ex.Message,
                    "Errore MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ServerDisponibile())
                pInserimento.Visible = true;
        }

        // Inserisce una nuova auto.
        private void btnInserisci_Auto(object sender, EventArgs e)
        {
            if (!ServerDisponibile())
                return;

            string apTarga = tbTarga.Text.Trim();
            string apMarca = tbMarca.Text.Trim();
            string apModello = tbModello.Text.Trim();

            if (apTarga.Length == 0 || apMarca.Length == 0 || apModello.Length == 0)
            {
                MessageBox.Show("Compilare targa, marca e modello.",
                    "Dati mancanti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const string querySQL =
                "INSERT INTO `auto` (`targa`, `marca`, `modello`) " +
                "VALUES (@targa, @marca, @modello)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(serverDB))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(querySQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@targa", apTarga);
                        cmd.Parameters.AddWithValue("@marca", apMarca);
                        cmd.Parameters.AddWithValue("@modello", apModello);
                        cmd.ExecuteNonQuery();
                    }
                }

                tbQuery.Text = "Inserita auto con targa: " + apTarga;
                tbTarga.Clear();
                tbMarca.Clear();
                tbModello.Clear();
                pInserimento.Visible = false;
                AggiornaLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'inserimento:\n" + ex.Message,
                    "Errore MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdTarga_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdTarga.Checked)
                return;
            colonnaOrdinamento = "targa";
            if (listView1.Enabled)
                AggiornaLista();
        }

        private void rdModello_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdModello.Checked)
                return;
            colonnaOrdinamento = "modello";
            if (listView1.Enabled)
                AggiornaLista();
        }

        private void rdMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdMarca.Checked)
                return;
            colonnaOrdinamento = "marca";
            if (listView1.Enabled)
                AggiornaLista();
        }

        private void lbDBserver_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scelta = Convert.ToString(lbDBserver.SelectedItem);
            listView1.Enabled = false;
            listView1.Items.Clear();
            pInserimento.Visible = false;

            if (scelta == "Uniserver Z (locale)")
                serverDB = connStrUniZ;
            else if (scelta == "Github (remoto)")
                serverDB = connGithub;
            else
            {
                serverDB = "";
                tbQuery.Text = "Selezionare un server.";
                return;
            }

            string messaggio;
            using (MySqlConnection conn = new MySqlConnection(serverDB))
            {
                if (!ApriConnessione(conn))
                {
                    tbQuery.Text = "Connessione fallita: " + scelta;
                    return;
                }
                // La connessione di prova viene chiusa dal blocco using.
            }

            tbQuery.Text = "Connesso a: " + scelta;
            listView1.Enabled = true;
            AggiornaLista();
        }

        // Metodi mantenuti per compatibilità con eventuali chiamate esistenti.
        public static bool ApriConnessione(MySqlConnection conn)
        {
            if (conn == null)
            {
                MessageBox.Show("Connessione MySQL non inizializzata.");
                return false;
            }

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore connessione",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ChiudiConnessione(MySqlConnection conn)
        {
            if (conn == null)
                return true;

            try
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore chiusura connessione",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
