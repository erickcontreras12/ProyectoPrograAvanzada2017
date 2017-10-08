using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograAvanzada
{
    class Ley
    {

        public static int CAPACITY = 0;
        private int idLey;
        private Reglamentos[] data;
        private int tamanio = 0;
        private int inicial = 0;
        private bool parlamentario;

        public int getLey()
        {
            return idLey;
        }
        public Ley(int n)
        {
            CAPACITY = n;
            data = new Reglamentos[CAPACITY];
        }

        public int size()
        {
            return tamanio;
        }

        public bool isEmpty()
        {
            return tamanio == 0;
        }

        public Reglamentos get(int i)
        {
            return data[i];
        }

       

        public void add(int i, Reglamentos e)
        {

            if (tamanio < data.Length)
            {

                 
                    data[i] = e;
               
                tamanio++;
            }
        }


        public Reglamentos remove(int i)
        {

            Reglamentos temp = data[i];
            for (int k = i; k < (tamanio - 1); k++)
            {
                data[k] = data[k + 1];
                data[tamanio - 1] = default(Reglamentos);
            }
            tamanio--;
            return temp;
        }

        public String mostrarLey()
        {
            string regreso= "";
            for (int i = 0; i < data.Length; i++)
            {
                regreso+= "Ley "+" "+idLey+" " + data[i].MostrarRegla()+"\n";
            }
            return regreso;

        }
    
}
}
