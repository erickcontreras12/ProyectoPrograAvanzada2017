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
    public partial class CLey : Form
    {
        public CLey()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SLeyes vim8 = new SLeyes();
            vim8.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Leyes
            try
            {
                Pila<Ley> pila1 = new Pila<Ley>();
                Ley ley1 = new Ley(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox1.Text),textBox4.Text);
                Reglamentos regla = new Reglamentos();
                regla.setIdregla(Convert.ToInt32(textBox2.Text));
                regla.setNombreregla(textBox3.Text);
                ley1.add(regla);
                pila1.push(ley1);
                pila1.push(ley1);
                pila1.push(ley1);
                pila1.push(ley1);
                pila1.push(ley1);
                ClaseCompartida.arregloLeyes.Insertar(pila1);
                MessageBox.Show(ClaseCompartida.arregloLeyes.Mostrar());
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
                throw;
            }

        }

        private void CLey_Load(object sender, EventArgs e)
        {

        }
    }
}
