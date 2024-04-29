namespace ExamenTPBD
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introducereDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizareDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareAngajatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereAngajatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiparireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statPlataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fluturasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareProcenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nRCRTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCTIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARBAZADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREMIIBRUTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALBRUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRUTIMPOZABILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPOZITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETINERIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIRATCARDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNGAJATIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ExamenTPBD.DataSet1();
            this.aNGAJATITableAdapter = new ExamenTPBD.DataSet1TableAdapters.ANGAJATITableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userControlRaport1 = new ExamenTPBD.UserControlRaport();
            this.userControlAjutor1 = new ExamenTPBD.UserControlAjutor();
            this.userControlProcente1 = new ExamenTPBD.UserControlProcente();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNGAJATIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajutorToolStripMenuItem,
            this.introducereDateToolStripMenuItem,
            this.tiparireToolStripMenuItem,
            this.modificareProcenteToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1477, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            this.ajutorToolStripMenuItem.Click += new System.EventHandler(this.ajutorToolStripMenuItem_Click);
            // 
            // introducereDateToolStripMenuItem
            // 
            this.introducereDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizareDateToolStripMenuItem,
            this.adaugareAngajatiToolStripMenuItem,
            this.stergereAngajatiToolStripMenuItem});
            this.introducereDateToolStripMenuItem.Name = "introducereDateToolStripMenuItem";
            this.introducereDateToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.introducereDateToolStripMenuItem.Text = "Introducere Date";
            // 
            // actualizareDateToolStripMenuItem
            // 
            this.actualizareDateToolStripMenuItem.Name = "actualizareDateToolStripMenuItem";
            this.actualizareDateToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.actualizareDateToolStripMenuItem.Text = "Actualizare Date";
            this.actualizareDateToolStripMenuItem.Click += new System.EventHandler(this.actualizareDateToolStripMenuItem_Click);
            // 
            // adaugareAngajatiToolStripMenuItem
            // 
            this.adaugareAngajatiToolStripMenuItem.Name = "adaugareAngajatiToolStripMenuItem";
            this.adaugareAngajatiToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.adaugareAngajatiToolStripMenuItem.Text = "Adaugare Angajati";
            this.adaugareAngajatiToolStripMenuItem.Click += new System.EventHandler(this.adaugareAngajatiToolStripMenuItem_Click);
            // 
            // stergereAngajatiToolStripMenuItem
            // 
            this.stergereAngajatiToolStripMenuItem.Name = "stergereAngajatiToolStripMenuItem";
            this.stergereAngajatiToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.stergereAngajatiToolStripMenuItem.Text = "Stergere Angajati";
            this.stergereAngajatiToolStripMenuItem.Click += new System.EventHandler(this.stergereAngajatiToolStripMenuItem_Click);
            // 
            // tiparireToolStripMenuItem
            // 
            this.tiparireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statPlataToolStripMenuItem,
            this.fluturasiToolStripMenuItem});
            this.tiparireToolStripMenuItem.Name = "tiparireToolStripMenuItem";
            this.tiparireToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.tiparireToolStripMenuItem.Text = "Tiparire";
            // 
            // statPlataToolStripMenuItem
            // 
            this.statPlataToolStripMenuItem.Name = "statPlataToolStripMenuItem";
            this.statPlataToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.statPlataToolStripMenuItem.Text = "Stat plata";
            this.statPlataToolStripMenuItem.Click += new System.EventHandler(this.statPlataToolStripMenuItem_Click);
            // 
            // fluturasiToolStripMenuItem
            // 
            this.fluturasiToolStripMenuItem.Name = "fluturasiToolStripMenuItem";
            this.fluturasiToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.fluturasiToolStripMenuItem.Text = "Fluturasi";
            this.fluturasiToolStripMenuItem.Click += new System.EventHandler(this.fluturasiToolStripMenuItem_Click);
            // 
            // modificareProcenteToolStripMenuItem
            // 
            this.modificareProcenteToolStripMenuItem.Name = "modificareProcenteToolStripMenuItem";
            this.modificareProcenteToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.modificareProcenteToolStripMenuItem.Text = "Modificare procente";
            this.modificareProcenteToolStripMenuItem.Click += new System.EventHandler(this.modificareProcenteToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(918, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nRCRTDataGridViewTextBoxColumn,
            this.nUMEDataGridViewTextBoxColumn,
            this.pRENUMEDataGridViewTextBoxColumn,
            this.fUNCTIEDataGridViewTextBoxColumn,
            this.sALARBAZADataGridViewTextBoxColumn,
            this.sPORDataGridViewTextBoxColumn,
            this.pREMIIBRUTEDataGridViewTextBoxColumn,
            this.tOTALBRUTDataGridViewTextBoxColumn,
            this.bRUTIMPOZABILDataGridViewTextBoxColumn,
            this.cASDataGridViewTextBoxColumn,
            this.cASSDataGridViewTextBoxColumn,
            this.iMPOZITDataGridViewTextBoxColumn,
            this.rETINERIDataGridViewTextBoxColumn,
            this.vIRATCARDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aNGAJATIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1330, 320);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // nRCRTDataGridViewTextBoxColumn
            // 
            this.nRCRTDataGridViewTextBoxColumn.DataPropertyName = "NR_CRT";
            this.nRCRTDataGridViewTextBoxColumn.HeaderText = "NR_CRT";
            this.nRCRTDataGridViewTextBoxColumn.Name = "nRCRTDataGridViewTextBoxColumn";
            // 
            // nUMEDataGridViewTextBoxColumn
            // 
            this.nUMEDataGridViewTextBoxColumn.DataPropertyName = "NUME";
            this.nUMEDataGridViewTextBoxColumn.HeaderText = "NUME";
            this.nUMEDataGridViewTextBoxColumn.Name = "nUMEDataGridViewTextBoxColumn";
            // 
            // pRENUMEDataGridViewTextBoxColumn
            // 
            this.pRENUMEDataGridViewTextBoxColumn.DataPropertyName = "PRENUME";
            this.pRENUMEDataGridViewTextBoxColumn.HeaderText = "PRENUME";
            this.pRENUMEDataGridViewTextBoxColumn.Name = "pRENUMEDataGridViewTextBoxColumn";
            // 
            // fUNCTIEDataGridViewTextBoxColumn
            // 
            this.fUNCTIEDataGridViewTextBoxColumn.DataPropertyName = "FUNCTIE";
            this.fUNCTIEDataGridViewTextBoxColumn.HeaderText = "FUNCTIE";
            this.fUNCTIEDataGridViewTextBoxColumn.Name = "fUNCTIEDataGridViewTextBoxColumn";
            // 
            // sALARBAZADataGridViewTextBoxColumn
            // 
            this.sALARBAZADataGridViewTextBoxColumn.DataPropertyName = "SALAR_BAZA";
            this.sALARBAZADataGridViewTextBoxColumn.HeaderText = "SALAR_BAZA";
            this.sALARBAZADataGridViewTextBoxColumn.Name = "sALARBAZADataGridViewTextBoxColumn";
            // 
            // sPORDataGridViewTextBoxColumn
            // 
            this.sPORDataGridViewTextBoxColumn.DataPropertyName = "SPOR";
            this.sPORDataGridViewTextBoxColumn.HeaderText = "SPOR";
            this.sPORDataGridViewTextBoxColumn.Name = "sPORDataGridViewTextBoxColumn";
            // 
            // pREMIIBRUTEDataGridViewTextBoxColumn
            // 
            this.pREMIIBRUTEDataGridViewTextBoxColumn.DataPropertyName = "PREMII_BRUTE";
            this.pREMIIBRUTEDataGridViewTextBoxColumn.HeaderText = "PREMII_BRUTE";
            this.pREMIIBRUTEDataGridViewTextBoxColumn.Name = "pREMIIBRUTEDataGridViewTextBoxColumn";
            // 
            // tOTALBRUTDataGridViewTextBoxColumn
            // 
            this.tOTALBRUTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_BRUT";
            this.tOTALBRUTDataGridViewTextBoxColumn.HeaderText = "TOTAL_BRUT";
            this.tOTALBRUTDataGridViewTextBoxColumn.Name = "tOTALBRUTDataGridViewTextBoxColumn";
            // 
            // bRUTIMPOZABILDataGridViewTextBoxColumn
            // 
            this.bRUTIMPOZABILDataGridViewTextBoxColumn.DataPropertyName = "BRUT_IMPOZABIL";
            this.bRUTIMPOZABILDataGridViewTextBoxColumn.HeaderText = "BRUT_IMPOZABIL";
            this.bRUTIMPOZABILDataGridViewTextBoxColumn.Name = "bRUTIMPOZABILDataGridViewTextBoxColumn";
            // 
            // cASDataGridViewTextBoxColumn
            // 
            this.cASDataGridViewTextBoxColumn.DataPropertyName = "CAS";
            this.cASDataGridViewTextBoxColumn.HeaderText = "CAS";
            this.cASDataGridViewTextBoxColumn.Name = "cASDataGridViewTextBoxColumn";
            // 
            // cASSDataGridViewTextBoxColumn
            // 
            this.cASSDataGridViewTextBoxColumn.DataPropertyName = "CASS";
            this.cASSDataGridViewTextBoxColumn.HeaderText = "CASS";
            this.cASSDataGridViewTextBoxColumn.Name = "cASSDataGridViewTextBoxColumn";
            // 
            // iMPOZITDataGridViewTextBoxColumn
            // 
            this.iMPOZITDataGridViewTextBoxColumn.DataPropertyName = "IMPOZIT";
            this.iMPOZITDataGridViewTextBoxColumn.HeaderText = "IMPOZIT";
            this.iMPOZITDataGridViewTextBoxColumn.Name = "iMPOZITDataGridViewTextBoxColumn";
            // 
            // rETINERIDataGridViewTextBoxColumn
            // 
            this.rETINERIDataGridViewTextBoxColumn.DataPropertyName = "RETINERI";
            this.rETINERIDataGridViewTextBoxColumn.HeaderText = "RETINERI";
            this.rETINERIDataGridViewTextBoxColumn.Name = "rETINERIDataGridViewTextBoxColumn";
            // 
            // vIRATCARDDataGridViewTextBoxColumn
            // 
            this.vIRATCARDDataGridViewTextBoxColumn.DataPropertyName = "VIRAT_CARD";
            this.vIRATCARDDataGridViewTextBoxColumn.HeaderText = "VIRAT_CARD";
            this.vIRATCARDDataGridViewTextBoxColumn.Name = "vIRATCARDDataGridViewTextBoxColumn";
            // 
            // aNGAJATIBindingSource
            // 
            this.aNGAJATIBindingSource.DataMember = "ANGAJATI";
            this.aNGAJATIBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aNGAJATITableAdapter
            // 
            this.aNGAJATITableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Actiune";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1362, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1362, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "Anulare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1359, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Intorduceti nume:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1365, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // userControlRaport1
            // 
            this.userControlRaport1.Location = new System.Drawing.Point(12, 31);
            this.userControlRaport1.Name = "userControlRaport1";
            this.userControlRaport1.Size = new System.Drawing.Size(1453, 428);
            this.userControlRaport1.TabIndex = 11;
            this.userControlRaport1.Visible = false;
            // 
            // userControlAjutor1
            // 
            this.userControlAjutor1.Location = new System.Drawing.Point(12, 31);
            this.userControlAjutor1.Name = "userControlAjutor1";
            this.userControlAjutor1.Size = new System.Drawing.Size(776, 397);
            this.userControlAjutor1.TabIndex = 2;
            // 
            // userControlProcente1
            // 
            this.userControlProcente1.Location = new System.Drawing.Point(12, 31);
            this.userControlProcente1.Name = "userControlProcente1";
            this.userControlProcente1.Size = new System.Drawing.Size(1464, 370);
            this.userControlProcente1.TabIndex = 8;
            this.userControlProcente1.Load += new System.EventHandler(this.userControlProcente1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControlAjutor1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userControlProcente1);
            this.Controls.Add(this.userControlRaport1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNGAJATIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem introducereDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizareDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareAngajatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereAngajatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiparireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statPlataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fluturasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareProcenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private UserControlAjutor userControlAjutor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource aNGAJATIBindingSource;
        private DataSet1TableAdapters.ANGAJATITableAdapter aNGAJATITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRCRTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fUNCTIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARBAZADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREMIIBRUTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALBRUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRUTIMPOZABILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPOZITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rETINERIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIRATCARDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControlProcente userControlProcente1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private UserControlRaport userControlRaport1;
    }
}

