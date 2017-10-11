using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograAvanzada
{
    class Cola<T>
    {
        //ATRIBUTOS
        private nodo<T> inicio;
        private nodo<T> fin;
        private int cola;

        
        public bool esta_vacia()
        {
            if (cola == 0)
                return true;
            return false;
        }
    
        public bool agregar(T dato)
        {
            nodo<T> nuevo = new nodo<T>(dato);
            if (esta_vacia())
            {
                inicio = nuevo;
            }
            else
            {
                fin.siguiente = nuevo;
            }
            fin = nuevo;
            cola++;
            return true;
        }

        public T obtener()
        {
            if (esta_vacia())
            {
                return default(T);
            }
            else
            {
                nodo<T> aux = inicio;
                inicio = inicio.siguiente;
                cola--;
                if (cola == 0)
                {
                    fin = null;
                }
                return aux.dato;
            }
        }

        /**public T imprimirCola()
        {
            int tmp = cola;
            
            nodo<T> temp = inicio;
            while (cola > 0)
            {
                T resultado = inicio.dato;
                return resultado;
                obtener();
            }
            inicio = temp;
            cola = tmp;
        }
   **/
}
}
