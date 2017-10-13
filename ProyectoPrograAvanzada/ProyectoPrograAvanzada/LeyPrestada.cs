using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograAvanzada
{
    class LeyPrestada<T>
    {
        int codigo;
        public Ley first, last;
        public LeyPrestada<T> siguiente;
        int size = 0;

        public LeyPrestada(int codigo)
        {
            this.codigo = codigo;
            first = last = null;
            siguiente = null;
        }
        public int getSize()
        {
            return size;
        }

        public int Codigo
        {
            get { return codigo; }
        }

        public void Insertar(Ley nuevo)
        {
            if (size == 0)
            {
                if (first == null)
                    first = nuevo;
                else
                    last.siguiente = nuevo;
                last = nuevo;
                nuevo.setPosicion(0);
                size++;
                MessageBox.Show("Ley Creada");
            }
            else if (size > 0)
            {
                if (Buscar(nuevo.getLey()) == null)
                {
                    nuevo.setPosicion(UltimaPosicion() + 1);
                    if (first == null)
                        first = nuevo;
                    else
                        last.siguiente = nuevo;
                    last = nuevo;
                    size++;
                    MessageBox.Show("Ley Creada");
                }
                else
                {
                    if (nuevo.getLey() == Buscar(nuevo.getLey()).getLey())
                    {
                        MessageBox.Show("No puede ingresar dos veces el mismo Id");
                    }
                }
            }
        }

        public String Mostrar()
        {
            String regreso = "";
            if (first != null)
            {
                Ley actual = first;
                Ley Temp = actual;
                while (actual != null)
                {
                    regreso += actual.mostrarLey() + "\n";
                    actual = actual.siguiente;
                }
            }
            else
                regreso = "\nLa pila de leyes esta {0} Está Vacía...";

            return regreso;
        }

        /** public void MostrarLey()
         {
             Console.Write("N° Ley: {0}\n", codigo);
         }**/

        public Ley Buscar(int n)
        {
            Ley actual = first;
            while (actual != null)
            {
                if (actual.getLey() == n)
                    return actual;
                actual = actual.siguiente;
            }
            return null;
        }

        public void Eliminar(int n)
        {
            if (size == 0)
            {
                if (first != null)
                {
                    Ley actual, padre;
                    padre = BuscarPadre(n);
                    if (padre == last)
                    {
                        MessageBox.Show("\nLey No Encontrada...");
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
                    MessageBox.Show("Ley eliminada");
                }
                else
                    MessageBox.Show("\nNo Existe ninguna ley");
            }
            else
            {
                AsignarPosicion(n);
                size--;
                if (first != null)
                {
                    Ley actual, padre;
                    padre = BuscarPadre(n);
                    if (padre == last)
                    {
                        MessageBox.Show("\nLey No Encontrada...");
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
                    MessageBox.Show("Ley eliminada");
                }
                else
                    MessageBox.Show("\nNo Existe ninguna ley");
            }
        }

        private Ley BuscarPadre(int n)
        {
            Ley padre, actual;
            actual = first;
            padre = null;
            while (actual != null)
            {
                if (actual.getLey() == n)
                    break;
                padre = actual;
                actual = actual.siguiente;
            }
            return padre;
        }
        public int UltimaPosicion()
        {
            return last.getPosicion();
        }
        public Ley BuscarPosicion(int n)
        {
            Ley actual = first;
            while (actual != null)
            {
                if (actual.getPosicion() == n)
                    return actual;
                actual = actual.siguiente;
            }
            return null;
        }

        public void AsignarPosicion(int n)
        {
            Ley temp = Buscar(n);
            int t = size - 1;
            int l = temp.getPosicion();
            for (int i = t; i > l; i--)
            {
                BuscarPosicion(i).setPosicion(i - 1);
            }
        }
    }
}
