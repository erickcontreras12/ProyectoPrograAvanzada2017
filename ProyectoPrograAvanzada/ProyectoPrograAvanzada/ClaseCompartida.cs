using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograAvanzada
{
    class ClaseCompartida
    {
        public static ArregloUsuarios arregloGrupos = new ArregloUsuarios(1);
        public static Leyes<Ley> arregloLeyes = new Leyes<Ley>(1);
        public static Cola<Prestamo> listaDeEspera = new Cola<Prestamo>();
    }
}
