using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenTPBD
{
    public partial class UserControlProcente : UserControl
    {
        public float CAS, CASS, IMPOZIT;

        public UserControlProcente()
        {
            InitializeComponent();
        }
        public event EventHandler Value1Change;
        public event EventHandler Value2Change;
        public event EventHandler Value3Change;
        public event EventHandler Button1Click;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CAS = (float)numericUpDown1.Value / 100;
            if (this.Value1Change != null)
                this.Value1Change(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Button1Click?.Invoke(this, e);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            CAS = (float)numericUpDown2.Value / 100;
            this.Value2Change?.Invoke(this, e);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            IMPOZIT = (float)numericUpDown3.Value / 100;
            this.Value3Change?.Invoke(this, e);
        }
    }
}
