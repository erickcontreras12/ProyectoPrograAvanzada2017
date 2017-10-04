using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograAvanzada
{
    class Pila : System.Collections.ArrayList
    {
        Pila()
        {
        }
            public void apilar(Object dato)
        {
            if (dato != null)
            {
                this.Add(dato);
            }
            else
            {
                MessageBox.Show("Introduzca un dato no nulo");
            }
        }

        //se elimina el elemento frontal de la pila.(pop)
        public void desapilar()
        {
            if (this.Count > 0)
            {
                this.Remove(this.Count - 1);
            }
        }

        //devuelve el elemento que esta en la cima de la pila. (top o peek)
        public Object cima()
        {
            Object datoAuxiliar = null;
            if (this.Count > 0)
            {
                datoAuxiliar = this.Contains(this.Count - 1);
            }
            return datoAuxiliar;
        }

        //devuelve cierto si la pila está vacía o falso en caso contrario (empty).
        public bool vacia()
        {
            bool ver = true;
            if (this.Count == 0)
            {
                ver = true;
            }
            else
            {
                ver = false;
            }
            return ver;
        }
    }
}
