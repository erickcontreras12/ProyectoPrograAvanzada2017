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
    public partial class EUsuario : Form
    {
        public EUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SUsuarios vim6 = new SUsuarios();
            vim6.Show();
            this.Hide();
        }

        private void EUsuario_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloGrupos.getSize(); i++)
            {
                ArregloUsuarios temp = ClaseCompartida.arregloGrupos;
                GrupoUsuarios temp2 = temp.BuscarPosicion(i);
                comboBox1.Items.Add(temp2.getIdGrupo());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloGrupos.Buscar(Convert.ToInt32(comboBox1.Text)).size(); i++)
            {
                ArregloUsuarios temp = ClaseCompartida.arregloGrupos;
                int temp2 = temp.Buscar(Convert.ToInt32(comboBox1.Text)).RecorrerUsuario()[i].getID();
                comboBox2.Items.Add(temp2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClaseCompartida.arregloGrupos.Buscar(Convert.ToInt32(comboBox1.Text)).remove(Convert.ToInt32(comboBox2.Text));
            MessageBox.Show(ClaseCompartida.arregloGrupos.Mostrar());
            SUsuarios vim = new SUsuarios();
            vim.Show();
            this.Hide();
            
        }
    }
}
