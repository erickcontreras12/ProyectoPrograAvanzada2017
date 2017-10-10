﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograAvanzada
{
    class Prestamo
    {
        private int idPrestamo; 
        private Usuario user;
        private GrupoUsuarios grupo;
        private Ley ley;
        private Reglamentos reglamento;

        public int getIdPrestamo()
        {
            return idPrestamo;
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
                return "Prestamo [Usuario: "+ user +" + ley: "+ ley +" reglamento: "+ reglamento +"]";
            }
            return "Prestamo [Usuario: " + user + " + ley: " + ley + "]";
        }

        
    }
}
