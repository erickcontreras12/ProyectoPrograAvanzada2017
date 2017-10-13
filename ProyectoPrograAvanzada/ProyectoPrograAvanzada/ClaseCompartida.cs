using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograAvanzada
{
    /// <summary>
    /// Clase que contiene los array generales donde se guardan todos los datos.
    /// </summary>
    class ClaseCompartida
    {
        public static ArregloUsuarios arregloGrupos = new ArregloUsuarios(1);
        public static Leyes<Ley> arregloLeyes = new Leyes<Ley>(1);
        public static ArregloPrestamos arregloPrestamos = new ArregloPrestamos();
        public static Cola<Prestamo> listaDeEspera = new Cola<Prestamo>();
    }
}
