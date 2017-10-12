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
    public partial class ELey : Form
    {
        public ELey()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void ELey_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloLeyes.getSize(); i++)
            {
                Leyes<Ley> temp = ClaseCompartida.arregloLeyes;
                Ley temp2 = temp.BuscarPosicion(i).verCima();
                comboBox1.Items.Add(temp2.getLey());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClaseCompartida.arregloLeyes.Eliminar(Convert.ToInt32(comboBox1.Text));
            MessageBox.Show(ClaseCompartida.arregloLeyes.Mostrar());
            this.Hide();
        }
    }
}
