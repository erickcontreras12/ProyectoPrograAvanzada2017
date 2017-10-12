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
    public partial class MLey : Form
    {
        public MLey()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SLeyes vim8 = new SLeyes();
            vim8.Show();
            this.Hide();
        }

        private void MLey_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloLeyes.getSize(); i++)
            {
                Leyes<Ley> temp = ClaseCompartida.arregloLeyes;
                Ley temp2 = temp.BuscarPosicion(i).verCima();
                comboBox1.Items.Add(temp2.getLey());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ley temp = new Ley(0,Convert.ToInt32(comboBox1.Text),textBox1.Text);
            Pila<Ley> temp2 = new Pila<Ley>();
            ClaseCompartida.arregloLeyes.Buscar(Convert.ToInt32(comboBox1.Text)).verCima().setEnunciado(textBox1.Text);
            //MessageBox.Show((ClaseCompartida.arregloLeyes.Buscar(Convert.ToInt32(comboBox1.Text)).verCima().mostrarLey()));
            temp = ClaseCompartida.arregloLeyes.Buscar(Convert.ToInt32(comboBox1.Text)).verCima();
            temp2 = ClaseCompartida.arregloLeyes.Buscar(Convert.ToInt32(comboBox1.Text));
            temp2.push(temp);
            temp2.push(temp);
            temp2.push(temp);
            temp2.push(temp);
            temp2.push(temp); 
            MessageBox.Show(ClaseCompartida.arregloLeyes.Mostrar());
        }
    }
}
