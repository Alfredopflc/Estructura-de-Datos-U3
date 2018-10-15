using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola MyCola = new Cola();

            for (int i = 0; i < 5; i++)
            {
                MyCola.EnQueue(i);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
              // =  Console.WriteLine(MyCola.Peek());
                MyCola.DeQueue();
            }

            Console.ReadKey();

            //Inicializacion de Colas con datos 
            Queue queue = new Queue(100);

            //La capacidad de la Cola y Factor de crecimiento (constante de crecimiento)
            Queue myQueue = new Queue(100, 3);

            //Cola con tipo de datos especifico
            Queue<int> numeros = new Queue<int>();

            //Tradicional
            Queue myc = new Queue();

        }
    }
}
