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
    public partial class SLeyes : Form
    {
        public SLeyes()
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
            Datos vim1 = new Datos();
            vim1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLey vim12 = new CLey();
            vim12.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MLey vim13 = new MLey();
            vim13.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ELey foo = new ELey();
            foo.Show();
        }
    }
}
