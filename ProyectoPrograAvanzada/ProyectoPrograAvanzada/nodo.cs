using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograAvanzada
{
    class nodo<T>
    {
        //clase que contiene el dato y los enlaces de la pila
        public T dato;
        public nodo<T> anterior, siguiente;
        public nodo(T sDato)
        {
            dato = sDato;
        }
    }
}

