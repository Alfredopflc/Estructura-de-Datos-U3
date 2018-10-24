using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3._3RamirezGarciaJesus
{
    class CargaCartas //Inicia Clase CargaCartas
    {
        Random random = new Random(); //Metodo para revolver baraja
        Stack<Carta> Baraja; //Pila para los numeros y tipos de las cartas

        string TipoCarta;
        int NumeroCarta, opc, Az, suma = 0;
        string mano = "";
        bool Salir = false;

        public void Carga() //Metodo para llenar los valores de las cartas
        {
            Baraja = new Stack<Carta>();
            Carta C;
            int[] Valor = new int[52];
            string[] Tipos = new string[52];

            for (int cont = 1, cont2 = 0; cont <= 4; cont++) //For para llenar los arreglos con los valores de cartas
            {
                for (int cont3 = 1; cont3 <= 13; cont3++)
                {
                    if (cont3 >= 10) //Si la carta es mayor que 10 (J,Q,K) Valdra 10
                    {
                        Valor[cont2] = 10;
                    }

                    else //Si no, el valor de k del 1 al 10
                    {
                        Valor[cont2] = cont3;
                    }
                    cont2++;
                }
            }

            for (int i= 0; i < 52; i++) //For para llenar el arreglo con los simbolos
            {
                if (i < 13) //13 cartas de cada simbolo
                {
                    Tipos[i] = "♠";
                }

                else if (i < 26)
                {
                    Tipos[i] = "♥";
                }

                else if (i < 39)
                {
                    Tipos[i] = "♦";
                }

                else
                {
                    Tipos[i] = "♣";
                }
            }

            Random(Tipos); //Una vez llenado los arreglos, los pondremos en el metodo Random, para "barajear" los elementos
            Random(Valor);

            for (int j = 0; j < 52; j++)
            {
                C = new Carta(); //Se llena la Pila Simbolos y Numeros con los elementos de los vectores

                C.Numero = Valor[j];
                C.Tipo = Tipos[j];
                Baraja.Push(C);
            }
        }

        public void Random<T>(T[] Array) //Metodo para "barajear"  los valores
        {
            int N = Array.Length; //El tamano del arreglo definira cuantas veces se repetira el for

            for (int I = 0; I < N; I++) //Se revuelven los valores
            {
                int R = I + random.Next(N - I);
                T Tt = Array[R];
                Array[R] = Array[I];
                Array[I] = Tt;
            }
        }

        public void SacarCarta(int CantCartas) //Metodo para sacar la carta y no se vuelva a repetir
        {
            var Carta = Baraja.Pop();

            if (CantCartas == 2) //Se realizara la suma de los numeros las cartas que se seleccionen
            {
                NumeroCarta = Carta.Numero;
                TipoCarta = Carta.Tipo;
                Carta = Baraja.Pop();

                if (NumeroCarta == 1)
                {
                    suma = Carta.Numero;
                    mano = Carta.Tipo + " " + Carta.Numero + "   ";
                    NumeroCarta = CartaAz(suma);
                    suma = suma + NumeroCarta;
                    mano = mano + TipoCarta + " " + NumeroCarta + "   ";
                }

                else if (Carta.Numero == 1)
                {
                    suma = NumeroCarta;
                    mano = TipoCarta + " " + NumeroCarta + "   ";
                    Carta.Numero = CartaAz(suma);
                    suma = suma + Carta.Numero;
                    mano = mano + Carta.Tipo + " " + Carta.Numero + "   ";
                }

                else
                {
                    suma = NumeroCarta + Carta.Numero;
                    mano = TipoCarta + " " + NumeroCarta + "   " + Carta.Tipo + " " + Carta.Numero + "   ";
                }
            }

            else
            {
                Carta = Baraja.Pop();

                if (Carta.Numero == 1)
                {
                    Carta.Numero = CartaAz(suma);
                    suma = suma + Carta.Numero;
                    mano = mano + Carta.Tipo + " " + Carta.Numero + "   ";
                }

                else
                {
                    suma = suma + Carta.Numero;
                    mano = mano + Carta.Tipo + " " + Carta.Numero + "  ";
                }
            }
        }

        public int CartaAz(int Suma) //Metodo: Al salir un az, este puede valer 1 u 11, el usuario decidira como tomarlo
        {
            if (Suma <= 10)
            {
                do
                {
                    Console.Clear();

                    Console.Write("\nHaz obtenido un az: (Suma total: {0}) \n1 = Usarlo como 1 \n2 = Usarlo como 11 \nR = ", Suma);
                    opc = int.Parse(Console.ReadLine());

                    if (opc == 1) //Si elige la opcion 1, el valor valdra 1 y se sumara al valor suma
                    {
                        Az = 1;
                        Salir = true;
                    }

                    else if (opc == 2) //Si elige la opcion 2, el valor valdra 11 y se sumara al valor suma
                    {
                        Az = 11;
                        Salir = true;
                    }

                    else //Si no, marcara un error
                    {
                        Console.WriteLine("ERROR");
                        Console.ReadKey();
                        Salir = false;
                    }

                } while (Salir == false);
            }

            else
            {
                Az = 1;
            }
            return Az;
        }

        public void MostrarMano() //Se mostrara la suma total de las cartas seleccionadas
        {
            Console.WriteLine("Suma: {0}", suma);
            Console.WriteLine(mano);
        }

        public bool VerificarSuma(bool Ver) //Este metodo verificara si el usuario gano o perdio obteniendo mas de 21 en su suma total
        {
            if (Ver == false)
            {
                if (suma < 21)
                {
                    return false;
                }

                else if (suma == 21)
                {
                    return true;
                }

                else
                {
                    return true;
                }
            }
            else
            {
                if (suma == 21)
                {
                    Console.WriteLine("HAZ GANADO!! :D ");
                    Console.ReadKey();
                    return true;
                }

                else
                {
                    Console.WriteLine("HAZ PERDIDO :(");
                    Console.ReadKey();
                    return false;
                }
            }
        }
    }
}