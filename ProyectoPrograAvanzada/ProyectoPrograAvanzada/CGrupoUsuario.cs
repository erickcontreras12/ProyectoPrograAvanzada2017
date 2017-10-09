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
    public partial class CGrupoUsuario : Form
    {
        public CGrupoUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SGrupoUsuario vim5 = new SGrupoUsuario();
            vim5.Show();
            this.Hide();
        }

        private void CGrupoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtbIDGrupo.Text);
            GrupoUsuarios grupo = new GrupoUsuarios(n);
            int n2 = Convert.ToInt32(txtbIDUsuario.Text);
            Usuario user = new Usuario(txtbNombreUsuario.Text, txtbPuestoUsuario.Text, n2);
            grupo.add(user);
            ClaseCompartida.arregloGrupos.Insertar(grupo);
            MessageBox.Show("Grupo Creado");
            MessageBox.Show(ClaseCompartida.arregloGrupos.Mostrar());
        }
    }
}
