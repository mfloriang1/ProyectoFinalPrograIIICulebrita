using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.ColaArreglo
{
    class ColaCircular
    {
        protected int fin;
        private static int MAXTAMQ = 99;
        protected int frente;
        protected int tamaño;

        public Object[] listaCola;

        public ColaCircular()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            listaCola = new Object[MAXTAMQ];
        }

        //avanza una posición
        private int siguiente(int r)
        {
            return (r + 1) % MAXTAMQ;
        }

        //validaciones
        public bool colaVacia()
        {
            return frente == siguiente(fin);
        }
        public bool colaLlena()
        {
            return frente == siguiente(siguiente(fin));
        }

        //operaciones de modificacion de cola
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                tamaño++;
                fin = siguiente(fin);
                listaCola[fin] = elemento;
            }
            else
            {
                throw new Exception("OverFlow de la cola");
            }
        }
        public int numerodeelementos()
        {
            return tamaño;
        }
        //quitar elemento
        public Object quitar()
        {
            if (!colaVacia())
            {
                Object tm = listaCola[frente];
                frente = siguiente(frente);
                tamaño--;
                return tm;
            }
            else
            {
                throw new Exception("Cola Vacía");
            }
        }

        public void BorrarCola()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
        }

        //obtener el valor de frente
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
        //obtener el valor de frente
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

            for (int i = 0; i <=fin;i++ )
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

            for (int i= 0; i<=fin;i++)
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
