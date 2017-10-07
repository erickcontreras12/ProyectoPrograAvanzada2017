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
        private String idUsuario;

        public Usuario(String n, String p, String id)
        {
            puesto = p;
            nombre= n;
            idUsuario = id;    
        }

        public String getPuesto()
        {
            return puesto;
        }

        public void setPuesto()
        {
            puesto = "asesor";
        }

        public String toString()
        {
            return "Usuario[ID: "+ idUsuario +"Nombre: "+nombre+" Puesto: "
                + puesto +"]";
        }
    }
}
