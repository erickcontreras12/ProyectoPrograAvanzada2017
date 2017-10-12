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
    public partial class LPrestamo : Form
    {
        public LPrestamo()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrestDev ven = new PrestDev();
            ven.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloGrupos.Buscar(Convert.ToInt32(comboBox1.Text)).size(); i++)
            {
                ArregloUsuarios temp = ClaseCompartida.arregloGrupos;
                int temp2 = temp.Buscar(Convert.ToInt32(comboBox1.Text)).RecorrerUsuario()[i].getID();
                comboBox2.Items.Add(temp2);
            }
        }

        private void LPrestamo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloGrupos.getSize(); i++)
            {
                ArregloUsuarios temp = ClaseCompartida.arregloGrupos;
                GrupoUsuarios temp2 = temp.BuscarPosicion(i);
                comboBox1.Items.Add(temp2.getIdGrupo());
            }

            for (int i = 0; i < ClaseCompartida.arregloLeyes.getSize(); i++)
            {
                Leyes<Ley> temp = ClaseCompartida.arregloLeyes;
                Ley temp2 = temp.BuscarPosicion(i).verCima();
                comboBox3.Items.Add(temp2.getLey());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Random obj = new Random();
                Prestamo prestamo = new Prestamo(obj.Next(0, 10000));
                prestamo.grupo = ClaseCompartida.arregloGrupos.Buscar(Convert.ToInt32(comboBox1.Text));
                prestamo.user = prestamo.grupo.Buscar(Convert.ToInt32(comboBox2.Text));
                prestamo.ley = ClaseCompartida.arregloLeyes.first.verCima();
                if (prestamo.realizarPrestamo(prestamo.getIDGrupoUsuario(), prestamo.user.getID(), prestamo.getIDLey(), prestamo.ley.Buscar(Convert.ToInt32(comboBox3.Text)).getIdregla(), 1))
                {
                    ClaseCompartida.arregloPrestamos.Insertar(prestamo);
                    MessageBox.Show(ClaseCompartida.arregloPrestamos.Mostrar());
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }
    }
}
