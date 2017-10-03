using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsolsa
{
    class GrupoUsuarios
    {

        public static int CAPACITY = 9;
        private int idGrupo;
        private Usuario[] data;
        private int tamanio = 0;
        private bool parlamentario;

        public GrupoUsuarios()
        {
            data = new Usuario[CAPACITY];
        }

        public int size()
        {
            return tamanio;
        }

        public bool isEmpty()
        {
            return tamanio == 0;
        }

        public Usuario get(int i)
        {
            return data[i];
        }

        public Usuario set(int i, Usuario e)
        {
            Usuario temp = data[i];
            data[i] = e;
            return temp;
        }

        public void add(int i, Usuario e)
        {
            if (validarPuesto(e))
            {
                e.setPuesto();
            }

            if (tamanio < data.Length)
            {

                for (int k = tamanio - 1; k >= i; k--)
                {
                    data[k + 1] = data[k];
                    data[i] = e;
                }
                tamanio++;
            }
        }

        public bool validarPuesto(Usuario e)
        {
            parlamentario = false;
            for (int j = 0; j < data.Length; j++)
            {
                if (data[j].getPuesto() == "parlamentario" || data[j].getPuesto() == "Parlamentario")
                {
                    parlamentario = true;
                }
            }

            return parlamentario;
        }

        public Usuario remove(int i)
        {

            Usuario temp = data[i];
            for (int k = i; k < (tamanio - 1); k++)
            {
                data[k] = data[k + 1];
                data[tamanio - 1] = default(Usuario);
            }
            tamanio--;
            return temp;
        }

        public void mostrarUsuarios()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i].toString());
            }
            
        }
    }

}
