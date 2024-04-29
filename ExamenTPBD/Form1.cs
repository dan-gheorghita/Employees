using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
//TO-DO
//de modificat UI sa fie dinamic in functie de marimea ferestrei(sa pun limite incat daca e mai mici de o marime sa nu se mai schimve ui-ul)
//parola modificari procente
//finalizare introducere messagebox?

//DONE
//evitarea introducerii numerelor negative in casute
//la Actualizare date sa nu se poata adauga date noi in gridview(ultima linie)
//la Cautare sa fie dezactivata functia de Adaugare angajati


namespace ExamenTPBD
{
    public partial class Form1 : Form
    {
        //Stocarea procentelor de la taxe
        float CAS, CASS, IMPOZIT;
        int rownum,lastrow = -1;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            //Ascunde meniul Ajutor si meniul Procente la initializare
            userControlAjutor1.Hide();
            toggleControlAjutor = false;
            userControlProcente1.Hide();
            userControlProcente1.SendToBack();
            toggleControlProcente = false;
            //Initializeaza procentele taxelor
            CAS = 0.25f;
            CASS = 0.1f;
            IMPOZIT = 0.1f;
            //Declarare de eventhandler pentru a reactiona la evenimentele din UserControl
            userControlProcente1.Value1Change += new EventHandler(UserControlProcente1_Value1Change);
            userControlProcente1.Value2Change += new EventHandler(UserControlProcente1_Value2Change);
            userControlProcente1.Value3Change += new EventHandler(UserControlProcente1_Value3Change);
            userControlProcente1.Button1Click += new EventHandler(UserControlProcente1_Button1Click);

        }

        //ITERFACE FUNCTIONS
        //Boolean pentru a verifica cand un meniu trebuie inchis sau deschis
        bool toggleControlAjutor, toggleControlProcente;
        //Meniu ajutor
        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toggleControlAjutor)
            {
                userControlAjutor1.Hide();
                userControlAjutor1.SendToBack();
                toggleControlAjutor = false;
            }
            else
            {
                userControlAjutor1.BringToFront();
                userControlAjutor1.Show();
                toggleControlAjutor = true;
            }

        }
        //Meniu modificare procente pentru taxe
        private void modificareProcenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //label1.Text = Convert.ToString(userControlProcente1.CAS);
            if (toggleControlProcente)
            {
                userControlProcente1.Hide();
                userControlProcente1.SendToBack();
                toggleControlProcente = false;
            }
            else
            {
                userControlProcente1.BringToFront();
                userControlProcente1.Show();
                toggleControlProcente = true;
            }
        }
        //Meniu care afiseaza statul de plata
        private void statPlataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Seteaza un toggle care indica procesul dintre StatPlata sau Fluturasi
            userControlRaport1.toggleRaport = true;
            //Toggle vizibilitate
            userControlRaport1.Visible = !userControlRaport1.Visible;
            if (userControlRaport1.Visible)
                userControlRaport1.BringToFront();
            else
                userControlRaport1.SendToBack();

        }
        //Meniu care afiseaza fluturasii fiecarui angajat
        private void fluturasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Seteaza un toggle care indica procesul dintre StatPlata sau Fluturasi
            userControlRaport1.toggleRaport = false;
            //Toggle vizibilitate
            userControlRaport1.Visible = !userControlRaport1.Visible;
            if (userControlRaport1.Visible)
                userControlRaport1.BringToFront();
            else
                userControlRaport1.SendToBack();
        }
        //Button de iesire din aplicatie
        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Actiuni la meniul cu Procente
        private void UserControlProcente1_Button1Click(object sender, EventArgs e)
        {
            recalculareToatala();
            Form1_Load(sender, e);
            
        }

        private void UserControlProcente1_Value3Change(object sender, EventArgs e)
        {
            IMPOZIT = userControlProcente1.IMPOZIT;
            
        }

        private void UserControlProcente1_Value2Change(object sender, EventArgs e)
        {
            CASS = userControlProcente1.CASS;
            
        }

        private void UserControlProcente1_Value1Change(object sender, EventArgs e)
        {
            CAS = userControlProcente1.CAS;
            
        }

        OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=STUDENT;Unicode=True");
        OracleDataAdapter da;
        DataSet ds;
        OracleCommandBuilder comanda;
        BindingSource bs = new BindingSource();

        //Extragerea datelor dintrun tabel OracleDatabase numit "angajati" si inserarea lor intr-un Dataset si Gridview
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ANGAJATI' table. You can move, or remove it, as needed.
            // this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
            //Dezactivarea butoanelor de Salvare si Anularea
            button1.Enabled = false;
            button2.Enabled = false;
            try
            {
                conn.Open();
                //Selectarea tabelei de angajati prin comanda sql
                string strSQL = "SELECT * FROM Angajati";
                da = new OracleDataAdapter(strSQL, conn);
                // ** Fill DataSet
                ds = new DataSet();
                da.Fill(ds, "angajati");
                comanda = new OracleCommandBuilder(da);
                //Introducere tabela in Gridview
                dataGridView1.DataSource = ds.Tables["angajati"];
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                //label1.Text = "Eroare‐ date invalide " + ex.ToString();
                MessageBox.Show("Eroare‐ date invalide " + ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }

        //ACTUALIZARE
        private void actualizareDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Actualizare Date";
            button1.Enabled = true;
            button2.Enabled = true;
            adaugareAngajatiToolStripMenuItem.Enabled = false;
            stergereAngajatiToolStripMenuItem.Enabled = false;
            //Harcodam selectia de coloane care pot fi schimbate
            try
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns[0].ReadOnly = true;
                for (int i = 7; i<12; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                dataGridView1.Columns[13].ReadOnly = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //ADAUGARE
        private void adaugareAngajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Adaugare Date";
            Form1_Load(sender, e);
            button1.Enabled = true;
            button2.Enabled = true;
            textBox1.Enabled = false;
            actualizareDateToolStripMenuItem.Enabled = false;
            stergereAngajatiToolStripMenuItem.Enabled = false;
            try
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns[0].ReadOnly = true;
                for (int i = 5; i < 14; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                DataRow Linie1 = ds.Tables["angajati"].NewRow();
                ds.Tables["angajati"].Rows.Add(Linie1);
                Linie1["SPOR"] = 0;
                Linie1["PREMII_BRUTE"] = 0;
                Linie1["RETINERI"] = 0;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //STERGERE
        private void stergereAngajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Doriti sa stergeti linia selectata?","Stergere", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (ds.Tables["angajati"].Rows.Count > 0)
                {
                    if (bs.Count > 0)
                    {
                        bs.RemoveCurrent();
                        bs.EndEdit();
                        // apel buton salvare (toolStripButton1_Click)
                        // button1_Click(null, null);
                        da.Update(ds.Tables["angajati"]);
                        dataGridView1.ReadOnly = true;
                        label1.Text = "Sters de Binding";
                    }
                    else
                    {
                        int rownum = (dataGridView1.CurrentCell.RowIndex);
                        DataRow Linie = ds.Tables["angajati"].Rows[rownum];
                        Linie.Delete();
                        da.Update(ds.Tables["angajati"]);
                        dataGridView1.ReadOnly = true;
                        label1.Text = "Sters";

                    }
                }
            }
        }

        //CAUTARE
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                label1.Text = "Enter";
                this.ActiveControl = null;
                bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                bs.Filter = "NUME" + " like '%" + textBox1.Text + "%'";
                dataGridView1.DataSource = bs;
                if (textBox1.Text == "")
                    adaugareAngajatiToolStripMenuItem.Enabled = true;
                else
                    adaugareAngajatiToolStripMenuItem.Enabled = false;
            }
        }

        //SALVARE
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            actualizareDateToolStripMenuItem.Enabled = true;
            adaugareAngajatiToolStripMenuItem.Enabled = true;
            stergereAngajatiToolStripMenuItem.Enabled = true;
            //Verificarea daca linia a fost salvata
            lastrow = -1;
            try
            {
                int rownum = (dataGridView1.CurrentCell.RowIndex);
                DataRow Linie = ds.Tables["angajati"].Rows[rownum];
                calculareRow(Linie);
                da.Update(ds.Tables["angajati"]);
                ds.AcceptChanges(); //era doar aceasta linie!
                                    // MessageBox.Show("OK");
                label2.Text = "OK‐ Salvat";
                Form1_Load(sender,e);
                //dataGridView1.ReadOnly = true;
                //button1.Enabled = false;
                //button2.Enabled = false;
            }
            catch(Exception error)
            {
                MessageBox.Show("Date incomplete ‐ " + error.Message);
            }
            
        }

        //ANULARE
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            actualizareDateToolStripMenuItem.Enabled = true;
            adaugareAngajatiToolStripMenuItem.Enabled = true;
            stergereAngajatiToolStripMenuItem.Enabled = true;
            //Verificarea daca linia a fost anulata
            lastrow = -1;
            try
            {
                ds.RejectChanges();
                dataGridView1.ReadOnly = true;
                button1.Enabled = false;
                button2.Enabled = false;
                label2.Text = "Anulat";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void calculareRow(DataRow Linie)
        {

            //TOTAL_BRUT= SALAR_BAZA*(1+SPOR_%/100)+PREMII_BRUTE
            Linie["TOTAL_BRUT"] = (Convert.ToInt32(Linie["SALAR_BAZA"]) * (1 + (Convert.ToDouble(Linie["SPOR"]) / 100))) + Convert.ToInt32(Linie["PREMII_BRUTE"]);
            //CAS = TOTAL_BRUT* CAS_%
            Linie["CAS"] = Convert.ToInt32(Linie["TOTAL_BRUT"]) * CAS;
            //SANAT = TOTAL_BRUT * CASS_ %
            Linie["CASS"] = Convert.ToInt32(Linie["TOTAL_BRUT"]) * CASS;
            //BRUT_IMPOZABIL = TOTAL_BRUT - CAS – CASS
            Linie["BRUT_IMPOZABIL"] = Convert.ToInt32(Linie["TOTAL_BRUT"]) - Convert.ToInt32(Linie["CAS"]) - Convert.ToInt32(Linie["CASS"]);
            //IMPOZIT = BRUT_IMPOZABIL * IMPOZIT_ %
            Linie["IMPOZIT"] = Convert.ToInt32(Linie["BRUT_IMPOZABIL"]) * IMPOZIT;
            //VIRAT_CARD = TOTAL_BRUT - IMPOZIT - CAS – CASS - RETINERI
            Linie["VIRAT_CARD"] = Convert.ToInt32(Linie["BRUT_IMPOZABIL"]) - Convert.ToInt32(Linie["IMPOZIT"]) - Convert.ToInt32(Linie["RETINERI"]);
        }

        private void recalculareToatala()
        {
            foreach (DataRow Linie in ds.Tables["angajati"].Rows)
            {
                calculareRow(Linie);
            }
            da.Update(ds.Tables["angajati"]);
            ds.AcceptChanges();
        }

        //Verificarea introducerii unor valori in coloanele care reprezinta numere pozitive
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                //Pentru coloanele SALAR_BAZA, SPOR, PREMII_BRUTE se verifica
                for (int i = 4; i < 7; i++)
                {
                    if (e.ColumnIndex == i)
                        if(dataGridView1.ReadOnly == false)
                            if (Convert.ToInt32(e.FormattedValue) < 0)
                            {
                                MessageBox.Show("Introduceti o valoare pozitiva");
                                //Ramane focusul pe caseta si trebuie schimbata valoarea pentru a trece mai departe
                                e.Cancel = true;
                            }
                }
                //Pentru coloana RETINERI
                if (e.ColumnIndex == 12)
                    if (dataGridView1.ReadOnly == false)
                        if (Convert.ToInt32(e.FormattedValue) < 0)
                        {
                            MessageBox.Show("Introduceti o valoare pozitiva");
                            //Ramane focusul pe caseta si trebuie schimbata valoarea pentru a trece mai departe
                            e.Cancel = true;
                        }

            }
            catch (Exception)
            {
                MessageBox.Show("Format gresit! Introduceti un numar.");
                e.Cancel = true;
                //throw;
            }
        }
        //Atentionarea utilizatorului sa salveze datele inainte sa editeze urmatoarea linie
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(button1.Enabled)
            if (lastrow != -1)
                if (e.RowIndex != lastrow)
                    {
                        MessageBox.Show("Save changes on row!");
                        e.Cancel = true;
                        dataGridView1.Rows[lastrow].Selected = true;
                    }

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            lastrow = e.RowIndex;
            //label1.Text = "Last row: " + lastrow;
        }

        //Tratarea exceptilor de inserare de date in gridview
        //In celulele unde sunt date numerice apare mesajul de avertizare
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            // MessageBox.Show("Error happened " + anError.Context.ToString());
            MessageBox.Show("Format gresit! Introduceti un numar.");

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }

        private void userControlProcente1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            //label1.Text = "Validat";
        }

    }
}
