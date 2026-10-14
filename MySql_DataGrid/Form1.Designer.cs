namespace MySql_DataGrid
{
    partial class frmMySQLconnessione
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCancellazione = new System.Windows.Forms.Button();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.tbTarga = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbModello = new System.Windows.Forms.TextBox();
            this.pInserimento = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdTarga = new System.Windows.Forms.RadioButton();
            this.pOrdinamento = new System.Windows.Forms.Panel();
            this.rdMarca = new System.Windows.Forms.RadioButton();
            this.rdModello = new System.Windows.Forms.RadioButton();
            this.lblOrdinamento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbConnessione = new System.Windows.Forms.Label();
            this.lbDBserver = new System.Windows.Forms.ListBox();
            this.pInserimento.SuspendLayout();
            this.pOrdinamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(256, 62);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(316, 266);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Targa";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Marca";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Modello";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 357);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Chiudi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 62);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Inserimento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCancellazione
            // 
            this.btnCancellazione.Location = new System.Drawing.Point(616, 62);
            this.btnCancellazione.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancellazione.Name = "btnCancellazione";
            this.btnCancellazione.Size = new System.Drawing.Size(171, 28);
            this.btnCancellazione.TabIndex = 4;
            this.btnCancellazione.Text = "Cancellazione";
            this.btnCancellazione.UseVisualStyleBackColor = true;
            this.btnCancellazione.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(32, 357);
            this.tbQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(620, 22);
            this.tbQuery.TabIndex = 6;
            // 
            // tbTarga
            // 
            this.tbTarga.Location = new System.Drawing.Point(9, 28);
            this.tbTarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTarga.Name = "tbTarga";
            this.tbTarga.Size = new System.Drawing.Size(132, 22);
            this.tbTarga.TabIndex = 8;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(9, 76);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(132, 22);
            this.tbMarca.TabIndex = 9;
            // 
            // tbModello
            // 
            this.tbModello.Location = new System.Drawing.Point(9, 124);
            this.tbModello.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbModello.Name = "tbModello";
            this.tbModello.Size = new System.Drawing.Size(132, 22);
            this.tbModello.TabIndex = 10;
            // 
            // pInserimento
            // 
            this.pInserimento.Controls.Add(this.label3);
            this.pInserimento.Controls.Add(this.label2);
            this.pInserimento.Controls.Add(this.label1);
            this.pInserimento.Controls.Add(this.btnInserisci);
            this.pInserimento.Controls.Add(this.tbModello);
            this.pInserimento.Controls.Add(this.tbMarca);
            this.pInserimento.Controls.Add(this.tbTarga);
            this.pInserimento.Location = new System.Drawing.Point(32, 117);
            this.pInserimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pInserimento.Name = "pInserimento";
            this.pInserimento.Size = new System.Drawing.Size(153, 212);
            this.pInserimento.TabIndex = 7;
            this.pInserimento.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modello";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Targa";
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(28, 175);
            this.btnInserisci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(100, 28);
            this.btnInserisci.TabIndex = 8;
            this.btnInserisci.Text = "Conferma";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Auto);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Visualizzazione Query";
            // 
            // rdTarga
            // 
            this.rdTarga.AutoSize = true;
            this.rdTarga.Location = new System.Drawing.Point(20, 20);
            this.rdTarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdTarga.Name = "rdTarga";
            this.rdTarga.Size = new System.Drawing.Size(65, 20);
            this.rdTarga.TabIndex = 9;
            this.rdTarga.TabStop = true;
            this.rdTarga.Text = "Targa";
            this.rdTarga.UseVisualStyleBackColor = true;
            this.rdTarga.CheckedChanged += new System.EventHandler(this.rdTarga_CheckedChanged);
            // 
            // pOrdinamento
            // 
            this.pOrdinamento.Controls.Add(this.rdMarca);
            this.pOrdinamento.Controls.Add(this.rdModello);
            this.pOrdinamento.Controls.Add(this.rdTarga);
            this.pOrdinamento.Location = new System.Drawing.Point(616, 174);
            this.pOrdinamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pOrdinamento.Name = "pOrdinamento";
            this.pOrdinamento.Size = new System.Drawing.Size(171, 122);
            this.pOrdinamento.TabIndex = 10;
            // 
            // rdMarca
            // 
            this.rdMarca.AutoSize = true;
            this.rdMarca.Location = new System.Drawing.Point(20, 76);
            this.rdMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdMarca.Name = "rdMarca";
            this.rdMarca.Size = new System.Drawing.Size(66, 20);
            this.rdMarca.TabIndex = 11;
            this.rdMarca.TabStop = true;
            this.rdMarca.Text = "Marca";
            this.rdMarca.UseVisualStyleBackColor = true;
            this.rdMarca.CheckedChanged += new System.EventHandler(this.rdMarca_CheckedChanged);
            // 
            // rdModello
            // 
            this.rdModello.AutoSize = true;
            this.rdModello.Location = new System.Drawing.Point(20, 48);
            this.rdModello.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdModello.Name = "rdModello";
            this.rdModello.Size = new System.Drawing.Size(77, 20);
            this.rdModello.TabIndex = 10;
            this.rdModello.TabStop = true;
            this.rdModello.Text = "Modello";
            this.rdModello.UseVisualStyleBackColor = true;
            this.rdModello.CheckedChanged += new System.EventHandler(this.rdModello_CheckedChanged);
            // 
            // lblOrdinamento
            // 
            this.lblOrdinamento.AutoSize = true;
            this.lblOrdinamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdinamento.Location = new System.Drawing.Point(611, 145);
            this.lblOrdinamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdinamento.Name = "lblOrdinamento";
            this.lblOrdinamento.Size = new System.Drawing.Size(115, 20);
            this.lblOrdinamento.TabIndex = 11;
            this.lblOrdinamento.Text = "Ordinare per";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Connessione al Server DB";
            // 
            // lbConnessione
            // 
            this.lbConnessione.AutoSize = true;
            this.lbConnessione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnessione.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbConnessione.Location = new System.Drawing.Point(300, 11);
            this.lbConnessione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConnessione.Name = "lbConnessione";
            this.lbConnessione.Size = new System.Drawing.Size(0, 29);
            this.lbConnessione.TabIndex = 13;
            // 
            // lbDBserver
            // 
            this.lbDBserver.DisplayMember = "UniserverZ (locale)";
            this.lbDBserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDBserver.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbDBserver.FormattingEnabled = true;
            this.lbDBserver.ItemHeight = 20;
            this.lbDBserver.Items.AddRange(new object[] {
            "Uniserver Z (locale)",
            "Github (remoto)"});
            this.lbDBserver.Location = new System.Drawing.Point(383, 10);
            this.lbDBserver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbDBserver.Name = "lbDBserver";
            this.lbDBserver.ScrollAlwaysVisible = true;
            this.lbDBserver.Size = new System.Drawing.Size(247, 44);
            this.lbDBserver.TabIndex = 14;
            this.lbDBserver.SelectedIndexChanged += new System.EventHandler(this.lbDBserver_SelectedIndexChanged);
            // 
            // frmMySQLconnessione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 554);
            this.Controls.Add(this.lbDBserver);
            this.Controls.Add(this.lbConnessione);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOrdinamento);
            this.Controls.Add(this.pOrdinamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pInserimento);
            this.Controls.Add(this.tbQuery);
            this.Controls.Add(this.btnCancellazione);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMySQLconnessione";
            this.Text = "MySQLconnessione";
            this.pInserimento.ResumeLayout(false);
            this.pInserimento.PerformLayout();
            this.pOrdinamento.ResumeLayout(false);
            this.pOrdinamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCancellazione;
        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.TextBox tbTarga;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbModello;
        private System.Windows.Forms.Panel pInserimento;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdTarga;
        private System.Windows.Forms.Panel pOrdinamento;
        private System.Windows.Forms.RadioButton rdMarca;
        private System.Windows.Forms.RadioButton rdModello;
        private System.Windows.Forms.Label lblOrdinamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbConnessione;
        public System.Windows.Forms.ListBox lbDBserver;
    }
}

