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
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ven = new Form1();
            ven.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ClaseCompartida.arregloPrestamos.Mostrar());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prestamo[] imprimir = ClaseCompartida.listaDeEspera.imprimirCola();
            
            for (int i = 0; i < ClaseCompartida.listaDeEspera.obtenerCola(); i++)
            {
                MessageBox.Show(imprimir[i].toString());
            }
            
        }
    }
}
