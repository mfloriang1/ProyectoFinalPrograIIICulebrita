using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.ColaArreglo
{
    class ColaLineal
    {
        protected int fin;
        private static int MAXTAMQ = 39;
        protected int frente;
        protected int tamaño;

        protected Object[] listaCola;

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            listaCola = new Object[MAXTAMQ];
        }

        //Operaciones para trabajar con datos en la cola
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                listaCola[++fin] = elemento;
                tamaño++;
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }
        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;
        }
        public bool colaVacia()
        {
            return frente > fin;
        }
        public int numdeelementos()
        {

            return tamaño;
        }
        //quitar elemento en la cola
        public Object quitar()
        {
            if (!colaVacia())
            {
                tamaño--;
                return listaCola[frente++];
                
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //limpiar toda la cola
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        //acceso a la cola
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola Vacía");
            }
        }
        //acceso a la cola
        public Object finalCola()
        {
            if (!colaVacia())
            {
                return listaCola[fin];
            }
            else
            {
                throw new Exception("Cola Vacía");
            }
        }
        public bool choque(Point posiciondelacabeza)
        {

            int bandera = 0;

            for (int i = 0; i <= fin; i++)
            {
                Point c = (Point)listaCola[i];
                bool r = c.X == posiciondelacabeza.X && c.Y == posiciondelacabeza.Y;


                if (r)
                {
                    bandera = bandera + 1;
                }
                else
                {
                    bandera = bandera + 0;
                }


            }
            return (bandera != 0) ? true : false;

        }
        public bool comida(int x, int y)
        {

            int bandera = 0;

            for (int i = 0; i <= fin; i++)
            {
                Point c = (Point)listaCola[i];
                bool r = c.X != x && c.Y != y;
                if (r)
                {
                    bandera = bandera + 0;
                }
                else
                {
                    bandera = bandera + 1;
                }


            }
            return (bandera == 0) ? true : false;

        }
    }
}
