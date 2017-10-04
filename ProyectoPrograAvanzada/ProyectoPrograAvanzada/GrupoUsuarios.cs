using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsolsa
{

    /// <summary>
    /// Clase con capacidad de lista para almacenar objetos de tipo Usuario
    /// 
    /// </summary>
    class GrupoUsuarios
    {

        public static int CAPACITY = 9;
        private int idGrupo;
        private Usuario[] data;
        private int tamanio = 0;
        private int inicial = 0;
        private bool parlamentario;

        /// <summary>
        /// Método constructor para crear un objeto de tipo usuario
        /// Un grupo puede tener un máximo de 9 miembros entonces lo 
        /// inicializa con la variable CAPACITY
        /// </summary>
        public GrupoUsuarios()
        {
            data = new Usuario[CAPACITY];
        }

        /// <summary>
        /// Método para vizualizar la cantidad de espacios ocupados
        /// </summary>
        /// <returns>Tamaño del grupo</returns>
        public int size()
        {
            return tamanio;
        }

        /// <summary>
        /// Método para validar si el grupo está vacío
        /// </summary>
        /// <returns>Verdadero o Falso</returns>
        public bool isEmpty()
        {
            return tamanio == 0;
        }

        /// <summary>
        /// Obtener el usuario contenido en una posición específico del grupo
        /// a partir de su número de identificación
        /// </summary>
        /// <param name="i">ID del Usuario</param>
        /// <returns>Usuario</returns>
        public Usuario busquedaUsuario(int j)
        {
            int k=0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].getIDUsuario()==j)
                {
                    k = i;
                }
            }
            return data[k];
        }

        /// <summary>
        /// Modificar el nombre y puesto de un usuario ya existente
        /// Llamada al método validarPuesto()
        /// </summary>
        /// <param name="i">ID del usuario</param>
        /// <param name="n">Nuevo nombre</param>
        /// <param name="p">Nuevo puesto</param>
        /// <returns>Usuario modificado</returns>
        public Usuario modificarUsuario(int i, String n, String p)
        {
            Usuario temp = busquedaUsuario(i);
            temp.setNombre(n);
            temp.setPuesto(p);
            if (validarPuesto(temp))
            {
                temp.setPuesto("asesor");
            }
            return temp;
        }

        /// <summary>
        /// Agregar nuevo usuario al grupo
        /// </summary>
        /// <param name="e">Usuario nuevo</param>
        public void add(Usuario e)
        {
            if (validarPuesto(e))
            {
                e.setPuesto("asesor");
            }

            if (tamanio < data.Length)
            {

                for (int k = 0; k <= tamanio; k++)
                {
                    if (data[k] == null)
                    {
                        data[k] = e;
                        continue;
                    }
                }
                tamanio++;
            }
        }

        public bool validarPuesto(Usuario e)
        {
            parlamentario = false;
            for (int j = 0; j < data.Length; j++)
            {
                if (data[j].getPuesto() == "parlamentario" || data[j].getPuesto() == "Parlamentario")
                {
                    parlamentario = true;
                }
            }

            return parlamentario;
        }

        /// <summary>
        /// Elimina un usuario especifico del grupo
        /// </summary>
        /// <param name="i">ID del usuario</param>
        /// <returns>Usuario eliminado</returns>
        public Usuario remove(int i)
        {

            Usuario temp = busquedaUsuario(i);
            for (int k = 0; k < (tamanio - 1); k++)
            {
                if (data[k].getIDUsuario() == i)
                {
                    data[k] = default(Usuario);
                    tamanio--;
                }
            }
            return temp;
        }

        public void mostrarUsuarios()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i].toString());
            }
            
        }
    }

}
