using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograAvanzada
{
    class Prestamo
    {
        private int idPrestamo; 
        public Usuario user;
        public GrupoUsuarios grupo;
        public Ley ley, leyprestada;
        public Reglamentos reglamento;
        public Prestamo siguiente;
        private int posicion = 0;

        
        public void setPosicion(int n)
        {
            this.posicion = n;
        }
        public int getPosicion()
        {
            return posicion;
        }
        public int getIdPrestamo()
        {
            return idPrestamo;
        }
        public int getIDGrupoUsuario()
        {
            return grupo.getIdGrupo();
        }
        public int getIDLey()
        {
            return ley.getLey();
        }
        public Prestamo(int n)
        {
            idPrestamo = n;
        }

        /// <summary>
        /// Comprobar si el prestamo es posible de realizar con los
        /// datos ingresado
        /// </summary>
        /// <param name="idGrupo">ID del grupo donde esta el usuario que hara el prestamo</param>
        /// <param name="idUser">ID del usuario que hará el prestamo</param>
        /// <param name="idLey">ID de la ley de donde se obtienen los reglamentos</param>
        /// <param name="idDocumento">ID del reglamento que se prestará</param>
        /// <param name="opc">Opcion para ver si el prestamo es por lotes o de un solo reglamento</param>
        /// <returns>True si se puede realizar</returns>
        public bool realizarPrestamo(int idGrupo,int idUser,int idLey, int idDocumento, int opc) {
            //Valores de opc (OPC toma un valor en el form por un radiobutton
            //opc=1 : leyes
            //opc=2 : reglamento
            if (opc != 2)
            {


                if (ClaseCompartida.arregloGrupos.Buscar(idGrupo) != null)
                {
                    grupo = ClaseCompartida.arregloGrupos.Buscar(idGrupo);
                    user = grupo.Buscar(idUser);
                }
                else
                {
                    return false;
                }

                if (ClaseCompartida.arregloLeyes.Buscar(idLey) != null)
                {
                    ley = ClaseCompartida.arregloLeyes.Buscar(idLey).verCima();
                    leyprestada = ClaseCompartida.arregloLeyes.Buscar(idLey).pop();
                }
                else
                {
                    return false;
                }

            }

            if (opc == 2)
            {
                if (true)
                {
                    reglamento = ley.get(0);
                } 
            }

            return true;
        }

        public String toString()
        {
            if (reglamento != null)
            {
                return "Prestamo: + " + idPrestamo + " [Usuario: " + user.toString() +" + ley: "+ ley +" reglamento: "+ reglamento +"]";
            }
            return "Prestamo: + "+ idPrestamo +" [Usuario: " + user.toString() + " + "+ ley.mostrarLey() +" ]";
        }

        
    }
}
