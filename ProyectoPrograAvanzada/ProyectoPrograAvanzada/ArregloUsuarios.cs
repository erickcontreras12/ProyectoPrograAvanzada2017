using System;
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
        int size = 0;
        int ni = 0;

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
        /// <summary>
        /// Insetar un nuevo dato en la lista
        /// </summary>
        /// <param name="nuevo">Insertar un grupo de usuarios</param>
        public void Insertar(GrupoUsuarios nuevo)
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
                MessageBox.Show("Grupo de Usuario Creado");
            }
            else if (size > 0)
            {
                if (Buscar(nuevo.getIdGrupo()) == null)
                {
                    nuevo.setPosicion(UltimaPosicion() + 1);
                    if (first == null)
                        first = nuevo;
                    else
                        last.siguiente = nuevo;
                    last = nuevo;
                    size++;
                    ni++;
                    MessageBox.Show("Grupo de Usuario Creado");
                }
                else
                {
                    if (nuevo.getIdGrupo() == Buscar(nuevo.getIdGrupo()).getIdGrupo())
                    {
                        MessageBox.Show("No puede ingresar dos veces el mismo Id");
                    }
                }

            }

        }
        /// <summary>
        /// Mostrar un Dato
        /// </summary>
        /// <returns>Retorna los datos dentro del array</returns>
        public String Mostrar()
        {
            String regreso = "";
            if (first != null)
            {
                GrupoUsuarios actual = first;
                GrupoUsuarios Temp = actual;
                while (actual != null)
                {
                    regreso += actual.mostrarUsuarios() + "\n";
                    actual = actual.siguiente;
                }
            }
            else
                regreso = "\nla lista de usuarios esta {0} Está Vacía...";

            return regreso;
        }

       /// <summary>
       /// Busca un dato en el array
       /// </summary>
       /// <param name="n">id del grupo</param>
       /// <returns>Dato del array con el id</returns>
       
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
        /// <summary>
        /// Busca la posición de un grupo
        /// </summary>
        /// <param name="n">posición de grupo</param>
        /// <returns></returns>
        public GrupoUsuarios BuscarPosicion(int n)
        {
            GrupoUsuarios actual = first;
            while (actual != null)
            {
                if (actual.getPosicion() == n)
                    return actual;
                actual = actual.siguiente;
            }
            return null;
        }

        /// <summary>
        /// Elimina un dato en el id indicado
        /// </summary>
        /// <param name="n">id del grupo</param>
        public void Eliminar(int n)
        {
            if (size == 0)
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

                    //ni--;
                }
                else
                    MessageBox.Show("\nNo Existe ningun Usuario");
            }
            else
            {
                AsignarPosicion(n);
                size--;
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

                    //ni--;
                }
                else
                    MessageBox.Show("\nNo Existe ningun Usuario");

            }

        }
        /// <summary>
        /// Valor de la posicion del ultimo dato
        /// </summary>
        /// <returns>ultima posicion</returns>
        public int UltimaPosicion()
        {
            return last.getPosicion();
        }
        /// <summary>
        /// Reasigna posiciones al eliminar un dato
        /// </summary>
        /// <param name="n">id del grupo</param>

        public void AsignarPosicion(int n)
        {
            GrupoUsuarios temp = Buscar(n);
            int t = size - 1;
            int l = temp.getPosicion();
            for (int i = t; i > l; i--)
            {
                BuscarPosicion(i).setPosicion(i - 1);
            }
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
        /// <summary>
        /// obtiene el tamaño
        /// </summary>
        /// <returns>Tamaño del array</returns>
        public int getSize()
        {
            return size;
        }
    }
}
