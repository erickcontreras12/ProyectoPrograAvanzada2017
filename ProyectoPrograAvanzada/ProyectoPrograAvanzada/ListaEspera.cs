using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograAvanzada
{
    class ListaEspera
    {
        public Prestamo inicio, fin;
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

        public void Insertar(Prestamo e)
        {
            if (size == 0)
            {
                Prestamo nuevo = e;
                if (isEmpty())
                {
                    inicio = nuevo;
                }
                else
                {
                    fin.siguiente = nuevo;
                }
                fin = nuevo;
                nuevo.setPosicion(0);
                size++;
            }
            else if (size > 0)
            {
                if (BuscarCopias(e.getIDGrupoUsuario(), e.getIDLey()) < 2)
                {
                    Prestamo nuevo = e;
                    if (isEmpty())
                    {
                        inicio = nuevo;
                    }
                    else
                    {
                        fin.siguiente = nuevo;
                    }
                    fin = nuevo;
                    nuevo.setPosicion(ultimaPosicion() + 1);
                    size++;
                }
                else
                {
                    ClaseCompartida.listaDeEspera.agregar(e);
                }
            }


        }

        public int ultimaPosicion()
        {
            return fin.getPosicion();
        }

        //Devolución
        public void Eliminar(int n)
        {
            if (size == 0)
            {

                if (inicio != null)
                {
                    Prestamo actual, padre;
                    padre = BuscarPadre(n);
                    if (padre == fin)
                    {
                        MessageBox.Show("\nPrestamo no encontrado...");
                        return;
                    }
                    if (padre == null)
                    {
                        actual = inicio;
                        inicio = inicio.siguiente;
                        padre = inicio;
                    }
                    else
                    {
                        actual = padre.siguiente;
                        padre.siguiente = actual.siguiente;
                    }
                    actual = null;
                    if (padre == null || padre.siguiente == null)
                        fin = padre;
                    MessageBox.Show("eliminado");

                    //ni--;
                }
                else
                    MessageBox.Show("\nNo Existe ningun Prestamo");
            }
            else
            {
                AsignarPosicion(n);
                size--;
                if (inicio != null)
                {
                    Prestamo actual, padre;
                    padre = BuscarPadre(n);
                    if (padre == fin)
                    {
                        MessageBox.Show("\nPrestamo No Encontrado...");
                        return;
                    }
                    if (padre == null)
                    {
                        actual = inicio;
                        inicio = inicio.siguiente;
                        padre = inicio;
                    }
                    else
                    {
                        actual = padre.siguiente;
                        padre.siguiente = actual.siguiente;
                    }
                    actual = null;
                    if (padre == null || padre.siguiente == null)
                        fin = padre;
                    MessageBox.Show("eliminado");

                    //ni--;
                }
                else
                    MessageBox.Show("\nNo Existe ningun Prestamo");

            }

        }

        public Prestamo BuscarPosicion(int n)
        {
            Prestamo actual = inicio;
            while (actual != null)
            {
                if (actual.getPosicion() == n)
                    return actual;
                actual = actual.siguiente;
            }
            return null;
        }


        public Prestamo Buscar(int i)
        {
            Prestamo temp = inicio;
            while (inicio != null)
            {
                if (temp.getIdPrestamo() == i)
                {
                    return temp;
                }
                temp = temp.siguiente;
            }
            return null;
        }

        public void AsignarPosicion(int n)
        {
            Prestamo temp = Buscar(n);
            int t = size - 1;
            int l = temp.getPosicion();
            for (int i = t; i > l; i--)
            {
                BuscarPosicion(i).setPosicion(i - 1);
            }
        }

        private Prestamo BuscarPadre(int n)
        {
            Prestamo padre, actual;
            actual = inicio;
            padre = null;
            while (actual != null)
            {
                if (actual.getIdPrestamo() == n)
                    break;
                padre = actual;
                actual = actual.siguiente;
            }
            return padre;
        }

        public int BuscarCopias(int idGrupo, int idLey)
        {
            Prestamo temp = inicio;
            int copias = 0;
            while (temp != null)
            {
                if (temp.getIDGrupoUsuario() == idGrupo)
                {
                    if (temp.getIDLey() == idLey)
                    {
                        copias++;
                    }
                }
                temp = temp.siguiente;
            }
            return copias;

        }

        public String Mostrar()
        {
            String regreso = "";
            if (inicio != null)
            {
                Prestamo actual = inicio;
                Prestamo Temp = actual;
                while (actual != null)
                {
                    regreso += actual.toString() + "\n";
                    actual = actual.siguiente;
                }
            }
            else
                regreso = "\nla lista de usuarios esta {0} Está Vacía...";

            return regreso;
        }
    }
}
