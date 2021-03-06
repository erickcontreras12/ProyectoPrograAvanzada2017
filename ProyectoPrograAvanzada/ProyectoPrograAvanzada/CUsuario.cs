﻿using System;
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
    public partial class CUsuario : Form
    {
        public CUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new ProyectoPrograAvanzada.Usuario(txtbNombreUsuario.Text, txtbPuestoUsuario.Text, Convert.ToInt32(txtbIDUsuario.Text));
            ClaseCompartida.arregloGrupos.Buscar(Convert.ToInt32(comboBox2.Text)).add(user);
            MessageBox.Show("Usuario Creado");
            MessageBox.Show(ClaseCompartida.arregloGrupos.Mostrar());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SUsuarios vim6 = new SUsuarios();
            vim6.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CUsuario_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ClaseCompartida.arregloGrupos.getSize(); i++)
            {
                ArregloUsuarios temp = ClaseCompartida.arregloGrupos;
                GrupoUsuarios temp2 = temp.BuscarPosicion(i);
                comboBox2.Items.Add(temp2.getIdGrupo());
            }
        }
    }
}
