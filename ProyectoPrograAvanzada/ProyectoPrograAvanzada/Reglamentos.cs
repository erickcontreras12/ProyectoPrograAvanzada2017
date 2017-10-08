using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograAvanzada
{
    /// <summary>
    /// Clase que contiene los reglamentos
    /// </summary>
    class Reglamentos
    {
        /// <summary>
        /// Atributos de la clase (id y el nombre del reglamento)
        /// </summary>
        private int idregla;
        private String nombreRegla;
        /// <summary>
        /// ingresar el id del reglamento
        /// </summary>
        /// <param name="num">Dato a ingresar en idregla</param>
        public void setIdregla(int num)
        {
            this.idregla = num;
        }
        /// <summary>
        /// Obtener el id del reglamento
        /// </summary>
        /// <returns>retorna valor de idregla</returns>
        public int getIdregla()
        {
            return this.idregla;
        }
        /// <summary>
        /// Ingresar el nombre del reglamento
        /// </summary>
        /// <param name="regla">nombre del reglamento</param>
        public void setNombreregla(String regla)
        {
            this.nombreRegla =regla ;
        }
        /// <summary>
        /// Obtener el nombre del reglamento
        /// </summary>
        /// <returns>retorna el nombre del reglamento</returns>
        public String getNombreregla()
        {
            return this.nombreRegla;
        }
        /// <summary>
        /// Muestra las propiedades de la regla
        /// </summary>
        /// <returns>devuelve un string con el texto que incluye las propiedades de la regla</returns>
        public string MostrarRegla()
        {
            string regreso = "Id " + idregla + "Nombre " + nombreRegla;
            return regreso;
        }
    }
}
