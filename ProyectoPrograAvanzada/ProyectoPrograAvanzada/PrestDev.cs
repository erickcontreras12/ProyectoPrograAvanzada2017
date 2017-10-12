using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograAvanzada
{
    public partial class PrestDev : Form
    {
        public PrestDev()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPrestamo ven = new IPrestamo();
            ven.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LPrestamo ven2 = new LPrestamo();
            ven2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Devolucion ven3 = new Devolucion();
            ven3.Show();
            this.Hide();
        }
    }
}
