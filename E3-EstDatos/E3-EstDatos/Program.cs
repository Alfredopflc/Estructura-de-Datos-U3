using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E3_EstDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            Operacion P = new Operacion();
            Ejercicio4 C = new Ejercicio4();

            Console.Write("Que Ejercicio desea ejecutar? \n1= Ejercicio 1 \n2= Ejercicio 2 \n3= Ejercicio 3 \n4= Ejercicio 4 \nR= ");
            opc = int.Parse(Console.ReadLine());

            if (opc == 1)
            {
                Console.Clear();
                Console.WriteLine("Tu resultado es: ");
                P.Principal();
            }

            else if(opc == 2)
            {
                Console.Clear();
                P.Ejercicio2();

            }

            else if(opc == 3)
            {
                Console.Clear();
                Console.WriteLine("Espera un momento....");
                P.Ejercicio3();
            }

            else if(opc == 4)
            {
                Console.Clear();
                P.Ejercicio4();            
            }

            else
            {
                Console.WriteLine("ERROR");
            }
            
        }
    }
}
