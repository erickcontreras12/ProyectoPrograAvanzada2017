using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograAvanzada
{
    class ArregloPrestamos
    {
        public nodo<Prestamo> inicio, fin;
        public ArregloPrestamos siguiente;
        public int size;

        public void Prestamo()
        {
            inicio = null;
            fin = null;
        }


        public bool isEmpty()
        {
            return size == 0;
        }

        public void Insertar(nodo<Prestamo> e)
        {
            if (BuscarCopias(e.dato.getIDGrupoUsuario(),e.dato.getIDLey()) < 2)
            {
                nodo<Prestamo> nuevo = e;
                if (isEmpty())
                {
                    inicio = nuevo;
                }
                else
                {
                    fin.siguiente = nuevo;
                }
                fin = nuevo;
                size++;
            }else
            {
                //Ingresa a la lista de espera
            }
            
        }

        public bool Eliminar(int d)
        {
            if (Buscar(d) != null)
            {
                nodo<Prestamo> aux = Buscar(d);
                aux = aux.siguiente;
                return true;
            }
            return false;
        }

        public nodo<Prestamo> Buscar(int i)
        {
            nodo<Prestamo> temp = inicio;
            if (inicio != null)
            {
                if (temp.dato.getIdPrestamo()==i)
                {
                    return temp;
                }
                temp = temp.siguiente;
            }
            return null;
        }

        public int BuscarCopias(int idGrupo, int idLey)
        {
            nodo<Prestamo> temp = inicio;
            int copias = 0;
            while (temp != null)
            {
                if (temp.dato.getIDGrupoUsuario() == idGrupo)
                {
                    if (temp.dato.getIDLey() == idLey)
                    {
                        copias++;
                    }
                }
                temp = temp.siguiente;
            }
            return copias;

        }
    }
}
