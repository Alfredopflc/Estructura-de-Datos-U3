using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3._3.BlackJack
{
    class BlackJack //Inicia Clase BlackJack
    {
        Stack Simbolos = new Stack(); //Pila para los simbolos de las cartas
        Stack Numeros = new Stack(); //Pila para los numeros
        Random random = new Random(); //Metodo para revolver baraja

        char[] valores = new char[52];
        int[] valores2 = new int[52];
       
        int suma = 0, num, cantjuegos, opc, partgan, partper;
        string mano = "";
        bool Salir = false;

        public BlackJack(int CantJuegos, int Ganados, int Perdidos) //Constructor por defecto
        {
            cantjuegos = CantJuegos;
            partgan = Ganados;
            partper = Perdidos;
        }

        public int Carga() //Metodo para llenar los valores de las cartas
        {
            for (int i = 1, j = 0; i < 5; i++) //For para llenar los arreglos con los valores de cartas
            {
                for (int k = 1; k <= 13; k++)
                {
                    if (k >= 10) //Si la carta es mayor que 10 (J,Q,K) Valdra 10
                    {
                        valores2[j] = 10;
                    }
                    else //Si no, el valor de k del 1 al 10
                    {
                        valores2[j] = k;
                    }

                    j++;
                }
            }

            for (int i = 0; i < 52; i++) //For para llenar el arreglo con los simbolos
            {
                if (i < 13) //13 cartas de cada simbolo
                {
                    valores[i] = (char)3;
                }
                else if (i < 26)
                {
                    valores[i] = (char)4;
                }
                else if (i <= 38)
                {
                    valores[i] = (char)5;
                }
                else
                {
                    valores[i] = (char)6;
                }
            }

            Random(valores); //Una vez llenado los arreglos, los pondremos en el metodo Random, para "barajear" los elementos
            Random(valores2);

            for (int Contador = 0; Contador < 52; Contador++) //Se llena la Pila Simbolos y Numeros con los elementos de los vectores
            {
                Simbolos.Push(valores[Contador]);
                Numeros.Push(valores2[Contador]);
            }

            SacarCarta(); //Se deben sacar 2 cartas al principio
            SacarCarta();

            return suma; //Regresamos la suma 
        }

        public void Random<T>(T[] array) //Metodo para "barajear"  los valores
        {
            int n = array.Length; //El tamano del arreglo definira cuantas veces se repetira el for

            for (int i = 0; i < n; i++) //Se revuelven los valores
            {
                int r = i + random.Next(n - i);
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }

        public int SacarCarta() //Metodo para sacar la carta y no se vuelva a repetir
        {
            num = Convert.ToInt16(Numeros.Peek());

            if (num == 1) //Si sale 1, se considerara como un Az
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("~~ Partida Numero: {0} ~~", cantjuegos); //Marca cuantas partidas se han jugado 

                    Console.Write("\nTe salio un az, desea usarlo como: \n1 = Uzarlo como 1 \n2 = Usarlo como 11 \nR = "); 
                    //Al salir un az, este puede valer 1 u 11, el usuario decidira como tomarlo
                    opc = int.Parse(Console.ReadLine());

                    if (opc == 1) //Si elige la opcion 1, el valor valdra 1 y se sumara al valor suma
                    {
                        num = 1;
                        Salir = true;
                    }

                    else if (opc == 2) //Si elige la opcion 2, el valor valdra 11 y se sumara al valor suma
                    {
                        num = 11;
                        Salir = true;
                    }

                    else //Si no, marcara un error
                    {
                        Console.WriteLine("ERROR");
                        Console.ReadKey();
                        Salir = false;
                    }

                } while (Salir == false); //Si el numero no es 1 (Un az) o termina el proceso de eleccion entonces....
            }
            
            Console.Clear();
            Console.WriteLine("~~ Partida Numero: {0} ~~", cantjuegos); //Mostrara el numero de partidas jugadas

            Console.WriteLine("Juegos ganados: {0}  \tJuegos perdidos: {1}", partgan, partper); 
            //Tambien te mostrara cuantas partidas has ganado o perdido, si es el primer juego, marcara 0 en ambos
            suma = suma + num; //Hara la suma de cada carta

            Console.WriteLine("\nSuma total: {0}", suma); //Te mostrara la suma de tus cartas
            mano = mano + Simbolos.Pop() + " " + num + "\t"; //Te mostrara los valores de las cartas y sus simbolos
            Numeros.Pop(); //Saca el valor de la pila

            Console.WriteLine(mano); //Imprime toda tu mano actual

            return suma; //Regresa la suma total de tu mano
        }
    }
}