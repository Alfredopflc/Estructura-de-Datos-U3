using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3._2_VenegasMedinaJoseAlfredo
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            do
            {
                try
                {
                    Console.Clear();

                    int opc = 0 ;
                    
                    Console.Write("Que desea utilizar? \n1 = Pila \n2 = Queue \nR= "); // Menu
                    opc = int.Parse(Console.ReadLine());

                    if (opc == 1)
                    {
                        int valor = 0, num = 0, enc = 0;

                        Console.Clear();
                        Stack Pila = new Stack(); // Se crea una Pila

                        Console.Write("Ingrese cantidad de valores que desea agregar: "); // Ingresamos numero de valores que meteremos en la pila
                        num = int.Parse(Console.ReadLine());

                        for (int i = 0; i < num; i++)  //for para ingresar valores
                        {
                            Console.Write("Ingrese el valor {0}: ", i + 1);
                            valor = int.Parse(Console.ReadLine());
                            Pila.Push(valor); //.Push para ingresar los valores a la Pila
                        }

                        Console.Write("\nQue valor desea encontrar? \nR= ");
                        enc = int.Parse(Console.ReadLine()); // Se ingresa posicion del valor que se desea encontrar

                        Console.WriteLine("Tu valor es: {0}  ", Pila.Contains(enc)); // .Contains para encontrar dicho elemento

                        Console.WriteLine("\nLa pila tiene {0} elementos", Pila.Count); //.Count para saber cuantos valores tiene la Pila
                        
                        foreach (var item in Pila)
                        {
                            Console.WriteLine("Valor: {0}    Tipo: {1}", item, item.GetType()); //.GetType para ver que tipo de variable son los valores de la Pila
                        }

                        IEnumerator mover = Pila.GetEnumerator(); //.GetEnumerator para crear un  enumerador para recorrer la pila.
                        mover.MoveNext(); //movemos el enumerador
                        mover.MoveNext();
                        mover.MoveNext(); 
                        Console.WriteLine("\nValor del enumerador: {0}", mover.Current); //.Current para ver el valor en el que se quedo el enumerador

                        object[] PilaArreglo = Pila.ToArray(); //.ToArray para tranformar Pila en Arreglo

                        Console.WriteLine("\nValores del Arreglo: "); //Se imprime el Arreglo

                        foreach (int item in PilaArreglo)
                        {
                            Console.Write("{0} ", item);
                        }


                        Console.WriteLine("\nTransformar valores a string: ");

                        foreach (var item2 in Pila)
                        {
                            Console.WriteLine("Valor: {0}       Tipo: {1}", item2, item2.ToString().GetType()); //.ToString para convertir valores a String
                        }   


                        Console.WriteLine("\nEl ultimo valor de la Pila es: {0}", Pila.Peek()); //.Peek devuelve el ultimo elemento en ingresarse.
                        Pila.Pop(); //.Pop quita el ultimo elemento que introdujimos

                        Console.WriteLine("\nImprimimos los valores de la pila sin el ultimo elemento: ");

                        foreach (var item in Pila)
                        {
                            Console.WriteLine(item); //Imprimimos para ver si se elimino dicho elemento
                        }
                        
                    }


                    else if (opc == 2)
                    {
                        Console.Clear();

                        int valor = 0, num = 0, enc = 0;
                       
                        Queue Cola = new Queue();  //Inicializamos Queue

                        Console.Write("Ingrese cantidad de valores a ingresar: "); //Ingresamos cantidad de elementos que vamos a ingresar
                        num = int.Parse(Console.ReadLine());

                        for (int i = 0; i < num; i++)  //for para introducir datos
                        {
                            Console.Write("Ingrese el valor {0}: ", i + 1);
                            valor = int.Parse(Console.ReadLine());
                            Cola.Enqueue(valor); //.Enqueue para introducir datos
                        }

                        Cola.TrimToSize(); //Restringe la capacidad de la cola al número actual de elementos en la cola
                                           

                        Console.Write("\nQue valor desea encontrar? \nR= ");
                        enc = int.Parse(Console.ReadLine()); //Buscar valor 

                        Console.WriteLine("Tu valor es: {0} ", Cola.Contains(enc)); //.Contains para encontrar elementos en la Cola

                        Console.WriteLine("\nLa Cola tiene {0} elementos", Cola.Count);


                        foreach (var item in Cola)
                        {
                            Console.WriteLine("Valor: {0}      Tipos: {1} ", item, item.GetType()); //.GetType para ver que tipo de variable son los datos de la Cola
                        }

                        IEnumerator mover = Cola.GetEnumerator(); //.GetEnumerator para crear un  enumerador para recorrer la Cola
                        mover.MoveNext(); 
                        mover.MoveNext();
                        mover.MoveNext(); 
                        Console.WriteLine("\nValor del enumerador: {0}", mover.Current); //.Current para ver el valor en el que se quedo el enumerador

                        object[] ColaArreglo = Cola.ToArray(); //.ToArray para transformar la cola en Array

                        Console.WriteLine("\nValores del Arreglo: ");

                        foreach (int i in ColaArreglo) //Imprimimos el Arreglo convertido
                        {
                            Console.Write("{0} ", i);
                        }

                        Console.WriteLine("\nTransformar valores a string: ");

                        foreach (var item2 in Cola)
                        {
                            Console.WriteLine("Valor: {0}              Tipo {1}", item2, item2.ToString().GetType()); //.ToString para tranformar datos
                        }   

                        Console.WriteLine("\nEl Primer Valor es: {0}", Cola.Peek()); //.Peek el primer elemento

                        Cola.Dequeue(); //Se quita el primer elemento que introdujimos

                        Console.WriteLine("\nImprimimos los valores de la Cola sin el primer elemento:");
                        foreach (var item in Cola)
                        {
                            Console.WriteLine(item); //Imprimimos para verificar si fue eliminado
                        }

                        //Pilas.Push = Queue.Enqueue 
                        //Pilas.Pop = Queue.Dequeue 
                        //Los demas metodos se utilizan de la misma manera
                        //En el caso de las Colas, se usa el TrimToSize restringir la capacidad de la cola al número actual de elementos en la cola

                    }

                    Console.Write("\nDesea volver a empezar? \n1=Si \n2=No \nR= ");
                    op = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (op ==  1);

            Console.ReadKey();
        }
    }
}

