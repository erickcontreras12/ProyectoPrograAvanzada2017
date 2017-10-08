using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograAvanzada
{
    class GrupoUsuarios
    {
        public static int CAPACITY = 9;
        private int idGrupo;
        private Usuario[] data;
        private int tamanio = 0;
        private int inicial = 0;
        private bool parlamentario;
        public GrupoUsuarios siguiente;

        /// <summary>
        /// Método constructor que define el tamaño del arreglo
        /// y el ID del grupo de usuarios
        /// </summary>
        /// <param name="i">ID del grupo</param>
        public GrupoUsuarios(int i)
        {
            data = new Usuario[CAPACITY];
            idGrupo = i;
        }
        public int getIdGrupo()
        {
            return idGrupo;
        }

        /// <summary>
        /// Método para ver el tamaño del arreglo
        /// </summary>
        /// <returns>Tamaño del arreglo</returns>
        public int size()
        {
            return tamanio;
        }

        /// <summary>
        /// Método que indica si el arreglo está vacío o no
        /// </summary>
        /// <returns>True si está vacío el arrelo</returns>
        public bool isEmpty()
        {
            return tamanio == 0;
        }

        /// <summary>
        /// Método que modifica un usuario especifico
        /// </summary>
        /// <param name="i">id del usuario a cambiar</param>
        /// <param name="e">propiedades nuevas del usuario</param>
        /// <returns>usuario modificado</returns>
        public Usuario set(int i, Usuario e)
        {
            Usuario temp = null;
            for (int j = 0; j <= tamanio; j++)
            {
                if (data[j].getID() == i)
                {
                    temp = data[j];
                    data[j] = e;

                }
            }
            return temp;
        }

        /// <summary>
        /// Método para agregar un nuevo usuario
        /// </summary>
        /// <param name="e">datos del nuevo usuario</param>
        public void add(Usuario e)
        {
            if (validarPuesto(e))
            {
                e.setPuesto("asesor");
            }

            if (tamanio < data.Length)
            {
                data[tamanio] = e;
                tamanio++;
            }
        }

        /// <summary>
        /// Método para validar el puesto del usuario (revisa para que solo
        /// haya un parlamentario)
        /// </summary>
        /// <param name="e">datos usuario</param>
        /// <returns></returns>
        public bool validarPuesto(Usuario e)
        {
            parlamentario = false;
            for (int j = 0; j < tamanio; j++)
            {
                if (data[j].getPuesto() == "parlamentario" || data[j].getPuesto() == "Parlamentario")
                {
                    parlamentario = true;
                }
            }

            return parlamentario;
        }

        /// <summary>
        /// Método para eliminar un usuario especifico
        /// </summary>
        /// <param name="i">id del usuario a eliminar</param>
        /// <returns></returns>
        public Usuario remove(int i)
        {
            Usuario temp = null;
            for (int k = 0; k <= tamanio; k++)
            {
                if (data[k].getID() == i)
                {
                    temp = data[k];
                    data[k] = default(Usuario);
                    tamanio--;
                }
            }
            return temp;
        }

        /// <summary>
        /// Método que imprime todos los usuarios del arreglo
        /// </summary>
        public String mostrarUsuarios()
        {
            string regresar = "";
            for (int i = 0; i < tamanio; i++)
            {
                regresar += "" + data[i].toString() + "\n";
            }
            return regresar;
        }
    }
}
