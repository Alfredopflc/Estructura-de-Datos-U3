using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E3_EstDatos
{
    public class Operacion
    {
        LinkedList<string> Lista = new LinkedList<string>();
        public void Principal()
        {
            Stack Lista = new Stack();
            Queue Cola = new Queue();

            Ejercicio1(Lista);
        }

        public void Ejercicio1(Stack Lista)
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()

            Lista.Push(5);
            Lista.Push(3);
            Lista.Pop();
            Lista.Push(2);
            Lista.Push(8);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(9);
            Lista.Push(1);
            Lista.Pop();
            Lista.Push(7);
            Lista.Push(6);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(4);
            Lista.Pop();
            Lista.Pop();

            foreach (int item in Lista)
            {
                Console.WriteLine(item);
            }

        }

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal

            string palabra;
            string[] test = {"abstract","enum", "long", "stackalloc", "as", "event","namespace","static","base","explicit","new", "string",
"bool", "extern",   "null", "struct","break","false","object","switch","byte", "finally",  "operator","this",
"case", "Fixed",   "out", "throw", "catch",    "float",   "override",  "true",
"char",    "for",   "params",  "try", "checked",  "foreach",  "private",  "typeof",
"class",   "goto",  "protected", "uint", "const",   "if",    "public", "ulong",
"continue", "implicit",    "readonly",  "unchecked", "decimal", "in", "ref", "unsafe",
"default",  "int",  "return",   "ushort", "delegate",    "interface",   "sbyte",  "using",
"do",   "internal", "sealed", "virtual", "double",   "is",   "short", "void", "else", "lock","sizeof","while"};

            LinkedList<string> palabrareservada = new LinkedList<string>();
            LinkedList<string> identificador = new LinkedList<string>();
            LinkedList<string> literales = new LinkedList<string>();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce palabra {0}", i + 1);
                palabra = Console.ReadLine();
                int valor;
                valor = Convert.ToInt32(palabra[0]);
                if (valor >= 65 && valor <= 122 || palabra[0] == '_')
                {
                    foreach (string item in test)
                    {
                        if (palabra == item)
                        {
                            palabrareservada.AddFirst(item);
                            goto final;
                        }
                    }
                    identificador.AddFirst(palabra);
                final:
                    Console.Clear();
                }

                else
                {
                   literales.AddFirst(palabra);
                   Console.Clear();
                }
            }

            Console.WriteLine("Identificadores introducidos");
            foreach (var r in identificador)
            {
                Console.WriteLine(r);
            }

            Console.ReadKey();
            Console.WriteLine("Literales introducidos");

            foreach (var r in literales)
            {
                Console.WriteLine(r);
            }

            Console.ReadKey();
            Console.WriteLine("Palabras Reservadas");

            foreach (var r in palabrareservada)
            {
                Console.WriteLine(r);
            }

            Console.ReadKey();
            Console.Clear();        

        }

        public void Ejercicio3()
        {
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            const int max = 100000;
            List<string> lista = new List<string>();
            LinkedList<string> listaligada = new LinkedList<string>();

            for (int i = 0; i < 9876; i++)
            {
                lista.Add("Okey");
                listaligada.AddLast("Okey");

            }
            var m1 = Stopwatch.StartNew();

            for (int i = 0; i < max; i++)
            {
                foreach (string item in lista)
                {
                    if (item.Length != 4)
                    {
                        throw new Exception();
                    }
                }
            }

            m1.Stop();

            var m2 = Stopwatch.StartNew();

            for (int i = 0; i < max; i++)
            {
                foreach (string item in listaligada)
                {
                    if (item.Length != 4)
                    {
                        throw new Exception();
                    }
                }
            }

            m2.Stop();

            Console.WriteLine("Lista: " + ((double)(m1.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));
            Console.WriteLine("Lista ligada: " + ((double)(m2.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));
        }

        public void Ejercicio4()
        {
            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            Clase curso = new Clase();
            curso.NombreClase = "";
            curso.Maestro = "";
            Stack Alumnos = new Stack();
            Stack<int> Calificaciones = new Stack<int>();
            Console.WriteLine(" Cual es el nombre de la clase:");
            curso.NombreClase = Console.ReadLine();

            Console.Write(" Nombre del maestro: ");
            curso.Maestro = Console.ReadLine();

            Console.Write(" Numero de alumnos: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.Write(" Nombre del alumno {0}: ", i + 1);
                Alumnos.Push(Console.ReadLine());

                Console.Write(" Calificacion del alumno {0}: ", i + 1);
                Calificaciones.Push(int.Parse(Console.ReadLine()));
            }

            // Console.Clear();          

            Console.WriteLine("\n El promedio es: {0:0000}", curso.Promedio(Calificaciones));
            Console.WriteLine(" El MAYOR es: {0}", Calificaciones.Max());
            Console.WriteLine(" El MENOR es: {0}", Calificaciones.Min());
        }
    }
}