using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC._3_2_VenegasMedinaJoseAlfredo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 10;

            Stack Pila = new Stack();

            for (int i = 0; i < 10; i++)
                Pila.Push(i+1);

            foreach(var i in Pila)
            {
                Console.WriteLine("Valor: {0}    Tipo:{1}   Posicion: {2}", i, i.GetType(), Count);
                Count--;
            }
        }
    }
}
