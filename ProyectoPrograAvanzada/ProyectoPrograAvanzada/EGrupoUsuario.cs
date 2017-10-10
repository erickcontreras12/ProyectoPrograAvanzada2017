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
    public partial class EGrupoUsuario : Form
    {
        public EGrupoUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SGrupoUsuario vim5 = new SGrupoUsuario();
            vim5.Show();
            this.Hide();   
        }

        private void EGrupoUsuario_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloGrupos.getSize(); i++)
            {
                ArregloUsuarios temp = ClaseCompartida.arregloGrupos;
                GrupoUsuarios temp2 = temp.BuscarPosicion(i);
                comboBox1.Items.Add(temp2.getIdGrupo());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox1.Text);
            ClaseCompartida.arregloGrupos.Eliminar(id);
            MessageBox.Show(ClaseCompartida.arregloGrupos.Mostrar());
            this.Hide();
        }
    }
}
