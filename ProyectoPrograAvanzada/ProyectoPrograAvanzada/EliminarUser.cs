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
    public partial class EliminarUser : Form
    {
        public EliminarUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClaseCompartida.arregloGrupos.Buscar(Convert.ToInt32(textBox2.Text)).remove(Convert.ToInt32(textBox1.Text));
            MessageBox.Show(ClaseCompartida.arregloGrupos.Mostrar());
            this.Hide();
        }
    }
}
