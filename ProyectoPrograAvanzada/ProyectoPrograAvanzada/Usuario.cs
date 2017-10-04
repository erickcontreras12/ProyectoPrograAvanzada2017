using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsolsa
{
    class Usuario
    {
        private String puesto;
        private String nombre;
        private int idUsuario;

        public Usuario(String n, String p, int id)
        {
            puesto = p;
            nombre= n;
            idUsuario = id;    
        }

        public void setNombre(String n)
        {
            nombre = n;
        }
        public int getIDUsuario()
        {
            return idUsuario;
        }

        public String getPuesto()
        {
            return puesto;
        }

        public void setPuesto(String p)
        {
            puesto = p;
        }


        public String toString()
        {
            return "Usuario[ID: "+ idUsuario +"Nombre: "+nombre+" Puesto: "
                + puesto +"]";
        }
    }
}
