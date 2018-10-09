using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3._1_VenegasMedinaJoseAlfredo_
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;

            do
            {
                try
                {
                    Console.Clear();

                    int numclas = 0;
                    Coleccion C = new Coleccion(); //Variable de la Clase Coleccion
                    ArrayList Materias = new ArrayList(); //Lista para Materias
                    ArrayList Alumnos = new ArrayList(); //Lista para Numero de Alumnos
                    ArrayList Calif = new ArrayList();  //Lista para calificaciones por materia

                    Console.Write("\nIngrese Numero de Clases: ");  //Se ingresa el numero de Clases
                    numclas = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nNombre de Clases: "); 

                    C.Add(Materias, numclas);   //Metodo para Ingresar Nombre de Clases

                    C.Add(Materias, Alumnos);  // Metodo para Ingresar cantidad de Alumnos por Clase

                    C.Add(Materias, Alumnos, Calif);  //Metodo para Ingresar Calificacion segun la materia y el Numero de Alumnos

                    Console.Clear();

                    C.Imprimir(Materias, Alumnos, Calif); //Metodo para imprimir datos

                    Console.Write("\n\nDesea reiniciar el programa? \n1 = Si \n2 = No \nR= ");   //Se pregunta si se quiere volver a iniciar
                    opc = int.Parse(Console.ReadLine());
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (opc == 1);

            Console.ReadKey();   
        }
    }
}
