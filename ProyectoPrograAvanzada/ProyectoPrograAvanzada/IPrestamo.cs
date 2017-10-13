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
    public partial class IPrestamo : Form
    {
        public IPrestamo()
        {
            InitializeComponent();
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

        private void IPrestamo_Load(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            PrestDev ven = new PrestDev();
            ven.Show();
            this.Hide();
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
                prestamo.reglamento = prestamo.ley.Buscar(Convert.ToInt32(comboBox4.Text));
                if (prestamo.realizarPrestamo(prestamo.getIDGrupoUsuario(),prestamo.user.getID(),prestamo.getIDLey(),prestamo.reglamento.getIdregla(),2))
                {
                    if (ClaseCompartida.arregloLeyes.Buscar(Convert.ToInt32(comboBox3.Text)).verCima().Buscar(Convert.ToInt32(comboBox4.Text)).getDisponible() != false)
                    {
                        ClaseCompartida.arregloPrestamos.Insertar(prestamo);
                        ClaseCompartida.arregloLeyes.Buscar(Convert.ToInt32(comboBox3.Text)).verCima().Buscar(Convert.ToInt32(comboBox4.Text)).RegLaPrestada();

                    }
                    
                }
                else
                {
                    MessageBox.Show("Su solicitud no esta disponible, sera ingresado a una lista de espera");
                    ClaseCompartida.listaEspera.Insertar(prestamo);
                }
               
            }catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloLeyes.Buscar(Convert.ToInt32(comboBox3.Text)).verCima().size(); i++)
            {
                Leyes<Ley> temp = ClaseCompartida.arregloLeyes;
                int temp2 = temp.Buscar(Convert.ToInt32(comboBox3.Text)).verCima().RecorrerRegla()[i].getIdregla();
                comboBox4.Items.Add(temp2);
            }
        }
    }
}
