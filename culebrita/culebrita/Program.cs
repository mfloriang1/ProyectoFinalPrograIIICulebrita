using culebrita.clases.culebrita;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;

namespace culebrita
{
    class Program
    {

        static void Main()
        {

            int i; 
            Console.WriteLine("1.Bicola");
            Console.WriteLine("2.ColaConLista");
            Console.WriteLine("3.ColaCircular");
            Console.WriteLine("4.ColaLineal");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    culebritabicola cb = new culebritabicola();
                    cb.principal();
                    break;
                case 2:
                    culebritaconColaconLista ccl = new culebritaconColaconLista();
                    ccl.principal();
                    break;
                case 3:
                    CulebritaColaCircular ccc = new CulebritaColaCircular();
                    ccc.principal();
                    break;
                case 4:
                    CulebritaConColaLineal cccl = new CulebritaConColaLineal();
                    cccl.principal();
                    break;

            }
        }


    }//end class
}




