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
    public partial class MUsuario : Form
    {
        public MUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClaseCompartida.arregloGrupos.Buscar(Convert.ToInt32(comboBox2.Text)).Buscar(Convert.ToInt32(comboBox1.Text)).setNombre(txtbNombreUsuario.Text);
            ClaseCompartida.arregloGrupos.Buscar(Convert.ToInt32(comboBox2.Text)).Buscar(Convert.ToInt32(comboBox1.Text)).setPuesto(txtbPuestoUsuario.Text);
            MessageBox.Show(ClaseCompartida.arregloGrupos.Mostrar());
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            SUsuarios vim6 = new SUsuarios();
            vim6.Show();
            this.Hide();
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

        private void MUsuario_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloGrupos.getSize(); i++)
            {
                ArregloUsuarios temp = ClaseCompartida.arregloGrupos;
                GrupoUsuarios temp2 = temp.BuscarPosicion(i);
                comboBox2.Items.Add(temp2.getIdGrupo());
            }
        }
    }
}
