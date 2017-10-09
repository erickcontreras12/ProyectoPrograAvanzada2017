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
    }
}
