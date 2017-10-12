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
    public partial class MReglamento : Form
    {
        public MReglamento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SReglamento vim9 = new SReglamento();
            vim9.Show();
            this.Hide();
        }

        private void MReglamento_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloLeyes.getSize(); i++)
            {
                Leyes<Ley> temp = ClaseCompartida.arregloLeyes;
                Ley temp2 = temp.BuscarPosicion(i).verCima();
                comboBox1.Items.Add(temp2.getLey());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloLeyes.Buscar(Convert.ToInt32(comboBox1.Text)).verCima().size(); i++)
            {
                Leyes<Ley> temp = ClaseCompartida.arregloLeyes;
                int temp2 = temp.Buscar(Convert.ToInt32(comboBox1.Text)).verCima().RecorrerRegla()[i].getIdregla();
                comboBox2.Items.Add(temp2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pila<Ley> temp2 = new Pila<Ley>();
            Ley temp = new Ley(0, Convert.ToInt32(comboBox1.Text), null);
            ClaseCompartida.arregloLeyes.Buscar(Convert.ToInt32(comboBox1.Text)).verCima().Buscar(Convert.ToInt32(comboBox2.Text)).setNombreregla(textBox3.Text);
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
