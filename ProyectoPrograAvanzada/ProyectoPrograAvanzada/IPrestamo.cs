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
    public partial class IPrestamo : Form
    {
        public IPrestamo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloGrupos.Buscar(Convert.ToInt32(comboBox2.Text)).size(); i++)
            {
                ArregloUsuarios temp = ClaseCompartida.arregloGrupos;
                int temp2 = temp.Buscar(Convert.ToInt32(comboBox2.Text)).RecorrerUsuario()[i].getID();
                comboBox1.Items.Add(temp2);
            }
        }

        
    }
}
