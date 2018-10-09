using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3._1_VenegasMedinaJoseAlfredo_
{
    public class Coleccion
    {      
        public void Add(ArrayList L, int n)  //Se ingresa la Lista de Materias y el numero de Clases - 
        {
            string valor = "";   //Variable String para ingresarse a la Lista
            for (int i = 0; i < n; i++)  //Ciclo para ingresar valores a la lista
            {
                Console.Write("{0}: ", (i + 1));  
                valor = Console.ReadLine();
                L.Add(valor);     //Se agrega el valor a la lista
            }
        }

        public void Add(ArrayList L, ArrayList L2) //Se ingresa Lista Materias y Cantidad de Alumnos por Clase
        {
            int numalum = 0;
            Console.WriteLine("\n");

            for( int i = 0; i < L.Count; i++)  //Se cicla dependiendo de cuantas materias se tienen
            {
                Console.Write("Ingrese Numero de Alumnos en {0}: ", L[i]);
                numalum = int.Parse(Console.ReadLine());
                L2.Add(numalum); //Se guarda cantidad de Alumnos en la segunda Lista (de Alumnos)
            }
        }

        public void Add(ArrayList L, ArrayList L2, ArrayList L3)  //Se ingre Lista de Materias, Lista de Alumnos y Lista de Calificaciones
        {
            Console.Write("\n");
            
            for (int i = 0; i < L.Count; i++) //Se cicla dependiendo de cuantas materias se tienen
            {
                int valor = 0;
                Console.Write("\nIngrese Numero Calificaciones de {0}: \n", L[i]);
                valor = Convert.ToInt32(L2[i]) ;  //Convertir el valor de la Lista de Alumnos a int

                for (int j = 0; j < valor; j++)  //Se cicla dependiendo de cuantos alumnos se tienen por clase
                {
                    double calf = 0;
                    Console.Write("Ingresar Calificacion {0}: ", (j + 1));
                    calf = double.Parse(Console.ReadLine());

                    L3.Add(calf); //Se agrega los valores a la lista de Calificaciones
                }
            }
        }

        public void Imprimir(ArrayList L, ArrayList L2, ArrayList L3) //Se ingresan las 3 listas
        {
            Console.WriteLine("\n");

            for (int i = 0; i < L.Count; i++) //Se cicla dependiendo de cuantas materias se tienen
            {
                int valor = 0;
                Console.WriteLine("Calificaciones de {0}: ", L[i]);
                valor = Convert.ToInt32(L2[i]);

                for (int j = 0; j < valor; j++)  //Se cicla dependiend de cuantos alumnos se tienen por clase 
                {
                    Console.WriteLine("{0}", L3[i]);
                }

            }
        }
    }
}
