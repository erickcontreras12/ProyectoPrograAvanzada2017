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
    public partial class SUsuarios : Form
    {
        public SUsuarios()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Usuarios vim4 = new Usuarios();
            vim4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CUsuario vim10 = new CUsuario();
            vim10.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MUsuario vim11 = new MUsuario();
            vim11.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EUsuario vim12 = new EUsuario();
            vim12.Show();
            this.Hide();
        }
    }
}
