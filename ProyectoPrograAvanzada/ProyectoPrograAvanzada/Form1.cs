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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos vim1 = new Datos();
            vim1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrestDev vim2 = new PrestDev();
            vim2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Informes vim3 = new Informes();
            vim3.Show();
            this.Hide();
        }
    }
}
