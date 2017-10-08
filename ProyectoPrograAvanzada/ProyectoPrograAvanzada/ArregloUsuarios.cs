﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograAvanzada
{
    class ArregloUsuarios
    {
        int codigo;
        public GrupoUsuarios first, last;
        public ArregloUsuarios siguiente;

        public ArregloUsuarios(int codigo)
        {
            this.codigo = codigo;
            first = last = null;
            siguiente = null;
        }

        public int Codigo
        {
            get { return codigo; }
        }

        public void Insertar(GrupoUsuarios nuevo)
        {
            if (first == null)
                first = nuevo;
            else
                last.siguiente = nuevo;
            last = nuevo;
        }

        public String Mostrar()
        {
            String regreso = "";
            if (first != null)
            {
                GrupoUsuarios actual = first;
                GrupoUsuarios Temp = actual;
                while (actual != null)
                {
                    regreso += actual.mostrarUsuarios()+ "\n";
                    actual = actual.siguiente;
                }
            }
            else
                regreso = "\nla lista de usuarios esta {0} Está Vacía...";

            return regreso;
        }

        /** public void MostrarLey()
         {
             Console.Write("N° Ley: {0}\n", codigo);
         }**/

        public GrupoUsuarios Buscar(int n)
        {
            GrupoUsuarios actual = first;
            while (actual != null)
            {
                if (actual.getIdGrupo() == n)
                    return actual;
                actual = actual.siguiente;
            }
            return null;
        }

        public void Eliminar(int n)
        {
            if (first != null)
            {
                GrupoUsuarios actual, padre;
                padre = BuscarPadre(n);
                if (padre == last)
                {
                    MessageBox.Show("\nUsuario No Encontrado...");
                    return;
                }
                if (padre == null)
                {
                    actual = first;
                    first = first.siguiente;
                    padre = first;
                }
                else
                {
                    actual = padre.siguiente;
                    padre.siguiente = actual.siguiente;
                }
                actual = null;
                if (padre == null || padre.siguiente == null)
                    last = padre;
                MessageBox.Show("Usuario eliminado");
            }
            else
                MessageBox.Show("\nNo Existe ningun Usuario");
        }

        private GrupoUsuarios BuscarPadre(int n)
        {
            GrupoUsuarios padre, actual;
            actual = first;
            padre = null;
            while (actual != null)
            {
                if (actual.getIdGrupo() == n)
                    break;
                padre = actual;
                actual = actual.siguiente;
            }
            return padre;
        }
    }
}