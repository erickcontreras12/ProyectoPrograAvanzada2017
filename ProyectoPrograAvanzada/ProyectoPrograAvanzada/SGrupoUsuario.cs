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
    public partial class SGrupoUsuario : Form
    {
        public SGrupoUsuario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usuarios vim4 = new Usuarios();
            vim4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CGrupoUsuario vim7 = new CGrupoUsuario();
            vim7.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EGrupoUsuario vim1 = new EGrupoUsuario();
            vim1.Show();
            this.Hide();
        }
    }
}
