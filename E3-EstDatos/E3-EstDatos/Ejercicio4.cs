using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos
{
    class Ejercicio4
    {
        List<double> lista = new List<double>();
        public void NotaMedia()
        {
            int alum = 0;
            double calf = 0,suma = 0, NotaMedia = 0;
            

            Console.Write("Ingrese numero de alumnos de la clase: ");
            alum = int.Parse(Console.ReadLine());

            for(int i = 0; i < alum; i++)
            {
                Console.Write("Ingrese Calificacion de alumno {0}: ", (i + 1));
                calf = double.Parse(Console.ReadLine());
                lista.Add(calf);

                suma = calf + suma;
            }
            NotaMedia = suma / alum;

            Console.WriteLine("Promedio: " + NotaMedia);

        }

        public void CalfMax()
        {
            Console.WriteLine("Calificacion Maxima: " + lista.Max());
        }

        public void CalfMin()
        {
            Console.WriteLine("Calificacion Minima: " + lista.Min());
        }

        
    }
}
