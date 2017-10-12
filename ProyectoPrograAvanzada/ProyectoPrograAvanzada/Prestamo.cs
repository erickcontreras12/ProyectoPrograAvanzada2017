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
        public Ley ley;
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

        public bool realizarPrestamo(int idGrupo,int idUser,int idLey, int idDocumento, int opc) {
            //Valores de opc (OPC toma un valor en el form por un radiobutton
            //opc=1 : leyes
            //opc=2 : reglamento
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
            }
            else
            {
                return false;
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
