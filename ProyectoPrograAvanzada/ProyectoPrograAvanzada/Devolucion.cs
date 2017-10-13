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
            comboBox2.Items.Add("Ley");
            comboBox2.Items.Add("Reglamento");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idley = 0;
            if (comboBox2.Text == "Ley")
            {
                 idley = ClaseCompartida.arregloPrestamos.Buscar(Convert.ToInt32(comboBox1.Text)).getIDLey();
                ClaseCompartida.arregloLeyes.Buscar(idley).push(ClaseCompartida.prestamoLey.Buscar(idley));
                ClaseCompartida.prestamoLey.Eliminar(idley);
                ClaseCompartida.arregloPrestamos.Eliminar(Convert.ToInt32(comboBox1.Text));
            }
            else
            {
                int idregla = ClaseCompartida.arregloPrestamos.Buscar(Convert.ToInt32(comboBox1.Text)).getIdReglamento();
                ClaseCompartida.arregloLeyes.Buscar(idley).verCima().Buscar(idregla).ReglaDevuelta();
                ClaseCompartida.arregloPrestamos.Eliminar(Convert.ToInt32(comboBox1.Text));
            }
           

        }
    }
}
