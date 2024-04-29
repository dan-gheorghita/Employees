using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ExamenTPBD
{
    public partial class UserControlRaport : UserControl
    {
        public bool toggleRaport;
        public UserControlRaport()
        {
            InitializeComponent();
            toggleRaport = true;
            
        }
        OracleConnection conn;
        OracleDataAdapter da;
        DataSet ds;
        OracleCommandBuilder comanda;
        BindingSource bs1 = new BindingSource();

        private void UserControlRaport_VisibleChanged(object sender, EventArgs e)
        {
            if (toggleRaport)
            {
                label1.Text = "S-a inregistrat";
                try
                {
                    conn = new OracleConnection("Data Source=xe;User ID=student;Password=STUDENT;Unicode=True");
                    string strSQL = "SELECT * FROM angajati";// where nume =" + "'" + textBox1.Text + "'";
                    da = new OracleDataAdapter(strSQL, conn);
                    ds = new DataSet();
                    da.Fill(ds, "angajati");
                    CrystalReportStat raport = new CrystalReportStat();
                    crystalReportViewer1.DisplayGroupTree = false;
                    raport.SetDataSource(ds.Tables["angajati"]);
                    crystalReportViewer1.ReportSource = raport;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            } else
            {
                label1.Text = "S-a FLUTURAS";
                try
                {
                    conn = new OracleConnection("Data Source=xe;User ID=student;Password=STUDENT;Unicode=True");
                    string strSQL = "SELECT * FROM angajati";// where nume =" + "'" + textBox1.Text + "'";
                    da = new OracleDataAdapter(strSQL, conn);
                    ds = new DataSet();
                    da.Fill(ds, "angajati");
                    CrystalReportFluturas raport = new CrystalReportFluturas();
                    crystalReportViewer1.DisplayGroupTree = false;
                    raport.SetDataSource(ds.Tables["angajati"]);
                    crystalReportViewer1.ReportSource = raport;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            
        }
    }
}
