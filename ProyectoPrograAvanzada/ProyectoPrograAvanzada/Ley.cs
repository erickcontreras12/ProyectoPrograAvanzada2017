using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograAvanzada
{
    class Ley
    {
        /// <summary>
        /// Propiedades de la clase
        /// </summary>

        public static int CAPACITY = 0;
        private int idLey;
        private String enunciado;
        private Reglamentos[] data;
        private int tamanio = 0;
        private bool disponible = true;
        public Ley siguiente;
        private int posicion;
        private int inicial = 0;
        private bool parlamentario;

        /// <summary>
        /// Obtiene ley
        /// </summary>
        /// <returns>retorna id de ley</returns>
        public int getLey()
        {
            return idLey;
        }
        public void setPosicion(int n)
        {
            posicion = n;
        }
        public int getPosicion()
        {
            return posicion;
        }
        /// <summary>
        /// determina si la ley esta disponible
        /// </summary>
        /// <param name="opc">verdadero o falso</param>
        public void setDisponible(bool opc)
        {
            disponible = opc;
        }
        /// <summary>
        /// se obtiene la disponibilidad de la ley
        /// </summary>
        /// <returns>falso o verdadero</returns>
        public bool getDisponible()
        {
            return disponible;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="n">numero reglas</param>
        /// <param name="id">id de grupo</param>
        /// <param name="en">enunciado</param>
        public Ley(int n, int id,string en)
        {
            CAPACITY = n;
            idLey = id;
            data = new Reglamentos[CAPACITY];
            enunciado = en;
        }
        /// <summary>
        /// Ingresa enunciado
        /// </summary>
        /// <param name="en">texto de enunciado</param>
        public void setEnunciado(string en)
        {
            enunciado = en;
        }
        /// <summary>
        /// Recorre el arreglo de reglamentos
        /// </summary>
        /// <returns></returns>
        public Reglamentos[] RecorrerRegla()
        {

            return data;
        }
        /// <summary>
        /// Obtiene capacidad
        /// </summary>
        /// <returns>capacidad arreglo usuarios</returns>
        public int getCapacity()
        {
            return CAPACITY;
        }
       /// <summary>
       /// Tamaño
       /// </summary>
       /// <returns>tamaño de la lista</returns>
        public int size()
        {
            return tamanio;
        }
        /// <summary>
        /// Lista vacia
        /// </summary>
        /// <returns>si la esta esta vacia</returns>
        public bool isEmpty()
        {
            return tamanio == 0;
        }

        public Reglamentos get(int i)
        {
            return data[i];
        }
        /// <summary>
        /// Busca un dato dentro del array
        /// </summary>
        /// <param name="id">id de la ley</param>
        /// <returns>dato que encuentra</returns>
        public Reglamentos Buscar(int id)
        {
            Reglamentos retorno = null;
            for (int i = 0; i < tamanio; i++)
            {
                if (id == data[i].getIdregla())
                {
                    retorno = data[i];
                }
            }
            return retorno;
        }
        /// <summary>
        /// Agrega un dato
        /// </summary>
        /// <param name="e">tipo reglamentos</param>
        public void add(Reglamentos e)
        {

            if (tamanio == 0)
            {
               
                if (tamanio < data.Length)
                {
                    data[tamanio] = e;
                    tamanio++;
                }
               // MessageBox.Show("Usuario Creado");
                e.posicion = 0;
            }
            else
            {
                e.posicion = data.Length;
                if (Buscar(e.getIdregla()) == null)
                {
                    

                    if (tamanio < data.Length)
                    {
                        data[tamanio] = e;
                        tamanio++;
                    }
                    MessageBox.Show("Usuario Creado");
                }
                else if (e.getIdregla() == Buscar(e.getIdregla()).getIdregla())
                {
                    MessageBox.Show("No puede repetir el id del usuario");
                }
            }
        }

        /// <summary>
        /// Elimina un dato
        /// </summary>
        /// <param name="i">elimina un dato</param>
        public void remove(int i)
        {
            int p=0;
            Reglamentos temp = null;
            for (int k = 0; k < tamanio; k++)
            {
                if (data[k].getIdregla() == i)
                {
                    temp = data[k];
                    data[k] = default(Reglamentos);
                    tamanio--;
                    p = k;
                }
            }
            AsignarPos(i, p);
            // return temp;
            MessageBox.Show("Usuario Eliminado");
        }
        /// <summary>
        /// Reasigna posiciones
        /// </summary>
        /// <param name="n">id</param>
        /// <param name="pos">posicion</param>
        public void AsignarPos(int n, int pos)
        {
            for (int i = pos; i < tamanio; i++)
            {
                data[i] = data[i + 1];
            }
        }
        /// <summary>
        /// MUESTRA LA LEY
        /// </summary>
        /// <returns>texto con la ley</returns>
        public String mostrarLey()
        {
            string regreso= "";
            for (int i = 0; i < tamanio; i++)
            {
                regreso+= "Ley "+" "+idLey+" " + data[i].getNombreregla()+"\n";
            }
            return regreso;

        }
    
}
}
