using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograAvanzada
{
    class Prestamo
    {
        private ArregloUsuarios usuarios;
        private Leyes<Ley> leyes;

        public Prestamo()
        {
            usuarios = ClaseCompartida.arregloGrupos;
            leyes = ClaseCompartida.arregloLeyes;
        }

        public bool realizarPrestamo(int idUser, int idDocumento, int opc) {
            //Valores de opc
            //opc=1 : leyes
            //opc=2 : reglamento
            //
            if (opc == 1)
            {
                leyes.Buscar(idDocumento);

            }
            else if (opc == 2)
            {

            }
            return true;
        }

        public String imprimirPrestamo()
        {
            return usuarios.Mostrar();
        }
    }
}
