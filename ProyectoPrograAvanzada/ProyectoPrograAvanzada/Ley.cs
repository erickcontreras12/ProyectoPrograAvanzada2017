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

        public static int CAPACITY = 0;
        private int idLey;
        private String enunciado;
        private Reglamentos[] data;
        private int tamanio = 0;
        private int inicial = 0;
        private bool parlamentario;

        public int getLey()
        {
            return idLey;
        }
        public Ley(int n, int id,string en)
        {
            CAPACITY = n;
            idLey = id;
            data = new Reglamentos[CAPACITY];
            enunciado = en;
        }
        public void setEnunciado(string en)
        {
            enunciado = en;
        }
        public Reglamentos[] RecorrerRegla()
        {

            return data;
        }
        public int getCapacity()
        {
            return CAPACITY;
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
        public void AsignarPos(int n, int pos)
        {
            for (int i = pos; i < tamanio; i++)
            {
                data[i] = data[i + 1];
            }
        }

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
