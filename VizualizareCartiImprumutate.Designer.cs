namespace b2
{
    partial class VizualizareCartiImprumutate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numarCurentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataImprumutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarInventarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRestituireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprumuturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblioteca_BazaDataSet4 = new b2.Biblioteca_BazaDataSet4();
            this.imprumuturiTableAdapter = new b2.Biblioteca_BazaDataSet4TableAdapters.ImprumuturiTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumuturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca_BazaDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1019, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alege un autor pentru a vedea toate cărțile împrumutate ale acelui autor, respect" +
    "iv toate cărțile împrumutate. ";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1084, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Închidere";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numarCurentDataGridViewTextBoxColumn,
            this.dataImprumutDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.numarInventarDataGridViewTextBoxColumn,
            this.clasificareDataGridViewTextBoxColumn,
            this.dataRestituireDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.clasaDataGridViewTextBoxColumn,
            this.numarTelefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.imprumuturiBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1248, 253);
            this.dataGridView1.TabIndex = 4;
            // 
            // numarCurentDataGridViewTextBoxColumn
            // 
            this.numarCurentDataGridViewTextBoxColumn.DataPropertyName = "NumarCurent";
            this.numarCurentDataGridViewTextBoxColumn.HeaderText = "NumarCurent";
            this.numarCurentDataGridViewTextBoxColumn.Name = "numarCurentDataGridViewTextBoxColumn";
            this.numarCurentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataImprumutDataGridViewTextBoxColumn
            // 
            this.dataImprumutDataGridViewTextBoxColumn.DataPropertyName = "DataImprumut";
            this.dataImprumutDataGridViewTextBoxColumn.HeaderText = "DataImprumut";
            this.dataImprumutDataGridViewTextBoxColumn.Name = "dataImprumutDataGridViewTextBoxColumn";
            this.dataImprumutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numarInventarDataGridViewTextBoxColumn
            // 
            this.numarInventarDataGridViewTextBoxColumn.DataPropertyName = "NumarInventar";
            this.numarInventarDataGridViewTextBoxColumn.HeaderText = "NumarInventar";
            this.numarInventarDataGridViewTextBoxColumn.Name = "numarInventarDataGridViewTextBoxColumn";
            this.numarInventarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clasificareDataGridViewTextBoxColumn
            // 
            this.clasificareDataGridViewTextBoxColumn.DataPropertyName = "Clasificare";
            this.clasificareDataGridViewTextBoxColumn.HeaderText = "Clasificare";
            this.clasificareDataGridViewTextBoxColumn.Name = "clasificareDataGridViewTextBoxColumn";
            this.clasificareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRestituireDataGridViewTextBoxColumn
            // 
            this.dataRestituireDataGridViewTextBoxColumn.DataPropertyName = "DataRestituire";
            this.dataRestituireDataGridViewTextBoxColumn.HeaderText = "DataRestituire";
            this.dataRestituireDataGridViewTextBoxColumn.Name = "dataRestituireDataGridViewTextBoxColumn";
            this.dataRestituireDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "Titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clasaDataGridViewTextBoxColumn
            // 
            this.clasaDataGridViewTextBoxColumn.DataPropertyName = "Clasa";
            this.clasaDataGridViewTextBoxColumn.HeaderText = "Clasa";
            this.clasaDataGridViewTextBoxColumn.Name = "clasaDataGridViewTextBoxColumn";
            this.clasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numarTelefonDataGridViewTextBoxColumn
            // 
            this.numarTelefonDataGridViewTextBoxColumn.DataPropertyName = "NumarTelefon";
            this.numarTelefonDataGridViewTextBoxColumn.HeaderText = "NumarTelefon";
            this.numarTelefonDataGridViewTextBoxColumn.Name = "numarTelefonDataGridViewTextBoxColumn";
            this.numarTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imprumuturiBindingSource
            // 
            this.imprumuturiBindingSource.DataMember = "Imprumuturi";
            this.imprumuturiBindingSource.DataSource = this.biblioteca_BazaDataSet4;
            // 
            // biblioteca_BazaDataSet4
            // 
            this.biblioteca_BazaDataSet4.DataSetName = "Biblioteca_BazaDataSet4";
            this.biblioteca_BazaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imprumuturiTableAdapter
            // 
            this.imprumuturiTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.MistyRose;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 365);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(476, 32);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "Alege un autor";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.MistyRose;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 403);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(476, 32);
            this.comboBox3.Sorted = true;
            this.comboBox3.TabIndex = 6;
            this.comboBox3.Text = "Alege o carte";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(520, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Vezi toți autorii";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VizualizareCartiImprumutate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1255, 441);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1271, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1271, 480);
            this.Name = "VizualizareCartiImprumutate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VizualizareCartiImprumutate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VizualizareCarti_FormClosing);
            this.Load += new System.EventHandler(this.VizualizareCarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumuturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca_BazaDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Biblioteca_BazaDataSet4 biblioteca_BazaDataSet4;
        private System.Windows.Forms.BindingSource imprumuturiBindingSource;
        private Biblioteca_BazaDataSet4TableAdapters.ImprumuturiTableAdapter imprumuturiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarCurentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataImprumutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarInventarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRestituireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarTelefonDataGridViewTextBoxColumn;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
    }
}