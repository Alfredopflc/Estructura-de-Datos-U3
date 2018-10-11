using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC3._1_VenegasMedinaJoseAlfredo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> Pila = new Stack<int>();

            for (int i = 0; i < 5; i++)
            {
                Pila.Push(i);
            }

            Console.WriteLine("\n" + Pila.Contains(2)); //Contains nos permite saber si un valor existe en la pila, regresara un true si existe 
            //o un Flase si no existe en la pila, en este caso, buscara el 2, y regresara un True.

            Console.WriteLine("\n" + Pila.GetType()); //GetType, nos dira que tipo de datos estan en la pila, en este caso sera tipo Stack - int32

            Console.WriteLine("\n" + Pila.Peek().ToString()); //ToString convertira los elementos en String, esto puede servir para imprimir resultados

            Console.WriteLine("\n" + Pila.GetEnumerator()); //GetEnumerator permite usar enumeradores para recorrer la pila. [No encontre mas informacion]

            Int32[] arreglo = Pila.ToArray();  //ToAarray transfiere los valores de la pila en un arreglo. Es mas facil manejar los valores.

            foreach (int p in arreglo) //Imprime los valores del nuevo arreglo con los valores de la pila
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
    }
}
