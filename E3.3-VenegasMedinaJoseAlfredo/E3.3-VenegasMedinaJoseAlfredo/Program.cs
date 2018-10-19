using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3._3.BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantjuegos = 0, opc = 0, partgan = 0, partper = 0; //Inicializar variables
            bool Salir = false;

            do
            {
                bool salida1 = false, salida2 = false;
                int suma = 0, Cartas = 2;
                cantjuegos++;

                BlackJack BJ = new BlackJack(cantjuegos, partgan, partper); //Se crea un objeto de la clase BlackJack
                suma = BJ.Carga();

                do
                {
                    if (suma < 21) //Si suma de tus cartas es menor que 21, entonces se ejecutara lo siguiente
                    {
                        do
                        {
                            if (Cartas < 5) //Si tienes menos de 5 cartas, te pedira si quieres otra para continuar sumando
                            {
                                Console.Write("\nDeseas otra carta? \n1 = Si \n2 = No \nR = ");
                                opc = int.Parse(Console.ReadLine());

                                if (opc == 1) //Si deseas sacar la carta, la suma sera regresada por el metodo SacarCartas de la clase BlackJack
                                {
                                    suma = BJ.SacarCarta();
                                    Cartas++;
                                    salida2 = true;
                                }

                                else if (opc == 2) //Si no, el programa te dira que perdiste por no llegar al 21
                                {
                                    Console.WriteLine("HAZ PERDIDO :(");
                                    salida1 = true; //Saldras del programa y te preguntara si quieres volver empezar
                                    salida2 = true;
                                }

                                else //Marcara un error si no elegiste 1 o 2
                                {
                                    Console.WriteLine("ERROR");
                                    Console.ReadKey();
                                    Console.Clear();
                                }                     
                            }

                            else //En el caso de ya tener 5 cartas
                            {
                                salida2 = true;

                                if (suma < 21) //El programa al tener una suma menor de 21, dira que perdiste
                                {
                                    Console.WriteLine("\nHAZ PERDIDO :(");
                                    partper++;
                                    salida1 = true;
                                }
                                else if (suma == 21) //Si es igual a 21 ganaste
                                {
                                    Console.WriteLine("\nHAZ GANADO :)");
                                    partgan++;
                                    salida1 = true;
                                }
                                else //Si te pasas del 21, habras perdido
                                {
                                    Console.WriteLine("\nHAZ PERDIDO :(");
                                    partper++;
                                    salida1 = true;
                                }

                            }

                        } while (salida2 == false); //Regresara si aun no has tomado 5 cartas y tu suma no ha pasado de 21
                    }

                    else if (suma == 21) //Si sale 21 antes de las 5 cartas, habras ganado
                    {
                        Console.WriteLine("\nHAZ GANADO :)");
                        partgan++;
                        salida1 = true;
                    }

                    else //De lo contrario, habras perdido
                    {
                        Console.WriteLine("\nHAZ PERDIDO :(");
                        partper++;
                        salida1 = true;
                    }

                } while (salida1 == false); //Sale del ciclo de eleccion de cartas

                Console.WriteLine("Presiona cualquier tecla para continuar.");
                Console.ReadKey();
                salida1 = false;

                do
                {
                    Console.Clear();
                    Console.Write("Deseas jugar de nuevo? \n1 = Si \n2 = No \nR = "); //Te preguntara si quieres volver a jugar
                    opc = int.Parse(Console.ReadLine());

                    if (opc == 1) //Si elijes 1, volveras a empezar
                    {
                        salida1 = true;
                    }

                    else if (opc == 2) //Si no, saldras del programa
                    {
                        Salir = true;
                        salida1 = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                        Console.ReadKey();
                    }

                } while (salida1 == false);

            } while (Salir == false); //Volveras a empezar 
        }
    }
}