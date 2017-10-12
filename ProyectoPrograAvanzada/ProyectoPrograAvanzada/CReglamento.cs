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
    public partial class CReglamento : Form
    {
        public CReglamento()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SReglamento vim9 = new SReglamento();
            vim9.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClaseCompartida.arregloLeyes.Buscar(Convert.ToInt32(comboBox1.Text)).verCima().size()== ClaseCompartida.arregloLeyes.Buscar(Convert.ToInt32(comboBox1.Text)).verCima().getCapacity())
            {
                MessageBox.Show("Ley llena de reglamentos");
            }
            else
            {
                Pila<Ley> temp2 = new Pila<Ley>();
                Ley temp = new Ley(0, Convert.ToInt32(comboBox1.Text), null);
                Reglamentos datos = new Reglamentos();
                datos.setIdregla(Convert.ToInt32(textBox2.Text));
                datos.setNombreregla(textBox3.Text);
                ClaseCompartida.arregloLeyes.Buscar(Convert.ToInt32(comboBox1.Text)).verCima().add(datos);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CReglamento_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloLeyes.getSize(); i++)
            {
                Leyes<Ley> temp = ClaseCompartida.arregloLeyes;
                Ley temp2 = temp.BuscarPosicion(i).verCima();
                comboBox1.Items.Add(temp2.getLey());
            }
        }
    }
}
