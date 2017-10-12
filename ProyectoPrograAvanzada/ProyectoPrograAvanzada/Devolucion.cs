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
    public partial class Devolucion : Form
    {
        public Devolucion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrestDev ven = new PrestDev();
            ven.Show();
            this.Hide();
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloPrestamos.size; i++)
            {
                ArregloPrestamos temp = ClaseCompartida.arregloPrestamos;
                Prestamo aux = temp.BuscarPosicion(i);
                comboBox1.Items.Add(aux.getIdPrestamo());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClaseCompartida.arregloPrestamos.Eliminar(Convert.ToInt32(comboBox1.Text));
        }
    }
}
