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
    public partial class SReglamento : Form
    {
        public SReglamento()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Datos vim1 = new Datos();
            vim1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CReglamento vim14 = new CReglamento();
            vim14.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EReglamento vim18 = new EReglamento();
            vim18.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MReglamento vim15 = new MReglamento();
            vim15.Show();
            this.Hide();
        }
    }
}
