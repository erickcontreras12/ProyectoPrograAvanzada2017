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
    public partial class EliminarGrupo : Form
    {
        public EliminarGrupo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            ClaseCompartida.arregloGrupos.Eliminar(id);
            MessageBox.Show(ClaseCompartida.arregloGrupos.Mostrar());
            this.Hide();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SGrupoUsuario vim1 = new SGrupoUsuario();
            vim1.Show();
            this.Hide();
        }
    }
}
