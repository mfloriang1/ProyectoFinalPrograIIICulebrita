using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.ColaLista
{
    class ColaConLista
    {
        protected Nodo frente;
        protected Nodo fin;

        //constructor: crear cola vacia
        public ColaConLista()
        {
            frente = fin = null;
        }

        //verificar si la cola est´vacia
        public bool colaVacia()
        {
            return (frente == null);
        }

        //inseratr: pone elemento por el final de la cola
        public void insertar(object elemento)
        {
            Nodo a;
            a = new Nodo(elemento);
            if (colaVacia())
            {
                frente = a;
            }
            else
            {
                fin.Siguiente = a;
            }
            fin = a;
        }

        //quitar un elemento
        public object quitar()
        {
            object aux;
            if (!colaVacia())
            {
                aux = frente.elemento;
                frente = frente.Siguiente;
            }
            else
            {
                throw new Exception("Error porqué la cola está vacía");
            }
            return aux;
        }

        //vaciar la cola o liberar todos los nodos
        public void borrarCola()
        {
            for(;frente != null;)
            {
                frente = frente.Siguiente;
            }
        }
        public int numElementosBicola()
        {
            int n;
            Nodo a = frente;
            if (colaVacia())
            {
                n = 0;
            }
            else
            {
                n = 1;
                while (a != fin)
                {
                    n++;
                    a = a.Siguiente;
                }
            }
            return n;
        }

        //devolver el valor que está al frente de la cola
        public object frenteCola()
        {
            if (colaVacia())
            {
                throw new Exception("Error la cola está vacía");
            }
            return (frente.elemento);
        }
        public object finalCola()
        {
            if (colaVacia())
            {
                throw new Exception("Error la cola está vacía");
            }
            return (fin.elemento);
        }
        public bool choque(Point posiciondelacabeza)
        {
            Nodo aux=frente;
            int bandera=0;

            for (; aux != null;)
            {
                Point c = (Point) aux.elemento;
                 bool r = c.X == posiciondelacabeza.X && c.Y == posiciondelacabeza.Y;


                if (r)
                {
                    bandera=bandera+1;
                }
                else
                {
                    bandera = bandera + 0;
                }
                aux = aux.Siguiente;

            }
            return (bandera != 0) ? true : false;

        }
        public bool comida(int x, int y )
        {
            Nodo aux = frente;
            int bandera = 0;

            for (; aux != null;)
            {
                Point c = (Point)aux.elemento;
                bool r = c.X != x && c.Y != y;
                if (r)
                {
                    bandera=bandera+0;
                }
                else {
                    bandera = bandera + 1;
                }

                aux = aux.Siguiente;
                  
            }
            return (bandera == 0) ? true : false;

        }

    }
}
