namespace okienkowyDoBazy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dodaj = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.sortuj = new System.Windows.Forms.Button();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.pobierz = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(691, 284);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(83, 70);
            this.dodaj.TabIndex = 0;
            this.dodaj.Text = "dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // usun
            // 
            this.usun.Location = new System.Drawing.Point(691, 360);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(83, 65);
            this.usun.TabIndex = 1;
            this.usun.Text = "usun";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // sortuj
            // 
            this.sortuj.Location = new System.Drawing.Point(691, 207);
            this.sortuj.Name = "sortuj";
            this.sortuj.Size = new System.Drawing.Size(83, 71);
            this.sortuj.TabIndex = 2;
            this.sortuj.Text = "sortuj";
            this.sortuj.UseVisualStyleBackColor = true;
            this.sortuj.Click += new System.EventHandler(this.sortuj_Click);
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(16, 50);
            this.tabela.MultiSelect = false;
            this.tabela.Name = "tabela";
            this.tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela.Size = new System.Drawing.Size(669, 388);
            this.tabela.TabIndex = 3;
            // 
            // pobierz
            // 
            this.pobierz.Location = new System.Drawing.Point(691, 50);
            this.pobierz.Name = "pobierz";
            this.pobierz.Size = new System.Drawing.Size(83, 98);
            this.pobierz.TabIndex = 10;
            this.pobierz.Text = "pobierz";
            this.pobierz.UseVisualStyleBackColor = true;
            this.pobierz.Click += new System.EventHandler(this.pobierz_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 60;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Użytkownicy",
            "Przedmioty",
            "Przywileje"});
            this.comboBox1.Location = new System.Drawing.Point(95, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(590, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pobierz);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.sortuj);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.dodaj);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Button sortuj;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Button pobierz;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

