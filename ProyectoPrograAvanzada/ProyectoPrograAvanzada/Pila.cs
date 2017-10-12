using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograAvanzada
{
    class Pila<T> : System.Collections.ArrayList
    {
        nodo<T> cima;
        public Pila<T> siguiente;
        public int posicion;
        public void setPosicion(int pos)
        {
            this.posicion = pos;
        }
        public int getPosicion()
        {
            return posicion;
        }
        public Pila()
        {
            cima = null;
            siguiente = null;
        }

        public bool pilaVacia()
        {
            return (cima == null);
        }

        public void push(T dato)
        {
            nodo<T> nuevo = new nodo<T>(dato);
            if (!pilaVacia())
            {
                nuevo.anterior = cima;
                cima.siguiente = nuevo;
            }
            cima = nuevo;
        }//push insertar


        public T verCima()
        {
            T resultado = default(T);
            if (!pilaVacia())
                resultado = cima.dato;
            return resultado;
        }

        public T pop()
        {
            T d;
            if (cima.anterior == null)
            {
                d = cima.dato;
                cima = null;
            }
            else
            {
                d = cima.dato;
                cima = cima.anterior;
                cima.siguiente.anterior = null;
                cima.siguiente = null;
            }
            return d;
        }//pop eliminar

        public void eliminarPila()
        {
            T aux;
            while (!pilaVacia())
                aux = pop();
        }



    }
}