using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograAvanzada
{
    class Usuario
    {
        private String puesto;
        private String nombre;
        private int idUsuario;
        public int posicion;

        /// <summary>
        /// Método constructor de la clase usuario
        /// </summary>
        /// <param name="n">Nombre del usuario</param>
        /// <param name="p">Puesto del usuario</param>
        /// <param name="id">ID del usuario</param>
        public Usuario(String n, String p, int id)
        {
            puesto = p;
            nombre = n;
            idUsuario = id;
        }

        /// <summary>
        /// Método que devuelve el id del usuario
        /// </summary>
        /// <returns>id del usuario</returns>
        public int getID()
        {
            return idUsuario;
        }
        public void setID(int id)
        {
            idUsuario = id;
        }

        /// <summary>
        /// Método que devuelve el valor del puesto del usuario
        /// </summary>
        /// <returns>Puesto del usuario</returns>
        public String getPuesto()
        {
            return puesto;
        }

        /// <summary>
        /// Método que define el puesto del usuario
        /// </summary>
        /// <param name="p">puesto del usuario</param>
        public void setPuesto(String p)
        {
            puesto = p;
        }

        /// <summary>
        /// Método que imprime todas las propiedades de la clase
        /// </summary>
        /// <returns>Datos del usuario</returns>
        public String toString()
        {
            return "Usuario[ID: " + idUsuario + "Nombre: " + nombre + " Puesto: "
                + puesto + "]";
        }
        public void setNombre(string nom)
        {
            this.nombre = nom;
        }
    }

}
