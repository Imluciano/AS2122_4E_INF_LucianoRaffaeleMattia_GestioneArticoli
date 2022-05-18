namespace AS2122_4E_INF_LucianoRaffaeleMattia_GestioneArticoli
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUnitaDiMisura = new System.Windows.Forms.ComboBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblUnitadiMisura = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblArticoli = new System.Windows.Forms.Label();
            this.cmbVisualizzaArticoli = new System.Windows.Forms.ComboBox();
            this.lstVisualizza = new System.Windows.Forms.ListBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.lblParentesi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUnitaDiMisura);
            this.groupBox1.Controls.Add(this.txtPrezzo);
            this.groupBox1.Controls.Add(this.txtDescrizione);
            this.groupBox1.Controls.Add(this.txtCodice);
            this.groupBox1.Controls.Add(this.btnAggiungi);
            this.groupBox1.Controls.Add(this.lblDescrizione);
            this.groupBox1.Controls.Add(this.lblUnitadiMisura);
            this.groupBox1.Controls.Add(this.lblPrezzo);
            this.groupBox1.Controls.Add(this.lblCodice);
            this.groupBox1.Location = new System.Drawing.Point(31, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dettagli articolo";
            // 
            // cmbUnitaDiMisura
            // 
            this.cmbUnitaDiMisura.FormattingEnabled = true;
            this.cmbUnitaDiMisura.Location = new System.Drawing.Point(99, 105);
            this.cmbUnitaDiMisura.Name = "cmbUnitaDiMisura";
            this.cmbUnitaDiMisura.Size = new System.Drawing.Size(121, 23);
            this.cmbUnitaDiMisura.TabIndex = 5;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(53, 138);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(100, 23);
            this.txtPrezzo.TabIndex = 2;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(79, 65);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(100, 23);
            this.txtDescrizione.TabIndex = 2;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(56, 31);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 23);
            this.txtCodice.TabIndex = 4;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(65, 170);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(150, 41);
            this.btnAggiungi.TabIndex = 1;
            this.btnAggiungi.Text = "Aggiungi/modifica articolo";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(6, 68);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(67, 15);
            this.lblDescrizione.TabIndex = 1;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblUnitadiMisura
            // 
            this.lblUnitadiMisura.AutoSize = true;
            this.lblUnitadiMisura.Location = new System.Drawing.Point(6, 108);
            this.lblUnitadiMisura.Name = "lblUnitadiMisura";
            this.lblUnitadiMisura.Size = new System.Drawing.Size(87, 15);
            this.lblUnitadiMisura.TabIndex = 2;
            this.lblUnitadiMisura.Text = "Unità di misura";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(6, 146);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(41, 15);
            this.lblPrezzo.TabIndex = 3;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(6, 31);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(44, 15);
            this.lblCodice.TabIndex = 1;
            this.lblCodice.Text = "Codice";
            // 
            // lblArticoli
            // 
            this.lblArticoli.AutoSize = true;
            this.lblArticoli.Location = new System.Drawing.Point(31, 287);
            this.lblArticoli.Name = "lblArticoli";
            this.lblArticoli.Size = new System.Drawing.Size(45, 15);
            this.lblArticoli.TabIndex = 1;
            this.lblArticoli.Text = "Articoli";
            // 
            // cmbVisualizzaArticoli
            // 
            this.cmbVisualizzaArticoli.FormattingEnabled = true;
            this.cmbVisualizzaArticoli.Location = new System.Drawing.Point(432, 53);
            this.cmbVisualizzaArticoli.Name = "cmbVisualizzaArticoli";
            this.cmbVisualizzaArticoli.Size = new System.Drawing.Size(172, 23);
            this.cmbVisualizzaArticoli.TabIndex = 2;
            this.cmbVisualizzaArticoli.SelectedIndexChanged += new System.EventHandler(this.cmbVisualizzaArticoli_SelectedIndexChanged);
            // 
            // lstVisualizza
            // 
            this.lstVisualizza.FormattingEnabled = true;
            this.lstVisualizza.ItemHeight = 15;
            this.lstVisualizza.Location = new System.Drawing.Point(432, 82);
            this.lstVisualizza.Name = "lstVisualizza";
            this.lstVisualizza.Size = new System.Drawing.Size(175, 184);
            this.lstVisualizza.TabIndex = 3;
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(610, 53);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(47, 23);
            this.btnLista.TabIndex = 4;
            this.btnLista.Text = "...";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // lblParentesi
            // 
            this.lblParentesi.AutoSize = true;
            this.lblParentesi.Location = new System.Drawing.Point(82, 287);
            this.lblParentesi.Name = "lblParentesi";
            this.lblParentesi.Size = new System.Drawing.Size(15, 15);
            this.lblParentesi.TabIndex = 5;
            this.lblParentesi.Text = "()";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblParentesi);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.lstVisualizza);
            this.Controls.Add(this.cmbVisualizzaArticoli);
            this.Controls.Add(this.lblArticoli);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AS2122_4E_INF_LucianoRaffaeleMattia_18/05/2022_GestioneArticoli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAggiungi;
        private Label lblDescrizione;
        private Label lblUnitadiMisura;
        private Label lblPrezzo;
        private Label lblCodice;
        private Label lblArticoli;
        private ComboBox cmbUnitaDiMisura;
        private TextBox txtPrezzo;
        private TextBox txtDescrizione;
        private TextBox txtCodice;
        private ComboBox cmbVisualizzaArticoli;
        private ListBox lstVisualizza;
        private Button btnLista;
        private Label lblParentesi;
    }
}